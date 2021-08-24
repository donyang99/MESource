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

namespace ClientRule.LotQuery
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
            string columnNames = "name,status,processingStatus,quantity,startQuantity,unit,lotType,carrierId,productId,routeId,stepId,ruleId," +
                                 "equipmentId,orderId,fab,specId,location,customerId,customerDueDate,dueDate,modifyUser,modifyDate";
            lvwLots.columnNames = columnNames.Split(',');
            columnNames = "lotId,status,processingStatus,quantity,startQuantity,unit,lotType,carrierId,productId,routeId,stepId,ruleId," +
                          "equipmentId,orderId,fab,specId,location,customerId,customerDueDate,dueDate,modifyUser,modifyDate";
            lvwLots.columnTags = columnNames.Split(',');
            lvwLots.prepareColumns();

            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();
            showLotStatus();
            showEquipmentType();
            showFAB();

            idv.utilities.cultureLanguage.switchLanguageSync(this);

            if (!idv.mesCore.systemConfig.stepStage)
            {
                int row = tableLayoutPanel1.GetRow(cboStage);
                lblStage.Hide();
                cboStage.Hide();
                tableLayoutPanel1.RowStyles[row].Height = 0;
            }            
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
            CancelButton = btnCancel;
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

        void showLotStatus()
        {
            foreach (string s in mesRelease.WIP.Lot.lotStatus)
            {
                string description = idv.utilities.cultureLanguage.getValue(s);
                if (description == "")
                    lvwStatus.Items.Add(s).Tag = s;//Status放在Tag裏
                else
                    lvwStatus.Items.Add(s + "(" + description + ")").Tag = s;
            }
            foreach (ListViewItem item in lvwStatus.Items)
            {
                if (item.Tag.ToString() == idv.mesCore.WIP.LotStatus.WAIT.ToString() ||
                    item.Tag.ToString() == idv.mesCore.WIP.LotStatus.RUN.ToString() ||
                    item.Tag.ToString() == idv.mesCore.WIP.LotStatus.HOLD.ToString())
                {
                    item.Checked = true;
                }
            }
        }

        void showEquipmentType()
        {
            cboEquipmentType.Items.Add("");
            foreach (mesRelease.EQP.EqType type in mesRelease.EQP.EqType.GetEqTypes(""))
                cboEquipmentType.Items.Add(type.name);
            cboEquipmentType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEquipmentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        void showFAB()
        {
            cboFAB.Enabled = false;

            cboFAB.Items.AddRange(mesRelease.BAS.Fab.GetFabNames());
            
            if (cboFAB.Items.Count == 1)
                cboFAB.SelectedIndex = 0;
            else
            {
                cboFAB.Items.Add("");
                if (mesRelease.WF.WorkFlow.CurrentFAB != "")
                    cboFAB.Text = mesRelease.WF.WorkFlow.CurrentFAB;
                else if (User.loginUser.fab != "")
                    cboFAB.Text = User.loginUser.fab;
                else
                    cboFAB.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwStatus.Items)
                item.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwStatus.Items)
                item.Checked = false;
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

            if (txtLotId.Text != "")
            {
                conditions.Add("a.lot_id like ?", "%" + txtLotId.Text + "%");
            }
            else
            {
                if (cboFAB.Text.Trim() != "")
                    conditions.Add("a.fab=?", cboFAB.Text.Trim());

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

                string statusCondition = getStatusConditionString();
                if (statusCondition != "")
                    fixedCondiftion.Add(statusCondition);
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

        string getStatusConditionString()
        {
            List<string> status = new List<string>();
            foreach (ListViewItem item in lvwStatus.Items)
            {
                if (item.Checked)
                    status.Add(item.Tag.ToString());
            }
            if (status.Count == 0 || status.Count == lvwStatus.Items.Count)
                return "";
            else
                return "a.status in ('" + string.Join("','", status.ToArray()) + "')";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtLotId.Text = "";
            //btnClear.PerformClick();
            if (cboFAB.Enabled)
                cboFAB.Text = "";
            cboOrderId.Text = "";
            cboProduct.Text = "";
            cboRoute.Text = "";
            cboStage.Text = "";
            cboStepId.Text = "";
            cboEquipmentType.Text = "";
            cboEquipmentId.Text = "";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (lvwLots.Items.Count > 0)
                mesRelease.utilities.ExcelAgent.WriteToFile(lvwLots);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (lvwLots.selectedMESItem == null)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void mnuLotProperty_Click(object sender, EventArgs e)
        {
            mesRelease.WF.WorkFlow.ExecuteRule(lvwLots.selectedMESItem as mesRelease.WIP.Lot, "LotProperty");
        }

        private void lvwLots_DoubleClick(object sender, EventArgs e)
        {
            mnuLotProperty.PerformClick();
        }
    }
}
