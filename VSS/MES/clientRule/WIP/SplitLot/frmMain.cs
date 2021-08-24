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

namespace ClientRule.SplitLot
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

            lotInfomation1.Init(currentLot);

            lotInfomation1.LotChanged += new mesRelease.Controls.LotChangeEventHandler(lotInfomation1_LotChanged);

            initLot();

            layoutForm();

            idv.utilities.cultureLanguage.switchLanguage(this);
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
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();
            InitParentLot();
            InitChildLot();
            txtChildLotId.Text = "";
            txtChildLotQuantity.Text = "";
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                reasonCode1.Init("SplitLot", currentLot.stepId);
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
                if (idv.mesCore.systemConfig.componentInfo)
                {
                    carParentCarrier.Visible = false;
                    carChildCarrier.Visible = false;
                    compParentComponent.Dock = DockStyle.Fill;
                    compChildComponent.Dock = DockStyle.Fill;
                }
                else
                {
                    tblParentCarrier.Hide();
                    tblChildCarrier.Hide();
                    compParentComponent.Visible = false;
                    compChildComponent.Visible = false;
                    carParentCarrier.Dock = DockStyle.Fill;
                    carChildCarrier.Dock = DockStyle.Fill;
                }
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                tblParentCarrier.Hide();
                tblChildCarrier.Hide();
                carParentCarrier.Visible = false;
                carChildCarrier.Visible = false;
                compParentComponent.Dock = DockStyle.Fill;
                compChildComponent.Dock = DockStyle.Fill;
            }
            else
            {
                pnlParent.Hide();
                tblMove.Hide();
                carChildCarrier.Hide();
                compChildComponent.Hide();
                tblChildCarrier.Hide();
                lblChild.Hide();
                tblInputData.ColumnStyles[0].Width = 0;
                tblInputData.ColumnStyles[1].Width = 0;
                txtChildLotQuantity.ReadOnly = false;
                txtChildLotQuantity.BackColor = SystemColors.Info;
                Width = 710;
                Height = 402;
                splitContainer1.SplitterDistance = 224;
                splitContainer2.SplitterDistance = 124;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.WIP.Txn.SplitLot txn = new mesRelease.WIP.Txn.SplitLot();
            txn.txnUser = User.loginUser.name;
            txn.reasonCode = reasonCode1.reasonCode;
            txn.comments = reasonCode1.comments;

            //add protagonist to txn item collcation by txn.add method
            txn.Add(currentLot);

            mesRelease.WIP.Txn.SplitLotInfo splitInfo = new mesRelease.WIP.Txn.SplitLotInfo();
            splitInfo.childLotId = txtChildLotId.Text;
            splitInfo.quantity = currentChild.quantity;
            splitInfo.componentInfo = currentChild.ComponentInfo;
            splitInfo.carrierList.AddRange(currentChild.CarrierList.ToArray());
            txn.splitInfo.Add(splitInfo);

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
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentLot != null)
            {
                if (cboChildCarrier.Items.Count > 1 || currentChild.CarrierList.Count > 0 ||
                    (currentChild.ComponentInfo != null && currentChild.ComponentInfo.Count > 0))
                {
                    if (!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo))
                    {
                        return;
                    }
                    currentLot.Refresh();
                }
            }
            Close();
        }

        bool checkBeforeTxn()
        {
            if (txtChildLotId.Text == "")
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", "&lotId")
                                                              , idv.mesCore.Controls.informationType.warn);
                return false;
            }
            if (reasonCode1.reasonCode == "")
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", "&ReasonCode")
                                                          , idv.mesCore.Controls.informationType.warn);
                return false;
            }
            double childQty = 0;
            double.TryParse(txtChildLotQuantity.Text, out childQty);
            if (childQty == 0 || childQty > currentLot.quantity)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgMakesureInformation", "&quantity")
                                                              , idv.mesCore.Controls.informationType.warn);
                return false;
            }
            currentChild.quantity = childQty;

            if (idv.mesCore.systemConfig.componentInfo)
            {
                compParentComponent.Confirm();
                compChildComponent.Confirm();
            }
            else if (idv.mesCore.systemConfig.carrierManagement)
            {
                int carQty = 0;
                int childCarQty = 0;
                foreach(mesRelease.CAR.Carrier car in currentLot.CarrierList)
                    carQty+=car.componentQty;
                foreach (mesRelease.CAR.Carrier car in currentChild.CarrierList)
                {
                    carQty += car.componentQty;
                    childCarQty += car.componentQty;
                }
                if (carQty != Math.Ceiling(currentLot.quantity) || childCarQty != Math.Ceiling(childQty))
                {
                    standardStatusbar1.setInformation(cultureLanguage.getValue("msgMakesureInformation", "&carrier")
                                  , idv.mesCore.Controls.informationType.warn);
                    return false;
                }
            }

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
                return false;
            return true;
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
            txtChildLotQuantity.MaxLength = ((int)currentLot.quantity).ToString().Length + 2;
        }
        void InitChildLot()
        {
            currentChild = new Lot();
            cboChildCarrier.Items.Clear();
            compChildComponent.Clear();
            if (idv.mesCore.systemConfig.carrierManagement)
            {
                if (idv.mesCore.systemConfig.componentInfo)
                {
                    cboChildCarrier.Items.Add("");
                    currentChild.ComponentInfo = new ComponentInfo();
                }
                else
                {
                    carChildCarrier.ShowCarriers(currentChild.CarrierList, null);
                }
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                currentChild.ComponentInfo = new ComponentInfo();
                compChildComponent.ShowComponents(currentChild.ComponentInfo);
            }
        }

        private void cboParentCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            compParentComponent.Confirm();
            compParentComponent.Clear();
            mesRelease.CAR.Carrier car = cboParentCarrier.SelectedItem as mesRelease.CAR.Carrier;
            compParentComponent.ShowComponents(currentLot.ComponentInfo, car);
        }
        private void cboChildCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            compChildComponent.Confirm();
            compChildComponent.Clear();
            mesRelease.CAR.Carrier car = cboChildCarrier.SelectedItem as mesRelease.CAR.Carrier;
            compChildComponent.ShowComponents(currentChild.ComponentInfo, car);
        }
        private void cboChildCarrier_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddCarrier.PerformClick();
        }

        private void btnMoveCarrier_Click(object sender, EventArgs e)
        {
            mesRelease.CAR.Carrier carrier = cboParentCarrier.SelectedItem as mesRelease.CAR.Carrier;
            if (carrier == null) return;
            WipComponent[] comps = compParentComponent.RemoveComponentByCarrier(carrier.name);
            if (comps.Length == 0) return;
            cboParentCarrier.Items.Remove(carrier);
            currentLot.CarrierList.Remove(carrier);
            if (cboParentCarrier.Items.Count == 2)
                cboParentCarrier.SelectedIndex = 1;
            else
                cboParentCarrier.SelectedIndex = -1;

            foreach (WipComponent comp in comps)
                currentChild.ComponentInfo.Add(comp);
            currentChild.CarrierList.Add(carrier);
            cboChildCarrier.Items.Add(carrier);
            cboChildCarrier.SelectedItem = carrier;
            showChildLotQuantity();
        }
        private void btnAddCarrier_Click(object sender, EventArgs e)
        {
            standardStatusbar1.setInformation("");
            if (cboChildCarrier.Text.Trim() == "") return;
            foreach (object obj in cboChildCarrier.Items)
            {
                mesRelease.CAR.Carrier c = obj as mesRelease.CAR.Carrier;
                if (c != null && c.name == cboChildCarrier.Text)
                    return;
            }
            mesRelease.CAR.Carrier carrier = new mesRelease.CAR.Carrier(cboChildCarrier.Text);
            if (carrier.sysid == "")
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgCannotFindData"), idv.mesCore.Controls.informationType.warn);
            else if (carrier.status != idv.mesCore.CAR.CarrierStatus.IDLE.ToString())
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgStatusInvalid"), idv.mesCore.Controls.informationType.warn);
            else
            {
                currentChild.CarrierList.Add(carrier);
                cboChildCarrier.Items.Add(carrier);
                cboChildCarrier.SelectedItem = carrier;
            }
        }

        void showChildLotQuantity()
        {
            if (idv.mesCore.systemConfig.carrierManagement)
            {
                if (idv.mesCore.systemConfig.componentInfo)
                {
                    double qty = 0;
                    foreach (WipComponent comp in currentChild.ComponentInfo.Items)
                        qty += comp.integrity;
                    txtChildLotQuantity.Text = qty.ToString();
                }
                else
                {
                    int qty = 0;
                    foreach (mesRelease.CAR.Carrier car in currentChild.CarrierList)
                        qty += car.componentQty;
                    txtChildLotQuantity.Text = qty.ToString();
                }
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                double qty = 0;
                foreach (WipComponent comp in currentChild.ComponentInfo.Items)
                    qty += comp.integrity;
                txtChildLotQuantity.Text = qty.ToString();
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (idv.mesCore.systemConfig.componentInfo)
            {
                if ((cboChildCarrier.SelectedItem as mesRelease.CAR.Carrier) == null
                               && idv.mesCore.systemConfig.carrierManagement) return;
                compParentComponent.SelectAll();
                WipComponent[] comps = compParentComponent.GetSelectedComponent();
                foreach (WipComponent comp in comps)
                {
                    compParentComponent.RemoveComponent(comp);
                    compChildComponent.AddComponent(comp);
                }
                showChildLotQuantity();
            }
            else
            {
                while (carParentCarrier.carrierList.Count > 0)
                {
                    mesRelease.CAR.Carrier car = carParentCarrier.carrierList[0];
                    carParentCarrier.RemoveCarrier(car.name);
                    carChildCarrier.AddCarrier(car);
                }
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
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
                showChildLotQuantity();
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

        private void btnUnSelect_Click(object sender, EventArgs e)
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
                showChildLotQuantity();
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

        private void carChildCarrier_CarrierAdded(mesRelease.CAR.Carrier carrier, ref bool accept)
        {
            standardStatusbar1.setInformation("");
            if (carrier.sysid == "")
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgCannotFindData"), idv.mesCore.Controls.informationType.warn);
                accept = false;
            }
            else if (carrier.status != idv.mesCore.CAR.CarrierStatus.IDLE.ToString() && carrier.lotId != currentLot.name)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgStatusInvalid"), idv.mesCore.Controls.informationType.warn);
                accept = false;
            }
        }

        private void carChildCarrier_CarrierRemoved(mesRelease.CAR.Carrier carrier, ref bool accept)
        {
            accept = messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, "delete");
        }

        private void carChildCarrier_AfterEdit(object sender, EventArgs e)
        {
            showChildLotQuantity();
        }

        private void compParentComponent_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void carParentCarrier_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void compChildComponent_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void carChildCarrier_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void btnGenerateLot_Click(object sender, EventArgs e)
        {
            if (currentLot != null)
                txtChildLotId.Text = Lot.NextChildLotId(currentLot);
        }

        private void txtChildLotQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            else if (e.KeyChar == '.' && (txtChildLotQuantity.Text.IndexOf('.') >= 0 || txtChildLotQuantity.Text == ""))
                e.Handled = true;
        }

        private void carParentCarrier_CarrierRemoved(mesRelease.CAR.Carrier carrier, ref bool accept)
        {
            accept = messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, "delete");
        }
    }
}
