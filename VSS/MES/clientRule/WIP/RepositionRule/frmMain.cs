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

namespace ClientRule.RepositionRule
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
                messageBox.showMessageById("msgStatusInvalid");
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
                cboRule.Items.Clear();
                foreach (mesRelease.PRP.Rule r in currentLot.GetCurrentStep().Items)
                {
                    if(r.name.Equals(currentLot.ruleId) || 
                      (!idv.mesCore.systemConfig.assemblyMode && r.name.EndsWith("TrackOut"))) continue;
                    cboRule.Items.Add(r);
                }
                reasonCode1.Init("RepositionRule", currentLot.GetCurrentStep().name);
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
            mesRelease.WIP.Txn.RepositionRule txn = new mesRelease.WIP.Txn.RepositionRule();
            txn.txnUser = User.loginUser.name;
            txn.reasonCode = reasonCode1.reasonCode;
            txn.comments = reasonCode1.comments;

            txn.ruleId = (cboRule.SelectedItem as mesRelease.PRP.Rule).name;

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

                currentLot = txn.Item(currentLot.name);
                if (currentLot != null && currentLot.GetCurrentRule().dispatchFlag)
                    mesRelease.WF.WorkFlow.Dispatch(currentLot, "", false, true, true, "", new idv.mesCore.WF.parameter("TriggerRule", "RepositionRule"));

                messageBox.showMessageById("msgExecuteSucceed");
                cboRule.SelectedIndex = -1;
                reasonCode1.Clear();
                lotInfomation1.ShowLot(null);
                currentLot = null;
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
            if(currentLot == null)
            {
                idv.utilities.messageBox.showMessageById("noItemSelected");
                return false;
            }
            else if(cboRule.Text.Equals(""))
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", "&rule"), idv.mesCore.Controls.informationType.warn);
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
