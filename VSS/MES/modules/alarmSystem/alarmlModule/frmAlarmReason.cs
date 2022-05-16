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
    public partial class frmAlarmReason : Form, idv.messageService.appModuleFunctionForm
    {
        mesRelease.ALM.AlarmReason curAlmReason = null;
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        
        public frmAlarmReason()
        {
            InitializeComponent();
            initToolbar();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void frmAlarmReason_Load(object sender, EventArgs e)
        {
            List<string> lstNames = new List<string>();
            List<string> lstTags = new List<string>();
            lstNames.AddRange(lvwAlarmReason.columnNames);
            lstTags.AddRange(lvwAlarmReason.columnTags);
            if (frmExt != null)//維護畫面延伸功能
                idv.messageService.appModuleFunctionFormControlDefine.Init(frmExt, this, pnlExt, tblDetail, lstNames, lstTags);
            lvwAlarmReason.columnNames = lstNames.ToArray();
            lvwAlarmReason.columnTags = lstTags.ToArray();
            lvwAlarmReason.prepareColumns();
            lvwAlarmReason.Columns[0].Width = 180;
            lvwAlarmReason.Columns[1].Width = 200;
            lvwAlarmReason.Columns[2].Width = 80;
            pnlExt.AutoSize = true;
            cboLanguage.Items.Add("");
            cboLanguage.Items.AddRange(cultureLanguage.availableLanguage);
            getLineGroup();
            btnEditLine.Enabled = actionAlarmReason.Items["Add"].Enabled || actionAlarmReason.Items["Modify"].Enabled;
        }
        void getLineGroup()
        {
            cboLine.Items.Clear();
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter("select value from mes_misc where item=?", "lineToken");
            foreach (DataRow row in ds.Tables[0].Rows)
                cboLine.Items.Add(row[0].ToString());
        }

        private void frmAlarmReason_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void initToolbar()
        {
            actionAlarmReason.loadStandardButtons();//Add, Modify, Delete, Query;
            actionAlarmReason.addButton("Clear", "");
            actionAlarmReason.addButton("Export", "");//add button needed with privilege string
        }

        private void frmAlarmReason_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmAlarmType", Name))
            {
                string orgType = cboAlarmType.Text;
                cboAlarmType.Items.Clear();
                cboAlarmType.Items.AddRange(mesRelease.ALM.AlarmType.GetAlarmTypes());

                if (!orgType.Equals(""))
                    cboAlarmType.Text = orgType;
            }
        }

        string prevSel = "";
        private void cboAlarmType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboAlarmType.SelectedItem == null) return;
            if (prevSel.Equals(cboAlarmType.Text)) return;
            prevSel = cboAlarmType.Text;
            cboReasonCode.Items.Clear();
            cboReasonCode.Text = "";
            mesRelease.ALM.AlarmType almType = cboAlarmType.SelectedItem as mesRelease.ALM.AlarmType;
            cboReasonCode.Items.AddRange(almType.GetReasonCode());
        }

        private void actionAlarmReason_ActionClicked(string actionName)
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
                case "Query":
                    executeQuery();
                    break;
                case "Clear":
                    executeClear();
                    break;
            }
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            byte ascii = (byte)e.KeyChar;
            if (ascii == 8)
                return;
            else if (ascii > 47 && ascii < 58)
            {

            }
            else if (ascii == 13 && sender == txtLevelCount)
                prepareLevels();
            else
                e.Handled = true;
        }
        byte getLevelCount()
        {
            byte b = 0;
            byte.TryParse(txtLevelCount.Text, out b);
            return b;
        }

        void executeClear()
        {
            cboAlarmType.SelectedIndex = -1;
            cboReasonCode.Text = "";
            txtLevelCount.Text = "";
            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeQuery()
        {
            lvwAlarmReason.ShowMESItems(mesRelease.ALM.AlarmReason.GetAlarmReasons(cboAlarmType.Text, cboReasonCode.Text.Trim()));
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(cboAlarmType, lblAlarmType, txtLevelCount, lblLevelCount)) return;
            if (getLevelCount() == 0)
            {
                appInstance.showInformation(cultureLanguage.getValue("msgWrongInfo", lblLevelCount.Text), informationType.error);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                AlarmType almType = cboAlarmType.SelectedItem as AlarmType;
                AlarmReason item = new AlarmReason();
                item.name = cboReasonCode.Text.Trim();
                item.alarmType = almType.name;
                item.typeSysId = almType.sysid;
                item.typeDescription = almType.description;
                item.levelCount = getLevelCount();
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New();
                lvwAlarmReason.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeModify()
        {
            saveLevelInfo();
            if (lvwAlarmReason.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (!appInstance.CheckInputData(cboAlarmType, lblAlarmType, txtLevelCount, lblLevelCount))
                return;
            if (getLevelCount() == 0)
            {
                appInstance.showInformation(cultureLanguage.getValue("msgWrongInfo", lblLevelCount.Text), informationType.error);
                return;
            }
            
            AlarmReason item = lvwAlarmReason.selectedMESItem as AlarmReason;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            
            try
            {
                AlarmType almType = cboAlarmType.SelectedItem as AlarmType;
                item.name = cboReasonCode.Text.Trim();
                item.alarmType = almType.name;
                item.typeSysId = almType.sysid;
                item.typeDescription = almType.description;
                item.levelCount = getLevelCount();
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.Modify();
                lvwAlarmReason.UpdateMESItem(item);
                RefreshAlarmCache(item.alarmType);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (lvwAlarmReason.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;

            try
            {
                AlarmReason item = lvwAlarmReason.selectedMESItem as AlarmReason;
                item.Delete();
                lvwAlarmReason.RemoveMESItem(item);
                RefreshAlarmCache(item.alarmType);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeExport()
        {
            if (lvwAlarmReason.Items.Count == 0) return;
            if (mesRelease.utilities.ExcelAgent.WriteToFile(lvwAlarmReason))
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

        private void lvwAlarmReason_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                saveLevelInfo();
                executeClear();
                curAlmReason = null;
                preLevelIndex = -1;
                clearLevelSetting();
            }
            else
            {
                curAlmReason = item as mesRelease.ALM.AlarmReason;
                curAlmReason.retrieveLevels();
                cboAlarmType.Text = curAlmReason.alarmType;
                cboReasonCode.Text = curAlmReason.name;
                txtLevelCount.Text = curAlmReason.levelCount.ToString();
                prepareLevels();
                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ShowData(curAlmReason);
            }
        }

        AlarmReason preReason = null;
        void prepareLevels()
        {
            if (curAlmReason == null) return;
            int orgIndex = cboLevel.SelectedIndex;
            cboLevel.Items.Clear();
            for (byte i = 0; i < getLevelCount(); i++)
            {
                cboLevel.Items.Add(i);
                AlarmLevel lev = curAlmReason.Item(i);
                if (lev == null)
                {
                    lev = new AlarmLevel();
                    lev.level = i;
                    curAlmReason.Add(lev);
                }
            }
            if (preReason == curAlmReason)
            {
                if (cboLevel.Items.Count > orgIndex)
                    cboLevel.SelectedIndex = orgIndex;
                else
                    cboLevel_SelectedIndexChanged(cboLevel, new EventArgs());
            }
            else 
            {
                if (cboLevel.Items.Count > 0)
                    cboLevel.SelectedIndex = 0;
                else
                    clearLevelSetting();
            }
            preReason = curAlmReason;
        }

        private void txtLevelCount_Validated(object sender, EventArgs e)
        {
            prepareLevels();
        }

//=================================================================================================
        byte getCycle()
        {
            byte s = 0;
            byte.TryParse(txtCycle.Text, out s);
            return s;
        }
        int getInterval()
        {
            int i = 0;
            int.TryParse(txtInterval.Text,out i);
            return i;
        }
        void saveLevelInfo()
        {
            if (curAlmReason == null) return;
            if (preLevelIndex != -1)
            {
                AlarmLevel lev = curAlmReason.Item(preLevelIndex);
                lev.cycle = getCycle();
                lev.interval = getInterval();
                lev.language = cboLanguage.Text;
                List<string> list = new List<string>();
                foreach (string s in lstEmail.Items)
                    list.Add(s);
                lev.sendEmail = string.Join(",", list);

                list.Clear();
                foreach (string s in lstWeChat.Items)
                    list.Add(s);
                lev.sendWeChat = string.Join(",", list);

                list.Clear();
                foreach (string s in lstLine.Items)
                    list.Add(s);
                lev.sendLine = string.Join(",", list);
            } 
        }
        sbyte preLevelIndex = -1;
        private void cboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLevel.SelectedIndex.Equals(preLevelIndex)) return;
            if (curAlmReason == null) return;
            saveLevelInfo();
            preLevelIndex = (sbyte)cboLevel.SelectedIndex;

            clearLevelSetting();

            if (preLevelIndex != -1)
            {
                AlarmLevel lev = curAlmReason.Item(preLevelIndex);
                txtCycle.Text = lev.cycle.ToString();
                txtInterval.Text = lev.interval.ToString();
                cboLanguage.Text = lev.language;
                lstEmail.Items.AddRange(lev.sendEmail.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
                lstWeChat.Items.AddRange(lev.sendWeChat.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
                lstLine.Items.AddRange(lev.sendLine.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
            }
        }
        void clearLevelSetting()
        {
            txtCycle.Text = "";
            txtInterval.Text = "";
            cboLanguage.Text = "";
            txtEmail.Text = "";
            lstEmail.Items.Clear();
            txtWeChat.Text = "";
            lstWeChat.Items.Clear();
            cboLine.Text = "";
            lstLine.Items.Clear();
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnAddEmail.PerformClick();
        }

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            if (curAlmReason != null && !txtEmail.Text.Trim().Equals("") && !lstEmail.Items.Contains(txtEmail.Text.Trim()))
                lstEmail.Items.Add(txtEmail.Text.Trim());
            txtEmail.Text = "";
        }

        private void btnDeleteEmail_Click(object sender, EventArgs e)
        {
            if (lstEmail.SelectedIndex != -1)
                lstEmail.Items.RemoveAt(lstEmail.SelectedIndex);
        }

        private void txtWeChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnAddWeChat.PerformClick();
        }

        private void btnAddWeChat_Click(object sender, EventArgs e)
        {
            if (curAlmReason != null && !txtWeChat.Text.Trim().Equals("") && !lstWeChat.Items.Contains(txtWeChat.Text.Trim()))
                lstWeChat.Items.Add(txtWeChat.Text.Trim());
            txtWeChat.Text = "";
        }

        private void btnDeleteWeChat_Click(object sender, EventArgs e)
        {
            if (lstWeChat.SelectedIndex != -1)
                lstWeChat.Items.RemoveAt(lstWeChat.SelectedIndex);
        }

        private void cboLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnAddLine.PerformClick();
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (curAlmReason != null && !cboLine.Text.Trim().Equals("") && !lstLine.Items.Contains(cboLine.Text.Trim()))
                lstLine.Items.Add(cboLine.Text.Trim());
            cboLine.Text = "";
        }

        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            if (lstLine.SelectedIndex != -1)
                lstLine.Items.RemoveAt(lstLine.SelectedIndex);
        }

        private void btnEditLine_Click(object sender, EventArgs e)
        {
            if (frmEditLineGroup.edit())
                getLineGroup();
        }
    }
}
