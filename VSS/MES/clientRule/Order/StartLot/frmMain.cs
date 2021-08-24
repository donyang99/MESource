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

namespace ClientRule.StartLot
{
    public partial class frmMain : Form
    {
        Lot currentLot = null;
        short routeVersion = -1;
        string startStepHandle = "";
        string specSysId = "";
        bool wipComponentInfoExist = true;//不指定載具，可指定ComponentInfo
        bool carrierInfoExist = true;
        mesRelease.WIP.ComponentInfo compInfo = new ComponentInfo();
        mesRelease.PRP.Route[] allRoutes = null;
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
            List<string> hideColumn = new List<string>();
            if (!idv.mesCore.systemConfig.productParameter)
                hideColumn.Add("specId");
            if (!idv.mesCore.systemConfig.orderReceiveMaterial)
                hideColumn.Add("receiveQuantity");
            if (hideColumn.Count > 0)
                lvwOrder.columnHide = hideColumn.ToArray();
            lvwOrder.prepareColumns();

            if (!idv.mesCore.systemConfig.productParameter || mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.specEqualsToOrder
                 || mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.specEqualsToProduct)
            {
                lblSpecId.Visible = false;
                cboSpecId.Visible = false;
            }

            t.Join();
            cboOrderProductId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboOrderProductId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboOrderCustomerId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboOrderCustomerId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cboProductId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboProductId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCustomerId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCustomerId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cboStatus.Text = idv.mesCore.WIP.OrderStatus.Active.ToString();
            cboStatus.Enabled = false;
            cboOrderFab.Text = User.loginUser.fab;
            if (!cboOrderFab.Text.Equals(""))
                cboOrderFab.Enabled = false;
            
            btnQuery.PerformClick();
            wipComponentInformation1.componentInfo = compInfo;
            wipComponentInformation1.prepare();
            carrierInformation1.componentInfo = compInfo;
            carrierInformation1.prepare();
            if (!idv.mesCore.systemConfig.componentInfo)
            {
                tabControl1.TabPages.RemoveByKey("tabMembers");
                wipComponentInfoExist = false;
            }
            if (!idv.mesCore.systemConfig.carrierManagement)
            {
                tabControl1.TabPages.RemoveByKey("tabCarrier");
                carrierInfoExist = false;
            }
            else
            {
                tabControl1.TabPages.RemoveByKey("tabMembers");
                wipComponentInfoExist = false;
            }
            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                cboOrderFab.Items.Add("");
                cboOrderFab.Items.AddRange(mesRelease.BAS.Fab.GetFabNames());
                foreach (string s in cboOrderFab.Items)
                    cboFab.Items.Add(s);
                
                cboOrderProductId.Items.Add("");
                foreach (mesRelease.PRP.Product p in mesRelease.PRP.Product.GetActiveProducts(""))
                {
                    cboOrderProductId.Items.Add(p.name);
                    cboProductId.Items.Add(p);
                }
                cboOrderType.Items.Add("");
                cboOrderType.Items.AddRange(mesRelease.BAS.LotType.GetLotTypes());
                foreach (object o in cboOrderType.Items)
                    cboLotType.Items.Add(o);

                for (int i = 1; i < 10; i++)
                    cboPriority.Items.Add(i);

                cboStatus.Items.AddRange(new string[]{"",idv.mesCore.WIP.OrderStatus.Active.ToString(),
                                                         idv.mesCore.WIP.OrderStatus.Close.ToString(),
                                                         idv.mesCore.WIP.OrderStatus.Finish.ToString(),
                                                         idv.mesCore.WIP.OrderStatus.New.ToString()});                               
                cboCustomerId.Items.AddRange(mesRelease.Misc.GetCustomer());
                cboUnit.Items.Add("WAFER");
                //Get Source Parent
                //Get CustomerLotId
                if (cboUnit.Items.Count == 1) cboUnit.SelectedIndex = 0;
                if (cboFab.Items.Count == 1) cboFab.SelectedIndex = 0;
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            RuleInstance.logFunctionIn("btnOK_Click");
            Cursor = Cursors.WaitCursor;

            mesRelease.PRP.Product prod = cboProductId.SelectedItem as mesRelease.PRP.Product;

            //generate txn object and assign correspond information
            mesRelease.WIP.Txn.StartLot txn = new mesRelease.WIP.Txn.StartLot();
            txn.txnUser = User.loginUser.name;

            txn.orderId = txtOrderId.Text;
            txn.orderFab = cboFab.Text;
            txn.lotType = cboLotType.Text;
            txn.productId = prod.name;
            txn.productType = prod.productType;
            txn.routeId = cboRoute.Text;
            txn.routeVersion = routeVersion;
             
            txn.startStepHandle = startStepHandle;
            if (cboPriority.Text != "")
                txn.priority = Convert.ToByte(cboPriority.Text);
            else
                txn.priority = 5;
            if (dtpDueDate.Checked)
                txn.dueDate = dtpDueDate.Value.Date;
            txn.owner = cboOwner.Text;
            txn.customerId = cboCustomerId.Text;
            if (dtpCustomerDueDate.Checked)
                txn.customerDueDate = dtpCustomerDueDate.Value.Date;
            txn.remark = txtRemark.Text;

            txn.lotId = txtLotId.Text;
            txn.unit = cboUnit.Text;
            txn.sourceParent = cboSourceParent.Text;
            txn.customerLotId = cboCustomerLotId.Text;
            txn.quantity = Convert.ToDouble(txtQuantity.Text);
            if (cboSpecId.Visible)
            {
                txn.specId = cboSpecId.Text;
                txn.specSysId = specSysId;
            }

            if (idv.mesCore.systemConfig.carrierManagement)
                txn.carrierList = carrierInformation1.carrierList;

            if (idv.mesCore.systemConfig.componentInfo)
                txn.componentInfo = compInfo;
            //add protagonist to txn item collcation by txn.add method            

            //dotxn and get return value
            try
            {
                txn = txn.doTxn();
            }
            catch { }

            //check txn result and do correspond action
            if (txn.result.Equals("PASS"))
            {
                //*IMPORTANT*
                //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                //if there are non PASS path in Route, you can also assign other path name in RuleResult
                try
                {
                    if (lvwOrder.selectedMESItem != null)
                    {
                        WorkOrder order = new WorkOrder(lvwOrder.selectedMESItem.name);
                        lvwOrder.UpdateCurrentItem(order);
                    }
                }
                catch { }

                try
                {
                    Lot lot = txn.Item(0) as Lot;
                    if (lot.GetCurrentRule().dispatchFlag)
                        mesRelease.WF.WorkFlow.DispatchLot(lot);
                }
                catch { }
                txtLotId.Text = "";
                compInfo = new ComponentInfo();
                if (wipComponentInfoExist)
                {
                    wipComponentInformation1.Clear();
                    wipComponentInformation1.componentInfo = compInfo;
                }
                if (carrierInfoExist)
                {
                    carrierInformation1.Clear();
                    carrierInformation1.componentInfo = compInfo;
                }
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
                RuleInstance.RuleResult = "PASS";
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
            }
            Cursor = Cursors.Default;
            RuleInstance.logFunctionOut("btnOK_Click");
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
            int qty = 0;
            int.TryParse(txtQuantity.Text, out qty);
            if (qty <= 0) txtQuantity.Text = "";
            bool checkResult = CheckInputData(txtLotId, lblLotId, txtQuantity, lblQuantity, cboUnit, lblUnit, cboFab, lblFab,
                               cboLotType, lblLotId, cboProductId, lblProductId, cboRoute, lblRouteId, cboSpecId, lblSpecId);
            if (!checkResult)
                return false;

            WorkOrder order = lvwOrder.selectedMESItem as WorkOrder;
            if (order != null)//工單不為null才檢查(允許無工單下線)
            {
                int availableQty = order.quantity - order.startQuantity;
                if (idv.mesCore.systemConfig.orderReceiveMaterial)
                    availableQty = order.receiveQuantity - order.startQuantity;
                if(qty>(availableQty*1.1))//假定可超額下線10%
                {
                    standardStatusbar1.setInformation(cultureLanguage.getValue("msgNotEnough").Replace("&", lblQuantity.Text), idv.mesCore.Controls.informationType.warn);
                    return false;
                }
            }

            if (idv.mesCore.systemConfig.carrierManagement)
            {
                if (!checkCarrier())
                    return false;
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                if (!checkComponentInfo())
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
                standardStatusbar1.setInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", field),
                                idv.mesCore.Controls.informationType.warn);
                return false;
            }
            else
                return true;
        }
        bool checkCarrier()
        {
            int lotQty = 0, carTotalQty = 0;
            string temp = "";
            bool returnValue = true;
            int.TryParse(txtQuantity.Text, out lotQty);
            carrierInformation1.RemoveNoCarrierComponent(null);
            foreach (mesRelease.CAR.Carrier car in carrierInformation1.carrierList)
            {
                if (car.componentQty > car.capacity)//qty 不可大於 capacity
                {
                    returnValue = false;
                    break;
                }
                carTotalQty += car.componentQty;
                if (compInfo.Count > 0)
                {   //check carrier component qty and components in carrier
                    if (compInfo.GetComponentQuantityByCarrier(car.name) != car.componentQty)
                    {
                        returnValue = false;
                        break;
                    }
                }
            }
            if (carTotalQty != lotQty)
                returnValue = false;

            if (!returnValue)
            {
                temp = idv.utilities.cultureLanguage.getValue("carrier");
                standardStatusbar1.setInformation(idv.utilities.cultureLanguage.getValue("msgMakesureInformation").Replace("&", temp),
                            idv.mesCore.Controls.informationType.warn);
            }
            return returnValue;
        }
        bool checkComponentInfo()
        {
            wipComponentInformation1.Confirm();
            int lotQty = 0;
            int.TryParse(txtQuantity.Text, out lotQty);
            if (idv.mesCore.systemConfig.componentInfo)
            {
                if (compInfo.Count != lotQty)
                {
                    standardStatusbar1.setInformation(idv.utilities.cultureLanguage.getValue("msgMakesureInformation", "&componentId"),
                                idv.mesCore.Controls.informationType.warn);
                    return false;
                }
            }
            return true;
        }

        void assignWipComponentInfoLotInfo()
        {
            if (wipComponentInfoExist)
            {
                int qty = 0;
                int.TryParse(txtQuantity.Text, out qty);
                wipComponentInformation1.expectedQuantity = qty;
                wipComponentInformation1.lotId = txtLotId.Text;
            }
            if (carrierInfoExist)
            {
                carrierInformation1.lotId = txtLotId.Text;
            }
        }
        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            assignWipComponentInfoLotInfo();
        }
        private void txtLotId_Leave(object sender, EventArgs e)
        {
            assignWipComponentInfoLotInfo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboOrderCustomerId.Text = "";
            cboOrderType.Text = "";
            cboOrderProductId.Text = "";
            if (cboOrderFab.Enabled)
                cboOrderFab.Text = "";
            if (cboStatus.Enabled)
                cboStatus.Text = "";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            List<string> condition = new List<string>();
            if (cboOrderFab.Text != "")
                condition.Add("fab='" + cboOrderFab.Text + "'");
            if (cboOrderProductId.Text != "")
                condition.Add("product_id='" + cboOrderProductId.Text + "'");
            if (cboOrderType.Text != "")
                condition.Add("order_type='" + cboOrderType.Text + "'");
            if (cboOrderCustomerId.Text != "")
                condition.Add("customer_id='" + cboOrderCustomerId.Text + "'");
            if (cboStatus.Text != "")
                condition.Add("status='" + cboStatus.Text + "'");
            if (condition.Count == 0)
            {
                messageBox.showMessageById("msgNoConditionSpecified");
                return;
            }
            mesRelease.WIP.WorkOrder[] orders = mesRelease.WIP.WorkOrder.GetOrders(string.Join(" and ", condition.ToArray()));
            lvwOrder.ShowMESItems(orders);
        }

        private void lvwOrder_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (selected)
            {
                mesRelease.WIP.WorkOrder order = item as mesRelease.WIP.WorkOrder;
                txtOrderId.Text = order.name;
                cboFab.Text = order.fab;
                cboLotType.Text = order.orderType;
                cboProductId.Text = order.productId;
                cboRoute.Text = order.routeId;
                routeVersion = order.routeVersion;
                cboStartStep.Text = order.startStep;
                startStepHandle = order.startStepHandle;
                cboPriority.Text = order.priority.ToString();
                cboOwner.Text = order.owner;
                if (order.dueDate != DateTime.MinValue)
                    dtpDueDate.Value = order.dueDate;
                else
                    dtpDueDate.Checked = false;
                cboCustomerId.Text = order.customerId;
                if (order.customerDueDate != DateTime.MinValue)
                    dtpCustomerDueDate.Value = order.customerDueDate;
                else
                    dtpCustomerDueDate.Checked = false;
                txtRemark.Text = order.remark;
                cboSpecId.Text = order.specId;
                specSysId = order.specSysId;
            }
            else
            {
                txtOrderId.Text = "";
                txtLotId.Text = "";
                cboFab.Text = "";
                cboLotType.Text = "";
                cboProductId.Text = "";
                cboRoute.Text = "";
                routeVersion = -1;
                cboStartStep.Text = "";
                startStepHandle = "";
                cboPriority.SelectedItem = null;
                cboOwner.Text = "";
                dtpDueDate.Checked = false;
                cboCustomerId.Text = "";
                dtpCustomerDueDate.Checked = false;
                txtRemark.Text = "";
                cboSpecId.SelectedItem = null;
                specSysId = "";
            }
        }

        private void cboProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesRelease.PRP.Product prod = cboProductId.SelectedItem as mesRelease.PRP.Product;
            if (prod == null) return;
            prod.retrieveRoutes();
            cboRoute.Items.Clear();
            if (prod.Count > 0)
                cboRoute.Items.AddRange(prod.Items.ToArray());
            else
            {
                if(allRoutes==null)
                    allRoutes = mesRelease.PRP.Route.GetActiveVersionRoutes("");
                cboRoute.Items.AddRange(allRoutes);
            }
        }

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesRelease.PRP.Route route = cboRoute.SelectedItem as mesRelease.PRP.Route;
            if (route == null) return;
            route.retrieveNodes();
            routeVersion = route.version;
            mesRelease.PRP.Step step = route.FirstStep();
            step = route.NextStep(step.stepHandle, "PASS");
            cboStartStep.Items.Clear();
            cboStartStep.Items.Add("");
            while (step != null)
            {
                cboStartStep.Items.Add(step);
                step = route.NextStep(step.stepHandle, "PASS");
            }
            if (cboSpecId.Visible)
            {
                cboSpecId.Items.Clear();
                cboSpecId.Items.AddRange(mesRelease.Misc.GetSpec(cboProductId.Text, route.name));
            }
        }

        private void cboStartStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            startStepHandle = "";
            mesRelease.PRP.Step step = cboStartStep.SelectedItem as mesRelease.PRP.Step;
            if (step == null) return;
            startStepHandle = step.stepHandle;
        }

        private void btnGenerateLot_Click(object sender, EventArgs e)
        {
            WorkOrder order = lvwOrder.selectedMESItem as WorkOrder;
            if (order == null) return;
            txtLotId.Text = order.NextLotId();
            assignWipComponentInfoLotInfo();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_Enter_For_SelectAll(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void carrierInformation1_CarrierAdded(mesRelease.CAR.Carrier carrier, ref bool accept)
        {
            standardStatusbar1.setInformation("");
            if (carrier.sysid == "")
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgCannotFindData"), idv.mesCore.Controls.informationType.warn);
                accept = false;
            }
            else if (carrier.status != idv.mesCore.CAR.CarrierStatus.IDLE.ToString())
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgStatusInvalid"), idv.mesCore.Controls.informationType.warn);
                accept = false;
            }
        }
    }
}
