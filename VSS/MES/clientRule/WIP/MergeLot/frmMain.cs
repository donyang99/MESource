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

namespace ClientRule.MergeLot
{
    public partial class frmMain : Form
    {
        Lot currentLot = null;
        Lot currentChild = null;
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
            layoutForm();

            lotInfomation1.Init(currentLot);

            lotInfomation1.LotChanged += new mesRelease.Controls.LotChangeEventHandler(lotInfomation1_LotChanged);

            initLot();

            idv.utilities.cultureLanguage.switchLanguage(this);

            //隱藏QueryCondition
            Width -= splitContainer1.SplitterDistance;
            splitContainer1.Panel1MinSize = 0;
            splitContainer1.SplitterDistance = 0;
            splitContainer1.IsSplitterFixed = true;

            if (!idv.mesCore.systemConfig.stepStage)
            {
                int row = tableLayoutPanel1.GetRow(cboStage);
                lblStage.Hide();
                cboStage.Hide();
                tableLayoutPanel1.RowStyles[row].Height = 0;
            }
        }

        void lotInfomation1_LotChanged(Lot lot, ref bool accept)
        {
            currentLot = null;
            if (lot == null)
            {
                messageBox.showMessageById("msgCantFindLot");
                accept = false;
                lotInfomation1.Init(null);
            }
            else if (!lot.status.Equals(idv.mesCore.WIP.LotStatus.WAIT.ToString()))
            {
                messageBox.showMessageById("msgStatusInvalid");
                accept = false;
            }
            else
            {
                currentLot = lot;
                initLot();
                accept = true;
            }
        }

        void initLot()
        {
            if (currentLot == null) return;
            txtParentLotId.Text = currentLot.name;
            txtQuantity.Text = currentLot.quantity.ToString();
            InitParentLot();
            btnQuery.PerformClick();
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
        }

        void layoutForm()
        {
            compParentComponent.prepare();
            compChildComponent.prepare();
            carParentCarrier.prepare();
            carChildCarrier.prepare();
            if (idv.mesCore.systemConfig.carrierManagement)
            {
                lblContents.Tag = "carrier";
                if (idv.mesCore.systemConfig.componentInfo)
                {
                    carParentCarrier.Visible = false;
                    carChildCarrier.Visible = false;
                    compParentComponent.Dock = DockStyle.Fill;
                    compChildComponent.Dock = DockStyle.Fill;
                }
                else
                {
                    tblParentCarrier.Visible = false;
                    tblChildCarrier.Visible = false;
                    compParentComponent.Visible = false;
                    compChildComponent.Visible = false;
                    carParentCarrier.Dock = DockStyle.Fill;
                    carChildCarrier.Dock = DockStyle.Fill;
                }
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                lblContents.Tag = "members";
                tblParentCarrier.Visible = false;
                tblChildCarrier.Visible = false;
                carParentCarrier.Visible = false;
                carChildCarrier.Visible = false;
                compParentComponent.Dock = DockStyle.Fill;
                compChildComponent.Dock = DockStyle.Fill;
            }
            else
            {
                Height -= scChildLot.SplitterDistance;
                scChildLot.SplitterDistance = scChildLot.Height;
            }
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

        void InitParentLot()
        {
            cboParentCarrier.Items.Clear();
            compParentComponent.Clear();
            if (idv.mesCore.systemConfig.carrierManagement)
            {
                if (idv.mesCore.systemConfig.componentInfo)
                {
                    cboParentCarrier.Items.Add("");
                    cboParentCarrier.Items.AddRange(currentLot.CarrierList.ToArray());
                    if (cboParentCarrier.Items.Count == 2)
                        cboParentCarrier.SelectedIndex = 1;
                }
                else
                {
                    carParentCarrier.ShowCarriers(currentLot.CarrierList, null);
                }
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                compParentComponent.ShowComponents(currentLot.ComponentInfo);
            }
        }

        private void carParentCarrier_CarrierAdded(mesRelease.CAR.Carrier carrier, ref bool accept)
        {
            standardStatusbar1.setInformation("");
            if (carrier.sysid == "")
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgCannotFindData"), idv.mesCore.Controls.informationType.warn);
                accept = false;
            }
            else if (carrier.status != idv.mesCore.CAR.CarrierStatus.IDLE.ToString() && carrier.lotId != currentLot.name)
            {
                foreach (TabPage page in tabChildLot.TabPages)
                {
                    Lot lot = page.Tag as Lot;
                    if (lot != null && carrier.lotId == lot.name)
                        return;
                }
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgStatusInvalid"), idv.mesCore.Controls.informationType.warn);
                accept = false;
            }
        }
        private void carParentCarrier_CarrierRemoved(mesRelease.CAR.Carrier carrier, ref bool accept)
        {
            accept = messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, "delete");
        }

        private void btnAddCarrier_Click(object sender, EventArgs e)
        {
            standardStatusbar1.setInformation("");
            if (cboParentCarrier.Text.Trim() == "") return;
            foreach (object obj in cboParentCarrier.Items)
            {
                mesRelease.CAR.Carrier c = obj as mesRelease.CAR.Carrier;
                if (c != null && c.name == cboParentCarrier.Text)
                    return;
            }
            mesRelease.CAR.Carrier carrier = new mesRelease.CAR.Carrier(cboParentCarrier.Text);            
            if (carrier.sysid == "")
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgCannotFindData"), idv.mesCore.Controls.informationType.warn);
            else if (carrier.status != idv.mesCore.CAR.CarrierStatus.IDLE.ToString() && carrier.lotId != currentLot.name)
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgStatusInvalid"), idv.mesCore.Controls.informationType.warn);
            else
            {
                currentLot.CarrierList.Add(carrier);
                cboParentCarrier.Items.Add(carrier);
                cboParentCarrier.SelectedItem = carrier;
            }
        }
        private void cboParentCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            compParentComponent.Confirm();
            compParentComponent.Clear();
            mesRelease.CAR.Carrier car = cboParentCarrier.SelectedItem as mesRelease.CAR.Carrier;
            compParentComponent.ShowComponents(currentLot.ComponentInfo, car);
        }
        private void cboParentCarrier_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddCarrier.PerformClick();
        }
        private void cboChildCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            compChildComponent.Clear();
            mesRelease.CAR.Carrier car = cboChildCarrier.SelectedItem as mesRelease.CAR.Carrier;
            compChildComponent.ShowComponents(currentChild.ComponentInfo, car);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            standardStatusbar1.setInformation("");
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.WIP.Txn.MergeLot txn = new mesRelease.WIP.Txn.MergeLot();
            txn.txnUser = User.loginUser.name;

            //add protagonist to txn item collcation by txn.add method
            txn.Add(currentLot);

            //被併批
            foreach (TabPage page in tabChildLot.TabPages)
            {
                txn.mergedLot.Add(page.Tag as Lot);
            }

            //dotxn and get return value
            try
            {
                txn = txn.doTxn();
            }
            catch { }

            RuleInstance.logFunctionOut("btnOK_Click");
            //check txn result and do correspond action
            if (txn.result == "PASS")
            {
                //*IMPORTANT*
                //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                //if there are non PASS path in Route, you can also assign other path name in RuleResult
                RuleInstance.RuleResult = "PASS";
                Close();
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                standardStatusbar1.setInformation(txn.errMessage, idv.mesCore.Controls.informationType.error);
            }
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lvwLots.selectedMESItems.Length > 0)
            {
                if (!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo))
                {
                    return;
                }
            }
            if (currentLot != null)
                currentLot.Refresh();
            Close();
        }

        bool checkBeforeTxn()
        {
            if (lvwLots.selectedMESItems.Length == 0)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("noItemSelected"), idv.mesCore.Controls.informationType.warn);
                return false;
            }

            if (idv.mesCore.systemConfig.carrierManagement)
            {
                if (idv.mesCore.systemConfig.componentInfo)
                {
                    double quantity = currentLot.quantity;
                    int carQty = 0;
                    foreach (TabPage page in tabChildLot.TabPages)
                    {
                        Lot lot = page.Tag as Lot;
                        quantity += lot.quantity;
                    }
                    compParentComponent.Confirm();
                    foreach (mesRelease.CAR.Carrier car in currentLot.CarrierList)
                    {
                        car.componentQty = currentLot.ComponentInfo.GetComponentQuantityByCarrier(car.name);
                        carQty += car.componentQty;
                    }
                    //user須指定母批各載具合併後數量
                    if (Math.Ceiling(quantity) != carQty)
                    {
                        standardStatusbar1.setInformation(cultureLanguage.getValue("msgMakesureInformation", "&componentId")
                                                          , idv.mesCore.Controls.informationType.warn);
                        return false;
                    }
                }
                else
                {
                    double quantity = currentLot.quantity;
                    int carQty = 0;
                    foreach (TabPage page in tabChildLot.TabPages)
                    {
                        Lot lot = page.Tag as Lot;
                        quantity += lot.quantity;
                    }
                    foreach (mesRelease.CAR.Carrier car in currentLot.CarrierList)
                        carQty += car.componentQty;
                    //user須指定母批各載具合併後數量
                    if (Math.Ceiling(quantity) != carQty)
                    {
                        standardStatusbar1.setInformation(cultureLanguage.getValue("msgMakesureInformation", "&carrier")
                                                          , idv.mesCore.Controls.informationType.warn);
                        return false;
                    }
                }
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                foreach (TabPage page in tabChildLot.TabPages)
                {
                    Lot lot = page.Tag as Lot;
                    //user 必須將子批刻號指定到母批
                    if (lot.ComponentInfo.Count != 0)
                    {
                        standardStatusbar1.setInformation(cultureLanguage.getValue("msgMakesureInformation", "&componentId")
                                                          , idv.mesCore.Controls.informationType.warn);
                        return false;
                    }
                }
            }

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
                return false;

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
            addSpecifiedConditionForThisRule(fixedCondiftion);
            if (txtLotId.Text != "")
            {
                conditions.Add("a.lot_id=?", txtLotId.Text);
            }
            else
            {
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
            lvwLots.RemoveMESItem(currentLot);
            lvwLots.Visible = true;
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
        void addSpecifiedConditionForThisRule(List<string> conditions)
        {
            if (currentLot.orderId != "")
                conditions.Add("a.order_id='" + currentLot.orderId + "'");
            if (currentLot.specId != "")
                conditions.Add("a.spec_id='" + currentLot.specId + "'");
            conditions.Add("a.status='" + currentLot.status + "'");
            conditions.Add("a.step_id='" + currentLot.stepId + "'");
        }

        private void btnClearAll_Click_1(object sender, EventArgs e)
        {
            txtLotId.Text = "";
            cboOrderId.Text = "";
            cboProduct.Text = "";
            cboRoute.Text = "";
            cboStage.Text = "";
            cboStepId.Text = "";
            cboEquipmentType.Text = "";
            cboEquipmentId.Text = "";
        }

        void removeChildLotObjectsFromParentLot(Lot lot)
        {
            if (idv.mesCore.systemConfig.carrierManagement)
            {   //remove child's carrier from ParentLot Carrier Combo and Lot.CarrierList
                foreach (mesRelease.CAR.Carrier car in lot.CarrierList)
                {
                    if (idv.mesCore.systemConfig.componentInfo)
                    {
                        for (int i = 0; i < cboParentCarrier.Items.Count; i++)
                        {
                            mesRelease.CAR.Carrier carrier = cboParentCarrier.Items[i] as mesRelease.CAR.Carrier;
                            if (carrier != null && carrier.name == car.name)
                            {
                                if (cboParentCarrier.Text == car.name)
                                {
                                    compParentComponent.componentInfo = null;
                                    cboParentCarrier.SelectedIndex = -1;
                                }
                                cboParentCarrier.Items.Remove(carrier);
                                break;
                            }
                        }
                        for (int i = 0; i < currentLot.CarrierList.Count; i++)
                        {
                            if (currentLot.CarrierList[i].name == car.name)
                            {
                                currentLot.CarrierList.RemoveAt(i);
                                break;
                            }
                        }
                    }
                    else
                        carParentCarrier.RemoveCarrier(car.name);
                }
            }
            if (idv.mesCore.systemConfig.componentInfo && lot.ComponentInfo != null)
            {
                foreach (WipComponent comp in lot.ComponentInfo)
                    compParentComponent.RemoveComponent(comp);
            }
        }
        private void lvwLots_MESItemCheckChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected, ref bool Cancel)
        {
            if (!selected)
            {
                Lot lot = new Lot(item.name);
                if (lot.sysid != "")
                {
                    removeChildLotObjectsFromParentLot(lot);
                    lvwLots.UpdateMESItem(lot);
                }
                tabChildLot.TabPages.RemoveByKey(item.name);
            }
            else
            {
                standardStatusbar1.setInformation("");
                if ((item as Lot).ruleId != currentLot.ruleId)
                {
                    standardStatusbar1.setInformation(cultureLanguage.getValue("msgMultiSelectButDiffCondition", "&ruleIndex"), idv.mesCore.Controls.informationType.warn);
                    Cancel = true;
                    return;
                }
                TabPage page = new TabPage();
                page.Name = item.name;
                page.Text = item.name;
                page.Tag = item;
                tabChildLot.TabPages.Add(page);
                if (tabChildLot.TabCount == 1)
                    tabChildLot_SelectedIndexChanged(null, null);
            }
        }

        private void tabChildLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboChildCarrier.Items.Clear();
            compChildComponent.Clear();
            if (tabChildLot.SelectedTab == null)
                currentChild = null;
            else
            {
                currentChild = tabChildLot.SelectedTab.Tag as Lot;
                if (idv.mesCore.systemConfig.carrierManagement)
                {
                    if (idv.mesCore.systemConfig.componentInfo)
                    {
                        cboChildCarrier.Items.Add("");
                        cboChildCarrier.Items.AddRange(currentChild.CarrierList.ToArray());
                        if (cboChildCarrier.Items.Count == 2)
                            cboChildCarrier.SelectedIndex = 1;
                    }
                    else
                    {
                        carChildCarrier.ShowCarriers(currentChild.CarrierList, null);
                    }
                }
                else if (idv.mesCore.systemConfig.componentInfo)
                {
                    compChildComponent.ShowComponents(currentChild.ComponentInfo);
                }
            }
        }

        private void btnMoveCarrier_Click(object sender, EventArgs e)
        {
            mesRelease.CAR.Carrier carrier = cboChildCarrier.SelectedItem as mesRelease.CAR.Carrier;
            if (carrier == null) return;
            WipComponent[] comps = compChildComponent.RemoveComponentByCarrier(carrier.name);
            if (comps.Length == 0) return;
            cboChildCarrier.Items.Remove(carrier);
            currentChild.CarrierList.Remove(carrier);
            if (cboChildCarrier.Items.Count == 2)
                cboChildCarrier.SelectedIndex = 1;
            else
                cboChildCarrier.SelectedIndex = -1;

            foreach (WipComponent comp in comps)
                currentLot.ComponentInfo.Add(comp);
            currentLot.CarrierList.Add(carrier);
            cboParentCarrier.Items.Add(carrier);
            cboParentCarrier.SelectedItem = carrier;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (idv.mesCore.systemConfig.componentInfo)
            {
                if ((cboParentCarrier.SelectedItem as mesRelease.CAR.Carrier) == null
                               && idv.mesCore.systemConfig.carrierManagement) return;
                compChildComponent.SelectAll();
                WipComponent[] comps = compChildComponent.GetSelectedComponent();
                foreach (WipComponent comp in comps)
                {
                    compChildComponent.RemoveComponent(comp);
                    compParentComponent.AddComponent(comp);
                }
            }
            else
            {
                while(carChildCarrier.carrierList.Count>0)
                {
                    mesRelease.CAR.Carrier car = carChildCarrier.carrierList[0];
                    carChildCarrier.RemoveCarrier(car.name);
                    carParentCarrier.AddCarrier(car);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (idv.mesCore.systemConfig.componentInfo)
            {
                if ((cboParentCarrier.SelectedItem as mesRelease.CAR.Carrier) == null
                               && idv.mesCore.systemConfig.carrierManagement) return;
                if (compParentComponent.componentInfo == null) return;
                WipComponent[] comps = compChildComponent.GetSelectedComponent();
                foreach (WipComponent comp in comps)
                {
                    compChildComponent.RemoveComponent(comp);
                    compParentComponent.AddComponent(comp);
                }
            }
            else
            {
                mesRelease.CAR.Carrier car = carChildCarrier.selectedCarrier;
                if (car != null)
                {
                    carChildCarrier.RemoveCarrier(car.name);
                    carParentCarrier.AddCarrier(car);
                }
            }
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (idv.mesCore.systemConfig.componentInfo)
            {
                if ((cboChildCarrier.SelectedItem as mesRelease.CAR.Carrier) == null
                               && idv.mesCore.systemConfig.carrierManagement) return;
                if (compChildComponent.componentInfo == null) return;
                WipComponent[] comps = compParentComponent.GetSelectedComponent();
                foreach (WipComponent comp in comps)
                {
                    compParentComponent.RemoveComponent(comp);
                    compChildComponent.AddComponent(comp);
                }
            }
            else
            {
                mesRelease.CAR.Carrier car = carParentCarrier.selectedCarrier;
                if (car != null)
                {
                    carParentCarrier.RemoveCarrier(car.name);
                    carChildCarrier.AddCarrier(car);
                }
            }
        }

        private void compParentComponent_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void compChildComponent_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void carParentCarrier_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void carChildCarrier_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

    }
}
