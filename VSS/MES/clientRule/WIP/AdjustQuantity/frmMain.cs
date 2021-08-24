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

namespace ClientRule.AdjustQuantity
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

            lotInfomation1.Init(currentLot);

            lotInfomation1.LotChanged += new mesRelease.Controls.LotChangeEventHandler(lotInfomation1_LotChanged);

            if (idv.mesCore.systemConfig.carrierManagement)
                tabControl1.TabPages.RemoveByKey("tabMembers");
            else if (idv.mesCore.systemConfig.componentInfo)
                tabControl1.TabPages.RemoveByKey("tabCarrier");
            else
            {
                tabControl1.TabPages.RemoveByKey("tabCarrier");
                tabControl1.TabPages.RemoveByKey("tabMembers");
            }
            if (tabControl1.TabCount == 0)
            {
                tabControl1.Hide();
                scRight.SplitterDistance = 80;
                scRight.Panel1MinSize = 80;
                Height = lotInfomation1.preferedHeight + 80;
            }

            initLot();

            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        void lotInfomation1_LotChanged(Lot lot, ref bool accept)
        {
            if (lot == null)
            {
                lotInfomation1.Init(currentLot);
                accept = false;
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
            txtQuantity.Text = currentLot.quantity.ToString();
            reasonCode1.Init("AdjustQuantity", currentLot.stepId);

            if (idv.mesCore.systemConfig.carrierManagement)
            {
                carrierInformation1.lotId = currentLot.name;
                carrierInformation1.ShowCarriers(currentLot.CarrierList, currentLot.ComponentInfo);
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                wipComponentInformation1.lotId = currentLot.name;
                wipComponentInformation1.ShowComponents(currentLot.ComponentInfo);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            RuleInstance.logFunctionIn("btnOK_Click");
            Cursor = Cursors.WaitCursor;
            //generate txn object and assign correspond information
            mesRelease.WIP.Txn.AdjustQuantity txn = new mesRelease.WIP.Txn.AdjustQuantity();
            txn.txnUser = User.loginUser.name;
            txn.reasonCode = reasonCode1.reasonCode;
            txn.comments = reasonCode1.comments;

            if (idv.mesCore.systemConfig.carrierManagement)
                carrierInformation1.RemoveNoCarrierComponent(null);

            currentLot.quantity = Convert.ToDouble(txtQuantity.Text);
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
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            RuleInstance.RuleResult = "CANCEL";
            if (idv.mesCore.systemConfig.carrierManagement || idv.mesCore.systemConfig.componentInfo)
            {
                if (currentLot != null)
                    currentLot.Refresh();
            }
            Close();
        }

        bool checkBeforeTxn()
        {
            standardStatusbar1.setInformation("");

            if (reasonCode1.reasonCode == "")
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", cultureLanguage.getValue("ReasonCode")), 
                                                  idv.mesCore.Controls.informationType.warn);
                return false;
            }
            int qty = 0;
            int.TryParse(txtQuantity.Text, out qty);
            if (qty <= 0) txtQuantity.Text = "";
            bool checkResult = CheckInputData(txtQuantity, lblQuantity);
            if (!checkResult)
                return false;

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
            foreach (mesRelease.CAR.Carrier car in carrierInformation1.carrierList)
            {
                if (car.componentQty > car.capacity)//qty 不可大於 capacity
                {
                    returnValue = false;
                    break;
                }
                carTotalQty += car.componentQty;
                if (currentLot.ComponentInfo != null && currentLot.ComponentInfo.Count > 0)
                {   //check carrier component qty and components in carrier
                    if (currentLot.ComponentInfo.GetComponentQuantityByCarrier(car.name) != car.componentQty)
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
            if (currentLot.ComponentInfo != null && currentLot.ComponentInfo.Count > 0)
            {
                if (currentLot.ComponentInfo.Count != lotQty)
                {
                    string temp = idv.utilities.cultureLanguage.getValue("componentId");
                    standardStatusbar1.setInformation(idv.utilities.cultureLanguage.getValue("msgMakesureInformation").Replace("&", temp),
                                idv.mesCore.Controls.informationType.warn);
                    return false;
                }
            }
            return true;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void carrierInformation1_CarrierAdded(mesRelease.CAR.Carrier carrier, ref bool accept)
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

        private void carrierInformation1_CarrierChanged(mesRelease.CAR.Carrier oldCarrier, mesRelease.CAR.Carrier newCarrier, ref bool accept)
        {
            standardStatusbar1.setInformation("");
            if (newCarrier.sysid == "")
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgCannotFindData"), idv.mesCore.Controls.informationType.warn);
                accept = false;
            }
            else if (newCarrier.status != idv.mesCore.CAR.CarrierStatus.IDLE.ToString())
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgStatusInvalid"), idv.mesCore.Controls.informationType.warn);
                accept = false;
            }
        }
    }
}
