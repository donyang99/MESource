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

namespace ClientRule.UnScrapLot
{
    public partial class frmMain : Form
    {
        Lot currentLot = null;
        string initSelectLotId = "";
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            RuleInstance.RuleResult = "CANCEL";
            currentLot = RuleInstance.GetItem(0);
            string columnNames = "name,status,quantity,unit,stepId,routeId,productId,ruleId,lotType,carrierId," +
                                 "equipmentId,orderId,fab,specId,customerId,modifyUser,modifyDate";
            lvwLots.columnNames = columnNames.Split(',');
            columnNames = "lotId,status,quantity,unit,stepId,routeId,productId,ruleId,lotType,carrierId," +
                          "equipmentId,orderId,fab,specId,customerId,modifyUser,modifyDate";
            lvwLots.columnTags = columnNames.Split(',');
            lvwLots.prepareColumns();

            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();
            showEquipmentType();            

            if (!idv.mesCore.systemConfig.stepStage)
            {
                int row = tableLayoutPanel1.GetRow(cboStage);
                lblStage.Hide();
                cboStage.Hide();
                tableLayoutPanel1.RowStyles[row].Height = 0;
            }

            idv.utilities.cultureLanguage.switchLanguageSync(this);
            CancelButton = btnCancel;
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                idv.messageService.IMessageGuard client = idv.messageService.serviceHost.IsolationClient;

                cboOrderId.Items.Add("");
                string sql = "select order_id from mes_wip_order where status='Active'";
                DataSet ds = client.getDataSet(sql);
                foreach (DataRow row in ds.Tables[0].Rows)
                    cboOrderId.Items.Add(row["order_id"].ToString());

                cboProduct.Items.Add("");
                sql = "select product_id from mes_prp_product where issue_state='Active'";
                ds = client.getDataSet(sql);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cboProduct.Items.Add(row["product_id"].ToString());
                }

                cboRoute.Items.Add("");
                sql = "select route_id from mes_prp_routing where issue_state='Active'";
                ds = client.getDataSet(sql);
                foreach (DataRow row in ds.Tables[0].Rows)
                    cboRoute.Items.Add(row["route_id"].ToString());

                cboStage.Items.Add("");
                cboStepId.Items.Add("");
                sql = "select stage,step_id from mes_prp_step where issue_state='Active'";
                ds = client.getDataSet(sql);
                List<string> stage = new List<string>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string description = "";
                    if (row["stage"].ToString() != "" && !stage.Contains(row["stage"].ToString()))
                    {
                        stage.Add(row["stage"].ToString());
                        //description = idv.utilities.cultureLanguage.getValue(row["stage"].ToString());
                        if (description == "")
                            cboStage.Items.Add(row["stage"].ToString());
                        else
                            cboStage.Items.Add(row["stage"].ToString() + " - " + description);
                    }

                    //description = idv.utilities.cultureLanguage.getValue(row["step_id"].ToString());
                    if (description == "")
                        cboStepId.Items.Add(row["step_id"].ToString());
                    else
                        cboStepId.Items.Add(row["step_id"].ToString() + " - " + description);
                }

                Invoke(new MethodInvoker(setComboAutoCompleteAttribute));
            }
            catch { }
        }
        void setComboAutoCompleteAttribute()
        {
            cboOrderId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboOrderId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboRoute.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboRoute.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboStage.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboStage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboStepId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboStepId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        void showEquipmentType()
        {
            cboEquipmentType.Items.Add("");
            foreach (mesRelease.EQP.EqType type in mesRelease.EQP.EqType.GetEqTypes(""))
                cboEquipmentType.Items.Add(type.name);
            cboEquipmentType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEquipmentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");

            currentLot = lvwLots.selectedMESItem as Lot;
            while (currentLot != null)
            {
                //generate txn object and assign correspond information
                mesRelease.WIP.Txn.PullBack txn = new mesRelease.WIP.Txn.PullBack();
                txn.txnUser = User.loginUser.name;
                txn.name = "UnScrap";//Override Activity

                //add protagonist to txn item collcation by txn.add method
                txn.Add(currentLot);

                //dotxn and get return value
                try
                {
                    txn = txn.doTxn();
                }
                catch { }
                
                //check txn result and do correspond action
                if(txn.result.Equals("PASS"))
                {
                    //*IMPORTANT*
                    //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                    //if there are non PASS path in Route, you can also assign other path name in RuleResult
                    RuleInstance.RuleResult = "PASS";
                    lvwLots.RemoveMESItem(currentLot);
                    currentLot = lvwLots.selectedMESItem as Lot;
                }
                else
                {
                    //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                    //RuleInstance.RuleResult = "CANCEL";
                    standardStatusbar1.setInformation(txn.errMessage, idv.mesCore.Controls.informationType.error);
                    currentLot = null;
                }
            }

            RuleInstance.logFunctionOut("btnOK_Click");
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            Close();
        }

        bool checkBeforeTxn()
        {
            standardStatusbar1.setInformation("");
            if (lvwLots.selectedMESItems.Length == 0)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("noItemSelected"),
                                idv.mesCore.Controls.informationType.warn);
                return false;
            }
            
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
            {
                return false;
            }

            return true;
        }
        bool CheckInputData(params Control[] ctrls)
        {
            bool validFail = false;
            string field = "";
            foreach (Control ctrl in ctrls)
            {
                if (!validFail)
                {
                    if (ctrl.BackColor == SystemColors.Info && ctrl.Visible && ctrl.Text.Trim() == "")
                        validFail = true;
                }
                else
                {
                    field = ctrl.Text;
                    break;
                }
            }
            if (validFail)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", field),
                                idv.mesCore.Controls.informationType.warn);
                return false;
            }
            else
                return true;
        }

        private void cboEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            cboEquipmentId.SelectedIndex = -1;
            cboEquipmentId.Items.Clear();
            cboEquipmentId.Items.Add("");
            cboEquipmentId.AutoCompleteMode = AutoCompleteMode.None;
            foreach (mesRelease.EQP.Equipment eq in mesRelease.EQP.Equipment.GetEquipments("", cbo.Text, "", 0, "", "",
                             mesRelease.WF.WorkFlow.CurrentFAB, 0, true))
            {
                cboEquipmentId.Items.Add(eq.name);
            }
            cboEquipmentId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEquipmentId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> conditions = new Dictionary<string, object>();
            List<string> fixedCondiftion = new List<string>();
            string sql = "select /*+rule*/a.*,b.fab order_fab from mes_wip_lot a left join mes_wip_order b on a.order_id= b.order_id";
            if (cboEquipmentType.Text != "" && cboEquipmentId.Text.Trim() == "")
            {
                sql += " left join mes_eqp_equipment c on a.equipment_id=c.equipment_id where ";
                conditions.Add("c.eq_type=?", cboEquipmentType.Text.Trim());
            }
            else
                sql += " where ";

            addFABCondition(fixedCondiftion);
            if (txtLotId.Text != "")
            {
                conditions.Add("a.lot_id=?", txtLotId.Text);
            }
            else
            {
                fixedCondiftion.Add("a.status='SCRP'");
                if (cboOrderId.Text.Trim() != "")
                    conditions.Add("a.order_id=?", cboOrderId.Text.Trim());

                if (cboProduct.Text.Trim() != "")
                    conditions.Add("a.product_id=?", cboProduct.Text.Trim());

                if (cboRoute.Text.Trim() != "")
                    conditions.Add("a.route_id=?", cboRoute.Text.Trim());

                if (cboStage.Text.Trim() != "" && cboStepId.Text.Trim() == "")
                    fixedCondiftion.Add(getStepsConditionStringByStage(cboStage.Text.Trim()));
                else if (cboStepId.Text.Trim() != "")
                    conditions.Add("a.step_id=?", cboStepId.Text.Trim());

                if (cboEquipmentId.Text.Trim() != "")
                    conditions.Add("a.equipment_id=?", cboEquipmentId.Text.Trim());
            }
            if ((fixedCondiftion.Count + conditions.Count) == 0)
            {
                idv.utilities.messageBox.showMessageById("msgNoConditionSpecified");
                return;
            }
            if (fixedCondiftion.Count > 0)
            {
                sql += string.Join(" and ", fixedCondiftion.ToArray());
                if (conditions.Count > 0)
                    sql += " and ";
            }
            if (conditions.Count > 0)
                sql += string.Join(" and ", conditions.Keys.ToArray());

            dbParams = conditions.Values.ToArray();
            sqlstatement = sql;
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(showResult));
            t.Start();
            Cursor = Cursors.WaitCursor;
        }
        object[] dbParams = null;
        string sqlstatement = "";
        void showResult()
        {
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sqlstatement, dbParams);
            List<Lot> list = new List<Lot>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Lot lot = new Lot();
                lot.putAttribute(row, "");
                list.Add(lot);
            }
            lvwLots.Hide();
            lvwLots.ShowMESItems(list.ToArray());
            lvwLots.Show();
            if(!initSelectLotId.Equals(""))
            {
                lvwLots.CheckMESItems(new string[] { initSelectLotId });
                initSelectLotId = "";
            }
            Cursor = Cursors.Default;
        }

        string getStepsConditionStringByStage(string stage)
        {
            string sql = "select step_id from mes_prp_step where stage=?";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, stage);
            List<string> steps = new List<string>();
            foreach (DataRow dr in ds.Tables[0].Rows)
                steps.Add(dr["step_id"].ToString());
            return "a.step_id in ('" + string.Join("','", steps.ToArray()) + "')";
        }

        void addFABCondition(List<string> conditions)
        {
            if (mesRelease.WF.WorkFlow.CurrentFAB != "")
                conditions.Add("a.fab='" + mesRelease.WF.WorkFlow.CurrentFAB + "'");
            else if (User.loginUser.fab != "")
                conditions.Add("a.fab='" + User.loginUser.fab + "'");
        }

        private void btnClearAll_Click_1(object sender, EventArgs e)
        {
            //btnClear.PerformClick();
            txtLotId.Text = "";
            cboOrderId.Text = "";
            cboProduct.Text = "";
            cboRoute.Text = "";
            cboStage.Text = "";
            cboStepId.Text = "";
            cboEquipmentType.Text = "";
            cboEquipmentId.Text = "";
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            lvwLots.CheckAllItems();
        }

        private void btnUnCheckAll_Click(object sender, EventArgs e)
        {
            lvwLots.UnCheckAllItems();
        }
    }
}
