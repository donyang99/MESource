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

namespace ClientRule.RecordFinishQuantity
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
            else
            {
                currentLot = lot;
                initLot();
                accept = true;
            }
        }

        void initLot()
        {
            taWorkInformation1.Clear();
            taWorkInformation1.TestPrivilege();
            btnOK.Enabled = false;
            if (currentLot == null) return;
            if (idv.mesCore.systemConfig.assemblyMode)
                btnOK.Enabled = true;
            else if(currentLot.status.Equals(idv.mesCore.WIP.LotStatus.RUN.ToString()))
                btnOK.Enabled=true;
            if (btnOK.Enabled)
            {
                if (idv.mesCore.systemConfig.assemblyMode)
                    taWorkInformation1.Init(currentLot.stepId, mesRelease.WF.WorkFlow.CurrentEquipment.name);
                else
                    taWorkInformation1.Init(currentLot.stepId, currentLot.equipmentId);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            RuleInstance.logFunctionIn("btnOK_Click");
            Cursor = Cursors.WaitCursor;
            //generate txn object and assign correspond information
            mesRelease.WIP.Txn.RecordFinishQuantity txn = new mesRelease.WIP.Txn.RecordFinishQuantity();
            txn.quantity = Convert.ToDouble(txtQuantity.Text);
            txn.taWorkInfo = taWorkInformation1.taWorkInfo;
            txn.txnUser = User.loginUser.name;
            txn.comments = reasonCode1.comments;

            if (idv.mesCore.systemConfig.assemblyMode)
                txn.equipmentId = mesRelease.WF.WorkFlow.CurrentEquipment.name;
            else
                txn.equipmentId = currentLot.equipmentId;

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
            Close();
        }

        bool checkBeforeTxn()
        {
            standardStatusbar1.setInformation("");
            if (currentLot == null) return false;
            if (taWorkInformation1.taWorkInfo.Equals("")) return false;
            double qty = 0;
            double.TryParse(txtQuantity.Text, out qty);
            if (qty <= 0 || qty >= currentLot.quantity - currentLot.finishedQuantity)
                return false;

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
            {
                return false;
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
    }
}
