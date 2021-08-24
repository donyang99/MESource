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
    public partial class frmReasonCategory : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmReasonCategory()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Export", "");
        }

        private void frmReasonCategory_Load(object sender, EventArgs e)
        {
            initToolbar();
            List<string> lstNames = new List<string>();
            List<string> lstTags = new List<string>();
            lstNames.AddRange(mesListView1.columnNames);
            lstTags.AddRange(mesListView1.columnTags);
            if (frmExt != null)//維護畫面延伸功能
                idv.messageService.appModuleFunctionFormControlDefine.Init(frmExt, this, pnlExt, tblDetail, lstNames, lstTags);
            mesListView1.columnNames = lstNames.ToArray();
            mesListView1.columnTags = lstTags.ToArray();
            mesListView1.prepareColumns();
            pnlExt.AutoSize = true;
            getReasonCategories();
        }

        private void frmReasonCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        private void getReasonGroups()
        {
            string orgValue = cboReasonGroup.Text;
            ReasonGroup[] groups = ReasonGroup.getReasonGroups("");
            cboReasonGroup.Items.Clear();
            cboReasonGroup.Items.Add("");
            foreach (ReasonGroup g in groups)
                cboReasonGroup.Items.Add(g.name);

            if (!orgValue.Equals(""))
                cboReasonGroup.Text = orgValue;
        }

        private void getReasonCategories()
        {
            string sql = "select distinct reason_category from mes_reason_category";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSet(sql);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (!cboReasonCategory.Items.Contains(row[0].ToString()))
                    cboReasonCategory.Items.Add(row[0].ToString());
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
                case "Query":
                    executeQuery();
                    break;
                case "Clear":
                    executeClear();
                    break;
                case "Export":
                    executeExport();
                    break;
            }
        }

        void executeQuery()
        {
            string condition = "";
            if (cboReasonCategory.Text.Trim() != "")
                condition = "reason_category like '%" + cboReasonCategory.Text.Trim() + "%'";
            if (txtReasonClass.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "reason_class like'%" + txtReasonClass.Text + "%'";
            }
            if (cboReasonGroup.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "reason_group = '" + cboReasonGroup.Text + "'";
            }
            ReasonCategory[] items = ReasonCategory.getReasonCategories(condition);
            mesListView1.ShowMESItems(items);
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(cboReasonCategory, lblReasonCategory, cboReasonGroup, lblReasonGroup)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                ReasonCategory item = new ReasonCategory();
                item.name = cboReasonCategory.Text;
                item.reasonClass = txtReasonClass.Text;
                item.reasonGroup = cboReasonGroup.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能

                item.New();
                mesListView1.UpdateMESItem(item);
                if (!cboReasonCategory.Items.Contains(item.name))
                    cboReasonCategory.Items.Add(item.name);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeModify()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (!appInstance.CheckInputData(cboReasonCategory, lblReasonCategory, cboReasonGroup, lblReasonGroup))
                return;

            ReasonCategory item = mesListView1.selectedMESItem as ReasonCategory;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            
            try
            {
                item.name = cboReasonCategory.Text;
                item.reasonClass = txtReasonClass.Text;
                item.reasonGroup = cboReasonGroup.Text;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能

                item.Modify();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            ReasonCategory item = mesListView1.selectedMESItem as ReasonCategory;
            try
            {
                item.Delete();
                mesListView1.RemoveMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeClear()
        {
            cboReasonCategory.Text = "";
            txtReasonClass.Text = "";
            cboReasonGroup.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeExport()
        {
            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(mesListView1))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                executeClear();
            }
            else
            {
                ReasonCategory r = item as ReasonCategory;
                if (r != null)
                {
                    cboReasonCategory.Text = r.name;
                    txtReasonClass.Text = r.reasonClass;
                    cboReasonGroup.Text = r.reasonGroup;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(r);
                }
            }         
        }

        private void btnReasonGroup_Click(object sender, EventArgs e)
        {
            frmReasonGroup frmReaGroup = null;
            try
            {
                frmReaGroup = new frmReasonGroup();
                frmReaGroup.lvwReasonGroup.DoubleClick += new EventHandler(lvwReasonGroup_DoubleClick);
                frmReaGroup.Load += new EventHandler(frmReaGroup_Load);
                frmReaGroup.StartPosition = FormStartPosition.CenterScreen;
                frmReaGroup.ShowDialog();
            }
            catch { }
            finally
            {
                if (frmReaGroup != null)
                    frmReaGroup.Close();
            }
        }

        void frmReaGroup_Load(object sender, EventArgs e)
        {
            cultureLanguage.switchLanguageSync(sender as Form);
        }

        void lvwReasonGroup_DoubleClick(object sender, EventArgs e)
        {
            ListView li = sender as ListView;
            if (li == null || li.SelectedItems.Count == 0) return;
            ListViewItem item = li.SelectedItems[0];
            ReasonGroup r = item.Tag as ReasonGroup;
            if (r == null) return;
            cboReasonGroup.Text = r.name;
            li.FindForm().Hide();
        }

        private void txtReasonCategory_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }

        private void frmReasonCategory_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmReasonGroup", Name))
            {
                getReasonGroups();
            }
            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmReasonCategory_Activated", null);
        }
    }
}
