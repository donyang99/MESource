using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.utilities;
using idv.mesCore.Controls;
using mesRelease.TOL;
using idv.messageService;

namespace toolingFunction
{
    public partial class frmToolingEvent : Form, idv.messageService.appModuleFunctionForm
    {  //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }

        ToolingEvent curItem = null;
        public frmToolingEvent()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void frmToolingEvent_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmToolingType", Name))
            {
                string selType = cboToolingType.Text;
                cboToolingType.Items.Clear();
                ToolingType tp = new ToolingType();
                tp.name = "-";
                tp.sysid = "-";
                cboToolingType.Items.Add(tp);//default
                cboToolingType.Items.AddRange(ToolingType.GetToolingTypes());
                if (!selType.Equals(""))
                    cboToolingType.Text = selType;
            }
            if (idv.utilities.misc.IsValueChanged("frmReasonGroup", Name))
            {
                string selType = cboReasonGroup.Text;
                cboReasonGroup.Items.Clear();
                cboReasonGroup.Items.Add("");

                foreach (DataRow row in serviceHost.Client.getDataSet("select group_id from mes_reason_group order by group_id").Tables[0].Rows)
                    cboReasonGroup.Items.Add(row[0].ToString());

                if (!selType.Equals(""))
                    cboReasonGroup.Text = selType;
            }
            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmToolingEvent_Activated", null);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query                        
            actionToolbar1.addButton("Clear", "");
            //actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Copy", "ADD");//Import privilege is the same as Add privilege
        }
        private void frmToolingEvent_Load(object sender, EventArgs e)
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

            foreach(string s in Enum.GetNames(typeof(idv.mesCore.TOL.toolingStatus)))
            {
                cboLastStatus.Items.Add(s);
                cboNextStatus.Items.Add(s);
            }
        }

        private void frmToolingEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
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
                    executeShowData(null);
                    break;
                case "Copy":
                    executeCopy();
                    break;
            }
        }

        void executeShowData(ToolingEvent item)
        {
            if (item == null)
            {
                txtEvent.Text = "";
                cboToolingType.SelectedIndex = -1;
                cboLastStatus.SelectedIndex = -1;
                cboNextStatus.SelectedIndex = -1;
                cboReasonGroup.SelectedIndex = -1;
                lvwLocation.Items.Clear();
                chkIdeFlag.Checked = true;

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ClearData();
            }
            else
            {
                txtEvent.Text = item.name;
                cboToolingType.Text = item.toolingType;
                cboLastStatus.Text = item.lastStatus;
                cboNextStatus.Text = item.nextStatus;
                cboReasonGroup.Text = item.reasonGroup;
                lvwLocation.Items.Clear();
                foreach (string loc in item.locationList)
                    lvwLocation.Items.Add(loc).Name = loc;
                chkIdeFlag.Checked = item.ideFlag;

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ShowData(item);
            }
        }

        void executeQuery()
        {
            mesListView1.ShowMESItems(ToolingEvent.GetToolingEvents(cboToolingType.Text, "", "", false));
        }

        void assignValues(ToolingEvent item)
        {
            ToolingType toolingType = cboToolingType.SelectedItem as ToolingType;
            item.toolingType = toolingType.name;
            item.typeSysId = toolingType.sysid;
            item.name = txtEvent.Text;
            item.lastStatus = cboLastStatus.Text;
            item.nextStatus = cboNextStatus.Text;
            item.reasonGroup = cboReasonGroup.Text;
            item.locationList.Clear();
            foreach (ListViewItem vItem in lvwLocation.Items)
                item.locationList.Add(vItem.Text);
            item.ideFlag = chkIdeFlag.Checked;
            item.modifyUser = idv.mesCore.USR.userBase.loginUserId;

            if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
        }
        void executeAdd()
        {
            if (!appInstance.CheckInputData(cboToolingType, lblToolingType, txtEvent, lblToolingEvent, cboLastStatus, lblLastStatus, cboNextStatus, lblNextStatus)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                ToolingEvent item = new ToolingEvent();
                assignValues(item);
                item.createUser = idv.mesCore.USR.userBase.loginUserId;
                item.createDate = idv.messageService.serviceHost.dateTime;

                item.New();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
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
            if (!appInstance.CheckInputData(cboToolingType, lblToolingType, txtEvent, lblToolingEvent, cboLastStatus, lblLastStatus, cboNextStatus, lblNextStatus)) return;
            if (frmExt != null && !frmExt.CheckData("modify", curItem)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                assignValues(curItem);
                curItem.Modify();
                mesListView1.UpdateMESItem(curItem);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
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
                curItem.modifyUser = idv.mesCore.USR.userBase.loginUserId;
                curItem.Delete();
                mesListView1.RemoveMESItem(curItem);

                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeCopy()
        {
            frmCopyEvent frm = new frmCopyEvent();
            try
            {
                cultureLanguage.switchLanguageSync(frm);
                frm.SetToolingTypes(cboToolingType);
                frm.ShowDialog();
                if (!frm.result) return;
                ToolingType toolingType = null;
                foreach (ToolingType tp in cboToolingType.Items)
                {
                    if (tp.name.Equals(frm.ToType))
                    {
                        toolingType = tp;
                        break;
                    }
                }
                foreach (ToolingEvent fromEvent in ToolingEvent.GetToolingEvents(frm.FromType, "", "", false))
                {

                    ToolingEvent toEvent = new ToolingEvent();
                    toEvent.toolingType = toolingType.name;
                    toEvent.typeSysId = toolingType.sysid;
                    toEvent.name = fromEvent.name;
                    toEvent.lastStatus = fromEvent.lastStatus;
                    toEvent.nextStatus = fromEvent.nextStatus;
                    toEvent.reasonGroup = fromEvent.reasonGroup;
                    toEvent.locations = fromEvent.locations;
                    toEvent.ideFlag = fromEvent.ideFlag;
                    toEvent.createUser = idv.mesCore.USR.userBase.loginUserId;
                    toEvent.New();
                    mesListView1.UpdateMESItem(toEvent);
                }
                messageBox.showMessageById("msgExecuteSucceed");
            }
            catch(Exception ex)
            { 
                messageBox.showMessage(ex.Message); 
            }
            finally
            {
                if (frm != null && !frm.IsDisposed)
                    frm.Close();
            }
        }

        private void mesListView1_MESItemSelectionChanged(itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                curItem = null;
                executeShowData(null);
            }
            else
            {
                curItem = item as ToolingEvent;
                executeShowData(curItem);
            }
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text.Trim().Equals("")) return;
            if (lvwLocation.Items[txtLocation.Text.Trim()] != null) return;
            ListViewItem item = new ListViewItem(txtLocation.Text.Trim());
            item.Name = item.Text;
            lvwLocation.Items.Add(item);
            txtLocation.Text = "";
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            if (lvwLocation.SelectedItems.Count == 0) return;
            foreach (ListViewItem item in lvwLocation.SelectedItems)
                item.Remove();
        }

        private void txtLocation_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddLocation.PerformClick();
        }
    }
}
