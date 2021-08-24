using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.mesCore.Controls;
using idv.utilities;
using mesRelease.EQP;

namespace mesBasicData
{
    public partial class frmEqState : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmEqState()
        {
            InitializeComponent();
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query            
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
                case "Modify":
                    executeModify();
                    break;
                case "Delete":
                    executeDelete();
                    break;
                case "Export":
                    executeExport();
                    break;
            }
        }

        private void frmEqState_Load(object sender, EventArgs e)
        {
            initToolbar();
            List<string> lstNames = new List<string>();
            List<string> lstTags = new List<string>();
            lstNames.AddRange(mesListView1.columnNames);
            lstTags.AddRange(mesListView1.columnTags);
            if (frmExt != null)//維護畫面延伸功能
                idv.messageService.appModuleFunctionFormControlDefine.Init(frmExt, this, pnlExt, tblDetail, lstNames, lstTags);
            mesListView1.columnNames = lstNames.ToArray();
            mesListView1.columnTags = lstTags.ToArray();
            mesListView1.prepareColumns();
            pnlExt.AutoSize = true;
            executeQuery();
        }

        private void frmEqState_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void executeQuery()
        {
            mesListView1.ShowMESItems(State.GetStates());
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtEqState, lblEqState)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                State item = new State();
                item.name = txtEqState.Text;
                item.available = rdoYes.Checked;
                item.description = txtDescription.Text;
                item.color = lblColor.BackColor.ToArgb();
                
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能

                item.New();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeModify()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (!appInstance.CheckInputData(txtEqState, lblEqState))
                return; 
            
            State item = mesListView1.selectedMESItem as State;
            if (item.name != txtEqState.Text)
            {
                appInstance.showInformation(cultureLanguage.getValue("cantModifyField", lblEqState.Text), informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                item.available = rdoYes.Checked;
                item.description = txtDescription.Text;
                item.color = lblColor.BackColor.ToArgb();
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.Modify();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            State item = mesListView1.selectedMESItem as State;
            if (item.createUser == "System")
            {
                appInstance.showInformationById("cantDelDefaults", informationType.warn);
                return; 
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;            
            try
            {
                item.Delete();
                mesListView1.RemoveMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeExport()
        {
            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(mesListView1))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                txtEqState.Text = "";
                rdoYes.Checked = true;
                rdoNo.Checked = false;
                txtDescription.Text = "";
                lblColor.BackColor = SystemColors.Control;
                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ClearData();
            }
            else
            {
                State s = item as State;
                if (s != null)
                {
                    txtEqState.Text = s.name;
                    if (s.available)
                        rdoYes.Checked = true;
                    else
                        rdoNo.Checked = true;
                    txtDescription.Text = s.description;
                    lblColor.BackColor = Color.FromArgb(s.color);

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(s);
                }
            }   
        }

        private void lblColor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ColorDialog dia = new ColorDialog();
                dia.Color = lblColor.BackColor;
                dia.ShowDialog();
                lblColor.BackColor = dia.Color;
            }
            catch { }
        }
    }
}
