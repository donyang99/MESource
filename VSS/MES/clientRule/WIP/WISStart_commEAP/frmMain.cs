using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;
using mesRelease.EQP;
using mesRelease.USR;
using idv.utilities;
using idv.messageService;

namespace ClientRule.WISStart
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
            //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            //t.Start();

            lotInfomation1.Init(currentLot);
            //t.Join();
            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                reasonCode1.Init("WISStart", "");
            }
            catch { }
        }

        string TID = "";
        System.Threading.AutoResetEvent ar = new System.Threading.AutoResetEvent(false);
        volatile bool reply = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            ////check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.WIS.WISStart txn = new mesRelease.WIS.WISStart();
            txn.txnUser = User.loginUser.name;
            txn.reasonCode = reasonCode1.reasonCode;
            txn.comments = reasonCode1.comments;
            TID = DateTime.Now.ToBinary().ToString();
            //add protagonist to txn item collcation by txn.add method
            for (int i = 0; i < RuleInstance.ItemCount; i++)
            {
                mesRelease.WIS.WISStartInfo info = new mesRelease.WIS.WISStartInfo();
                info.Lot = RuleInstance.GetItem(i);
                info.EquipmentId = info.Lot.equipmentId;
                info.ClientId = mesRelease.WF.WorkFlow.ClientId;
                info.TID = TID;
                txn.Add(info);
            }

            //dotxn and get return value
            try
            {
                //註冊訊息通知
                serviceHost.MessageNotice += new MessageNoticeEventHandler(serviceHost_MessageNotice);
                reply = false;
                txn = txn.doTxn();
                lblInfo.ForeColor = Color.Blue;
                lblInfo.Text = cultureLanguage.getValue("waitingForEQReply");
                Refresh();
            }
            catch { }

            //check txn result and do correspond action
            if (txn.result == "PASS")
            {
                RuleInstance.RuleResult = "PASS";

                if (!reply)
                    ar.WaitOne(5000);                
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                reply = true;
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            serviceHost.MessageNotice -= new MessageNoticeEventHandler(serviceHost_MessageNotice);
            RuleInstance.logFunctionOut("btnOK_Click");
            if (reply)
                Close();
            else
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = cultureLanguage.getValue("waitingForEQReplyFail");
                for (int i = 0; i < RuleInstance.ItemCount; i++)
                    RuleInstance.GetItem(i).Refresh();
            }
        }

        void serviceHost_MessageNotice(messageBase item)
        {
            if (item is mesRelease.WIS.WISStartInfo)
            {
                if ((item as mesRelease.WIS.WISStartInfo).TID == TID)
                {
                    reply = true;
                    ar.Set();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }

        bool checkBeforeTxn()
        {
            //if (reasonCode1.reasonCode == "")
            //{
            //    standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", "&ReasonCode"), idv.mesCore.Controls.informationType.warn);
            //    return false;
            //}
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
            {
                return false;
            }

            return true;
        }
    }
}
