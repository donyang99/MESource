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
using WeifenLuo.WinFormsUI.Docking;
using mesRelease.WIP.Txn;
using idv.messageService.sql;

namespace ClientRule.CartonPacking
{
    public partial class frmMain : DockContent
    {
        mesRelease.PRP.Product currentProduct = null;
        Lot currentLot = null;
        Equipment currentEqp = null;
        Carton currentCarton = null;
        mesRelease.PRP.Step currentStep = null;
        public void SetCurrentStep(mesRelease.PRP.Step step)
        {
            currentStep = step;
            cboEquipmentId.Items.Clear();
            foreach (Equipment eq in EqGroup.GetEquipments(step.equipmentGroup, true))
            {
                if (string.Equals(eq.fab, WorkFlow.CurrentFAB))
                    cboEquipmentId.Items.Add(eq);
            }
        }

        WorkOrder currentOrder = null;
        WorkOrder GetOrder(string orderId)
        {
            if (currentOrder == null || !currentOrder.name.Equals(orderId))
                currentOrder = new WorkOrder(orderId);
            return currentOrder;
        }

        public frmMain()
        {
            InitializeComponent();
            stepDC1.InputDataCompleted += new EventHandler(stepDC1_InputDataCompleted);
        }

        void MESApplication_TextCommandInput(Control sender, string commandText)
        {
            if (sender.FindForm() != this) return;
            MessageBox.Show("InputTextCommand=" + commandText);
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            WorkFlow.MESItemUpdated += new MESItemNoticeEventHandler(WorkFlow_MESItemUpdated);//訂閱Server端MES物件更新事件通知
            idv.MESApplication.TextCommandInput += new idv.MESApplication.InputCommandEventHandler(MESApplication_TextCommandInput);
            mesRelease.MESApplication.MessagePanel = pnlDisplayMessage;
            mesRelease.WF.WorkFlow.DisErrStyle = DisplayErrorStyle.MessagePanel;

            //put the logic that run with matin thread here
            lvwCartonInfo.prepareColumns();
            lvwLotInfo.prepareColumns();
            btnExit.Visible = Parent == null;

            Text = WorkFlow.CurrentWorkingArea;
            if (WorkFlow.CurrentEquipment != null)
                cboEquipmentId.Text = WorkFlow.CurrentEquipment.name;

            if (idv.mesCore.systemConfig.assemblyMode)
                cboEquipmentId.Enabled = false;

            stepDC1.Init(currentStep, idv.mesCore.PRP.DcItemTiming.TrackOut);
            stepDC1.MaximumSize = new System.Drawing.Size(1000, 125);
            //stepDC1.AutoSize(0);
            pnlStepDC.Visible = stepDC1.VisibleCount > 0;

            t.Join();
            ActiveControl = txtLotId;

            try
            {
                ruleExtension.Agent.Init(this, currentStep, null, ruleExt_InputDataCompleted);
                ruleExtension.Agent.RuleStart(this, WorkFlow.CurrentFAB, currentStep, WorkFlow.CurrentEquipment, RuleInstance.RuleName, stepDC1, null, null, pnlLeft, pnlRight, RuleInstance.Logger);
            }
            catch (Exception ex)
            {
                messageBox.showMessage(ex.Message);
                Close();
            }

            foreach (DataRow row in idv.messageService.serviceHost.Client.getDataSetWithParameter("select distinct order_id from MES_WIP_LOT where step_id=? and status=?", currentStep.name, "WAIT").Tables[0].Rows)
                cboOrderId.Items.Add(row["order_id"].ToString());

            cultureLanguage.switchLanguageSync(this);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {   //取消Server端MES物件更新事件通知
            WorkFlow.MESItemUpdated -= new MESItemNoticeEventHandler(WorkFlow_MESItemUpdated);
            idv.MESApplication.TextCommandInput -= new idv.MESApplication.InputCommandEventHandler(MESApplication_TextCommandInput);
            ruleExtension.Agent.RuleEnd(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            pnlCurrWorkInfo.Visible = idv.mesCore.systemConfig.operatorPerformance;
        }

        private void btnRefreshOrder_Click(object sender, EventArgs e)
        {
            cboOrderId.Items.Clear();
            foreach (DataRow row in idv.messageService.serviceHost.Client.getDataSetWithParameter("select distinct order_id from MES_WIP_LOT where step_id=? and status=?", currentStep.name, "WAIT").Tables[0].Rows)
                cboOrderId.Items.Add(row["order_id"].ToString());
        }

        void WorkFlow_MESItemUpdated(idv.messageService.itemBase mesItem, Type type)
        {   //機台有更新時
            if(type.Equals(typeof(Equipment)) && mesItem.name.Equals(cboEquipmentId.Text))
            {
                txtState.Text = WorkFlow.CurrentEquipment.state;
                btnGetLot.Enabled = WorkFlow.CurrentEquipment.available;
            }
        }

        void stepDC1_InputDataCompleted(object sender, EventArgs e)
        {
            if (!ruleExtension.Agent.SetFocus(this))
            {
                txtLotId.SelectAll();
                txtLotId.Focus();
            }
        }

        void ruleExt_InputDataCompleted(object sender, EventArgs e)
        {
            txtLotId.SelectAll();
            txtLotId.Focus();
        }  

        private void txtLotId_BarcodeInput(object sender, string barcode)
        {
            btnGetLot.PerformClick();
        }

        private void btnGetLot_Click(object sender, EventArgs e)
        {
            if (idv.MESApplication.TriggerInputCommand(txtLotId, txtLotId.Text)) return;
            mesRelease.MESApplication.ClearMessage();

            if (currentCarton == null)
            {
                idv.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgPlsSelectItem", lblCartonId.Text), Color.Red);
                return; 
            }

            currentLot = null;
            if (txtLotId.Text.Trim().Equals(""))
            {
                idv.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("requireField2", lblLotId.Text), Color.Red);
                focusLotId();
                return;
            }
            Lot lot = Lot.GetLotByAny(txtLotId.Text);
            if (lot == null)
            {
                idv.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgCantFindLot"), Color.Red);
                focusLotId();
                return;
            }
            else if (!lot.equipmentId.Equals("") && !lot.equipmentId.Equals(cboEquipmentId.Text))
            {
                idv.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgWrongInfo", lblEquipment.Text), Color.Red);
                focusLotId();
                return;
            }
            txtLotStatus.Text = lot.status;

            if (!WorkFlow.RuleBegin(lot, RuleInstance.ClientRule, WorkFlow.CurrentStep))
            {
                focusLotId();
                return;
            }

            if (!currentCarton.orderId.Equals("") && !currentCarton.orderId.Equals(lot.orderId))
            {
                idv.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgWrongInfo", lblOrderId.Text), Color.Red);
                focusLotId();
                return;
            }

            if (!ruleExtension.Agent.LotRetrieved(this, lot))
            {
                focusLotId();
                return;
            }

            if (stepDC1.Count > 0)
            {
                stepDC1.Init(lot);
                stepDC1.ApplyValues(lot);

                if (stepDC1.AssignFromContains("Equipment"))
                    stepDC1.ApplyValues(WorkFlow.CurrentEquipment);
                if (stepDC1.AssignFromContains("WorkOrder"))
                    stepDC1.ApplyValues(GetOrder(lot.orderId));
                if (stepDC1.AssignFromContains("Step"))
                    stepDC1.ApplyValues(lot.GetCurrentStep());
            }

            try
            {
                if (currentCarton.Item(lot.name) == null)
                {
                    if (lvwLotInfo.TotalCount == currentProduct.packingQuantity && currentProduct.packingQuantity > 0)
                    {
                        messageBox.showMessageById("msgReachUpperLimit", "packingQuantity");
                        return;
                    }
                    currentCarton.Add(lot);
                    lvwLotInfo.UpdateMESItem(lot);
                    idv.MESApplication.PlayOKSound();
                }
                else if (messageBox.showMessageById("msgRemoveItem", messageStyle.askYesNo, lot.name, currentCarton.name))
                {
                    currentCarton.Remove(lot.name);
                    lvwLotInfo.RemoveMESItem(lot);
                }
                lvwCartonInfo.UpdateCurrentItem(currentCarton);
                txtLotId.Text = "";
            }
            catch (Exception ex)
            {
                focusLotId();
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(ex.Message, Color.Red);
            }

            currentLot = lot;

            if (lvwLotInfo.TotalCount == currentProduct.packingQuantity && currentProduct.packingQuantity > 0)
                packing();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLotId.Text = "";
            currentLot = null;
            txtLotId.Focus();
        }

        bool checkBeforeTxn()
        {   
            if(currentCarton == null)
            {
                idv.MESApplication.PlayNGSound();
                messageBox.showMessageById("noItemSelected");
                return false;
            }

            if (stepDC1.Count > 0 && !stepDC1.ValidateInputValue(true, true))
                return false;

            string judgePath = "";
            foreach (Lot lot in currentCarton.Items)
            {
                if (stepDC1.Count > 0)
                {
                    List<idv.messageService.itemBase> list = new List<idv.messageService.itemBase>();
                    list.Add(lot);
                    list.Add(WorkFlow.CurrentEquipment);
                    if (stepDC1.CompareToContains("WorkOrder"))
                        list.Add(GetOrder(lot.orderId));
                    if (stepDC1.CompareToContains("Step"))
                        list.Add(lot.GetCurrentStep());
                    stepDC1.SetParameters(list);
                }
                if (!WorkFlow.TxnBegin(lot, stepDC1, ref judgePath))
                    return false;
            }

            return true;
        }

        private void packing()
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;

            RuleInstance.logFunctionIn("btnOK_Click", "cartonId", currentCarton.name);
            List<sqlTable> lstTable = new List<sqlTable>();//額外要執行的SqlTable清單
            //generate txn object and assign correspond information
            Packing txn = new Packing();
            txn.equipmentId = cboEquipmentId.Text;
            txn.txnUser = User.loginUser.name;
            txn.taWorkInfo = taWorkInformation1.taWorkInfo;
            txn.cartonId = currentCarton.name;
            txn.lotCount = currentCarton.Count;
            if (stepDC1.Count > 0)
                txn.dcItemList.AddRange(stepDC1.GetDCItems());

            txn.result = "PASS";

            if (!ruleExtension.Agent.CheckBeforeTxn(this, txn, lstTable, null))
            {
                if (txn.result.Equals("TXNFINISH"))//在延伸邏輯裏已完成交易
                    finishAction();
                return;
            }

            txn.extraSQLTable.AddRange(lstTable);//sqlTables for step rule extension

            Cursor = Cursors.WaitCursor;
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
                idv.MESApplication.PlayOKSound();
                RuleInstance.RuleResult = "PASS";
                currentCarton.refresh();
                List<Lot> lots = new List<Lot>();
                foreach (Lot lot in currentCarton.Items)
                    lots.Add(lot);
                WorkFlow.DispatchLotToNext(lots.ToArray(), RuleInstance.RuleResult);
                lvwCartonInfo.RemoveMESItem(currentCarton);
                currentCarton = null;
                finishAction();
            }
            else
            {
                idv.MESApplication.PlayNGSound();
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            Cursor = Cursors.Default;
        }

        void focusLotId()
        {
            ActiveControl = txtLotId;
            txtLotId.SelectAll();
        }

        //完成Lot交易後，清空畫面及變數
        void finishAction()
        {
            txtLotId.Text = "";
            txtLotStatus.Text = "";
            WorkFlow.CurrentLot = null;
            currentLot = null;
            //currentOrder = null;
            stepDC1.ClearValues();
            txtLotId.Focus();
            mesRelease.MESApplication.ClearMessage();
            ruleExtension.Agent.ActionAfterTxn(this, RuleInstance.RuleResult);
        }

        private void cboEquipmentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentEqp = cboEquipmentId.SelectedItem as Equipment;
            if (currentEqp != null)
            {
                WorkFlow.CurrentEquipment = currentEqp;
                lvwCartonInfo.ShowMESItems(mesRelease.WIP.Carton.GetCartonByLocation(currentEqp.name));
                if (lvwCartonInfo.TotalCount == 1)
                    lvwCartonInfo.Items[0].Selected = true;
                txtState.Text = currentEqp.state;
                btnGetLot.Enabled = currentEqp.available;
            }
            else
            {
                lvwCartonInfo.RemoveAllMESItems();
                txtState.Text = "";
                btnGetLot.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddCarton_Click(object sender, EventArgs e)
        {
            mesRelease.MESApplication.ClearMessage();
            if (txtProductId.Text.Equals(""))
            {
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("requireField2", lblProductId.Text), Color.Red);
                return;
            }
            if (cboOrderId.Text.Equals(""))
            {
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("requireField2", lblOrderId.Text), Color.Red);
                return;
            }
            foreach (Carton item in lvwCartonInfo.GetAllMESItem())
            {
                if (cboOrderId.Text.Equals(item.orderId))//一個工單只能有一個箱號正在包裝中(同一工位)
                {
                    mesRelease.MESApplication.PlayNGSound();
                    messageBox.showMessageById("msgPackingCartonExist");
                    return;
                }
            }
            try
            {
                Carton car = new Carton();
                car.name = Carton.GetCartonId(txtProductId.Text, cboOrderId.Text);
                car.productId = txtProductId.Text;
                car.orderId = cboOrderId.Text;
                car.fab = WorkFlow.CurrentFAB;
                car.locationType = idv.mesCore.WIP.CartonLocation.Equipment;
                car.location = cboEquipmentId.Text;
                car.createUser = mesRelease.USR.User.loginUserId;
                car.New();
                lvwCartonInfo.UpdateMESItem(car);
                
            }
            catch (Exception ex)
            {
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(ex.Message, Color.Red);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            mesRelease.MESApplication.ClearMessage();
            if (currentCarton == null)
            {
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("noItemSelected", lblProductId.Text), Color.Red);
                return;
            }
            if (!messageBox.showMessageById("msgCancelPacking", messageStyle.askYesNo))
                return;

            try
            {
                currentCarton.Delete();
                lvwCartonInfo.RemoveMESItem(currentCarton);
            }
            catch (Exception ex)
            {
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(ex.Message, Color.Red);
            }
        }

        private void btnForcePack_Click(object sender, EventArgs e)
        {
            mesRelease.MESApplication.ClearMessage();
            if (currentCarton == null)
            {
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("noItemSelected", lblProductId.Text), Color.Red);
                return;
            }
            if (!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo))
                return;

            packing();
        }

        bool ignoreMESSelectEvent = false;
        private void lvwCartonInfo_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (ignoreMESSelectEvent) return;
            if (!selected)
            {
                currentCarton = null;
                txtProductId.Text = "";
                cboOrderId.Text = "";
                txtCartonId.Text = "";
                lvwLotInfo.RemoveAllMESItems();
            }
            else
            {
                currentCarton = item as Carton;
                if (currentCarton == null) return;
                txtProductId.Text = currentCarton.productId;
                cboOrderId.Text = currentCarton.orderId;
                txtCartonId.Text = currentCarton.name;
                currentCarton.retrieveLots();
                ignoreMESSelectEvent = true;
                lvwCartonInfo.UpdateCurrentItem(currentCarton);
                ignoreMESSelectEvent = false;
                lvwLotInfo.ShowMESItems(currentCarton.Items.ToArray());

                if (currentProduct == null || !currentProduct.name.Equals(currentCarton.productId))
                {
                    if (currentCarton.productId.Equals(""))
                        currentProduct = null;
                    else
                        currentProduct = WorkFlow.CurrentProduct(currentCarton.productId);
                }
            }
        }

        private void lvwLotInfo_DoubleClick(object sender, EventArgs e)
        {
            if (lvwLotInfo.selectedMESItem != null)
            {
                txtLotId.Text = lvwLotInfo.selectedMESItem.name;
                btnGetLot.PerformClick();
            }
        }

        private void cboOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOrderId.Text.Trim().Equals("")) return;
            WorkOrder order = GetOrder(cboOrderId.Text);
            if (order != null)
                txtProductId.Text = order.productId;
        }


    }
}
