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
    public partial class frmLotType : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmLotType()
        {
            InitializeComponent();
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Export", "");
        }
        
        private void frmLotType_Load(object sender, EventArgs e)
        {
            initToolbar();
            List<string> lstNames = new List<string>();
            List<string> lstTags = new List<string>();
            lstNames.AddRange(lvwLotType.columnNames);
            lstTags.AddRange(lvwLotType.columnTags);
            if (idv.mesCore.systemConfig.validItem("toolingManagement"))
            {
                lstNames.Add("checkTooling");
                lstTags.Add("Tooling");
            }
            if (frmExt != null)//維護畫面延伸功能
                idv.messageService.appModuleFunctionFormControlDefine.Init(frmExt, this, pnlExt, tblDetail, lstNames, lstTags);
            lvwLotType.columnNames = lstNames.ToArray();
            lvwLotType.columnTags = lstTags.ToArray();
            lvwLotType.prepareColumns();
            pnlExt.AutoSize = true;
            chkDcSpec.Visible = idv.mesCore.systemConfig.productParameter;
            chkRecipe.Visible = idv.mesCore.systemConfig.parmEqTypeFlag;
            chkMaterial.Visible = idv.mesCore.systemConfig.materialTracking && idv.mesCore.systemConfig.productParameter;
            chkTooling.Visible = idv.mesCore.systemConfig.productParameter && idv.mesCore.systemConfig.validItem("toolingManagement");
            executeQuery();
        }

        private void frmLotType_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void actionToolbar1_ActionClicked(string actionName)
        {
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
                case "Export":
                    executeExport();
                    break;
            }
        }

        void executeClear()
        {
            txtLotType.Text = "";
            txtDescription.Text = "";
            chkDcSelf.Checked = false;
            chkDcSpec.Checked = false;
            chkFutureHold.Checked = false;
            chkMaterial.Checked = false;
            chkQTime.Checked = false;
            chkRecipe.Checked = false;

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeQuery()
        {
            lvwLotType.ShowMESItems(mesRelease.BAS.LotType.GetLotTypes());
        }

        void assignAttribute(mesRelease.BAS.LotType type)
        {
            //type.name = txtLotType.Text;
            type.description = txtDescription.Text;
            type.checkDcSelf = chkDcSelf.Checked;
            type.checkDcSpec = chkDcSpec.Checked;
            type.checkFutureHold = chkFutureHold.Checked;
            type.checkMaterial = chkMaterial.Checked;
            type.checkTooling = chkTooling.Checked;
            type.checkQTime = chkQTime.Checked;
            type.checkRecipe = chkRecipe.Checked;
            type.modifyUser = mesRelease.USR.User.loginUserId;
            type.modifyDate = idv.messageService.serviceHost.dateTime;

            if (frmExt != null) frmExt.AssignValue(type);//維護畫面延伸功能
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtLotType, lblLotType)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                mesRelease.BAS.LotType type = new mesRelease.BAS.LotType();
                type.name = txtLotType.Text;
                assignAttribute(type);
                type.createUser = mesRelease.USR.User.loginUserId;
                type.createDate = idv.messageService.serviceHost.dateTime;
                type.New();
                lvwLotType.UpdateMESItem(type);
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
            if (lvwLotType.SelectedItems.Count == 0)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!appInstance.CheckInputData(txtLotType, lblLotType)) return;
            mesRelease.BAS.LotType type = lvwLotType.selectedMESItem as mesRelease.BAS.LotType;
            if (frmExt != null && !frmExt.CheckData("modify", type)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                assignAttribute(type);
                type.Modify();
                lvwLotType.UpdateMESItem(type);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (lvwLotType.SelectedItems.Count == 0)
            {
                appInstance.showInformationById("msgDeleteNoSelect", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                mesRelease.BAS.LotType type = lvwLotType.selectedMESItem as mesRelease.BAS.LotType;
                type.Delete();
                lvwLotType.RemoveMESItem(type);
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
            if (mesRelease.utilities.ExcelAgent.WriteToFile(lvwLotType))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        private void lvwLotType_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
                executeClear();
            else
            {
                mesRelease.BAS.LotType type = item as mesRelease.BAS.LotType;
                txtLotType.Text = type.name;
                txtDescription.Text = type.description;
                chkDcSelf.Checked = type.checkDcSelf;
                chkDcSpec.Checked = type.checkDcSpec;
                chkFutureHold.Checked = type.checkFutureHold;
                chkMaterial.Checked = type.checkMaterial;
                chkTooling.Checked = type.checkTooling;
                chkQTime.Checked = type.checkQTime;
                chkRecipe.Checked = type.checkRecipe;

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ShowData(type);
            }
        }
    }
}
