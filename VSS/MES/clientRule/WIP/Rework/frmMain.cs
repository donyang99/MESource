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

namespace ClientRule.Rework
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

            if(currentLot != null && !currentLot.status.Equals(idv.mesCore.WIP.LotStatus.WAIT.ToString()))
                currentLot = null;

            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            lotInfomation1.Init(currentLot);

            lotInfomation1.LotChanged += new mesRelease.Controls.LotChangeEventHandler(lotInfomation1_LotChanged);

            t.Join();
            idv.utilities.cultureLanguage.switchLanguageSync(this);
            CancelButton = btnCancel;
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
                idv.utilities.messageBox.showMessageById("msgStatusInvalid");
                accept = false;
            }
            else
            {
                currentLot = lot;
                initAsynchronize();
                accept = true;
            }
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                nextStepInfo1.Init(currentLot);
                reasonCode1.Init("Rework", currentLot.GetCurrentStep().name);
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.WIP.Txn.Rework txn = new mesRelease.WIP.Txn.Rework();
            txn.txnUser = User.loginUser.name;
            txn.reasonCode = reasonCode1.reasonCode;
            txn.comments = reasonCode1.comments;
            txn.stepHandle = nextStepInfo1.selectedStep.stepHandle;

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
            if(txn.result.Equals("PASS"))
            {
                //*IMPORTANT*
                //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                //if there are non PASS path in Route, you can also assign other path name in RuleResult
                RuleInstance.RuleResult = "PASS";

                Lot lot = txn.Item(0);

                if(lot != null && lot.GetCurrentRule().dispatchFlag)
                    mesRelease.WF.WorkFlow.DispatchLot(lot);

            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            Cursor = Cursors.Default;

            lotInfomation1.ShowLot(null);
            currentLot = null;
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
            if(currentLot == null)
            {
                idv.utilities.messageBox.showMessageById("noItemSelected");
                return false;
            }
            else if(nextStepInfo1.selectedStep == null)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", "&step"), idv.mesCore.Controls.informationType.warn);
                return false;
            }
            else if (nextStepInfo1.selectedStep.componentType != currentLot.componentType && nextStepInfo1.selectedStep.componentType != "")
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgMultiSelectButDiffCondition", "&componentType"), idv.mesCore.Controls.informationType.warn);
                return false;
            }
            else if(reasonCode1.reasonCode.Equals(""))
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", "&ReasonCode"), idv.mesCore.Controls.informationType.warn);
                return false;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
                return false;
            
            return true;
        }
    }
}
