using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;
using mesRelease.PRP;
using mesRelease.EQP;
using mesRelease.USR;
using mesRelease.WF;
using idv.utilities;
using idv.messageService.sql;

namespace ClientRule.TrackOut
{
    public partial class frmMain : Form
    {
        Lot currentLot = null;
        bool haveNextRule = false;
        bool haveTrackInRule = false;//沒有TrackIn，才在TrackOut顯示生產參數

        WorkOrder currentOrder = null;
        WorkOrder GetOrder(string orderId)
        {
            if (currentOrder == null || !currentOrder.name.Equals(orderId))
                currentOrder = new WorkOrder(orderId);
            return currentOrder;
        }

        Equipment currentEqp = null;
        Equipment GetEqp(string eqpId)
        {
            if (currentEqp == null || !currentEqp.name.Equals(eqpId))
                currentEqp = new Equipment(eqpId);
            return currentEqp;
        }

        public frmMain()
        {
            InitializeComponent();
            stepDC1.InputDataCompleted += new EventHandler(stepDC1_InputDataCompleted);
            Activated += new EventHandler(frmMain_Activated);
        }

        bool firstActive = true;
        void frmMain_Activated(object sender, EventArgs e)
        {
            if (firstActive)
            {
                firstActive = false;
                if (ruleExtension.Agent.SetFocus(this))
                    return;
                if (stepDC1.Visible)
                    stepDC1.Focus();
                else
                    reasonCode1.Focus();
            }
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            currentLot = RuleInstance.GetItem(0);
            Step step = currentLot.GetCurrentStep();
            lvwCarrier.prepareColumns();
            foreach (mesRelease.PRP.Rule r in step.Items)
            {
                if (r.name.ToUpper().IndexOf("TRACKIN") >= 0)
                {
                    haveTrackInRule = true;
                    break;
                }
            }

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            lotInfomation1.Init(currentLot);

            stepDC1.Init(step, idv.mesCore.PRP.DcItemTiming.TrackOut);
            stepDC1.MaximumSize = new System.Drawing.Size(1000, 125);
            pnlStepDC.Visible = stepDC1.VisibleCount > 0;
            if (stepDC1.Count > 0)
            {
                stepDC1.Init(currentLot);
                string sql = "select a.value,b.sysid,b.name from mes_wip_lot_history_dc_item a join mes_prp_step_dc_item b on a.dc_item_sysid=b.sysid " +
                             "where a.txn_sysid in (select value from mes_wip_lot_extension where item=? and step_id=? and ext_name=?)";
                DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, currentLot.name, currentLot.stepId, "StepDC");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                        stepDC1.ApplyValue(row["sysid"].ToString(), row["value"].ToString());
                }
                else
                {
                    stepDC1.ApplyValues(currentLot);
                    if (stepDC1.AssignFromContains("Equipment"))
                        stepDC1.ApplyValues(GetEqp(currentLot.equipmentId));
                    if (stepDC1.AssignFromContains("WorkOrder"))
                        stepDC1.ApplyValues(GetOrder(currentLot.orderId));
                    if (stepDC1.AssignFromContains("Step"))
                        stepDC1.ApplyValues(currentLot.GetCurrentStep());
                }
            }
            haveNextRule = step.Count > (step.GetRuleSeq(currentLot.ruleId) + 1);
            t.Join();

            try
            {
                ruleExtension.Agent.Init(this, step, null, ruleExt_InputDataCompleted);
                ruleExtension.Agent.RuleStart(this, WorkFlow.CurrentFAB, step, WorkFlow.CurrentEquipment, RuleInstance.RuleName, stepDC1, null, null, pnlLeft, pnlRight, RuleInstance.Logger);
                if (!ruleExtension.Agent.LotRetrieved(this, currentLot))
                {
                    btnOK.Enabled = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                messageBox.showMessage(ex.Message);
                btnOK.Enabled = false;
                return;
            }

            if (pnlLeft.Controls.Count == 0 && pnlRight.Controls.Count == 0)
                pnlCustomize.Visible = false;
            else
                pnlRight.Visible = pnlRight.Controls.Count != 0;

            pnlCarrier.Visible = idv.mesCore.systemConfig.carrierManagement;

            if (!pnlStepDC.Visible && !pnlCarrier.Visible && !pnlCustomize.Visible)
                Width = 560;

            if (lvwParameter.Items.Count == 0) pnlParameter.Visible = false;
            cultureLanguage.switchLanguage(this);

            if (lvwParameter.Visible)
            {
                lvwParameter.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwParameter.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwParameter.Columns[2].Width = lvwParameter.Width - lvwParameter.Columns[0].Width - lvwParameter.Columns[1].Width - 6;
            }
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                if (idv.mesCore.systemConfig.carrierManagement)
                    lvwCarrier.ShowMESItems(currentLot.CarrierList.ToArray());
                if (idv.mesCore.systemConfig.operatorPerformance)
                    taWorkInformation1.Init(currentLot.stepId, currentLot.equipmentId);
                else
                {
                    pnlCurrWorkInfo.Visible = false;
                    pnlCarrier.Dock = DockStyle.Fill;
                }

                if (!haveTrackInRule && idv.mesCore.systemConfig.productParameter && idv.mesCore.systemConfig.validItem("confirmParameter"))
                {
                    mesRelease.PARM.StepParameter stepParm = currentLot.GetCurrentStepParameter();
                    if (stepParm != null && stepParm.Count > 0)
                    {
                        lvwParameter.prepareColumns();
                        lvwParameter.ShowMESItems(stepParm.Items.ToArray());
                    }
                }
            }
            catch { }
        }

        void ruleExt_InputDataCompleted(object sender, EventArgs e)
        {
            if (stepDC1.Visible)
                stepDC1.Focus();
            else
                reasonCode1.Focus();
        }

        void stepDC1_InputDataCompleted(object sender, EventArgs e)
        {
            reasonCode1.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkBeforeTxn()) return;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            List<sqlTable> lstTable = new List<sqlTable>();//額外要執行的SqlTable清單
            mesRelease.WIP.Txn.TrackOut txn = new mesRelease.WIP.Txn.TrackOut();
            txn.txnUser = User.loginUser.name;
            txn.taWorkInfo = taWorkInformation1.taWorkInfo;  
            txn.comments = reasonCode1.comments;
            if (stepDC1.Count > 0)
                txn.dcItemList.AddRange(stepDC1.GetDCItems());
            txn.changeEqCapacity = true;
            if (judgePath.Equals(""))
                judgePath = "PASS";
            txn.result = judgePath;
            //add protagonist to txn item collcation by txn.add method
            txn.Add(currentLot);

            if (!ruleExtension.Agent.CheckBeforeTxn(this, txn, lstTable, null))
            {
                if (txn.result.Equals("TXNFINISH"))//在延伸邏輯裏已完成交易
                    Close();
                return;
            }
            txn.extraSQLTable.AddRange(lstTable);//sqlTables for step rule extension

            //txn.dispatchPath = "PASS";//交易和帳流一起執行
            //txn.adjustStepHandle = "S:黃光:001";//交易和帳流一起執行

            //dotxn and get return value
            try
            {
                txn = txn.doTxn();
            }
            catch { }

            RuleInstance.logFunctionOut("btnOK_Click");
            //check txn result and do correspond action
            if (txn.result.Equals("PASS"))
            {
                //*IMPORTANT*
                //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                //if there are non PASS path in Route, you can also assign other path name in RuleResult

                //RuleInstance.RuleResult = "N/A";//交易和帳流一起執行時，回傳N/A

                if (haveNextRule || judgePath.StartsWith("HOLD"))
                    RuleInstance.RuleResult = "PASS";//有下一個rule時，下一個rule依lot.ruleResult DispatchLotToNext
                else
                    RuleInstance.RuleResult = judgePath;

                if (judgePath.StartsWith("HOLD"))
                    messageBox.showMessage("Lot " + currentLot.name + " " + cultureLanguage.getValue("wasHeld"));
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            ruleExtension.Agent.ActionAfterTxn(this, RuleInstance.RuleResult);
            
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }

        string judgePath = "";
        bool checkBeforeTxn()
        {
            judgePath = "";
            Equipment curEq = GetEqp(currentLot.equipmentId);
            if (chkConfirmParameter.Visible && !chkConfirmParameter.Checked)
            {
                messageBox.showMessageById("msgConfirmParameter");
                return false;
            }
            if (stepDC1.Count > 0)
            {
                if (!stepDC1.ValidateInputValue(true, true)) return false;
                List<idv.messageService.itemBase> list = new List<idv.messageService.itemBase>();
                list.Add(currentLot);
                list.Add(curEq);
                if (stepDC1.CompareToContains("WorkOrder"))
                    list.Add(GetOrder(currentLot.orderId));
                if (stepDC1.CompareToContains("Step"))
                    list.Add(currentLot.GetCurrentStep());
                stepDC1.SetParameters(list);
            }

            if (!WorkFlow.TxnBegin(currentLot, curEq, stepDC1, ref judgePath, false))//出機不檢查Material(進機時已經檢查)
            {
                if (judgePath.Equals(""))
                    return false;
                else if (currentLot.GetCurrentStep().availablePaths.Contains(judgePath))
                {
                    idv.MESApplication.PlayNGSound();
                    messageBox.showMessageById("msgJudgeLotToStep", currentLot.GetNextStepId(judgePath));
                }
                else if (!judgePath.StartsWith("HOLD"))
                {
                    idv.MESApplication.PlayNGSound();
                    messageBox.showMessageById("msgJudgePathNotExist", judgePath);
                    return false;
                }
            }

            return true;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ruleExtension.Agent.RuleEnd(this);
        }
    }
}
