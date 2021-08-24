using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.mesCore.Controls;
using idv.utilities;
using mesRelease.BAS;

namespace mesBasicData
{
    public partial class frmReasonGroup : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        ReasonGroup curItem = null;
        public frmReasonGroup()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            tblReasonGroup.loadStandardButtons();//Add, Modify, Delete, Query
            tblReasonGroup.addButton("Clear", "");
            tblReasonGroup.addButton("Export", "");
        }

        private void frmReasonGroup_Load(object sender, EventArgs e)
        {
            initToolbar();
            List<string> lstNames = new List<string>();
            List<string> lstTags = new List<string>();
            lstNames.AddRange(lvwReasonGroup.columnNames);
            lstTags.AddRange(lvwReasonGroup.columnTags);
            if (frmExt != null)//維護畫面延伸功能
                idv.messageService.appModuleFunctionFormControlDefine.Init(frmExt, this, pnlExt, tblDetail, lstNames, lstTags);
            lvwReasonGroup.columnNames = lstNames.ToArray();
            lvwReasonGroup.columnTags = lstTags.ToArray();
            lvwReasonGroup.prepareColumns();

            lvwAvailableReason.prepareColumns();
            lvwAvailableReason.MultiSelect = true;
            lvwSelectedReason.prepareColumns();
            lvwSelectedReason.MultiSelect = true;
            pnlExt.AutoSize = true;
        }

        private void frmReasonGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void lvwReasonGroup_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                groupExecuteClear();
                btnSelect.Enabled = false;
                btnUnSelect.Enabled = false;
                curItem = null;
            }
            else
            {
                curItem = item as ReasonGroup;
                if (curItem != null)
                {
                    txtReasonGroup.Text = curItem.name;
                    txtDescription.Text = curItem.description;
                    btnSelect.Enabled = true;
                    btnUnSelect.Enabled = true;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(curItem);
                }
            }
            showSelectedReasonCodes();
        }

        void showSelectedReasonCodes()
        {
            if (lvwSelectedReason.Items.Count > 0)
            {
                //lvwAvailableReason.UpdateMESItem(lvwSelectedReason.GetAllMESItem());
                lvwSelectedReason.RemoveAllMESItems();
            }

            if (curItem != null)
            {
                curItem.retrieveReasonCodes();
                lvwSelectedReason.Visible = false;
                lvwSelectedReason.UpdateMESItem(curItem.Items.ToArray());
                lvwSelectedReason.Visible = true;
                //lvwAvailableReason.RemoveMESItem(curItem.Items.ToArray());
            }
        }

        private void tblReasonGroup_ActionClicked(string actionName)
        {

            appInstance.showInformation("");
            switch (actionName)
            {
                case "Add":
                    groupExecuteAdd();
                    break;
                case "Modify":
                    groupExecuteModify();
                    break;
                case "Delete":
                    groupExecuteDelete();
                    break;
                case "Query":
                    groupExecuteQuery();
                    break;
                case "Clear":
                    groupExecuteClear();
                    break;
                case "Export":
                    groupExecuteExport();
                    break;
            }
        }

        void groupExecuteClear()
        {
            txtReasonGroup.Text = "";
            txtDescription.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void groupExecuteAdd()
        {          
            if (!appInstance.CheckInputData(txtReasonGroup, lblReasonGroup)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                ReasonGroup item = new ReasonGroup();
                item.name = txtReasonGroup.Text;
                item.description = txtDescription.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New();
                lvwReasonGroup.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void groupExecuteModify()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (!appInstance.CheckInputData(txtReasonGroup, lblReasonGroup))
                return;

            if (frmExt != null && !frmExt.CheckData("modify", curItem)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;            
            try
            {
                curItem.name = txtReasonGroup.Text;
                curItem.description = txtDescription.Text;
                curItem.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(curItem);//維護畫面延伸功能
                curItem.Modify();
                lvwReasonGroup.UpdateMESItem(curItem);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void groupExecuteDelete()
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
                lvwReasonGroup.RemoveMESItem(curItem);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void groupExecuteQuery()
        {
            string condition = "";
            if (txtReasonGroup.Text.Trim() != "")
                condition = "group_id like '%" + txtReasonGroup.Text.Trim() + "%'";
            lvwReasonGroup.SelectedItems.Clear();
            ReasonGroup[] items = ReasonGroup.getReasonGroups(condition);
            lvwReasonGroup.ShowMESItems(items);
            groupExecuteClear();
        }

        void groupExecuteExport()
        {
            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(lvwReasonGroup))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        void getAllReasonCode()
        {
            ReasonCode[] r = ReasonCode.getReasonCodes("");
            lvwAvailableReason.ShowMESItems(r);
            //if (curItem != null)
            //    lvwAvailableReason.RemoveMESItem(curItem.Items.ToArray());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lvwAvailableReason.ClearFilterItems();
            if (txtFilterReason.Text != "")
            {
                MESListViewFilterItem f = new MESListViewFilterItem();
                f.columnName = "name";
                f.values = new string[] { txtFilterReason.Text };
                lvwAvailableReason.AddFilterItem(f);
            }
            lvwAvailableReason.RefreshListView();
        }

        private void txtFilterReason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFilter.PerformClick();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (idv.messageService.itemBase item in lvwAvailableReason.selectedMESItems)
            {
                try
                {
                    if (lvwSelectedReason.GetMESItemByName(item.name) != null) continue;
                    curItem.Add(item as ReasonCode);
                    //lvwAvailableReason.RemoveMESItem(item);
                    lvwSelectedReason.UpdateMESItem(item);
                }
                catch { }
            }
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            foreach (idv.messageService.itemBase item in lvwSelectedReason.selectedMESItems)
            {
                try
                {
                    curItem.Remove(item.name);
                    lvwSelectedReason.RemoveMESItem(item);
                    //lvwAvailableReason.UpdateMESItem(item);
                }
                catch { }
            }
        }

        private void txtReasonGroup_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }

        private void lvwAvailableReason_DoubleClick(object sender, EventArgs e)
        {
            if (lvwAvailableReason.selectedMESItem != null)
                btnSelect.PerformClick();
            
        }

        private void lvwSelectedReason_DoubleClick(object sender, EventArgs e)
        {
            if (lvwSelectedReason.selectedMESItem != null)
                btnUnSelect.PerformClick();
        }

        private void frmReasonGroup_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmReasonCode", Name))
            {
                getAllReasonCode();
            }

            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmReasonGroup_Activated", null);
        }
    }
}
