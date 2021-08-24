using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.USR;

namespace mesRelease.USR
{
    public partial class frmChangePassword : Form
    {
        bool _force = false;
        public bool force
        {
            get { return _force; }
            set
            {
                _force = value;
                txtOriginalPassword.Enabled = !_force;
                ControlBox = !_force;
                btnCancel.Enabled = !_force;
            }
        }

        bool _result = false;
        public bool result
        {
            get { return _result; }
            set { _result = value; }
        }

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_force && !User.loginUser.CheckPassword(txtOriginalPassword.Text))
                {
                    idv.utilities.messageBox.showMessageById("msgPasswordInvalid");
                    return;
                }
                else if (txtNewPassword.Text != txtConfirmPassword.Text || txtNewPassword.Text == "")
                {
                    idv.utilities.messageBox.showMessageById("msgInputPassword");
                    return;
                }
                User.loginUser.ChangePassword(txtNewPassword.Text);
                string msg = Text + " " + idv.utilities.cultureLanguage.getValue("msgExecuteSucceed");
                idv.utilities.messageBox.showMessage(msg);
                Close();
            }
            catch { }
        }

        private void txtOriginalPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtOriginalPassword.Text.Length != 0)
            {
                txtNewPassword.Focus();
            }
        }

        private void txtNewPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtNewPassword.Text.Length != 0)
            {
                txtConfirmPassword.Focus();
            }
        }

        private void txtConfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtConfirmPassword.Text.Length != 0)
            {
                btnOK.PerformClick();
            }
        }
    }
}
