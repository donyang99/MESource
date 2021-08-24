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

namespace ClientRule.SpecifyCarrier
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
            RuleInstance.RuleResult = "CANCEL";
            currentLot = RuleInstance.GetItem(0);

            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();
            lotInfomation1.Init(currentLot);
            
            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                layoutForm();
                InitCurrentLot();
            }
            catch { }
        }

        void layoutForm()
        {
            compBeforeComponent.prepare();
            compAfterComponent.prepare();
            carBeforeCarrier.prepare();
            carAfterCarrier.prepare();

            if (idv.mesCore.systemConfig.componentInfo)
            {
                carBeforeCarrier.Visible = false;
                carAfterCarrier.Visible = false;
                compBeforeComponent.Dock = DockStyle.Fill;
                compAfterComponent.Dock = DockStyle.Fill;
            }
            else
            {
                tblBeforeCarrier.Hide();
                tblAfterCarrier.Hide();
                compBeforeComponent.Visible = false;
                compAfterComponent.Visible = false;
                carBeforeCarrier.Dock = DockStyle.Fill;
                carAfterCarrier.Dock = DockStyle.Fill;
                tblMove.Hide();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.WIP.Txn.AdjustQuantity txn = new mesRelease.WIP.Txn.AdjustQuantity();
            txn.txnUser = User.loginUser.name;
            txn.name = "SpecifyCarrier";

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
            currentLot.Refresh();
            Close();
        }

        bool checkBeforeTxn()
        {
            compAfterComponent.Confirm();

            if (currentLot.ComponentInfo != null && currentLot.ComponentInfo.Count > 0)
            {
                foreach (mesRelease.CAR.Carrier car in currentLot.CarrierList)
                    car.componentQty = currentLot.ComponentInfo.GetComponentQuantityByCarrier(car.name);
            }

            int carQty = 0;
            foreach (mesRelease.CAR.Carrier car in currentLot.CarrierList)
                carQty += car.componentQty;

            if (carQty != Math.Ceiling(currentLot.quantity))
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgMakesureInformation", "&carrier")
                              , idv.mesCore.Controls.informationType.warn);
                return false;
            }

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
                return false;
            return true;
        }

        void InitCurrentLot()
        {
            cboAfterCarrier.Items.Clear();
            compAfterComponent.Clear();
            cboBeforeCarrier.Items.Clear();
            compBeforeComponent.Clear();

            if (idv.mesCore.systemConfig.componentInfo)
            {
                cboAfterCarrier.Items.Add("");
                cboAfterCarrier.Items.AddRange(currentLot.CarrierList.ToArray());
                if (cboAfterCarrier.Items.Count == 2)
                    cboAfterCarrier.SelectedIndex = cboAfterCarrier.Items.Count - 1;

                cboBeforeCarrier.Items.Add("");
                cboBeforeCarrier.Items.AddRange(currentLot.CarrierList.ToArray());
                if (cboBeforeCarrier.Items.Count <= 2)
                    cboBeforeCarrier.SelectedIndex = cboBeforeCarrier.Items.Count - 1;
            }
            else
            {
                carAfterCarrier.ShowCarriers(currentLot.CarrierList, null);
                carBeforeCarrier.ShowCarriers(currentLot.CarrierList, null);
            }
        }

        private void cboBeforeCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            compAfterComponent.Confirm();
            mesRelease.CAR.Carrier car = cboBeforeCarrier.SelectedItem as mesRelease.CAR.Carrier;
            compBeforeComponent.ShowComponents(currentLot.ComponentInfo, car);
        }
        private void cboAfterCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            compAfterComponent.Confirm();
            mesRelease.CAR.Carrier car = cboAfterCarrier.SelectedItem as mesRelease.CAR.Carrier;
            compAfterComponent.ShowComponents(currentLot.ComponentInfo, car);
        }
        private void cboAfterCarrier_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddCarrier.PerformClick();
        }

        private void btnAddCarrier_Click(object sender, EventArgs e)
        {
            standardStatusbar1.setInformation("");
            if (cboAfterCarrier.Text.Trim() == "") return;
            foreach (object obj in cboAfterCarrier.Items)
            {
                mesRelease.CAR.Carrier c = obj as mesRelease.CAR.Carrier;
                if (c != null && c.name == cboAfterCarrier.Text)
                    return;
            }
            mesRelease.CAR.Carrier carrier = new mesRelease.CAR.Carrier(cboAfterCarrier.Text);
            if (carrier.sysid == "")
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgCannotFindData"), idv.mesCore.Controls.informationType.warn);
            else if (carrier.status != idv.mesCore.CAR.CarrierStatus.IDLE.ToString())
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgStatusInvalid"), idv.mesCore.Controls.informationType.warn);
            else
            {
                currentLot.CarrierList.Add(carrier);
                cboAfterCarrier.Items.Add(carrier);
                cboAfterCarrier.SelectedItem = carrier;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

            if (!canMoveComponent()) return;

            compBeforeComponent.SelectAll();
            WipComponent[] comps = compBeforeComponent.GetSelectedComponent();
            foreach (WipComponent comp in comps)
            {
                compBeforeComponent.RemoveComponent(comp);
                compAfterComponent.AddComponent(comp);
            }

        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!canMoveComponent()) return;

            WipComponent[] comps = compBeforeComponent.GetSelectedComponent();
            foreach (WipComponent comp in comps)
            {
                compBeforeComponent.RemoveComponent(comp);
                compAfterComponent.AddComponent(comp);
            }
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (!canMoveComponent()) return;

            WipComponent[] comps = compAfterComponent.GetSelectedComponent();
            foreach (WipComponent comp in comps)
            {
                compAfterComponent.RemoveComponent(comp);
                compBeforeComponent.AddComponent(comp);
            }
        }

        bool canMoveComponent()
        {
            if (cboAfterCarrier.SelectedItem == cboBeforeCarrier.SelectedItem) return false;
            if (compAfterComponent.componentInfo == null) return false;
            if (compBeforeComponent.componentInfo == null) return false;
            return true;
        }

        private void carAfterCarrier_CarrierAdded(mesRelease.CAR.Carrier carrier, ref bool accept)
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

        private void carAfterCarrier_CarrierRemoved(mesRelease.CAR.Carrier carrier, ref bool accept)
        {
            accept = messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, "delete");
        }

        private void compBeforeComponent_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void compAfterComponent_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }
    }
}
