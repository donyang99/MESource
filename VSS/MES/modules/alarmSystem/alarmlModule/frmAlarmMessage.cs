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
    public partial class frmAlarmMessage : Form
    {
        public frmAlarmMessage()
        {
            InitializeComponent();
            initToolbar();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void frmAlarmMessage_Activated(object sender, EventArgs e)
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

        private void frmAlarmMessage_Load(object sender, EventArgs e)
        {
            lvwAlarmMessage.prepareColumns();
            lvwAlarmMessage.Columns[0].Width = 200;
            lvwAlarmMessage.Columns[1].Width = 100;
            lvwAlarmMessage.Columns[2].Width = 120;
            lvwAlarmMessage.Columns[3].Width = 120;
            lvwAlarmMessage.Columns[4].Width = 100;
            lvwAlarmMessage.Columns[5].Width = 100;
            lvwAlarmMessage.Columns[6].Width = 300;
            lvwAlarmMessage.Columns[7].Width = 200;
            lvwAlarmMessage.Columns[8].Width = 200;

            SortedList<int, object> srtList = new SortedList<int, object>();
            foreach (object o in Enum.GetValues(typeof(idv.mesCore.ALM.AlarmStatus)))
                srtList.Add((int)o, o);
            foreach (object o in srtList.Values)
                cboAlarmStatus.Items.Add(o);
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
                case "Modify":
                    editAlarmMessage(false);
                    break;
                case "Delete":
                    editAlarmMessage(true);
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

        void executeClear()
        {
            cboAlarmType.SelectedIndex = -1;
            cboAlarmStatus.SelectedIndex = -1;
            cboAlarmStatus.Text = "";
            cboAlarmReason.SelectedIndex = -1;
            cboAlarmReason.Text = "";
            cboObjectType.SelectedIndex = -1;
            cboObjectType.Text = "";
            txtObjectId.Text = "";
        }

        void executeQuery()
        {
            List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
            if (!cboAlarmType.Text.Equals(""))
                list.Add(new KeyValuePair<string, object>("alarm_type", cboAlarmType.Text));
            if(!cboAlarmReason.Text.Equals(""))
                list.Add(new KeyValuePair<string, object>("reason_code", cboAlarmReason.Text));
            if (!cboAlarmStatus.Text.Equals(""))
                list.Add(new KeyValuePair<string, object>("status", cboAlarmStatus.SelectedIndex.ToString()));

            if (!txtObjectId.Text.Equals(""))
                list.Add(new KeyValuePair<string, object>("object_id", txtObjectId.Text));
            if (!cboObjectType.Text.Equals(""))
                list.Add(new KeyValuePair<string, object>("object_type", cboObjectType.Text));
            lvwAlarmMessage.ShowMESItems(mesRelease.ALM.AlarmMessage.GetActiveAlarmMessages(list.ToArray()));
        }

        void editAlarmMessage(bool clear)
        {
            if (lvwAlarmMessage.selectedMESItem == null) return;
            idv.mesCore.ALM.alarmMessageBase alarm = lvwAlarmMessage.selectedMESItem as idv.mesCore.ALM.alarmMessageBase;
            if (alarm == null) return;
            frmEditAlarmMessage frm = new frmEditAlarmMessage();
            frm.clear = clear;
            try
            {
                idv.utilities.cultureLanguage.switchLanguage(frm);
                frm.alarmMessage = alarm;
                frm.ShowDialog();

                if (frm.result)
                {
                    if (alarm.status == idv.mesCore.ALM.AlarmStatus.Clear)
                        lvwAlarmMessage.RemoveMESItem(alarm);
                    else
                    {
                        lvwAlarmMessage.UpdateMESItem(alarm);
                        foreach (ListViewItem item in lvwAlarmMessage.SelectedItems)
                        {
                            item.Selected = false;
                            item.Selected = true;
                        }
                    }
                }
            }
            catch { }
            finally
            {
                frm.Close();
            }
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

        private void lvwAlarmMessage_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                actionToolbar1.Items["Modify"].Visible = false;
                actionToolbar1.Items["Delete"].Visible = false;
            }
            else
            {
                idv.mesCore.ALM.alarmMessageBase alarm = item as idv.mesCore.ALM.alarmMessageBase;
                if (alarm == null) return;
                if (alarm.status == idv.mesCore.ALM.AlarmStatus.New)
                {
                    actionToolbar1.Items["Modify"].Visible = true;
                    actionToolbar1.Items["Delete"].Visible = true;
                }
                else if (alarm.status == idv.mesCore.ALM.AlarmStatus.Action)
                {
                    actionToolbar1.Items["Delete"].Visible = true;
                }
            }
        }

    }
}
