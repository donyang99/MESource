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

namespace ClientRule.OutStepCheck
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
            t.Join();
            nextStepInfo1.SelectPath(currentLot.ruleResult);
            if (!nextStepInfo1.selectedPath.Equals("PASS") && !nextStepInfo1.selectedPath.Equals(""))
                nextStepInfo1.Enabled = false;

            idv.utilities.cultureLanguage.switchLanguageSync(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                nextStepInfo1.Init(currentLot);
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.WIP.Txn.MoveOut txn = new mesRelease.WIP.Txn.MoveOut();
            txn.txnUser = User.loginUser.name;
            txn.comments = reasonCode1.comments;

            //add protagonist to txn item collcation by txn.add method
            for (int i = 0; i < RuleInstance.ItemCount; i++)
            {
                txn.Add(RuleInstance.GetItem(i));
            }
            txn.result = nextStepInfo1.selectedPath;
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
                if (nextStepInfo1.availablePaths.Length == 0)//最後一站
                    RuleInstance.RuleResult = "PASS";
                else
                    RuleInstance.RuleResult = nextStepInfo1.selectedPath;
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
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
            if (nextStepInfo1.availablePaths.Length > 0)
            {
                if (nextStepInfo1.selectedPath.Equals(""))
                {
                    messageBox.showMessageById("msgPathNotSelected");
                    return false;
                }
            }
            return true;
        }
    }
}
