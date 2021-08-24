using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mesRelease.USR;
using mesRelease.ALM;

namespace mesFABMonitor
{
    public partial class frmNotice : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmNotice()
        {
            InitializeComponent();
            HideOnClose = true;
            lvwAlarm.prepareColumns();
            actionToolbar1.loadStandardButtons();
            actionToolbar1.Items["Add"].Visible = false;
            actionToolbar1.Items["Delete"].Visible = false;
            actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Clear", "CLEAR");
        }

        public void CheckPrivilege()
        {
            if (User.loginUser == null)
                actionToolbar1.Items["Modify"].Enabled = false;
            else
                actionToolbar1.Items["Modify"].Enabled = User.loginUser.CheckFunctionPrivilege("IDE:FMS:ALARM:EDIT");
            actionToolbar1.Items["Clear"].Enabled = actionToolbar1.Items["Modify"].Enabled;
            actionToolbar1.Items["Modify"].Visible = false;
            actionToolbar1.Items["Clear"].Visible = false;
        }

        private void actionToolbar1_ActionClicked(string actionName)
        {
            switch (actionName)
            { 
                case "Modify":
                    editAlarmMessage(false);
                    break;
                case "Clear":
                    editAlarmMessage(true);
                    break;
            }
        }

        void editAlarmMessage(bool clear)
        {
            if (lvwAlarm.selectedMESItem == null) return;
            idv.mesCore.ALM.alarmMessageBase alarm = lvwAlarm.selectedMESItem as idv.mesCore.ALM.alarmMessageBase;
            if (alarm == null) return;
            frmEditAlarmMessage frm = new frmEditAlarmMessage();
            frm.clear = clear;
            try
            {
                idv.utilities.cultureLanguage.switchLanguage(frm);
                frm.alarmMessage = alarm;
                frm.ShowDialog();
            }
            catch { }
            finally 
            {
                frm.Close();
            }
        }

        private void lvwAlarm_MESItemSelectionChanging(idv.messageService.itemBase item, ListViewItem listItem, bool selected, ref bool Cancel)
        {
            if (!selected)
            {
                actionToolbar1.Items["Modify"].Visible = false;
                actionToolbar1.Items["Clear"].Visible = false;
            }
            else
            {
                idv.mesCore.ALM.alarmMessageBase alarm = item as idv.mesCore.ALM.alarmMessageBase;
                if (alarm == null) return;
                if (alarm.status == idv.mesCore.ALM.AlarmStatus.New)
                {
                    actionToolbar1.Items["Modify"].Visible = true;
                    actionToolbar1.Items["Clear"].Visible = true;
                }
                else if (alarm.status == idv.mesCore.ALM.AlarmStatus.Action)
                {
                    actionToolbar1.Items["Clear"].Visible = true;
                }
            }
        }
    }
}
