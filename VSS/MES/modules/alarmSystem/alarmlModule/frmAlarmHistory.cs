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

namespace alarmModule
{
    public partial class frmAlarmHistory : Form
    {
        public frmAlarmHistory()
        {
            InitializeComponent();
            initToolbar();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }
        private void frmAlarmHistory_Activated(object sender, EventArgs e)
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
        private void frmAlarmHistory_Load(object sender, EventArgs e)
        {
            lvwAlarmMessage.prepareColumns();
            lvwAlarmMessage.Columns[0].Width = 200;
            lvwAlarmMessage.Columns[1].Width = 100;
            lvwAlarmMessage.Columns[2].Width = 120;
            lvwAlarmMessage.Columns[3].Width = 120;
            lvwAlarmMessage.Columns[4].Width = 100;//reasonCode
            lvwAlarmMessage.Columns[5].Width = 100;
            lvwAlarmMessage.Columns[6].Width = 120;//comment
            lvwAlarmMessage.Columns[7].Width = 120;//處理人員
            lvwAlarmMessage.Columns[8].Width = 120;//處理日期
            lvwAlarmMessage.Columns[9].Width = 120;//處理備註
            lvwAlarmMessage.Columns[10].Width = 120;//清除人員
            lvwAlarmMessage.Columns[11].Width = 120;//清除日期
            lvwAlarmMessage.Columns[12].Width = 120;//清除原因
            lvwAlarmMessage.Columns[13].Width = 120;//清除備註

            dtFrom.Value = idv.messageService.serviceHost.dateTime.Date;
            dtTo.Value = idv.messageService.serviceHost.dateTime.Date.AddDays(1).AddSeconds(-1);
            dtFrom.Checked = false;
            dtTo.Checked = false;
        }
        void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query;
            actionToolbar1.Items["Add"].Visible = false;
            actionToolbar1.Items["Modify"].Visible = false;
            actionToolbar1.Items["Delete"].Visible = false;
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Export", "");//add button needed with privilege string
        }

        private void actionToolbar1_ActionClicked(string actionName)
        {
            appInstance.showInformation("");
            switch (actionName)
            {
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

        void executeClear()
        {
            cboAlarmType.SelectedIndex = -1;
            cboAlarmReason.SelectedIndex = -1;
            cboAlarmReason.Text = "";
            cboObjectType.SelectedIndex = -1;
            cboObjectType.Text = "";
            txtObjectId.Text = "";
            dtFrom.Checked = false;
            dtTo.Checked = false;
        }

        void executeQuery()
        {
            List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
            if (!cboAlarmType.Text.Equals(""))
                list.Add(new KeyValuePair<string, object>("alarm_type", cboAlarmType.Text));
            if (!cboAlarmReason.Text.Equals(""))
                list.Add(new KeyValuePair<string, object>("reason_code", cboAlarmReason.Text));

            if (!txtObjectId.Text.Equals(""))
                list.Add(new KeyValuePair<string, object>("object_id", txtObjectId.Text));
            if (!cboObjectType.Text.Equals(""))
                list.Add(new KeyValuePair<string, object>("object_type", cboObjectType.Text));

            if(dtFrom.Checked)
                list.Add(new KeyValuePair<string, object>("create_date>=", dtFrom.Value));

            if (dtTo.Checked)
                list.Add(new KeyValuePair<string, object>("create_date<=", dtTo.Value));

            if (list.Count == 0)
            {
                idv.utilities.messageBox.showMessageById("msgNoConditionSpecified");
                return;
            }
            lvwAlarmMessage.ShowMESItems(mesRelease.ALM.AlarmMessage.GetAlarmMessagesHis(list.ToArray()));
        }

        void executeExport()
        {
            if (mesRelease.utilities.ExcelAgent.WriteToFile(lvwAlarmMessage))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        string prevSel = "";
        private void cboAlarmType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboAlarmType.SelectedItem == null) return;
            if (prevSel.Equals(cboAlarmType.Text)) return;
            prevSel = cboAlarmType.Text;
            cboAlarmReason.Items.Clear();
            cboAlarmReason.Text = "";
            mesRelease.ALM.AlarmType almType = cboAlarmType.SelectedItem as mesRelease.ALM.AlarmType;
            cboAlarmReason.Items.AddRange(almType.GetReasonCode());
        }

    }
}
