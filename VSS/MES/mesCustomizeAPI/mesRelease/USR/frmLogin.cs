using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesRelease.USR
{
    public partial class frmLogin : Form
    {
        string[] fabs = new string[] { "" };
        public frmLogin()
        {
            InitializeComponent();
            lblInformation.Text = "";
            showFab();
            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        void showFab()
        {
            fabs = BAS.Fab.GetFabNames();
            if (!idv.mesCore.systemConfig.loginFabSelection || fabs.Length == 1)
            {
                lblFab.Visible = false;
                cboFab.Visible = false;
            }

            if (fabs.Length == 1)
                WF.WorkFlow.loginFAB = fabs[0];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text.Trim().Equals(""))
            {
                lblInformation.Text = idv.utilities.cultureLanguage.getValue("msgInputUserId");
                return;
            }
            if (txtPassword.Text.Trim().Equals(""))
            {
                lblInformation.Text = idv.utilities.cultureLanguage.getValue("msgInputPassword");
                return;
            }
            if (cboFab.Visible && cboFab.Text.Equals(""))
            {
                lblInformation.Text = idv.utilities.cultureLanguage.getValue("msgPlsSelectItem", lblFab.Text);
                return;
            }

            try
            {
                USR.User.LogOn(txtUserId.Text, txtPassword.Text);
                if (txtPassword.Text.Equals("000") || USR.User.loginUserId.ToLower().Equals(txtPassword.Text.ToLower()))
                    User.ChangePassword(true);
            }
            catch (Exception ex)
            {
                if (ex.Message == "user not found" || ex.Message == "user is not actived")
                {
                    lblInformation.Text = idv.utilities.cultureLanguage.getValue("msgUserNotFound");
                    txtUserId.Text = "";
                    txtPassword.Text = "";
                    txtUserId.Focus();
                }
                else if (ex.Message == "wrong password")
                {
                    lblInformation.Text = idv.utilities.cultureLanguage.getValue("msgPasswordInvalid");
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
                else
                {
                    string value = idv.utilities.cultureLanguage.getValue(ex.Message);
                    lblInformation.Text = value == "" ? ex.Message : value;
                }
                return;
            }
            if (cboFab.Visible)
                WF.WorkFlow.loginFAB = cboFab.Text;
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (!cboFab.Visible || txtUserId.Text.Trim().Equals("")) return;
            string userFab = idv.messageService.serviceHost.Client.getValueWithParameter("select fab from mes_user_profile where user_id=? or windows_account=?", txtUserId.Text, txtUserId.Text);
            cboFab.SelectedIndex = -1;
            cboFab.Enabled = true;
            string[] userFabs = userFab.Split(',');
            cboFab.Items.Clear();
            if (userFab.Trim().Length == 0)
            {
                cboFab.Items.AddRange(fabs);
            }
            else if (userFab.Split(',').Length == 1)
            {
                cboFab.Items.AddRange(fabs);
                cboFab.Text = userFab;
                cboFab.Enabled = false;
            }
            else
            {
                foreach (string fab in fabs)
                {
                    foreach (string s in userFabs)
                    {
                        if (s.Equals(fab))
                            cboFab.Items.Add(fab);
                    }
                }
            }

            if (cboFab.Enabled && cboFab.Items.Count > 0)
                cboFab.SelectedIndex = 0;
        }

        private void txtUserId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtUserId.Text.Length != 0)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPassword.Text.Length != 0)
            {
                if (!cboFab.Visible || !cboFab.Enabled)
                    btnOK.PerformClick();
                else
                    cboFab.Focus();
            }
        }

        private void cboFab_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cboFab.Text.Length != 0)
            {
                btnOK.PerformClick();
            }
        }
    }
}
