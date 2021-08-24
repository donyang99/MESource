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

namespace ClientRule.EqChangeState
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
            RuleInstance.RuleResult = "CANCEL";
            lvwEquipment.columnNames =
                "name,state,type,capacityUsed,capacity,owner,description,counter,lotId,recipe".Split(',');
            lvwEquipment.columnTags =
                "Equipment,state,EquipmentType,capacityUsed,capacity,owner,description,counter,lotId,recipe".Split(',');
            lvwEquipment.prepareColumns();

            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            showEquipmentType();
            showFAB();
            showState();

            t.Join();
            cboStepId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboStepId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (RuleInstance.GetItem(0) != null)
            {
                cboEquipmentId.Text = RuleInstance.GetItem(0).name;
                btnQuery.PerformClick();
                lvwEquipment.SelectMESItem(RuleInstance.GetItem(0));
            }
            if(!mesRelease.WF.WorkFlow.CurrentStep.Equals(""))
                cboStepId.Text = mesRelease.WF.WorkFlow.CurrentStep;

            idv.utilities.cultureLanguage.switchLanguageSync(this);
            CancelButton = btnCancel;
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                idv.messageService.IMessageGuard client = idv.messageService.serviceHost.IsolationClient;

                cboStepId.Items.Add("");
                string sql = "select stage,step_id from mes_prp_step where issue_state='Active'";
                DataSet ds = client.getDataSet(sql);
                List<string> stage = new List<string>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string description = "";

                    description = idv.utilities.cultureLanguage.getValue(row["step_id"].ToString());
                    if(description.Equals(""))
                        cboStepId.Items.Add(row["step_id"].ToString());
                    else
                        cboStepId.Items.Add(row["step_id"].ToString() + " - " + description);
                }

            }
            catch { }
        }

        void showEquipmentType()
        {
            cboEquipmentType.Items.Add("");
            foreach (mesRelease.EQP.EqType type in mesRelease.EQP.EqType.GetEqTypes(""))
                cboEquipmentType.Items.Add(type.name);
            cboEquipmentType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEquipmentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        void showFAB()
        {
            cboFAB.Items.AddRange(mesRelease.BAS.Fab.GetFabNames());
            if (cboFAB.Items.Count == 1)
            {
                cboFAB.SelectedIndex = 0;
                cboFAB.Enabled = false;
            }
            else
            {
                cboFAB.Items.Add("");
                if(!mesRelease.WF.WorkFlow.CurrentFAB.Equals(""))
                {
                    cboFAB.Text = mesRelease.WF.WorkFlow.CurrentFAB;
                    cboFAB.Enabled = false;
                }
            }
        }
        void showState()
        {
            cboState.Items.Add("");
            cboState.Items.AddRange(mesRelease.EQP.State.GetStates());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.EQP.Txn.ChangeState txn = new mesRelease.EQP.Txn.ChangeState();
            txn.txnUser = User.loginUser.name;

            txn.state = cboToState.Text;
            txn.reasonCode = reasonCode1.reasonCode;
            txn.comments = reasonCode1.comments;
            //add protagonist to txn item collcation by txn.add method
            foreach (Equipment eq in lvwEquipment.selectedMESItems)
                txn.Add(eq);
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
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
                lvwEquipment.UnCheckAllItems();
                foreach(Equipment eq in txn.Items)
                    lvwEquipment.UpdateMESItem(eq);

                if(txn.localMode)
                    SendBroadcast(txn);
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                standardStatusbar1.setInformation(txn.errMessage, idv.mesCore.Controls.informationType.error);
            }
            Cursor = Cursors.Default;
        }

        void SendBroadcast(idv.messageService.txnBase txn)
        {
            foreach(Equipment eq in txn.Items)
            {
                try
                {
                    eq.send();
                }
                catch { }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            Close();
        }

        bool checkBeforeTxn()
        {
            standardStatusbar1.setInformation("");
            if(currentEqp == null)
            {
                messageBox.showMessageById("noItemSelected");
                return false;
            }
            else if(cboToState.Text.Equals(""))
            {
                messageBox.showMessageById("requireField2", "to_state");
                return false;
            }
            else if(reasonCode1.reasonCode.Equals(""))
            {
                messageBox.showMessageById("requireField2", "ReasonCode");
                return false;
            }
            if(!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
                return false;

            return true;
        }

        private void cboEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            cboEquipmentId.SelectedIndex = -1;
            cboEquipmentId.Items.Clear();
            cboEquipmentId.Items.Add("");
            cboEquipmentId.AutoCompleteMode = AutoCompleteMode.None;
            foreach (mesRelease.EQP.Equipment eq in mesRelease.EQP.Equipment.GetEquipments("", cbo.Text, "", 0, "", "",
                             mesRelease.WF.WorkFlow.CurrentFAB, 0, true))
            {
                cboEquipmentId.Items.Add(eq.name);
            }
            cboEquipmentId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEquipmentId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Equipment[] eq = Equipment.GetEquipments(cboEquipmentId.Text, cboEquipmentType.Text, cboState.Text, 0, "", "", cboFAB.Text, 0, true, cboStepId.Text);
            lvwEquipment.ShowMESItems(eq);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (cboFAB.Enabled)
                cboFAB.Text = "";
            cboStepId.Text = "";
            cboEquipmentType.Text = "";
            cboEquipmentId.Text = "";
            cboState.SelectedItem = null;
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void lvwEquipment_MESItemCheckChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected, ref bool Cancel)
        {
            standardStatusbar1.setInformation("");
            if (!selected && lvwEquipment.selectedMESItems.Length <= 1)
            {
                currentEqp = null;
                cboToState.Items.Clear();
                reasonCode1.Clear();
            }
            else
            {
                if (currentEqp == null)
                {
                    currentEqp = item as Equipment;
                    cboToState.Items.Clear();
                    foreach (idv.mesCore.EQP.stateTransferRule state in State.GetAvailableRule(currentEqp.state, mesRelease.USR.User.loginUser.division))
                    {
                        if (!cboToState.Items.Contains(state.stateTo))
                            cboToState.Items.Add(state.stateTo);
                    }
                }
                else
                {
                    Equipment eq = item as Equipment;
                    if (eq.state != currentEqp.state)
                    {
                        standardStatusbar1.setInformation(cultureLanguage.getValue("msgMultiSelectButDiffCondition", lblState.Text)
                            , idv.mesCore.Controls.informationType.warn);
                        Cancel = true;
                    }
                }
            }
        }

        private void cboToState_SelectedIndexChanged(object sender, EventArgs e)
        {
            reasonCode1.Init("EqChangeState", cboToState.Text);
        }
    }
}
