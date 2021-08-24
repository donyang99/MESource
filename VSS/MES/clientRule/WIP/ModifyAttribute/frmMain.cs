﻿using System;
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

namespace ClientRule.ModifyAttribute
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
            else if (!lot.IsWIPStatus())
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
                if(cboCustomerId.Items.Count == 0)
                {
                    cboCustomerId.Items.Add(new mesRelease.IdName());
                    cboCustomerId.Items.AddRange(mesRelease.Misc.GetCustomer());
                }
                if (currentLot.dueDate != DateTime.MinValue)
                    dtpDueDate.Value = currentLot.dueDate;
                else
                    dtpDueDate.Value = DateTime.Now;

                if (currentLot.customerDueDate != DateTime.MinValue)
                    dtpCustomerDueDate.Value = currentLot.customerDueDate;
                else
                    dtpCustomerDueDate.Value = DateTime.Now;
                dtpDueDate.Checked = false;
                dtpCustomerDueDate.Checked = false;   
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
            mesRelease.WIP.Txn.ModifyAttribute txn = new mesRelease.WIP.Txn.ModifyAttribute();
            txn.txnUser = User.loginUser.name;
            txn.comments = reasonCode1.comments;

            if(!cboPriority.Text.Equals(""))
                txn.priority = Convert.ToByte(cboPriority.Text);
            if(!cboCustomerId.Text.Equals(""))
                txn.customerId = cboCustomerId.Text;
            if(!txtCustomerLotId.Text.Equals(""))
                txn.customerLotId = txtCustomerLotId.Text;
            if (dtpDueDate.Checked)
                txn.dueDate = dtpDueDate.Value.Date;
            if (dtpCustomerDueDate.Checked)
                txn.customerDueDate = dtpCustomerDueDate.Value.Date;
            if(!cboOwner.Text.Equals(""))
                txn.owner = cboOwner.Text;
            if(!txtRemark.Text.Equals(""))
                txn.remark = txtRemark.Text;

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
            else if(cboPriority.Text.Equals("") && cboCustomerId.Text.Equals("") && txtCustomerLotId.Text.Equals("") && !dtpDueDate.Checked &&
               !dtpCustomerDueDate.Checked && cboOwner.Text.Equals("") && txtRemark.Text.Equals(""))
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("noDataChanged"), idv.mesCore.Controls.informationType.warn);
                return false;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))            
                return false;
            
            return true;
        }
    }
}
