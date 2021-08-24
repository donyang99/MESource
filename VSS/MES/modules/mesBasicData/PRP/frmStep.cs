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
using mesRelease.PRP;
using idv.mesCore.PRP;

namespace mesBasicData
{
    public partial class frmStep : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        Step curItem = null;
        public frmStep()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query                        
            actionToolbar1.addButton("IssueState", "ISSUE");
            actionToolbar1.addButton("Version", "");
            actionToolbar1.addButton("StepDC", "STEPDC");
            actionToolbar1.addButton("Rollout", "ROLLOUT");
            actionToolbar1.addButton("|", "");
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
            actionToolbar1.addButton("Export", "");           
        }

        private void frmStep_Load(object sender, EventArgs e)
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
            initData();
            mesListView1.prepareColumns();
            pnlExt.AutoSize = true;
        }

        private void frmStep_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void initData()
        {
            List<string> hideColumn = new List<string>();

            if (!idv.mesCore.systemConfig.stepStage)
            {
                lblStage.Visible = false;
                cboStage.Visible = false;
                hideColumn.Add("stage");
            }

            if (!idv.mesCore.systemConfig.componentType)
            {
                lblComponentType.Visible = false;
                cboComponentType.Visible = false;
                hideColumn.Add("componentType");
            }

            if (!idv.mesCore.systemConfig.stepCode)
            {
                lblStepCode.Visible = false;
                cboStepCode.Visible = false;
                hideColumn.Add("stepCode");
            }

            mesListView1.columnHide = hideColumn.ToArray();
            grpStation.Visible = idv.mesCore.systemConfig.operatorPerformance;
            lvwSelected.prepareColumns();
            lvwAvailable.prepareColumns();            
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
                case "Version":
                    executeVersion();
                    break;
                case "Clear":
                    executeClear();
                    break;
                case "StepDC":
                    executeStepDC();
                    break;
                case "Rollout":
                    executeRollout();
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
            txtStep.Text = "";
            txtVersion.Text = "";
            txtDescription.Text = "";
            cboComponentType.Text = "";
            cboEqGroup.Text = "";
            cboFAB.Text = "";
            cboStage.Text = "";
            cboStepCode.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeQuery()
        {
            string condition = "";
            if (txtStep.Text.Trim() != "")
                condition = "step_id like '%" + txtStep.Text.Trim() + "%'";
            if (cboEqGroup.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "equipment_group = '" + cboEqGroup.Text + "'";
            }
            if (cboFAB.Text != "" && cboFAB.Text != "ALL")
            {
                if (condition != "") condition += " and ";
                condition += "fab = '" + cboFAB.Text + "'";
            }
            if (cboStage.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "stage = '" + cboStage.Text + "'";
            }
            if (cboComponentType.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "component_type = '" + cboComponentType.Text + "'";
            }
            if (cboStepCode.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "step_code = '" + cboStepCode.Text + "'";
            }
            mesListView1.ShowMESItems(Step.GetLastestVersionSteps(condition));            
        }

        void executeAdd()
        {
            bool check = appInstance.CheckInputData(txtStep, lblStep, cboEqGroup, lblEqGroup, cboFAB, lblFAB, cboStage, lblStage);
            if (!check) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                Step item = new Step();
                item.name = txtStep.Text;
                item.equipmentGroup = cboEqGroup.Text;
                item.fab = cboFAB.Text;
                item.stage = cboStage.Text;
                item.componentType = cboComponentType.Text;
                item.stepCode = cboStepCode.Text;
                item.seq = displaySeq;
                item.description = txtDescription.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;

                item.Clear();
                foreach(ListViewItem ruleItem in lvwSelected.Items)
                    item.Add(ruleItem.Tag as mesRelease.PRP.Rule);

                item.stations = getStations();
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能

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
            bool check = appInstance.CheckInputData(txtStep, lblStep, cboEqGroup, lblEqGroup, cboFAB, lblFAB, cboStage, lblStage);
            if (!check) return;

            if (curItem.name != txtStep.Text && (curItem.issueState != idv.mesCore.IssueState.New || curItem.version != 0))
            {
                appInstance.showInformation(cultureLanguage.getValue("cantModifyField", lblStep.Text), informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("modify", curItem)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;            
            try
            {
                curItem.name = txtStep.Text;
                curItem.equipmentGroup = cboEqGroup.Text;
                curItem.fab = cboFAB.Text;
                curItem.stage = cboStage.Text;
                curItem.componentType = cboComponentType.Text;
                curItem.stepCode = cboStepCode.Text;
                curItem.seq = displaySeq;
                curItem.description = txtDescription.Text;
                curItem.modifyUser = mesRelease.USR.User.loginUser.name;

                curItem.Clear();
                foreach (ListViewItem ruleItem in lvwSelected.Items)
                    curItem.Add(ruleItem.Tag as mesRelease.PRP.Rule);

                curItem.stations = getStations();
                if (frmExt != null) frmExt.AssignValue(curItem);//維護畫面延伸功能
               
                curItem.Modify();

                mesListView1.UpdateMESItem(curItem);
                
                if (curItem.issueState == idv.mesCore.IssueState.Active)
                    refreshStepCatch(curItem);

                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        string[] getStations()
        {
            List<string> list = new List<string>();
            foreach (ListViewItem item in lvwStation.Items)
                list.Add(item.Text);
            return list.ToArray();
        }

        void refreshStepCatch(Step step)
        {
            try
            {
                mesRelease.PRP.Step.RefreshStepCatch("", step.sysid);
            }
            catch { }
        }

        void executeDelete()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (curItem.issueState != idv.mesCore.IssueState.New)
            {
                appInstance.showInformationById("msgCanOnlyDeleteNewState", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                curItem.Delete();
                Step[] lastItem = Step.GetLastestVersionSteps("step_id='" + curItem.name + "'");
                if (lastItem.Length == 0)
                    mesListView1.RemoveMESItem(curItem);
                else
                    mesListView1.UpdateCurrentItem(lastItem[0]);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeIssue()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (lvwSelected.Items.Count == 0)
            {
                messageBox.showMessageById("requireField2", messageStyle.error, cultureLanguage.getValue("rule"));
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("issue"))) return;
            try
            {
                curItem.modifyUser = mesRelease.USR.User.loginUser.name;
                curItem.Issue();                
                mesListView1.UpdateCurrentItem(curItem);

                if (curItem.issueState == idv.mesCore.IssueState.Active)
                    refreshStepCatch(curItem);

                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeVersion()
        {
            if (curItem == null) return;
            
            if (mnuVersion.Items.Count == 0)
            {
                string caption = cultureLanguage.getValue("version");
                bool haveNewVersion = false;
                ToolStripMenuItem mnuItem = null;
                foreach (Step s in curItem.GetOtherVersions())
                {
                    mnuItem = new ToolStripMenuItem();
                    mnuItem.Text = caption + " " + s.version.ToString() + " (" + s.issueState.ToString() + ")"; ;
                    mnuItem.Tag = s;
                    if (s.version == curItem.version)
                        mnuItem.Checked = true;
                    mnuItem.Click += new EventHandler(mnuItemVersion_Click);
                    mnuVersion.Items.Add(mnuItem);
                    if (s.issueState == idv.mesCore.IssueState.New) haveNewVersion = true;
                }
                if (!haveNewVersion)
                {
                    if (actionToolbar1.Items["Add"].Enabled)
                    {
                        mnuVersion.Items.Add(new ToolStripSeparator());
                        mnuItem = new ToolStripMenuItem();
                        mnuItem.Text = cultureLanguage.getValue("buttonNewVersion");
                        mnuItem.Click += new EventHandler(mnuItemNewVersion_Click);
                        mnuVersion.Items.Add(mnuItem);
                    }
                }
            }
            ToolStripItem tsi = actionToolbar1.Items["Version"] as ToolStripItem;
            mnuVersion.Show(actionToolbar1, tsi.Bounds.Location.X, tsi.Bounds.Location.Y + tsi.Bounds.Height);
        }

        void executeRollout()
        {
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("buttonRollout"))) return;
            bool includingLotEquipment = messageBox.showMessageById("msgIsIncludingLotAndequipment", messageStyle.askYesNo);
            try
            {
                idv.messageService.serverCommand cmd = new idv.messageService.serverCommand();
                cmd.name = "refreshWorkingArea";
                cmd.requestReply = false;
                cmd.To = "Client:";
                if (includingLotEquipment)
                {
                    idv.messageService.serverCommandArgument arg = new idv.messageService.serverCommandArgument();
                    arg.name = "includeOthers";
                    arg.value = "True";
                    cmd.Add(arg);
                }
                cmd.send();
            }
            catch { }
        }

        void mnuItemVersion_Click(object sender, EventArgs e)
        {
            Step s = (sender as ToolStripMenuItem).Tag as Step;
            if (s.version == curItem.version) return;
            mesListView1.UpdateCurrentItem(s);
        }

        void mnuItemNewVersion_Click(object sender, EventArgs e)
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("buttonNewVersion"))) return;
            try
            {
                Step newItem = new Step(curItem.name, curItem.version);
                newItem.createUser = mesRelease.USR.User.loginUser.name;
                newItem.modifyDate = DateTime.Now;
                newItem.modifyUser = newItem.createUser;
                newItem.modifyDate = newItem.createDate;
                newItem.NewVersion();
                mesListView1.UpdateCurrentItem(newItem);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeStepDC()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            frmStepDC frm = null;
            try
            {
                frm = new frmStepDC(curItem);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
            finally
            {
                frm.Close();
            }
        }

        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                executeClear();
                curItem = null;
                mnuVersion.Items.Clear();
            }
            else
            {
                curItem = item as Step;
                if (curItem != null)
                {
                    txtStep.Text = curItem.name;
                    txtVersion.Text = curItem.version.ToString();
                    cboEqGroup.Text = curItem.equipmentGroup;
                    cboFAB.Text = curItem.fab;
                    cboStage.Text = curItem.stage;
                    cboComponentType.Text = curItem.componentType;
                    cboStepCode.Text = curItem.stepCode;
                    displaySeq = curItem.seq;
                    txtDescription.Text = curItem.description;

                    if (curItem.issueState == idv.mesCore.IssueState.New && curItem.version == 0)
                        actionToolbar1.setButtonState("StepDC", false);
                    else
                        actionToolbar1.setButtonState("StepDC", true);

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(curItem);
                }
            }
            showSelectedItems();
        }
        string displaySeq
        {
            get
            {
                if (int.TryParse(txtDisplaySeq.Text, out int seq))
                    return seq.ToString("000");
                else
                    return "";
            }
            set
            {
                if (int.TryParse(value, out int seq))
                    txtDisplaySeq.Text = seq.ToString();
                else
                    txtDisplaySeq.Text = "";
            }
        }

        void showSelectedItems()
        {
            lvwAvailable.UpdateMESItem(lvwSelected.GetAllMESItem());
            lvwSelected.RemoveAllMESItems();
            lvwStation.Items.Clear();
            if (curItem == null)
            {
                //btnSelect.Enabled = false;
                //btnUnSelect.Enabled = false;
            }
            else
            {
                curItem.retrieveRules();
                lvwSelected.UpdateMESItem(curItem.Items.ToArray());
                lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
                foreach (string s in curItem.stations)
                    lvwStation.Items.Add(s);
                //btnSelect.Enabled = true;
                //btnUnSelect.Enabled = true;
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

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lvwSelected.SelectedItems.Count == 0) return;
            int i = 0;
            ListViewItem item = lvwSelected.SelectedItems[0];
            i = item.Index - 1;
            if (i < 0) return;
            lvwSelected.Items.Remove(item);
            lvwSelected.Items.Insert(i, item);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lvwSelected.SelectedItems.Count == 0) return;
            int i = 0;
            ListViewItem item = lvwSelected.SelectedItems[0];
            i = item.Index + 1;
            if (i >= lvwSelected.Items.Count) return;
            lvwSelected.Items.Remove(item);
            lvwSelected.Items.Insert(i, item);                
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvwAvailable.selectedMESItem == null) return;
            lvwSelected.UpdateMESItem(lvwAvailable.selectedMESItem);
            lvwAvailable.RemoveMESItem(null);
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (lvwSelected.selectedMESItem == null) return;
            lvwAvailable.UpdateMESItem(lvwSelected.selectedMESItem);
            lvwSelected.RemoveMESItem(null);
        }

        private void lvwAvailable_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void lvwSelected_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        void executeExport()
        {
            //build information in listview
            ListView exportView = new ListView();
            foreach (ColumnHeader column in mesListView1.Columns)
            {
                ColumnHeader newCol = column.Clone() as ColumnHeader;
                exportView.Columns.Add(newCol);
            }
            int maxRuleCount = 0;
            foreach (ListViewItem item in mesListView1.Items)
            {
                ListViewItem newItem = item.Clone() as ListViewItem;
                Step step = newItem.Tag as Step;
                newItem.Tag = null;
                step.retrieveRules();
                if (step.Count > maxRuleCount) maxRuleCount = step.Count;

                for (int i = 0; i < step.Count; i++)
                {
                    newItem.SubItems.Add(step.Item(i).name);
                }

                exportView.Items.Add(newItem);
            }
            string ruleName=cultureLanguage.getValue("rule");
            for (int i = 0; i < maxRuleCount; i++)
            {
                ColumnHeader col = new ColumnHeader();
                col.Text = ruleName + (i + 1).ToString();
                exportView.Columns.Add(col);
            }

            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(exportView))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        void executeImport()
        {
            bool allSucceed = true;
            DataTable table = mesRelease.utilities.ExcelAgent.ImpportSelectExcel();
            List<string> columns = new List<string>();
            columns.AddRange("StepId,EqGroup,FAB,Stage,StepCode,ComponentType,Description,Issue".Split(','));
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
                    Step item = new Step();
                    item.name = row["StepId"].ToString();
                    item.equipmentGroup = row["EqGroup"].ToString();
                    item.fab = row["FAB"].ToString();
                    item.stage = row["Stage"].ToString();
                    item.stepCode = row["StepCode"].ToString();
                    item.componentType = row["ComponentType"].ToString();
                    item.description = row["Description"].ToString();
                    item.createUser = mesRelease.USR.User.loginUser.name;
                    item.createDate = DateTime.Now;
                    for (int i = 8; i < table.Columns.Count; i++)
                    {
                        if (row[i].ToString() == "") break;
                        mesRelease.PRP.Rule r = new mesRelease.PRP.Rule(row[i].ToString());
                        if (r.sysid == "")
                            throw new Exception("Rule[" + row[i].ToString() + "] not found");
                        item.Add(r);
                    }
                    item.New();
                    item = new Step(item.name, 0);
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
                        if (!s.ToUpper().StartsWith("StepId\tEqGroup\tFAB\tStage\tStepCode\tComponentType\tDescription\tIssue".ToUpper()))
                        {
                            appInstance.showInformationById("invalidFormat", informationType.warn);
                            break;
                        }
                        check = true;
                        succeed = true;
                    }
                    else
                    {
                        string[] step = s.Split('\t');
                        try
                        {
                            Step item = new Step();
                            item.name = step[0];
                            item.equipmentGroup = step[1];
                            item.fab = step[2];
                            item.stage = step[3];
                            item.stepCode = step[4];
                            item.componentType = step[5];
                            item.description = step[6];
                            item.createUser = mesRelease.USR.User.loginUser.name;
                            item.createDate = DateTime.Now;
                            for (int i = 8; i < step.Length; i++)
                            {
                                if (step[i] == "") break;
                                mesRelease.PRP.Rule r = new mesRelease.PRP.Rule(step[i]);
                                if (r.sysid == "")
                                    throw new Exception("Rule[" + step[i] + "] not found");
                                item.Add(r);
                            }
                            item.New();
                            item = new Step(item.name, 0);
                            if (step[7] == "1")
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

        private void frmStep_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmFAB", Name))
            {
                string orgFab = cboFAB.Text;
                cboFAB.Items.Clear();
                cboFAB.Items.Add("");
                cboFAB.Items.AddRange(mesRelease.BAS.Fab.GetFabs());
                if (cboFAB.Items.Count > 2)
                    cboFAB.Items.Add("ALL");

                if (!orgFab.Equals(""))
                    cboFAB.Text = orgFab;
            }

            if (idv.utilities.misc.IsValueChanged("frmEquipmentGroup", Name))
            {
                string orgEqGroup = cboEqGroup.Text;
                cboEqGroup.Items.Clear();
                cboEqGroup.Items.Add("");
                cboEqGroup.Items.AddRange(mesRelease.EQP.EqGroup.GetGroup());
                if (!orgEqGroup.Equals(""))
                    cboEqGroup.Text = orgEqGroup;
            }

            if (idv.utilities.misc.IsValueChanged("frmRule", Name))
            {
                mesRelease.PRP.Rule[] rules = mesRelease.PRP.Rule.GetRules();
                lvwAvailable.ShowMESItems(rules);
                lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
            }

            if (idv.mesCore.systemConfig.componentType && idv.utilities.misc.IsValueChanged("frmComponentType", Name))
            {
                string orgType = cboComponentType.Text;
                cboComponentType.Items.Clear();
                cboComponentType.Items.Add("");
                cboComponentType.Items.AddRange(idv.mesCore.misc.ComponentTypeGet());
                if (!orgType.Equals(""))
                    cboComponentType.Text = orgType;
            }

            if (idv.mesCore.systemConfig.stepStage && idv.utilities.misc.IsValueChanged("frmStage", Name))
            {
                string orgStage = cboStage.Text;
                cboStage.Items.Clear();
                cboStage.Items.Add("");
                cboStage.Items.AddRange(idv.mesCore.misc.StageGet());
                if (!orgStage.Equals(""))
                    cboStage.Text = orgStage;
            }

            if (idv.mesCore.systemConfig.stepCode && idv.utilities.misc.IsValueChanged("frmStepCode", Name))
            {
                string orgStepCode = cboStepCode.Text;
                cboStepCode.Items.Clear();
                cboStepCode.Items.Add("");
                cboStepCode.Items.AddRange(idv.mesCore.misc.StepCodeGet());
                if (!orgStepCode.Equals(""))
                    cboStepCode.Text = orgStepCode;
            }
            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmStep_Activated", null);
        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            if (txtStation.Text.Equals("")) return;
            foreach (ListViewItem item in lvwStation.Items)
            {
                if (item.Text.ToUpper().Equals(txtStation.Text.ToUpper()))
                    return;
            }
            lvwStation.Items.Add(txtStation.Text);
            txtStation.Text = "";
            txtStation.Focus();
        }

        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
            if (lvwStation.SelectedItems.Count == 0) return;
            lvwStation.SelectedItems[0].Remove();
            txtStation.Focus();
        }

        private void txtStation_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddStation.PerformClick();
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
    }
}
