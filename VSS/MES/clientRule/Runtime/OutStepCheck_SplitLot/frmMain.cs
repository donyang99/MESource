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
            idv.utilities.cultureLanguage.switchLanguage(this);
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
            mesRelease.WIP.Txn.MoveOut moveOutTxn = new mesRelease.WIP.Txn.MoveOut();
            moveOutTxn.txnUser = User.loginUser.name;
            moveOutTxn.comments = reasonCode1.comments;

            //add protagonist to txn item collcation by txn.add method
            for (int i = 0; i < RuleInstance.ItemCount; i++)
            {
                moveOutTxn.Add(RuleInstance.GetItem(i));
            }
            moveOutTxn.result = nextStepInfo1.selectedPath;
            //dotxn and get return value
            try
            {
                moveOutTxn.txnActor = idv.messageService.TransactionActor.First;//指定為非單一交易(此為起始交易)
                moveOutTxn = moveOutTxn.doTxn();
            }
            catch { }

            string result = "CANCEL";
            mesRelease.WIP.Txn.SplitLot splitTxn = new mesRelease.WIP.Txn.SplitLot();
            if (moveOutTxn.result == "PASS")
            {
                splitTxn.Add(moveOutTxn.Item(0));
                splitTxn.txnUser = User.loginUser.name;
                splitTxn.inheritLotTracking = false;

                mesRelease.WIP.Txn.SplitLotInfo splitInfo;

                for (int i = 1; i < 11; i++)
                {
                    splitInfo = new mesRelease.WIP.Txn.SplitLotInfo();
                    splitInfo.childLotId = moveOutTxn.Item(0).name + "." + i.ToString("00");
                    splitInfo.quantity = 1;
                    splitTxn.splitInfo.Add(splitInfo);
                }
                
                try
                {
                    splitTxn.txnActor = idv.messageService.TransactionActor.Last;//指定此為最後交易
                    splitTxn = splitTxn.doTxn();
                    result = splitTxn.result;
                }
                catch { }
            }

            //check txn result and do correspond action
            if (result == "PASS")
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
            }
            RuleInstance.logFunctionOut("btnOK_Click");
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
                if (nextStepInfo1.selectedPath == "")
                {
                    messageBox.showMessageById("msgPathNotSelected");
                    return false;
                }
            }
            return true;
        }
    }
}
