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
using mesRelease.WF;
using idv.utilities;
using idv.messageService.sql;

namespace ClientRule.StepDataCollect
{
    public partial class frmMain : Form
    {
        Lot currentLot = null;
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
                stepDC1.Focus();
            }
        }
        void stepDC1_InputDataCompleted(object sender, EventArgs e)
        {
            reasonCode1.Focus();
        }
        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {                        
            currentLot = RuleInstance.GetItem(0);

            stepDC1.Init(currentLot.GetCurrentStep(), idv.mesCore.PRP.DcItemTiming.TrackOut);
            stepDC1.MaximumSize = new System.Drawing.Size(1000, 125);
            stepDC1.Visible = stepDC1.VisibleCount > 0;

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            lotInfomation1.Init(currentLot);

            t.Join();
            btnOK.Enabled = stepDC1.Visible;
            idv.utilities.cultureLanguage.switchLanguageSync(this);
            CancelButton = btnCancel;
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                if (stepDC1.Visible)
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
                    }
                }
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.WIP.Txn.LogLotHistory txn = new mesRelease.WIP.Txn.LogLotHistory();
            txn.name = "StepDC";
            txn.txnUser = User.loginUser.name;
            txn.comments = reasonCode1.comments;
            if (stepDC1.Visible)
            {
                //記錄當前站點最後一次資料收集的key值
                sqlTable table = new sqlTable("mes_wip_lot_extension", eDMLtype.Delete);
                table.WhereClause.Add("item", currentLot.name);
                table.WhereClause.Add("step_id", currentLot.stepId);
                table.WhereClause.Add("ext_name", "StepDC");
                txn.extraSQLTable.Add(table);

                table = new sqlTable("mes_wip_lot_extension", eDMLtype.Insert);
                table.Add("item", currentLot.name);
                table.Add("step_id", currentLot.stepId);
                table.Add("ext_name", "StepDC");
                table.Add("value", currentLot.txnSysId);
                table.Add("modify_date", idv.messageService.serviceHost.dateTime);
                txn.extraSQLTable.Add(table);

                foreach (mesRelease.PRP.DCItem dcItem in stepDC1.GetDCItems())
                {
                    if (dcItem.itemValue.Equals("")) continue;
                    table = new sqlTable("mes_wip_lot_history_dc_item", eDMLtype.Insert);
                    table.Add("txn_sysid", currentLot.txnSysId);
                    table.Add("dc_item_sysid", dcItem.sysid);
                    table.Add("value", dcItem.itemValue);
                    txn.extraSQLTable.Add(table);
                }
            }

            //add protagonist to txn item collcation by txn.add method
            txn.Add(currentLot);

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
                RuleInstance.RuleResult = "PASS";
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            Cursor = Cursors.Default;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }

        bool checkBeforeTxn()
        {
            standardStatusbar1.setInformation("");
            if(currentLot == null)
            {
                idv.utilities.messageBox.showMessageById("noItemSelected");
                return false;
            }
            
            if (stepDC1.Visible)
                if (!stepDC1.ValidateInputValue(true, true)) return false;

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
                return false;

            return true;
        }
    }
}
