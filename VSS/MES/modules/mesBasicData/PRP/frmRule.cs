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

namespace mesBasicData
{
    public partial class frmRule : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmRule()
        {
            InitializeComponent();
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Clear", "");
        }

        private void frmRule_Load(object sender, EventArgs e)
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
            initData();
        }

        private void frmRule_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void initData()
        {
            mesListView1.ShowMESItems(mesRelease.PRP.Rule.GetRules());            
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
                case "Clear":
                    executeClear();
                    break;
            }
        }        

        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                executeClear();
            }
            else
            {
                mesRelease.PRP.Rule r = item as mesRelease.PRP.Rule;
                if (r != null)
                {
                    txtRule.Text = r.name;
                    if (r.dispatchFlag)
                        rdoYes.Checked = true;
                    else
                        rdoNo.Checked = true;
                    txtDescription.Text = r.description;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(r);
                }
            }  
        }

        void executeClear()
        {
            txtRule.Text = "";
            rdoNo.Checked = true;
            txtDescription.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtRule, lblRule)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                mesRelease.PRP.Rule item = new mesRelease.PRP.Rule();
                item.name = txtRule.Text;
                item.dispatchFlag = rdoYes.Checked;
                item.description = txtDescription.Text;
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
            else if (!appInstance.CheckInputData(txtRule, lblRule))
                return;
            mesRelease.PRP.Rule item = mesListView1.selectedMESItem as mesRelease.PRP.Rule;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
             try
            {
                item.name = txtRule.Text;
                item.dispatchFlag = rdoYes.Checked;
                item.description = txtDescription.Text;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.Modify();
                mesListView1.UpdateMESItem(item);

                refreshRuleCatch(item);

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
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            mesRelease.PRP.Rule item = mesListView1.selectedMESItem as mesRelease.PRP.Rule;
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

        void refreshRuleCatch(mesRelease.PRP.Rule rule)
        {
            try
            {
                mesRelease.PRP.Rule.RefreshRuleCatch("", rule.sysid);
            }
            catch { }
        }

        private void HandlerSendKeyTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }
    }
}
