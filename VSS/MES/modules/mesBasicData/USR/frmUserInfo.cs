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

namespace mesBasicData
{
    public partial class frmUserInfo : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        User curItem = null;
        List<string> lstMyPrevilegeString = new List<string>();
        Color colNotMyGroup = SystemColors.ControlDark;

        public frmUserInfo()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);

            lvwUserGroup.ItemCheck += LvwUserGroup_ItemCheck;
        }

        bool eventFlag = true;
        private void LvwUserGroup_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!eventFlag) return;
            if (lvwUserGroup.Items[e.Index].BackColor == colNotMyGroup)
                e.NewValue = e.CurrentValue;
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query   
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
            actionToolbar1.addButton("Export", "");
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            initToolbar();
            List<string> lstNames = new List<string>();
            List<string> lstTags = new List<string>();
            lstNames.AddRange(lvwUsers.columnNames);
            lstTags.AddRange(lvwUsers.columnTags);
            if (frmExt != null)//維護畫面延伸功能
                idv.messageService.appModuleFunctionFormControlDefine.Init(frmExt, this, pnlExt, tblDetail, lstNames, lstTags);
            lvwUsers.columnNames = lstNames.ToArray();
            lvwUsers.columnTags = lstTags.ToArray();
            lvwUsers.prepareColumns();
            pnlExt.AutoSize = true;
            lvwSteps.prepareColumns();
            lvwAvailable.prepareColumns();
            lvwSelected.prepareColumns();
            lvwAvailable.MultiSelect = true;
            lvwSelected.MultiSelect = true;
            initData();
        }

        private void frmUserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void initData()
        {                        
            cboLanguage.Items.Add("");
            cboLanguage.Items.AddRange(idv.utilities.cultureLanguage.availableLanguage);
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
                case "Query":
                    executeQuery();
                    break;
                case "Clear":
                    executeClear();
                    break;
                case "Import":
                    executeImport();
                    break;
                case "Export":
                    executeExport();
                    break;
            }
        }

        void executeClear()
        {
            txtUserId.Text = "";
            txtWindowsAccount.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            cboFab.Text = "";
            cboDivision.Text = "";
            cboLanguage.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }
        
        void executeQuery()
        {
            string condition = "";
            if (txtUserId.Text.Trim() != "")
                condition = "user_id like '%" + txtUserId.Text.Trim() + "%'";
            if (cboFab.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "fab = '" + cboFab.Text + "'";
            }  
            if (cboDivision.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "division = '" + cboDivision.Text + "'";
            }            
            lvwUsers.ShowMESItems(User.GetUsers(condition));
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtUserId, lblUserId, txtPassword, lblPassword, cboDivision, lblDivision)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                User item = new User();
                item.name = txtUserId.Text;
                item.windowsAccount = txtWindowsAccount.Text;
                item.nickName = txtUserName.Text;
                item.password = txtPassword.Text;
                item.fab = cboFab.Text;
                item.division = cboDivision.Text;
                item.mobile = txtMobile.Text;
                item.email = txtEmail.Text;
                item.language = cboLanguage.Text;
                if (User.loginUser.isAdmin())//管理員維護帳號時將用戶的部門寫入Mibile2欄位(用來判別「帳號管理員」可以指定的用戶群組)
                    item.privilegeGroup = item.division;
                item.createUser = User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New();

                foreach (idv.messageService.itemBase p in lvwSelected.GetAllMESItem())
                    item.AddPrivilege(p as PrivilegeString);

                foreach (idv.messageService.itemBase s in lvwSteps.selectedMESItems)
                    item.AddStep(s.name);

                //modify
                foreach (ListViewItem vItem in lvwUserGroup.CheckedItems)
                    item.AddGroup(vItem.Name);
                
                lvwUsers.UpdateMESItem(item);
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
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!appInstance.CheckInputData(txtUserId, lblUserId, cboDivision, lblDivision)) return;

            if (curItem.name != txtUserId.Text)
            {
                appInstance.showInformation(cultureLanguage.getValue("cantModifyField", lblUserId.Text), informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("modify", curItem)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                curItem.windowsAccount = txtWindowsAccount.Text;
                curItem.nickName = txtUserName.Text;
                curItem.fab = cboFab.Text;
                curItem.division = cboDivision.Text;
                curItem.mobile = txtMobile.Text;
                curItem.email = txtEmail.Text;
                curItem.language = cboLanguage.Text;
                if (User.loginUser.isAdmin())//管理員維護帳號時將用戶的部門寫入Mibile2欄位(用來判別「帳號管理員」可以指定的用戶群組)
                    curItem.privilegeGroup = curItem.division;
                curItem.modifyUser = User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(curItem);//維護畫面延伸功能
                curItem.Modify();                

                if (txtPassword.Text != "")
                    curItem.ChangePassword(txtPassword.Text);

                updatePrivilegeAndStep();
                lvwUsers.UpdateMESItem(curItem);

                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }
        void updatePrivilegeAndStep()
        {
            //Step
            List<ListViewItem> list = new List<ListViewItem>();
            List<string> list2 = new List<string>();
            list2.AddRange(curItem.userStep);
            foreach (ListViewItem item in lvwSteps.CheckedItems)
            {
                list.Add(item);
                list2.Remove((item.Tag as mesRelease.PRP.Step).name);
            }

            int i = 0;
            while (i < list.Count)
            {
                bool find = false;
                foreach (string s in curItem.userStep)
                {
                    if ((list[i].Tag as mesRelease.PRP.Step).name.Equals(s))
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
                curItem.DeleteStep(s);//delete original(step)

            foreach (ListViewItem item in list)
                curItem.AddStep((item.Tag as mesRelease.PRP.Step).name);//new add(step)

            //Privilege
            list.Clear();
            foreach (ListViewItem item in lvwSelected.Items)
                list.Add(item);
            i = 0;
            while (i < list.Count)
            {
                bool find = false;
                foreach (idv.messageService.itemBase item in curItem.GetUserPrivileges())
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
                curItem.AddPrivilege(item.Tag as PrivilegeString);//new add(privilege)

            List<PrivilegeString> list3 = new List<PrivilegeString>();
            list3.AddRange(curItem.GetUserPrivileges());
            i = 0;
            while (i < list3.Count)
            {
                bool find = false;
                foreach (ListViewItem item in lvwSelected.Items)
                {
                    if ((item.Tag as PrivilegeString).name == list3[i].name)
                    {
                        list3.RemoveAt(i);
                        find = true;
                        break;
                    }
                }
                if (!find)
                    i++;
            };

            foreach (PrivilegeString s in list3)
                curItem.DeletePrivilege(s);//delete original(privilege)

            //modify
            //Group
            list.Clear();
            list2.Clear();
            list2.AddRange(curItem.userGroup);
            foreach (ListViewItem item in lvwUserGroup.CheckedItems)
            {
                list.Add(item);
                list2.Remove(item.Name);
            }

            i = 0;
            while (i < list.Count)
            {
                bool find = false;
                foreach (string s in curItem.userGroup)
                {
                    if (list[i].Name.Equals(s))
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
                curItem.DeleteGroup(s);//delete original(userGroup)

            foreach (ListViewItem item in list)
                curItem.AddGroup(item.Name);//new add(userGroup)
        }

        void executeDelete()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                curItem.Delete();
                lvwUsers.RemoveMESItem(curItem);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        private void HandlerSendKeyTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }

        private void lvwUsers_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                executeClear();
                curItem = null;
            }
            else
            {
                curItem = item as User;
                if (curItem != null)
                {
                    txtUserId.Text = curItem.name;
                    txtWindowsAccount.Text = curItem.windowsAccount;
                    txtUserName.Text = curItem.nickName;
                    txtMobile.Text = curItem.mobile;
                    txtEmail.Text = curItem.email;
                    cboFab.Text = curItem.fab;
                    cboDivision.Text = curItem.division;
                    cboLanguage.Text = curItem.language;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(curItem);
                }
            }
            showSelectedItems();
        }

        void showSelectedItems()
        {
            lvwAvailable.UpdateMESItem(lvwSelected.GetAllMESItem().Where(item => isMyPrivilege(item)).ToArray());
            lvwSelected.RemoveAllMESItems();
            lvwSteps.UnCheckAllItems();
            bool forceRetrieveGroup = false;//modify
            if (curItem == null)
            {
                //btnSelect.Enabled = false;
                //btnUnSelect.Enabled = false;
            }
            else
            {
                forceRetrieveGroup = curItem.isInfoRetrieved();//modify
                curItem.retrieveAll();
                lvwSelected.UpdateMESItem(curItem.GetUserPrivileges());
                lvwSelected.AutoSizeAllColumns();
                lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
                lvwSteps.CheckMESItems(curItem.userStep);
                //btnSelect.Enabled = true;
                //btnUnSelect.Enabled = true;
            }
            showUserGroup(forceRetrieveGroup);//modify
        }

        bool isMyPrivilege(idv.messageService.itemBase item)
        {
            return lstMyPrevilegeString.Count == 0 || lstMyPrevilegeString.Contains(item.name);
        }

        //modify
        void showUserGroup(bool force)
        {
            eventFlag = false;
            foreach (ListViewItem item in lvwUserGroup.Items)
            {
                item.Checked = false;
                item.BackColor = isMyGroup(item) ? Color.White : colNotMyGroup;
            }
            if (curItem == null)
            {
                eventFlag = true;
                return;
            }
            curItem.retrieveGroups(force);
            foreach (string s in curItem.userGroup)
            {
                ListViewItem item = lvwUserGroup.Items[s];
                if (item != null)
                    item.Checked = true;
            }
            eventFlag = true;
        }
        bool isMyGroup(ListViewItem vItem)
        {
            if (User.loginUser.isAdmin()) return true;
            if (string.IsNullOrWhiteSpace(User.loginUser.privilegeGroup)) return false;
            try
            {
                idv.mesCore.misc.info info = (idv.mesCore.misc.info)vItem.Tag;
                if (string.IsNullOrWhiteSpace(info.remark) || string.Equals(info.remark, User.loginUser.privilegeGroup))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
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
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (lvwSelected.selectedMESItem == null) return;
            idv.messageService.itemBase[] selItems = lvwSelected.selectedMESItems.Where(item => isMyPrivilege(item)).ToArray();
            lvwAvailable.UpdateMESItem(selItems);
            lvwSelected.RemoveMESItem(selItems);
        }

        void executeExport()
        {
            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(lvwUsers))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        void executeImport()
        {
            bool allSucceed = true;
            DataTable table = mesRelease.utilities.ExcelAgent.ImpportSelectExcel();
            List<string> columns = new List<string>();
            columns.AddRange("UserId,UserName,Password,Fab,Division,Mobile,Email,Language".Split(','));
            foreach (DataColumn col in table.Columns)
                columns.Remove(col.ColumnName);
            if (columns.Count > 0)
            {
                appInstance.showInformationById("invalidFormat", informationType.warn);
                return;
            }
            foreach (DataRow row in table.Rows)
            {
                try
                {
                    User item = new User();
                    item.name = row["UserId"].ToString();
                    item.nickName = row["UserName"].ToString();
                    item.password = row["Password"].ToString();
                    item.fab = row["Fab"].ToString();
                    item.division = row["Division"].ToString();
                    item.mobile = row["Mobile"].ToString();
                    item.email = row["Email"].ToString();
                    item.language = row["Language"].ToString();
                    item.createUser = mesRelease.USR.User.loginUser.name;
                    item.createDate = DateTime.Now;
                    item.New();
                    for (int i = 8; i < table.Columns.Count; i++)
                    {
                        if (row[i].ToString() == "") break;
                        item.AddStep(row[i].ToString());
                    }

                    lvwUsers.UpdateMESItem(item);
                }
                catch (Exception ex)
                {
                    allSucceed = false;
                    messageBox.showMessage(ex.Message, messageStyle.error);
                    break;
                }
            }
            misc.SetValueChangeByItemName(Name);
            if (allSucceed)
                messageBox.showMessageById("msgExecuteSucceed");
        }
        void executeImport2()
        {
            bool succeed = false;
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "excel(*.xls)|*.xls";
            ofg.ShowDialog();
            if (ofg.FileName == "") return;
            using (System.IO.TextReader reader = new System.IO.StreamReader(ofg.FileName, Encoding.Default))
            {

                bool check = false;
                lvwUsers.RemoveAllMESItems();
                bool tmp = lvwUsers.makesureNewItemVisible;
                lvwUsers.makesureNewItemVisible = false;
                do
                {
                    string s = reader.ReadLine();
                    if (s == null) break;
                    if (!check)
                    {
                        if (!s.ToUpper().StartsWith("UserId\tUserName\tPassword\tFab\tDivision\tMobile\tEmail\tLanguage".ToUpper()))
                        {
                            appInstance.showInformationById("invalidFormat", informationType.warn);
                            break;
                        }
                        check = true;
                        succeed = true;
                    }
                    else
                    {
                        string[] user = s.Split('\t');
                        try
                        {
                            User item = new User();
                            item.name = user[0];
                            item.nickName = user[1];
                            item.password = user[2];
                            item.fab = user[3];
                            item.division = user[4];
                            item.mobile = user[5];
                            item.email = user[6];
                            item.language = user[7];
                            item.createUser = mesRelease.USR.User.loginUser.name;
                            item.createDate = DateTime.Now;
                            item.New();
                            for (int i = 8; i < user.Length; i++)
                            {
                                if (user[i] == "") break;
                                item.AddStep(user[i]);
                            }

                            lvwUsers.UpdateMESItem(item);
                            appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                        }
                        catch (Exception ex)
                        {
                            succeed = false;
                            appInstance.showInformation(ex.Message, informationType.error);
                            break;
                        }
                    }
                } while (true);
                lvwUsers.makesureNewItemVisible = tmp;
            }
            idv.utilities.misc.SetValueChangeByItemName(Name);
            if (succeed)
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        private void frmUserInfo_Activated(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(formActive));
        }

        void formActive()
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            if (idv.utilities.misc.IsValueChanged("frmFAB", Name))
            {
                string orgFab = cboFab.Text;
                cboFab.Items.Clear();
                cboFab.Items.Add("");
                cboFab.Items.AddRange(mesRelease.BAS.Fab.GetFabs());
                if (!orgFab.Equals(""))
                    cboFab.Text = orgFab;
            }

            if (idv.utilities.misc.IsValueChanged("frmDivision", Name))
            {
                string orgDivision = cboDivision.Text;
                cboDivision.Items.Clear();
                cboDivision.Items.Add("");
                cboDivision.Items.AddRange(idv.mesCore.misc.DivisionGet());
                if (!orgDivision.Equals(""))
                    cboDivision.Text = orgDivision;
            }

            if (idv.utilities.misc.IsValueChanged("frmStep", Name))
            {
                lvwSteps.ShowMESItems(mesRelease.PRP.Step.GetActiveVersionSteps(""));
                if (curItem != null)
                    lvwSteps.CheckMESItems(curItem.userStep);
            }

            if (idv.utilities.misc.IsValueChanged("frmAccessString", Name))
            {
                lstMyPrevilegeString = User.GetMyGrantedPrivilegeString(User.loginUserId);
                lvwAvailable.ShowMESItems(PrivilegeString.GetPrivilegeStrings("").Where(item => isMyPrivilege(item)).ToArray());
                lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
            }

            if (idv.utilities.misc.IsValueChanged("frmUserGroup", Name))
            {
                lvwUserGroup.Items.Clear();
                foreach (idv.mesCore.misc.info s in idv.mesCore.misc.InformationGetDetail("UserGroup"))
                {
                    ListViewItem item = lvwUserGroup.Items.Add(s.value);
                    item.Name = s.value;
                    item.Tag = s;
                }
                showUserGroup(true);
            }

            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmUserInfo_Activated", null);

            Cursor = Cursors.Default;
        }
    }
}
