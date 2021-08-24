using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.USR;
using idv.utilities;
using idv.mesCore.Controls;
using idv.messageService;

namespace mesBasicData
{
    public partial class frmUserGroup : Form
    {
        string curGroup = "";
        List<string> lstMyPrevilegeString = new List<string>();

        public frmUserGroup()
        {
            InitializeComponent();
            lvwAvailableUser.prepareColumns();
            lvwSelectedUser.prepareColumns();
            lvwAvailableUser.MultiSelect = true;
            lvwSelectedUser.MultiSelect = true;
            lvwSteps.prepareColumns();
            lvwAvailablePrivilege.prepareColumns();
            lvwSelectedPrivilege.prepareColumns();
            lvwAvailablePrivilege.MultiSelect = true;
            lvwSelectedPrivilege.MultiSelect = true;
            initToolbar();
            initData();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query   
            actionToolbar1.Items["Query"].Visible = false;
            //actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
            //actionToolbar1.addButton("Export", "");
        }

        void initData()
        {                       
            foreach (idv.mesCore.misc.info s in idv.mesCore.misc.InformationGetDetail("UserGroup"))
            {
                if (User.loginUser.isAdmin() || string.IsNullOrWhiteSpace(s.remark) || string.Equals(s.remark, User.loginUser.privilegeGroup))
                    lvwGroups.Items.Add(s.value);
            }
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
                //case "Import":
                //    executeImport();
                //    break;
                //case "Export":
                //    executeExport();
                //    break;
            }
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtUserGroup, lblUserGroup)) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                string group = txtUserGroup.Text;
                UserGroup.AddGroup(group, User.loginUser.privilegeGroup, User.loginUser.name);

                foreach (itemBase s in lvwSteps.selectedMESItems)
                    UserGroup.AddStep(group, s.name);

                foreach (itemBase s in lvwSelectedUser.GetAllMESItem())
                    UserGroup.AddUser(group, s.name);

                foreach (itemBase s in lvwSelectedPrivilege.GetAllMESItem())
                    UserGroup.AddPrivilege(group, s as PrivilegeString);

                lvwGroups.Items.Add(group).Selected = true;
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
            if (lvwGroups.SelectedItems.Count == 0)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                ListViewItem item = lvwGroups.SelectedItems[0];
                updatePrivilegeStepAndUser(item.Text);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void updatePrivilegeStepAndUser(string userGroup)
        {
            //Step
            string[] steps = UserGroup.GetSteps(userGroup);
            List<ListViewItem> list = new List<ListViewItem>();//要增加的站點
            List<string> list2 = new List<string>();//要移除的站點
            
            list2.AddRange(steps); //加入原有的站點
            foreach (ListViewItem item in lvwSteps.CheckedItems)
            {
                list.Add(item);//加入勾選的站點
                list2.Remove((item.Tag as mesRelease.PRP.Step).name);//移除勾選的站點(剩餘的就是此次要移除的)
            }

            //勾選的-原有的=此次要新增的
            int i = 0;
            while (i < list.Count)
            {
                bool find = false;
                foreach (string s in steps)
                {
                    if ((list[i].Tag as mesRelease.PRP.Step).name == s)
                    {
                        list.RemoveAt(i);
                        find = true;
                        break;
                    }
                }
                if (!find)
                    i++;
            };            
            foreach (string s in list2)
                UserGroup.DeleteStep(userGroup, s);

            foreach (ListViewItem item in list)
                UserGroup.AddStep(userGroup, (item.Tag as mesRelease.PRP.Step).name);

            //PrivilegeString
            list.Clear();
            foreach (ListViewItem item in lvwSelectedPrivilege.Items)
                list.Add(item);
            i = 0;

            PrivilegeString[] groupPrivileges = UserGroup.GetPrivileges(userGroup);
            while (i < list.Count)
            {
                bool find = false;
                foreach (idv.messageService.itemBase item in groupPrivileges)
                {
                    if ((list[i].Tag as PrivilegeString).name == item.name)
                    {
                        list.RemoveAt(i);
                        find = true;
                        break;
                    }
                }
                if (!find)
                    i++;
            };
            foreach (ListViewItem item in list)
                UserGroup.AddPrivilege(userGroup, item.Tag as PrivilegeString);

            List<PrivilegeString> lstPrivilege = new List<PrivilegeString>();
            lstPrivilege.AddRange(UserGroup.GetPrivileges(userGroup));
            i = 0;
            while (i < lstPrivilege.Count)
            {
                bool find = false;
                foreach (ListViewItem item in lvwSelectedPrivilege.Items)
                {
                    if ((item.Tag as PrivilegeString).name == lstPrivilege[i].name)
                    {
                        lstPrivilege.RemoveAt(i);
                        find = true;
                        break;
                    }
                }
                if (!find)
                    i++;
            };

            foreach (PrivilegeString s in lstPrivilege)
                UserGroup.DeletePrivilege(userGroup, s);

            //User
            list.Clear();
            foreach (ListViewItem item in lvwSelectedUser.Items)
                list.Add(item);
            i = 0;

            User[] groupUsers = UserGroup.GetUsers(userGroup);
            while (i < list.Count)
            {
                bool find = false;
                foreach (idv.messageService.itemBase item in groupUsers)
                {
                    if ((list[i].Tag as User).name == item.name)
                    {
                        list.RemoveAt(i);
                        find = true;
                        break;
                    }
                }
                if (!find)
                    i++;
            };
            foreach (ListViewItem item in list)
                UserGroup.AddUser(userGroup, (item.Tag as User).name);

            List<User> lstUser = new List<User>();
            lstUser.AddRange(UserGroup.GetUsers(userGroup));
            i = 0;
            while (i < lstUser.Count)
            {
                bool find = false;
                foreach (ListViewItem item in lvwSelectedUser.Items)
                {
                    if ((item.Tag as User).name == lstUser[i].name)
                    {
                        lstUser.RemoveAt(i);
                        find = true;
                        break;
                    }
                }
                if (!find)
                    i++;
            };

            foreach (User s in lstUser)
                UserGroup.DeleteUser(userGroup, s.name);
        }

        void executeDelete()
        {
            if (lvwGroups.SelectedItems.Count == 0)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                ListViewItem item = lvwGroups.SelectedItems[0];
                UserGroup.DeleteGroup(item.Text);
                lvwGroups.Items.Remove(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        private void lvwGroups_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            curGroup = "";
            lvwAvailableUser.UpdateMESItem(lvwSelectedUser.GetAllMESItem());
            lvwSelectedUser.RemoveAllMESItems();
            lvwAvailablePrivilege.UpdateMESItem(lvwSelectedPrivilege.GetAllMESItem().Where(item => isMyPrivilege(item)).ToArray());
            lvwSelectedPrivilege.RemoveAllMESItems();
            lvwSteps.UnCheckAllItems();
            if (e.IsSelected)
            {
                curGroup = e.Item.Text;
                lvwSelectedUser.UpdateMESItem(UserGroup.GetUsers(curGroup));
                lvwAvailableUser.RemoveMESItem(lvwSelectedUser.GetAllMESItem());

                lvwSelectedPrivilege.UpdateMESItem(UserGroup.GetPrivileges(curGroup));
                lvwAvailablePrivilege.RemoveMESItem(lvwSelectedPrivilege.GetAllMESItem());

                lvwSteps.CheckMESItems(UserGroup.GetSteps(curGroup));
            }
            //btnSelectPrivilege.Enabled = e.IsSelected;
            //btnSelectUser.Enabled = e.IsSelected;
            //btnUnSelectPrivilege.Enabled = e.IsSelected;
            //btnUnSelectUser.Enabled = e.IsSelected;
        }

        bool isMyPrivilege(idv.messageService.itemBase item)
        {
            return lstMyPrevilegeString.Count == 0 || lstMyPrevilegeString.Contains(item.name);
        }

        private void lvwAvailablePrivilege_DoubleClick(object sender, EventArgs e)
        {
            btnSelectPrivilege.PerformClick();
        }

        private void lvwSelectedPrivilege_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelectPrivilege.PerformClick();
        }

        private void lvwSelectedUser_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelectUser.PerformClick();
        }

        private void lvwAvailableUser_DoubleClick(object sender, EventArgs e)
        {
            btnSelectUser.PerformClick();
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            if (lvwAvailableUser.selectedMESItem == null) return;
            lvwSelectedUser.UpdateMESItem(lvwAvailableUser.selectedMESItems);
            lvwAvailableUser.RemoveMESItem(null);
        }

        private void btnUnSelectUser_Click(object sender, EventArgs e)
        {
            if (lvwSelectedUser.selectedMESItem == null) return;
            lvwAvailableUser.UpdateMESItem(lvwSelectedUser.selectedMESItems);
            lvwSelectedUser.RemoveMESItem(null);
        }

        private void btnSelectPrivilege_Click(object sender, EventArgs e)
        {
            if (lvwAvailablePrivilege.selectedMESItem == null) return;
            lvwSelectedPrivilege.UpdateMESItem(lvwAvailablePrivilege.selectedMESItems);
            lvwAvailablePrivilege.RemoveMESItem(null);
        }

        private void btnUnSelectPrivilege_Click(object sender, EventArgs e)
        {
            if (lvwSelectedPrivilege.selectedMESItem == null) return;
            itemBase[] selItems = lvwSelectedPrivilege.selectedMESItems.Where(item => isMyPrivilege(item)).ToArray();
            lvwAvailablePrivilege.UpdateMESItem(selItems);
            lvwSelectedPrivilege.RemoveMESItem(selItems);
        }

        private void frmUserGroup_Activated(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(formActive));
        }

        void formActive()
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            if (idv.utilities.misc.IsValueChanged("frmUserInfo", Name))
            {
                lvwAvailableUser.ShowMESItems(User.GetUsers(""));
                if (!curGroup.Equals("")) lvwSelectedUser.ShowMESItems(UserGroup.GetUsers(curGroup));//modify
                lvwAvailableUser.RemoveMESItem(lvwSelectedUser.GetAllMESItem());
            }

            if (idv.utilities.misc.IsValueChanged("frmStep", Name))
            {
                lvwSteps.ShowMESItems(mesRelease.PRP.Step.GetActiveVersionSteps(""));
                if (!curGroup.Equals(""))
                    lvwSteps.CheckMESItems(UserGroup.GetSteps(curGroup));
            }

            if (idv.utilities.misc.IsValueChanged("frmAccessString", Name))
            {
                lstMyPrevilegeString = User.GetMyGrantedPrivilegeString(User.loginUserId);
                lvwAvailablePrivilege.ShowMESItems(PrivilegeString.GetPrivilegeStrings("").Where(item => isMyPrivilege(item)).ToArray());
                lvwAvailablePrivilege.RemoveMESItem(lvwSelectedPrivilege.GetAllMESItem());
            }
            Cursor = Cursors.Default;
        }
    }
}
