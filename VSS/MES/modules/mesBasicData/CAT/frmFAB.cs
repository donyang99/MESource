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
    public partial class frmFAB : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmFAB()
        {
            InitializeComponent();           
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Modify"].Visible = false;
            actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Export", "");
        }

        private void frmFAB_Load(object sender, EventArgs e)
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

        void actionToolbar1_ActionClicked(string actionName)
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

        void executeQuery()
        {
            mesListView1.ShowMESItems(mesRelease.BAS.Fab.GetFabs());
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtFAB, lblFAB, txtFabCode, lblFabCode, txtOrgId, lblOrgId)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                mesRelease.BAS.Fab fab = new mesRelease.BAS.Fab();
                fab.name = txtFAB.Text;
                fab.fabCode = txtFabCode.Text;
                fab.orgId = txtOrgId.Text;
                fab.createUser = mesRelease.USR.User.loginUser.name;

                if (frmExt != null) frmExt.AssignValue(fab);//維護畫面延伸功能

                fab.New();
                mesListView1.UpdateMESItem(fab);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                txtFAB.Text = "";
                txtFabCode.Text = "";
                txtOrgId.Text = "";
                idv.utilities.misc.SetValueChangeByItemName(Name);
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
                appInstance.showInformationById("msgDeleteNoSelect", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            mesRelease.BAS.Fab item = mesListView1.selectedMESItem as mesRelease.BAS.Fab;
            try
            {
                item.modifyUser = mesRelease.USR.User.loginUser.name;
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

        private void HandlerSendKeyTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }

        private void frmFAB_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }
    }
}
