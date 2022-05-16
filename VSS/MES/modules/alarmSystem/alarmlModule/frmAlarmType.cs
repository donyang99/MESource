using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.mesCore.Controls;
using mesRelease.ALM;
using idv.utilities;

namespace alarmModule
{
    public partial class frmAlarmType : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmAlarmType()
        {
            InitializeComponent();
            initToolbar();
            
        }

        void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Export", "");//add button needed with privilege string
        }

        private void frmAlarmType_Load(object sender, EventArgs e)
        {
            List<string> lstNames = new List<string>();
            List<string> lstTags = new List<string>();
            lstNames.AddRange(lvwAlarmType.columnNames);
            lstTags.AddRange(lvwAlarmType.columnTags);
            if (frmExt != null)//維護畫面延伸功能
                idv.messageService.appModuleFunctionFormControlDefine.Init(frmExt, this, pnlExt, tblDetail, lstNames, lstTags);
            lvwAlarmType.columnNames = lstNames.ToArray();
            lvwAlarmType.columnTags = lstTags.ToArray();
            lvwAlarmType.prepareColumns();
            pnlExt.AutoSize = true;

            lvwAlarmType.ShowMESItems(AlarmType.GetAlarmTypes());
            cboReasonGroup.Items.AddRange(mesRelease.BAS.ReasonGroup.getReasonGroups(""));
        }
        private void frmAlarmType_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
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

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtAlarmType, lblAlarmType)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                AlarmType item = new AlarmType();
                item.name = txtAlarmType.Text;
                item.reasonGroup = cboReasonGroup.Text;
                item.description = txtDescription.Text;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New();
                lvwAlarmType.UpdateMESItem(item);
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
            if (lvwAlarmType.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (!appInstance.CheckInputData(txtAlarmType, lblAlarmType))
                return;

            AlarmType item = lvwAlarmType.selectedMESItem as AlarmType;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            
            try
            {
                item.name = txtAlarmType.Text;
                item.reasonGroup = cboReasonGroup.Text;
                item.description = txtDescription.Text;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.Modify();
                lvwAlarmType.UpdateMESItem(item);
                RefreshAlarmCache(item.name);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (lvwAlarmType.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            AlarmType item = lvwAlarmType.selectedMESItem as AlarmType;
            try
            {
                item.Delete();
                lvwAlarmType.RemoveMESItem(item);
                RefreshAlarmCache(item.name);
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
            if (mesRelease.utilities.ExcelAgent.WriteToFile(lvwAlarmType))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        void RefreshAlarmCache(string alarmType)
        {
            idv.messageService.serverCommand cmd = new idv.messageService.serverCommand();
            cmd.name = "refreshAlarmCache";
            cmd.To = "AlarmServer:*";
            idv.messageService.serverCommandArgument arg = new idv.messageService.serverCommandArgument();
            arg.name = "AlarmType";
            arg.value = alarmType;
            cmd.Add(arg);
            cmd.send();
        }

        private void lvwAlarmType_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                txtAlarmType.Text = "";
                cboReasonGroup.Text = "";
                txtDescription.Text = "";
            }
            else
            {
                AlarmType type = item as AlarmType;
                txtAlarmType.Text = type.name;
                cboReasonGroup.Text = type.reasonGroup;
                txtDescription.Text = type.description;

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ShowData(type);
            }
        }


    }
}
