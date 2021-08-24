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

namespace ClientRule.WIPReceive
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            RuleInstance.RuleResult = "CANCEL";
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

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
                    cboProduct.Items.Add(row["product_id"].ToString());

                cboStep.Items.AddRange(mesRelease.PRP.Step.GetActiveVersionSteps(""));
                if (!mesRelease.WF.WorkFlow.CurrentStep.Equals(""))
                {
                    cboStep.Text = mesRelease.WF.WorkFlow.CurrentStep;
                    cboStep.Enabled = false;
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
            cboStep.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboStep.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            standardStatusbar1.setInformation("");
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");

            List<Lot> list = new List<Lot>();
            foreach (Lot lot in lvwLots.selectedMESItems)
                list.Add(lot);

            idv.mesCore.WF.parameter comments = new idv.mesCore.WF.parameter();
            comments.key = "Comments";
            comments.value = reasonCode1.comments;

            idv.mesCore.WF.parameter nextPath = new idv.mesCore.WF.parameter();
            nextPath.key = "NextPathByWipReceive";

            foreach (string path in list[0].GetCurrentStep().availablePaths)
            {
                if (list[0].GetRoute().NextStep(list[0].GetCurrentStep().stepHandle, path).name.Equals(cboStep.Text))
                {
                    nextPath.value = path;
                    break;
                }
            }

            try
            {
                mesRelease.WF.WorkFlow.Dispatch(list.ToArray(), "", false, true, true, "PASS", nextPath, comments);
                RuleInstance.RuleResult = "PASS";
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);

                foreach (Lot lot in list)
                    lvwLots.RemoveMESItem(lot);
            }
            catch(Exception ex)
            {
                RuleInstance.RuleResult = "CANCEL";
                standardStatusbar1.setInformation(ex.Message, idv.mesCore.Controls.informationType.error);
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
            if (lvwLots.CheckedItems.Count == 0)
            {
                messageBox.showMessageById("noItemSelected");
                return false;
            }
            else
            {
                string stepId = "";
                foreach (Lot lot in lvwLots.selectedMESItems)
                {
                    if (stepId.Equals(""))
                        stepId = lot.stepId;
                    else
                    {
                        if (!lot.stepId.Equals(stepId))
                        {
                            messageBox.showMessageById("errSelectSameCondition", lblStep.Text);
                            return false;
                        }
                    }
                }                
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
            {
                return false;
            }

            return true;
        }

        

        private void btnQuery_Click(object sender, EventArgs e)
        {
            lvwLots.RemoveAllMESItems();
            Dictionary<string, object> conditions = new Dictionary<string, object>();
            List<string> fixedCondiftion = new List<string>();
            string sql = "select /*+rule*/a.*,b.fab order_fab from mes_wip_lot a left join mes_wip_order b on a.order_id= b.order_id where ";

            if (cboStep.SelectedIndex == -1)
            {
                idv.utilities.messageBox.showMessageById("msgPlsSelectItem", lblStep.Text);
                return;
            }
            else if (cboOrderId.Text.Equals("") && cboProduct.Text.Equals(""))
            {
                idv.utilities.messageBox.showMessageById("msgPlsSelectItem", lblOrderId.Text + " or " + lblProductId.Text);
                return;
            }
            if (!addPreviousStepCondition(fixedCondiftion))
                return;
            addFABCondition(fixedCondiftion);
            fixedCondiftion.Add("a.status='WAIT'");
            if (!txtLotId.Text.Equals(""))
            {
                conditions.Add("a.lot_id=?", txtLotId.Text);
            }
            else
            {
                if (!cboOrderId.Text.Trim().Equals(""))
                    conditions.Add("a.order_id=?", cboOrderId.Text.Trim());
                else if (!cboProduct.Text.Trim().Equals("")) 
                    conditions.Add("a.product_id=?", cboProduct.Text.Trim());                   
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
                if (lot.ruleSeq == lot.GetCurrentStep().Count - 1)
                {
                    if (lot.status.Equals("WAIT") && lot.GetNextStepId(lot.ruleResult.Equals("") ? "PASS" : lot.ruleResult).Equals(cboStep.Text))
                        list.Add(lot);
                }
            }
            lvwLots.ShowMESItems(list.ToArray());
            Cursor = Cursors.Default;
        }

        void addFABCondition(List<string> conditions)
        {
            if (!mesRelease.WF.WorkFlow.CurrentFAB.Equals(""))
                conditions.Add("a.fab='" + mesRelease.WF.WorkFlow.CurrentFAB + "'");
            else if (!User.loginUser.fab.Equals(""))
                conditions.Add("a.fab='" + User.loginUser.fab + "'");
        }
        bool addPreviousStepCondition(List<string> conditions)
        {
            string[] previousStepIds = getPreviousStepIds();
            if (previousStepIds.Length == 0) return false;
            string conditon = "a.step_id in ('" + string.Join("','", previousStepIds) + "')";
            conditions.Add(conditon);
            return true;
        }
        private string[] getPreviousStepIds()
        {
            List<string> list = new List<string>();

            mesRelease.PRP.Step step = cboStep.SelectedItem as mesRelease.PRP.Step;
            if (step != null)
            {
                string productId = cboProduct.Text;
                if (!cboOrderId.Text.Equals(""))
                {
                    WorkOrder order = new WorkOrder(cboOrderId.Text);
                    if (!order.sysid.Equals(""))
                        productId = order.productId;
                }
                //取得料號所有流程，再取得所有流程的前站點
                if (!productId.Equals(""))
                {
                    mesRelease.PRP.Product product = new mesRelease.PRP.Product(productId);
                    product.retrieveRoutes();
                    foreach (mesRelease.PRP.Route route in product.Items)
                    {
                        route.retrieveNodes();
                        foreach (mesRelease.PRP.Step s in route.PreviousStepsById(step.name))
                        {
                            if (!list.Contains(s.name))
                                list.Add(s.name);
                        }
                    }
                }
            }
            return list.ToArray();
        }

        private void btnClearAll_Click_1(object sender, EventArgs e)
        {
            txtLotId.Text = "";
            cboOrderId.Text = "";
            cboProduct.Text = "";
            if (cboStep.Enabled)
                cboStep.Text = "";
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (lvwLots.Items.Count == 0) return;
            
            //選擇相同站點、工單
            if (lvwLots.CheckedItems.Count == 0)
                lvwLots.Items[0].Checked = true;

            Lot selectedLot=null;
            foreach (ListViewItem item in lvwLots.Items)
            {
                if (item.Checked)
                {
                    selectedLot = item.Tag as Lot;
                    if (selectedLot != null)
                        break;
                }
            }

            if (selectedLot == null) return;
            foreach (ListViewItem item in lvwLots.Items)
            {
                Lot lot = item.Tag as Lot;
                if (lot == null) continue;
                if (lot.stepId.Equals(selectedLot.stepId) && lot.orderId.Equals(selectedLot.orderId))
                    item.Checked = true;
                else
                    item.Checked = false;
            }
        }

        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            lvwLots.UnCheckAllItems();
        }
       
    }
}
