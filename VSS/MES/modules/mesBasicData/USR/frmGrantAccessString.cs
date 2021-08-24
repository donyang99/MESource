using System;
using System.Collections.Generic;
using mesRelease.USR;
using idv.utilities;
using System.Windows.Forms;

namespace mesBasicData
{
    public partial class frmGrantAccessString : Form
    {
        string curUserId = "";

        public frmGrantAccessString()
        {
            InitializeComponent();
            initToolbar();
            lvwAvailable.prepareColumns();
            lvwSelected.prepareColumns();
            lvwAvailable.MultiSelect = true;
            lvwSelected.MultiSelect = true;
        }

        private void initToolbar()
        {
            actionToolbar1.addButton("Modify", "MODIFY");
            actionToolbar1.addButton("Copy", "MODIFY");
        }

        private void actionToolbar1_ActionClicked(string actionName)
        {
            appInstance.showInformation("");
            switch (actionName)
            {
                case "Modify":
                    executeModify();
                    break;
                case "Copy":
                    executeCopy();
                    break;
            }
        }

        void executeModify()
        {
            if (string.Equals(curUserId,""))
            {
                messageBox.showMessageById("noItemSelected", messageStyle.error);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;

            try
            {
                List<PrivilegeString> list = new List<PrivilegeString>();
                foreach (idv.messageService.itemBase item in lvwSelected.GetAllMESItem())
                    list.Add(item as PrivilegeString);
                User.ModifyMyGrantedPrivilegeString(curUserId, list.ToArray());

                messageBox.showMessageById("msgExecuteSucceed", messageStyle.success);
            }
            catch (Exception ex)
            {
                messageBox.showMessage(ex.Message, messageStyle.error);
            }
        }
        void executeCopy()
        {            
            if (string.Equals(curUserId, ""))
            {
                messageBox.showMessageById("noItemSelected", messageStyle.error);
                return;
            }

            showSelUserPanel();
        }

        void formLoad()
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            lvwAvailable.ShowMESItems(PrivilegeString.GetPrivilegeStrings(""));
            lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());

            Cursor = Cursors.Default;
        }

        private void frmGrantAccessString_Load(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(formLoad));
        }

        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == txtUserId)
                {
                    lvwAvailable.UpdateMESItem(lvwSelected.GetAllMESItem());
                    lvwSelected.RemoveAllMESItems();
                    curUserId = "";
                    txtUserName.Text = "";
                    User u = new User(txtUserId.Text.Trim());
                    if (string.IsNullOrWhiteSpace(u.sysid))
                        txtUserId.Text = "";
                    else
                    {
                        curUserId = u.name;
                        txtUserName.Text = u.nickName;
                        foreach (string s in User.GetMyGrantedPrivilegeString(u.name))
                            lvwSelected.UpdateMESItem(lvwAvailable.GetMESItemByName(s, true));

                    }
                }
                else
                {
                    User u = new User(txtSelUserId.Text.Trim());
                    txtSelUserId.Text = "";
                    txtSelUserName.Text = "";
                    btnOK.Enabled = false;
                    if (!string.IsNullOrWhiteSpace(u.sysid) && !string.Equals(txtUserId.Text.Trim(), u.name))
                    {
                        txtSelUserId.Text = u.name;
                        txtSelUserName.Text = u.nickName;
                        btnOK.Enabled = true;
                    }
                }
            }
        }

        private void lvwSelected_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void lvwAvailable_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvwAvailable.selectedMESItem == null) return;
            lvwSelected.UpdateMESItem(lvwAvailable.selectedMESItems);
            lvwAvailable.RemoveMESItem(null);
            lvwSelected.AutoSizeAllColumns();
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (lvwSelected.selectedMESItem == null) return;
            idv.messageService.itemBase[] selItems = lvwSelected.selectedMESItems;
            lvwAvailable.UpdateMESItem(selItems);
            lvwSelected.RemoveMESItem(selItems);
        }

        void showSelUserPanel()
        {
            txtSelUserId.Text = "";
            txtSelUserName.Text = "";
            btnOK.Enabled = false;
            pnlSelectUser.Visible = true;
            pnlSelectUser.Location = PointToClient(Cursor.Position);
            txtSelUserId.Focus();
        }

        private void pnlSelectUser_Leave(object sender, EventArgs e)
        {
            pnlSelectUser.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlSelectUser.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("buttonCopy"))) return;
            try
            {
                List<PrivilegeString> list = new List<PrivilegeString>();
                foreach (idv.messageService.itemBase item in lvwSelected.GetAllMESItem())
                    list.Add(item as PrivilegeString);
                User.ModifyMyGrantedPrivilegeString(txtSelUserId.Text, list.ToArray());
                pnlSelectUser.Visible = false;
                messageBox.showMessageById("msgExecuteSucceed", messageStyle.success);
            }
            catch (Exception ex)
            {
                messageBox.showMessage(ex.Message, messageStyle.error);
            }
        }
    }
}
