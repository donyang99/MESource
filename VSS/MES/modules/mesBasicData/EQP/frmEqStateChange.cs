using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.mesCore.EQP;
using idv.utilities;
using mesRelease.EQP;
using idv.mesCore.Controls;

namespace mesBasicData
{
    public partial class frmEqStateChange : Form
    {
        public frmEqStateChange()
        {
            InitializeComponent();
            initToolbar();
            initData();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Modify"].Visible = false;
            actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Export", "");
        }

        private void actionToolbar1_ActionClicked(string actionName)
        {
            appInstance.showInformation("");
            switch (actionName)
            { 
                case "Add":
                    executeAdd();
                    break;
                case "Delete":
                    executeDelete();
                    break;
                case "Export":
                    executeExport();
                    break;
            }
        } 

        void initData()
        {
            foreach (stateTransferRule r in State.GetStateTransferRule(""))
                addStateRuleToListView(r);
        }

        ListViewItem addStateRuleToListView(stateTransferRule r)
        {
            ListViewItem item = new ListViewItem();
            item.Text = r.stateFrom;
            item.SubItems.Add(r.stateTo);
            item.SubItems.Add(r.division);
            item.Tag = r;
            lvwStateRule.Items.Add(item);
            return item;
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(lstFromState, lblFromState, lstToState, lblToState)) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;

            try
            {
                stateTransferRule st;
                st.stateFrom = lstFromState.Text;
                st.stateTo = lstToState.Text;
                st.division = lstDivision.Text;
                State.AddStateTransferRule(st);
                addStateRuleToListView(st).Selected = true;              
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (lvwStateRule.SelectedItems.Count == 0)
            {
                appInstance.showInformationById("msgDeleteNoSelect", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                ListViewItem item = lvwStateRule.SelectedItems[0];
                stateTransferRule st = (stateTransferRule)item.Tag;
                State.DeleteStateTransferRule(st);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                lvwStateRule.Items.Remove(item);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeExport()
        {
            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(lvwStateRule))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        private void lvwStateRule_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                lstFromState.SelectedIndex = -1;
                lstToState.SelectedIndex = -1;
                lstDivision.SelectedIndex = -1;
            }
            else
            {
                try
                {
                    stateTransferRule r = (stateTransferRule)e.Item.Tag;
                    lstFromState.SelectedIndex = -1;
                    for (int i = 0; i < lstFromState.Items.Count; i++)
                    {
                        if (lstFromState.Items[i].ToString() == r.stateFrom)
                        {
                            lstFromState.SelectedIndex = i;
                            break;
                        }
                    }
                    lstToState.SelectedIndex = -1;
                    for (int i = 0; i < lstToState.Items.Count; i++)
                    {
                        if (lstToState.Items[i].ToString() == r.stateTo)
                        {
                            lstToState.SelectedIndex = i;
                            break;
                        }
                    }
                    lstDivision.SelectedIndex = -1;
                    for (int i = 0; i < lstDivision.Items.Count; i++)
                    {
                        if (lstDivision.Items[i].ToString() == r.division)
                        {
                            lstDivision.SelectedIndex = i;
                            break;
                        }
                    }
                }
                catch { }              
            }
        }

        private void frmEqStateChange_Activated(object sender, EventArgs e)
        {
            bool changed = false;
            if (idv.utilities.misc.IsValueChanged("frmEqState", Name))
            {
                lstFromState.Items.Clear();
                lstToState.Items.Clear();
                foreach (State st in State.GetStates())
                {
                    lstFromState.Items.Add(st.name);
                    lstToState.Items.Add(st.name);
                }
                changed = true;
            }

            if (idv.utilities.misc.IsValueChanged("frmDivision", Name))
            {
                lstDivision.Items.Clear();
                lstDivision.Items.Add("");
                foreach (string s in idv.mesCore.misc.DivisionGet())
                    lstDivision.Items.Add(s);
                changed = true;
            }

            if (changed && lvwStateRule.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwStateRule.SelectedItems[0];
                item.Selected = false;
                item.Selected = true;
            }
        }       
    }
}
