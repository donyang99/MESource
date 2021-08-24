using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;
using mesRelease.PARM;
using mesRelease.EQP;
using mesRelease.USR;
using idv.utilities;

namespace ClientRule.EqSetupClear
{
    public partial class frmMain : Form
    {
        Equipment currentEqp = null;
      
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!idv.mesCore.systemConfig.materialTracking)
            {
                btnOK.Enabled = false;
                return;
            }
            RuleInstance.RuleResult = "CANCEL";
            currentEqp = RuleInstance.GetItem(0);

            lvwCurSetupMaterial.columnNames = "position,name,partNo,materialLotId,quantity".Split(',');
            lvwCurSetupMaterial.columnTags = "position,materialType,materialPartNo,materialLotId,quantity".Split(',');

            //if (!idv.mesCore.systemConfig.materialConsuming)
            //    lvwCurSetupMaterial.columnHide = "quantity".Split(',');

            lvwCurSetupMaterial.prepareColumns();
            lvwCurSetupMaterial.Columns[0].Width = 0;
            lvwCurSetupMaterial.Columns[1].Width = 130;
            lvwCurSetupMaterial.Columns[2].Width = 130;
            lvwCurSetupMaterial.Columns[3].Width = 130;
            lvwCurSetupMaterial.Columns[4].Width = 60;

            equipmentInformation1.Init(currentEqp);
            if (currentEqp != null)
            {
                currentEqp.Refresh(true);
                showCurrentEqpInfo();
            }

            idv.utilities.cultureLanguage.switchLanguageSync(this);
            CancelButton = btnCancel;
        }

        private void equipmentInformation1_EquipmentChanged(Equipment equipment, ref bool accept)
        {
            if (equipment == null)
            {
                equipmentInformation1.Init(currentEqp);
                accept = false;
                return; 
            }

            currentEqp = equipment;
            showCurrentEqpInfo();
        }

        void showCurrentEqpInfo()
        {
            btnOK.Enabled = false;
            if (idv.mesCore.systemConfig.materialTracking)
            {
                lvwCurSetupMaterial.RemoveAllMESItems();
                if (currentEqp.SetupInfo != null)
                {
                    lvwCurSetupMaterial.ShowMESItems(currentEqp.SetupInfo.ToSortedList());
                    if (currentEqp.trackCount == 0)
                        lvwCurSetupMaterial.Columns[0].Width = 0;
                    else
                        lvwCurSetupMaterial.Columns[0].Width = 70;
                    btnOK.Enabled = true;
                }
            }
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void HandlerSendKeyTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }

        void SendBroadcast(Equipment eq)
        {
            try
            {
                eq.send();
            }
            catch { }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
                return;

            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.EQP.Txn.SetupClear txn = new mesRelease.EQP.Txn.SetupClear();
            txn.txnUser = User.loginUser.name;
            txn.saveMaterialInfo = true;
            
            Cursor = Cursors.WaitCursor;

            //add protagonist to txn item collcation by txn.add method
            txn.Add(currentEqp);

            //dotxn and get return value
            try
            {
                txn = txn.doTxn();
            }
            catch { }

            RuleInstance.logFunctionOut("btnOK_Click");
            currentEqp = txn.Item(0);
            equipmentInformation1.Init(currentEqp);
            //check txn result and do correspond action
            if (txn.result.Equals("PASS"))
            {
                //*IMPORTANT*
                //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                //if there are non PASS path in Route, you can also assign other path name in RuleResult
                RuleInstance.RuleResult = "PASS";
                showCurrentEqpInfo();
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
                if (txn.localMode)
                    SendBroadcast(currentEqp);
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                standardStatusbar1.setInformation(txn.errMessage, idv.mesCore.Controls.informationType.error);
            }
            Cursor = Cursors.Default;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            Close();
        }
        


    }
}
