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
using mesRelease.EQP;
using idv.mesCore.EQP;

namespace mesBasicData
{
    public partial class frmEquipment : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmEquipment()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query                        
            actionToolbar1.addButton("IssueState", "ISSUE");
            grpSubEq.Visible = !idv.mesCore.systemConfig.singleEqType;
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("|", "");
            actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
            actionToolbar1.addButton("Export", "");
        }

        private void frmEquipment_Load(object sender, EventArgs e)
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

            lvwAvailable.prepareColumns();
            lvwSelected.prepareColumns();
            initData();
            mesListView1.prepareColumns();

            pnlExt.AutoSize = true;
        }

        private void frmEquipment_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }  

        private void initData()
        {
            List<string> lvwHide = new List<string>();
            if (idv.mesCore.systemConfig.validItem("eqParameter") && idv.mesCore.systemConfig.validItem("eqSetSpec"))
            {
                cboSpecRef.Items.Add(new mesRelease.PARM.ProductSpec());
                cboSpecRef.Items.AddRange(mesRelease.PARM.ProductSpec.GetActiveVersionSpecs(""));
            }
            else
            {
                lblSpecRef.Visible = false;
                cboSpecRef.Visible = false;
                lvwHide.Add("reservedBy");
            }
            if (idv.mesCore.systemConfig.simpleEqLine)
            {
                lblEqLine.Visible = false;
                txtEqLine.Visible = false;
                lblEqSeq.Visible = false;
                txtEqSeq.Visible = false;
                lvwHide.Add("line");
                lvwHide.Add("seq");
            }
            else
            {
                lblEqLine.Visible = true;
                txtEqLine.Visible = true;
                lblEqSeq.Visible = true;
                txtEqSeq.Visible = true;
            }
            if (lvwHide.Count > 0)
                mesListView1.columnHide = lvwHide.ToArray();

            if (!idv.mesCore.systemConfig.singleEqType)
                lvwAvailable.ShowMESItems(Equipment.GetAvailableSubEquipment());
        }
        
        private void initFab()
        {
            string orgFab = cboFAB.Text;
            cboFAB.Items.Clear();
            cboFAB.Items.Add("");
            cboFAB.Items.AddRange(mesRelease.BAS.Fab.GetFabs());
            if (cboFAB.Items.Count == 2)
            {
                cboFAB.Items.RemoveAt(0);
                cboFAB.SelectedIndex = 0;
                cboFAB.Enabled = false;
            }
            if (!orgFab.Equals(""))
                cboFAB.Text = orgFab;
        }

        private void initEqType()
        {
            string orgType = cboEqType.Text;
            cboEqType.Items.Clear();
            cboEqType.Items.Add("");
            foreach (EqType t in EqType.GetEqTypes(""))
                cboEqType.Items.Add(t.name);

            if (!orgType.Equals(""))
                cboEqType.Text = orgType;
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
                case "IssueState":
                    executeIssue();
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
            txtEquipment.Text = "";
            txtEqLine.Text = "";
            txtEqSeq.Text = "";
            txtOwner.Text = "";
            txtDescription.Text = "";
            cboFAB.Text = "";
            cboEqType.Text = "";
            cboSpecRef.Text = "";
            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeQuery()
        {
            Equipment[] items = Equipment.GetEquipments(txtEquipment.Text, cboEqType.Text, "", 0, "", "", cboFAB.Text, 0, false);
            mesListView1.ShowMESItems(items);
        }

        void executeAdd()
        {
            bool check = appInstance.CheckInputData(txtEquipment, lblEquipment, cboEqType, lblEqType, cboFAB, lblFAB);
            if (!check) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                Equipment item = new Equipment();
                item.name = txtEquipment.Text;
                item.type = cboEqType.Text;
                item.fab = cboFAB.Text;
                item.line = txtEqLine.Text;
                item.seq = txtEqSeq.Text == "" ? 0 : Convert.ToInt32(txtEqSeq.Text);
                item.owner = txtOwner.Text;
                if (cboSpecRef.Visible)
                {
                    if (cboSpecRef.Text.Equals(""))
                        item.reservedBy = "";
                    else
                        item.reservedBy = "S@" + cboSpecRef.Text;
                }
                item.description = txtDescription.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New();
                item = new Equipment(item.name);
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);

                //if (!idv.mesCore.systemConfig.singleEqType)
                //{
                //    if (item.toolType != EqToolType.Process && item.toolType != EqToolType.Measure)
                //        lvwAvailable.UpdateMESItem(item);
                //}
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
            else
            {
                bool check = appInstance.CheckInputData(txtEquipment, lblEquipment, cboEqType, lblEqType, cboFAB, lblFAB);
                if (!check) return;
            }
            Equipment item = mesListView1.selectedMESItem as Equipment;
            if (item.name != txtEquipment.Text && item.issueState != idv.mesCore.IssueState.New)
            {
                appInstance.showInformation(cultureLanguage.getValue("cantModifyField", lblEquipment.Text), informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                item.name = txtEquipment.Text;
                item.type = cboEqType.Text;
                if (!item.fab.Equals(cboFAB.Text))
                {
                    item.addProperty("orgFab", item.fab);//for廣播到原廠別
                    item.fab = cboFAB.Text;
                }
                item.line = txtEqLine.Text;
                item.seq = txtEqSeq.Text == "" ? 0 : Convert.ToInt32(txtEqSeq.Text);
                item.owner = txtOwner.Text;
                if (cboSpecRef.Visible)
                {
                    if (cboSpecRef.Text.Equals(""))
                        item.reservedBy = "";
                    else
                        item.reservedBy = "S@" + cboSpecRef.Text;
                }
                item.description = txtDescription.Text;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.Modify();
                mesListView1.UpdateMESItem(item);

                if (item.issueState == idv.mesCore.IssueState.Active)
                {
                    //發佈到Client端
                    item.To = "";
                    idv.mesCore.EQP.Txn.txnCommon.assignEqBroadcastTarget(item);
                    item.send();
                }
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
            Equipment item = mesListView1.selectedMESItem as Equipment;
            if (item.createUser == "System")
            {
                appInstance.showInformationById("cantDelDefaults", informationType.warn);
                return;
            }
            else if (item.issueState != idv.mesCore.IssueState.New)
            {
                appInstance.showInformation(cultureLanguage.getValue("notInStatus", idv.mesCore.IssueState.New.ToString()), informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                item.Delete();
                mesListView1.RemoveMESItem(item);
                btnRefresh.PerformClick();
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);                

                //if (!idv.mesCore.systemConfig.singleEqType)
                //{
                //    if (item.toolType != EqToolType.Process && item.toolType != EqToolType.Measure)
                //        lvwAvailable.RemoveMESItem(item);
                //}
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }        

        void executeIssue()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            Equipment item = mesListView1.selectedMESItem as Equipment;

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("issue"))) return;
            try
            {               
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                item.Issue();
                mesListView1.UpdateMESItem(item);
                //發佈到Client端
                item.To = "";
                idv.mesCore.EQP.Txn.txnCommon.assignEqBroadcastTarget(item);
                item.send();
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeImport()
        {
            bool allSucceed = true;
            DataTable table = mesRelease.utilities.ExcelAgent.ImpportSelectExcel();
            List<string> columns = new List<string>();
            columns.AddRange("EquipmentId,EquipmentType,FAB,Line,LineSeq,Owner,Description,Issue".Split(','));
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
                    Equipment item = new Equipment();
                    item.name = row["EquipmentId"].ToString();
                    item.type = row["EquipmentType"].ToString();
                    item.fab = row["FAB"].ToString();
                    item.line = row["Line"].ToString();
                    item.seq = row["LineSeq"].ToString() == "" ? 0 : Convert.ToInt32(row["LineSeq"].ToString());
                    item.owner = row["Owner"].ToString();
                    item.description = row["Description"].ToString();
                    item.createUser = mesRelease.USR.User.loginUser.name;
                    item.createDate = DateTime.Now;
                    item.New();
                    item = new Equipment(item.name);
                    if (row["Issue"].ToString() == "1")
                        item.Issue();
                    mesListView1.UpdateMESItem(item);
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
                mesListView1.RemoveAllMESItems();
                do
                {
                    string s = reader.ReadLine();
                    if (s == null) break;
                    if (!check)
                    {
                        if (!s.ToUpper().StartsWith("EquipmentId\tEquipmentType\tFAB\tLine\tLineSeq\tOwner\tDescription\tIssue".ToUpper()))
                        {
                            appInstance.showInformationById("invalidFormat", informationType.warn);
                            break;
                        }
                        check = true;
                        succeed = true;
                    }
                    else
                    {
                        string[] eq = s.Split('\t');
                        try
                        {
                            Equipment item = new Equipment();
                            item.name = eq[0];
                            item.type = eq[1];
                            item.fab = eq[2];
                            item.line = eq[3];
                            item.seq = eq[4] == "" ? 0 : Convert.ToInt32(eq[4]);
                            item.owner = eq[5];
                            item.description = eq[6];
                            item.createUser = mesRelease.USR.User.loginUser.name;
                            item.createDate = DateTime.Now;
                            item.New();
                            item = new Equipment(item.name);
                            if (eq[7] == "1")
                                item.Issue();
                            mesListView1.UpdateMESItem(item);
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
            }
            idv.utilities.misc.SetValueChangeByItemName(Name);
            if (succeed)
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
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
                Equipment e = item as Equipment;
                if (e != null)
                {
                    txtEquipment.Text = e.name;
                    cboEqType.Text = e.type;
                    cboFAB.Text = e.fab;
                    txtEqLine.Text = e.line;
                    txtEqSeq.Text = e.seq.ToString();
                    txtOwner.Text = e.owner;
                    txtDescription.Text = e.description;
                    if (e.reservedBy.StartsWith("S@"))
                        cboSpecRef.Text = e.reservedBy.Substring(2);
                    else
                        cboSpecRef.Text = e.reservedBy;
                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(e);
                }
            }
            if (!idv.mesCore.systemConfig.singleEqType)
                showInternalUnit();
        }

        private void showInternalUnit()
        {
            Equipment e = mesListView1.selectedMESItem as Equipment;            
            lvwSelected.RemoveAllMESItems();
            btnSelect.Enabled = false;
            btnUnSelect.Enabled = false;
            if (e != null)
            {
                e.retrieveRelatedEquipment();
                lvwSelected.UpdateMESItem(e.Items.ToArray());
                if (e.toolType == EqToolType.Process || e.toolType == EqToolType.Measure)
                {
                    btnSelect.Enabled = true;
                    btnUnSelect.Enabled = true;
                }
            }
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void HandlerSendKeyTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvwAvailable.ShowMESItems(Equipment.GetAvailableSubEquipment());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Equipment subEq = lvwAvailable.selectedMESItem as Equipment;
            if (subEq == null) return;
            Equipment eq = mesListView1.selectedMESItem as Equipment;
            if (eq == null) return;
            try
            {
                eq.AddInternalUnit(subEq);
                lvwSelected.UpdateMESItem(subEq);
                lvwAvailable.RemoveMESItem(null);
                
                //發佈到Client端
                subEq.To = "";
                idv.mesCore.EQP.Txn.txnCommon.assignEqBroadcastTarget(subEq);
                idv.messageService.serverCommand cmd = new idv.messageService.serverCommand();
                cmd.name = "equipmentChangeParent";
                cmd.To = subEq.To;
                idv.messageService.serverCommandArgument arg =
                    new idv.messageService.serverCommandArgument();
                arg.value = subEq.name;
                cmd.Add(arg);
                cmd.send();
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message);
            }
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            Equipment subEq = lvwSelected.selectedMESItem as Equipment;
            if (subEq == null) return;
            Equipment eq = mesListView1.selectedMESItem as Equipment;
            if (eq == null) return;
            try
            {
                subEq.To = "";
                idv.mesCore.EQP.Txn.txnCommon.assignEqBroadcastTarget(subEq);

                eq.DeleteInternalUnit(subEq);
                lvwAvailable.UpdateMESItem(subEq);
                lvwSelected.RemoveMESItem(null);

                //發佈到Client端
                idv.messageService.serverCommand cmd = new idv.messageService.serverCommand();
                cmd.name = "equipmentChangeParent";
                cmd.To = subEq.To;
                idv.messageService.serverCommandArgument arg =
                    new idv.messageService.serverCommandArgument();
                arg.value = subEq.name;
                cmd.Add(arg);
                cmd.send();
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message);
            }
        }

        private void lvwAvailable_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void lvwSelected_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void frmEquipment_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmFAB", Name))
            {
                initFab();
            }

            if (idv.utilities.misc.IsValueChanged("frmEquipmentType", Name))
            {
                initEqType();
            }
            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmEquipment_Activated", null);
        }     
    }
}
