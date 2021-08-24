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

namespace ClientRule.LotRuleTemplate
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
            currentLot = WorkFlow.CurrentLot;

            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            lotInfomation1.Init(currentLot);
            t.Join();
            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                reasonCode1.Init("Hold", "ITX");
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
            mesRelease.WIP.Txn.LogLotHistory txn = new mesRelease.WIP.Txn.LogLotHistory();
            txn.txnUser = User.loginUser.name;
            txn.reasonCode = reasonCode1.reasonCode;
            txn.comments = reasonCode1.comments;

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
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            Cursor = Cursors.Default;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }

        bool checkBeforeTxn()
        {
            if (reasonCode1.reasonCode=="")
            {
                messageBox.showMessageById("requireField2", "ReasonCode");
                return false;
            }

            return true;
        }
    }
}
