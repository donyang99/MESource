using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mesRelease.EQP;
using mesRelease.ALM;

namespace mesFABMonitor
{
    public partial class frmEditAlarmMessage : Form
    {
        bool _clear = false;
        public bool clear
        {
            get { return _clear; }
            set { _clear = value; }
        }

        idv.mesCore.ALM.alarmMessageBase _alarmMessage = null;
        public frmEditAlarmMessage()
        {
            InitializeComponent();
        }

        public idv.mesCore.ALM.alarmMessageBase alarmMessage
        {
            set
            {
                _alarmMessage = value;
                txtEquipmentId.Text = _alarmMessage.objectId;
                txtAlarmType.Text = _alarmMessage.alarmType;
                txtDate.Text = _alarmMessage.createDate.ToString();
                txtMessage.Text = _alarmMessage.message;

                cboStatus.Items.Add(idv.mesCore.ALM.AlarmStatus.Action);
                cboStatus.Items.Add(idv.mesCore.ALM.AlarmStatus.Clear);
                if (!clear)
                    cboStatus.SelectedItem = idv.mesCore.ALM.AlarmStatus.Action;
                else
                    cboStatus.SelectedItem = idv.mesCore.ALM.AlarmStatus.Clear;
                cboStatus.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                _alarmMessage.status = (idv.mesCore.ALM.AlarmStatus)cboStatus.SelectedItem;
                _alarmMessage.serverFlag = false;
                _alarmMessage.To = "AlarmServer:*";

                if (_alarmMessage.status == idv.mesCore.ALM.AlarmStatus.Clear)
                {
                    //_alarmMessage.clearReason = clearReason;
                    _alarmMessage.clearComments = txtComments.Text;
                    _alarmMessage.clearUser = mesRelease.USR.User.loginUserId;
                }
                else
                {
                    _alarmMessage.actionComments = txtComments.Text;
                    _alarmMessage.modifyUser = mesRelease.USR.User.loginUserId;
                }
                _alarmMessage.send(5000);
                Close();
            }
            catch { }
        }
    }
}
