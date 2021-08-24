using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;
using mesRelease.EQP;
using mesRelease.USR;
using idv.utilities;

namespace ClientRule.LotProperty
{
    public partial class frmMain : Form
    {
        Lot currentLot = null;
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {                        
            currentLot = RuleInstance.GetItem(0);

            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();
            dtFrom.Value = DateTime.Now.AddMonths(-1).Date;
            dtTo.Value = DateTime.Now.Date;
            //if(idv.mesCore.systemConfig.assemblyMode)
            //{
                lotInfomation1.editable = true;
                lotInfomation1.LotChanged += new mesRelease.Controls.LotChangeEventHandler(lotInfomation1_LotChanged);
            //}
            lotInfomation1.Init(currentLot);
            t.Join();

            if (!idv.mesCore.systemConfig.carrierManagement && !idv.mesCore.systemConfig.componentInfo)
                tblMembers.Visible = false;
            else if (!idv.mesCore.systemConfig.carrierManagement)
                tblMembers.ColumnStyles[0].Width = 0;
            else if (!idv.mesCore.systemConfig.componentInfo)
                tblMembers.ColumnStyles[1].Width = 0;

            if(!idv.mesCore.systemConfig.materialTracking)
                tabControl1.TabPages.RemoveByKey("tabMaterialTracking");

            if(idv.mesCore.systemConfig.assemblyMode)
            {
                tabControl1.TabPages.RemoveByKey("tabMembers");
                tabControl1.TabPages.RemoveByKey("tabParentChild");
                lblStepMap.Visible = false;
                lvwStepMap.Visible = false;
            }

            if (!idv.mesCore.systemConfig.validItem("toolingManagement"))
                tabControl1.TabPages.RemoveByKey("tabTooling");

            idv.utilities.cultureLanguage.switchLanguageSync(this);
            CancelButton = btnCancel;
        }

        void lotInfomation1_LotChanged(Lot lot, ref bool accept)
        {
            if(lot == null)
            {
                messageBox.showMessageById("msgCantFindLot");
                accept = false;
                return;
            }
            currentLot = lot;
            lvwLotHistory.Items.Clear();
            lvwCarrier.Items.Clear();
            lvwComponents.Items.Clear();
            lvwWI.Items.Clear();
            lvwFutureHold.Items.Clear();
            lvwQTime.Items.Clear();
            lvwChildLot.Items.Clear();
            cboStep.Items.Clear();
            lvwStepDC.Items.Clear();
            lvwStepMap.Items.Clear();
            cboMaterialTrackingStep.Items.Clear();
            lvwMaterialTracking.Items.Clear();
            cboToolingStep.Items.Clear();
            lvwTooling.Items.Clear();
            bFlag_Members = false;
            bFlag_FutureAction = false;
            bFlag_ParentChild = false;
            bFlag_StepDC = false;
            bFlag_Step = false;
            bFlag_MaterialTracking = false;
            bFlag_Tooling = false;
            tabControl1.SelectedTab = tabHistory;
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }

        private void btnQueryHistory_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try { executeQueryLotHistory(dtFrom.Value, dtTo.Value); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            Cursor = Cursors.Default;
        }

        void executeQueryLotHistory(DateTime from, DateTime to)
        {
            lvwLotHistory.Items.Clear();
            string sql = "select a.*,b.user_name from mes_wip_lot_history a "+
                                    "left join mes_user_profile b on a.modify_user=b.user_id "+
                         "where a.lot_id = ? and a.modify_date between ? and ? order by a.txnstamp desc";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, currentLot.name, from, to.Date.AddDays(1));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(dr["activity"].ToString());
                foreach (ColumnHeader col in lvwLotHistory.Columns)
                {
                    if (col.Name.Equals("activity")) continue;
                    item.SubItems.Add(dr[col.Name].ToString());
                }
                item.Tag = dr;
                if (idv.mesCore.systemConfig.validItem("eqParameter"))
                {
                    int parmSeq = 0;
                    if (int.TryParse(dr["eq_parm_seq"].ToString(), out parmSeq) && parmSeq >= 0)
                        item.ForeColor = Color.Blue;
                }
                lvwLotHistory.Items.Add(item);
            }
        }

        private void btnExportHistory_Click(object sender, EventArgs e)
        {
            if (lvwLotHistory.Items.Count > 0)
                mesRelease.utilities.ExcelAgent.WriteToFile(lvwLotHistory);
        }

        private void btnHistoryDetail_Click(object sender, EventArgs e)
        {
            if (lvwLotHistory.SelectedItems.Count == 0) return;
            frmHistoryDetail detail = new frmHistoryDetail();
            try
            {
                detail.Init(lvwLotHistory.SelectedItems[0].Tag as DataRow);
                idv.utilities.cultureLanguage.switchLanguage(detail);
                detail.ShowDialog();
            }
            finally
            {
                detail.Close();
            }
        }

        private void lvwLotHistory_DoubleClick(object sender, EventArgs e)
        {
            btnHistoryDetail.PerformClick();
        }

        bool bFlag_Members = false;
        bool bFlag_FutureAction = false;
        bool bFlag_ParentChild = false;
        bool bFlag_StepDC = false;
        bool bFlag_Step = false;
        bool bFlag_MaterialTracking = false;
        bool bFlag_Tooling = false;
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabHistory) return;
            if (currentLot == null)
            {
                tabControl1.SelectedTab = tabHistory;
                return;
            }
            
            Cursor = Cursors.WaitCursor;
            try
            {
                if (e.TabPage == tabMembers && bFlag_Members == false)
                    initTabMembers();
                else if (e.TabPage == tabFutureAction && bFlag_FutureAction == false)
                    initTabFutureAction();
                else if (e.TabPage == tabParentChild && bFlag_ParentChild == false)
                    initParentChild();
                else if (e.TabPage == tabStepDC && bFlag_StepDC == false)
                    initStepDC();
                else if (e.TabPage == tabStep && bFlag_Step == false)
                    initStep();
                else if (e.TabPage == tabMaterialTracking && bFlag_MaterialTracking == false)
                    initMaterialTracking();
                else if (e.TabPage == tabTooling && bFlag_Tooling == false)
                    initTooling();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #region tabMembers
        void initTabMembers()
        {
            if (currentLot == null) return;
            bFlag_Members = true;
            txtStartQty.Text = currentLot.startQuantity.ToString();
            txtCurrentQty.Text = currentLot.quantity.ToString();
            txtUnit.Text = currentLot.unit;
            lvwCarrier.Items.Clear();
            foreach (mesRelease.CAR.Carrier c in currentLot.CarrierList)
            {
                ListViewItem item = new ListViewItem(c.name);
                item.SubItems.Add(c.componentQty.ToString());
                lvwCarrier.Items.Add(item);
            }
            showComponentInfo("");
        }

        void showComponentInfo(string carrierId)
        {
            if (currentLot.ComponentInfo == null) return;
            lvwComponents.Items.Clear();
            foreach (mesRelease.WIP.WipComponent c in currentLot.ComponentInfo)
            {
                if (c.carrierId == "" || carrierId == "" || c.carrierId == carrierId)
                {
                    ListViewItem item = new ListViewItem(c.name);
                    item.SubItems.Add(c.carrierId);
                    item.SubItems.Add(c.position.ToString());
                    item.SubItems.Add(c.integrity.ToString());
                    lvwComponents.Items.Add(item);
                }
            }
        }

        private void lvwCarrier_MouseUp(object sender, MouseEventArgs e)
        {
            if (lvwCarrier.SelectedItems.Count == 0)
                showComponentInfo("");
            else
                showComponentInfo(lvwCarrier.SelectedItems[0].Text);
        }

        #endregion

        void initTabFutureAction()
        {
            bFlag_FutureAction = true;

            //Working Instruction
            string condition = "(id='" + currentLot.orderId + "' and kind='0') or " +
                               "(id='" + currentLot.name + "' and kind='1') or " +
                               "(id='" + currentLot.routeId + "' and kind='2') or " +
                               "(id='" + currentLot.productId + "' and kind='3')";
            mesRelease.WIP.WorkingInstruction[] wis = mesRelease.WIP.WorkingInstruction.GetWorkingInstruction(condition);

            List<string> nextStepIds = new List<string>();//未來會經過的站點
            mesRelease.PRP.Route route = currentLot.GetRoute();
            mesRelease.PRP.Step step = currentLot.GetCurrentStep();
            step = route.NextStep(step.stepHandle, "PASS");
            while (step != null)
            {
                nextStepIds.Add(step.name);
                step = route.NextStep(step.stepHandle, "PASS");
            }

            foreach (mesRelease.WIP.WorkingInstruction wi in wis)
            {
                if (DateTime.Now > wi.expireDate || wi.deleteFlag == "1") continue;
                bool bNextStep = false;
                foreach (string s in nextStepIds)
                {
                    if (s == wi.stepId)
                    {
                        bNextStep = true;
                        break;
                    }
                }
                if (!bNextStep) continue;
                ListViewItem item = new ListViewItem(wi.instruction);
                item.SubItems.Add(wi.stepId);
                item.SubItems.Add(wi.modifyUser);
                lvwWI.Items.Add(item);
            }
            if (lvwWI.Items.Count > 0)
            {
                lvwWI.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwWI.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            //Future Hold
            mesRelease.WIP.FutureHoldInfo[] futureHolds = mesRelease.WIP.FutureHoldInfo.GetFutureHoldInfo(condition);
            foreach (mesRelease.WIP.FutureHoldInfo futureHold in futureHolds)
            {
                if (DateTime.Now > futureHold.expireDate || futureHold.deleteFlag == "1" || futureHold.active == "0")
                    continue;
                bool bNextStep = false;
                foreach (string s in nextStepIds)
                {
                    if (s == futureHold.stepId)
                    {
                        bNextStep = true;
                        break;
                    }
                }
                if (!bNextStep) continue;
                string description = idv.utilities.cultureLanguage.getValue(futureHold.reasonCode);
                ListViewItem item = new ListViewItem();
                if (description == "")
                    item.Text = futureHold.reasonCode;
                else
                    item.Text = futureHold.reasonCode + " - " + description;
                item.SubItems.Add(futureHold.stepId);
                description = cultureLanguage.getValue(futureHold.timing.ToString());
                if (description == "")
                    item.SubItems.Add(futureHold.timing.ToString());
                else
                    item.SubItems.Add(description);
                item.SubItems.Add(futureHold.modifyUser);
                lvwFutureHold.Items.Add(item);
            }
            if (lvwFutureHold.Items.Count > 0)
            {
                lvwFutureHold.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwFutureHold.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwFutureHold.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            //Q Time
            string sql = "select * from mes_wip_q_time_monitor where lot_id=? and delete_flag=?";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, currentLot.name, "0");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["from_step_id"].ToString();
                item.SubItems.Add(row["from_step_handle"].ToString());
                item.SubItems.Add(row["to_step_id"].ToString());
                item.SubItems.Add(row["to_step_handle"].ToString());
                item.SubItems.Add(row["start_date"].ToString());
                item.SubItems.Add(row["q_time"].ToString());
                TimeSpan ts = DateTime.Now - (DateTime)row["start_date"];
                int remainHour = Convert.ToInt32(row["q_time"].ToString()) - (int)ts.TotalMinutes;
                item.SubItems.Add(remainHour.ToString());
                lvwQTime.Items.Add(item);
            }
            if (lvwQTime.Items.Count > 0)
            {
                lvwQTime.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwQTime.Columns[1].Width = 0;
                lvwQTime.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwQTime.Columns[3].Width = 0;
                lvwQTime.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwQTime.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwQTime.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        void initParentChild()
        {
            bFlag_ParentChild = true;
            txtSourceParent.Text = currentLot.sourceParent;
            if (currentLot.name != currentLot.topParent)
                txtTopParent.Text = currentLot.topParent;
            txtSplitParent.Text = currentLot.splitParent;
            txtMergeParent.Text = currentLot.mergeParent;

            mesRelease.WIP.Lot[] lots = mesRelease.WIP.Lot.GetLots("split_parent", currentLot.name);
            foreach (mesRelease.WIP.Lot lot in lots)
            {
                if (!lot.IsWIPStatus()) continue;
                ListViewItem item = new ListViewItem(lot.name);
                item.SubItems.Add(lot.quantity.ToString());
                item.SubItems.Add(lot.status);
                item.SubItems.Add(lot.stepId);
                lvwChildLot.Items.Add(item);
            }
        }

        #region tabStepDC

        DataTable dtStepDC = null;
        void initStepDC()
        {
            bFlag_StepDC = true;
            string sql = "select a.step_id,a.activity,a.modify_date,b.value,c.name,c.description from mes_wip_lot_history a " +
                                 "join mes_wip_lot_history_dc_item b on a.txn_sysid=b.txn_sysid " +
                                 "join mes_prp_step_dc_item c on b.dc_item_sysid=c.sysid " +
                         "where a.lot_id=?";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, currentLot.name);
            dtStepDC = ds.Tables[0];
            Dictionary<string, DataRow> stepIds = new Dictionary<string, DataRow>();
            foreach (DataRow row in dtStepDC.Rows)
            {
                if (!stepIds.ContainsKey(row["step_id"].ToString()))
                    stepIds.Add(row["step_id"].ToString(), row);
            }
            cboStep.Items.Add("");
            foreach (string s in stepIds.Keys.ToArray())
            {
                string stepDesc = idv.utilities.cultureLanguage.getValue(s);
                if (stepDesc == "")
                    cboStep.Items.Add(s);
                else
                    cboStep.Items.Add(s + " - " + stepDesc);
            }
        }
        void showStepDCValues(string stepId)
        {
            lvwStepDC.Items.Clear();
            foreach (DataRow row in dtStepDC.Rows)
            {
                if (stepId == "" || stepId == row["step_id"].ToString())
                {
                    ListViewItem item = new ListViewItem(row["step_id"].ToString());
                    item.SubItems.Add(row["name"].ToString());
                    item.SubItems.Add(row["description"].ToString());
                    item.SubItems.Add(row["value"].ToString());
                    item.SubItems.Add(row["modify_date"].ToString());
                    item.SubItems.Add(row["activity"].ToString());
                    lvwStepDC.Items.Add(item);
                }
            }
            if (lvwStepDC.Items.Count > 0)
            {
                lvwStepDC.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwStepDC.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                //lvwStepDC.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwStepDC.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwStepDC.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);

                if (lvwStepDC.Columns[0].Width < 80) lvwStepDC.Columns[0].Width = 80;
            }
        }
        private void cboStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            showStepDCValues(cboStep.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]);
        }
        private void btnExportStepDC_Click(object sender, EventArgs e)
        {
            if (lvwStepDC.Items.Count > 0)
                mesRelease.utilities.ExcelAgent.WriteToFile(lvwStepDC);
        }
        #endregion

        void initStep()
        {
            string temp = "";
            bFlag_Step = true;
            txtStepId.Text = currentLot.stepId;
            txtStepDescription.Text = idv.utilities.cultureLanguage.getValue(currentLot.stepId);
            temp = idv.utilities.cultureLanguage.getValue(currentLot.ruleId);
            if (temp != "")
                txtCurrentRule.Text = temp;
            else
                txtCurrentRule.Text = currentLot.ruleId;
            txtRuleIndex.Text = currentLot.ruleSeq.ToString();
            idv.mesCore.WIP.Txn.Info.lotTrackingInfo trackInfo = currentLot.GetLotTrackingInfo();
            if (trackInfo != null)
            {
                if (trackInfo.moveInDate != DateTime.MinValue)
                {
                    txtMoveInDate.Text = trackInfo.moveInDate.ToString();
                    if (trackInfo.trackInDate == DateTime.MinValue)
                    {
                        TimeSpan ts = DateTime.Now - trackInfo.moveInDate;
                        if (ts.Days != 0)
                            txtWaitTime.Text = ts.Days.ToString() + "D ";
                        txtWaitTime.Text += ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString();
                    }
                }
                trackInfo = trackInfo.GetPreviousLotTracking();
                if (trackInfo != null && trackInfo.moveOutDate != DateTime.MinValue)
                    txtMoveOutDate.Text = trackInfo.moveOutDate.ToString();
            }
            txtStepStatus.Text = currentLot.processingStatus;
            if (currentLot.GetCurrentStep() != null)
            {
                txtAvailablePath.Text = string.Join(Environment.NewLine, currentLot.GetCurrentStep().availablePaths);
                txtStage.Text = currentLot.GetCurrentStep().stage;
                txtEquipmentGroup.Text = currentLot.GetCurrentStep().equipmentGroup;
            }

            //stepMap
            temp = "select step_handle,move_out_date from mes_wip_lot_tracking where lot_id=? order by seq";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(temp, currentLot.name);
            mesRelease.PRP.Route r = currentLot.GetRoute();
            mesRelease.PRP.Step step = null;
            //先顯示已完工站點
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr["move_out_date"].ToString() == "") continue;
                step = r.FindStep(dr["step_handle"].ToString());
                if (step == null) continue;
                ListViewItem item = new ListViewItem(step.stepHandle);
                //item.SubItems.Add(step.name+"."+step.version.ToString());
                item.SubItems.Add(step.name);
                item.SubItems.Add(dr["move_out_date"].ToString());
                lvwStepMap.Items.Add(item);
            }

            if (currentLot.IsWIPStatus())
            {
                step = currentLot.GetCurrentStep();
                while (step != null)
                {
                    ListViewItem item = new ListViewItem(step.stepHandle);
                    //item.SubItems.Add(step.name + "." + step.version.ToString());
                    item.SubItems.Add(step.name);
                    item.SubItems.Add("");
                    lvwStepMap.Items.Add(item);
                    step = r.NextStep(step.stepHandle, "PASS");
                }
            }
        }

        #region tabMaterialTracking

        DataTable dtMaterialTracking = null;
        void initMaterialTracking()
        {
            bFlag_MaterialTracking = true;
            string sql = "select a.step_id,a.lot_id,a.modify_date,b.* from mes_wip_lot_history a " +
                                "join mes_eqp_history_setup_info b on a.setup_info=b.eqp_setup_info " +
                         "where a.lot_id=? ";

            //if (idv.mesCore.systemConfig.assemblyMode)
            //    sql += "and a.activity='TrackOut'";
            //else
            //    sql += "and a.activity='TrackIn'";

            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, currentLot.name);
            dtMaterialTracking = ds.Tables[0];
            Dictionary<string, DataRow> stepIds = new Dictionary<string, DataRow>();
            foreach (DataRow row in dtMaterialTracking.Rows)
            {
                if (!stepIds.ContainsKey(row["step_id"].ToString()))
                    stepIds.Add(row["step_id"].ToString(), row);
            }
            cboMaterialTrackingStep.Items.Add("");
            foreach (string s in stepIds.Keys.ToArray())
            {
                string stepDesc = idv.utilities.cultureLanguage.getValue(s);
                if (stepDesc == "")
                    cboMaterialTrackingStep.Items.Add(s);
                else
                    cboMaterialTrackingStep.Items.Add(s + " - " + stepDesc);
            }
        }
        void showMaterialTracking(string stepId)
        {
            lvwMaterialTracking.Items.Clear();
            List<string> filter = new List<string>();
            foreach (DataRow row in dtMaterialTracking.Rows)
            {
                if (stepId == "" || stepId == row["step_id"].ToString())
                {
                    string filKey = row["step_id"].ToString() + row["part_no"].ToString() + row["material_lot_id"].ToString() + row["position"].ToString();
                    if (filter.Contains(filKey)) continue;
                    filter.Add(filKey);
                    ListViewItem item = new ListViewItem(row["step_id"].ToString());
                    item.SubItems.Add(row["material_type"].ToString());
                    item.SubItems.Add(row["part_no"].ToString());
                    item.SubItems.Add(row["material_lot_id"].ToString());
                    item.SubItems.Add(row["position"].ToString());
                    item.SubItems.Add(row["setup_user"].ToString());
                    item.SubItems.Add(row["modify_date"].ToString());
                    lvwMaterialTracking.Items.Add(item);
                }
            }
            if (lvwMaterialTracking.Items.Count > 0)
            {
                lvwMaterialTracking.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwMaterialTracking.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwMaterialTracking.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwMaterialTracking.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwMaterialTracking.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwMaterialTracking.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwMaterialTracking.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
        private void cboMaterialTrackingStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMaterialTracking(cboMaterialTrackingStep.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]);
        }

        private void btnExportMaterialTracking_Click(object sender, EventArgs e)
        {
            if (lvwMaterialTracking.Items.Count > 0)
                mesRelease.utilities.ExcelAgent.WriteToFile(lvwMaterialTracking);
        }

        #endregion

        #region tabTooling

        DataTable dtTooling = null;
        void initTooling()
        {
            bFlag_Tooling = true;
            string sql = "select a.step_id,a.lot_id,a.modify_date,b.* from mes_wip_lot_history a " +
                         "join mes_eqp_history_tooling_info b on a.tooling_setup_info=b.tooling_setup_info " +
                         "where a.lot_id=? ";

            //if (idv.mesCore.systemConfig.assemblyMode)
            //    sql += "and a.activity='TrackOut'";
            //else
            //    sql += "and a.activity='TrackIn'";

            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, currentLot.name);
            dtTooling = ds.Tables[0];
            Dictionary<string, DataRow> stepIds = new Dictionary<string, DataRow>();
            foreach (DataRow row in dtTooling.Rows)
            {
                if (!stepIds.ContainsKey(row["step_id"].ToString()))
                    stepIds.Add(row["step_id"].ToString(), row);
            }
            cboToolingStep.Items.Add("");
            foreach (string s in stepIds.Keys.ToArray())
            {
                string stepDesc = idv.utilities.cultureLanguage.getValue(s);
                if (stepDesc == "")
                    cboToolingStep.Items.Add(s);
                else
                    cboToolingStep.Items.Add(s + " - " + stepDesc);
            }
        }

        void showTooling(string stepId)
        {
            lvwTooling.Items.Clear();
            List<string> filter = new List<string>();
            foreach (DataRow row in dtTooling.Rows)
            {
                if (stepId == "" || stepId == row["step_id"].ToString())
                {
                    string filKey = row["step_id"].ToString() + row["tooling_id"].ToString();
                    if (filter.Contains(filKey)) continue;
                    filter.Add(filKey);
                    ListViewItem item = new ListViewItem(row["step_id"].ToString());
                    item.SubItems.Add(row["tooling_id"].ToString());
                    item.SubItems.Add(row["part_no"].ToString());
                    item.SubItems.Add(row["current_count"].ToString());
                    item.SubItems.Add(row["use_count"].ToString());
                    item.SubItems.Add(row["setup_user"].ToString());
                    item.SubItems.Add(row["modify_date"].ToString());
                    lvwTooling.Items.Add(item);
                }
            }
            if (lvwTooling.Items.Count > 0)
            {
                lvwTooling.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwTooling.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwTooling.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwTooling.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwTooling.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwTooling.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwTooling.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
        private void cboToolingStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTooling(cboToolingStep.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]);
        }

        private void btnExportTooling_Click(object sender, EventArgs e)
        {
            if (lvwTooling.Items.Count > 0)
                mesRelease.utilities.ExcelAgent.WriteToFile(lvwTooling);
        }
        #endregion
    }
}
