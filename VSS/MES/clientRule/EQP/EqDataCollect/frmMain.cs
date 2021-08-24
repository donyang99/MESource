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

namespace ClientRule.EqDataCollect
{
    public partial class frmMain : Form
    {
        Equipment curItem = null;
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
            reasonCode1.Init("EqDataCollect", "");

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
            List<EqTypeParameter> lstParms = new List<EqTypeParameter>();
            if (parmInputStatus(true, true, lstParms) == 0) return;
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.EQP.Txn.EqParmDataCollect txn = new mesRelease.EQP.Txn.EqParmDataCollect();
            txn.AddEqParameter(lstParms.ToArray());
            txn.txnUser = User.loginUser.name;
            txn.comments = reasonCode1.comments;
            //add protagonist to txn item collcation by txn.add method            
            txn.Add(lvwEquipment.selectedMESItem);

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

                if(txn.localMode && txn.publish)
                    SendBroadcast(txn);
                reasonCode1.comments = "";

                if (!txn.parmCheckResult)//檢查生產規範的結果不通過時，顯示不符合規格的機台參數
                    messageBox.showMessageById("msgEqParmCheckFail", txn.parmFailInfo);
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
            if (parmInputStatus() > 0 && tblParmList.Controls.Count > 0)
            {
                if (messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo) == false)
                    return;
            }
            Close();
        }

        bool checkBeforeTxn()
        {
            standardStatusbar1.setInformation("");
            Equipment eq = lvwEquipment.selectedMESItem as Equipment;
            if (eq == null)
            {
                messageBox.showMessageById("noItemSelected");
                return false;
            }

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
            {
                return false;
            }
            return true;
        }

        int parmInputStatus(bool assignValue = false, bool showInputRequried = false, List<EqTypeParameter> lstEqTypeParm = null)//0:沒輸入，1:輸入一半，2輸入完成(都有輸入)
        {
            int returnValue = 0;
            bool allInput = true;
            foreach (Control ctl in tblParmList.Controls)
            {
                EqTypeParameter parm = ctl.Tag as EqTypeParameter;
                if (parm == null) continue;
                if (!ctl.Text.Trim().Equals(""))
                {
                    returnValue = 1;
                    if (assignValue)
                        parm.value = ctl.Text;
                    if (lstEqTypeParm != null)
                        lstEqTypeParm.Add(parm);
                }
                else
                {
                    allInput = false;
                    if (parm.required && showInputRequried)
                    {
                        returnValue = 0;
                        messageBox.showMessageById("requireField2", tblParmList.Controls["lbl" + parseName(parm.name)].Text);
                        ctl.Focus();
                        break;
                    }
                }
            }
            if (allInput)
                returnValue = 2;
            return returnValue;
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

        private void lvwEquipment_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (selected)
            {
                reasonCode1.comments = "";
                curItem = item as Equipment;
                txtEquipmentId.Text = curItem.name;
                EqType type = EqType.GetEqType(curItem.type);
                tblParmList.Controls.Clear();
                tblParmList.RowStyles.Clear();
                tblParmList.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tblParmList.RowCount = 1;
                EqTypeParameter[] parms = type.GetEqParameters();
                for (int i = 0; i < parms.Length; i++)
                {
                    EqTypeParameter parm = parms[i];
                    tblParmList.RowCount++;
                    tblParmList.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    Label lbl = new Label();
                    lbl.Name = "lbl" + parseName(parm.name);
                    string caption = cultureLanguage.getValue(parm.name);
                    if (caption.Equals(""))
                        lbl.Text = parm.name;
                    else
                        lbl.Text = caption;
                    lbl.AutoSize = true;
                    tblParmList.Controls.Add(lbl, 0, tblParmList.RowCount - 2);
                    lbl.Anchor = AnchorStyles.Right;
                    if (parm.dataType == idv.mesCore.DataType.Numeric || parm.dataType == idv.mesCore.DataType.String)
                    {
                        TextBox txt = new TextBox();
                        txt.TabIndex = 1;
                        txt.Name = "txt" + parseName(parm.name);
                        txt.MaxLength = parm.length;
                        txt.ImeMode = System.Windows.Forms.ImeMode.Off;
                        txt.Tag = parm;
                        if (parm.dataType == idv.mesCore.DataType.Numeric)
                            txt.KeyPress += HandleKeyPressNumericOnly;
                        if (i < parms.Length - 1)
                            txt.KeyUp += new KeyEventHandler(txt_KeyUp);
                        tblParmList.Controls.Add(txt, 1, tblParmList.RowCount - 2);
                        txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    }
                    else
                    {
                        ComboBox cbo = new ComboBox();
                        cbo.TabIndex = 1;
                        cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                        cbo.Items.AddRange(parm.GetOptionList());
                        cbo.Name = "txt" + parseName(parm.name);
                        cbo.Tag = parm;
                        if (i < parms.Length - 1)
                            cbo.KeyUp += new KeyEventHandler(txt_KeyUp);
                        tblParmList.Controls.Add(cbo, 1, tblParmList.RowCount - 2);
                        cbo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    }
                }
                FocusParmInputCtl();
            }
            else
            {
                curItem = null;
                txtEquipmentId.Text = "";
                tblParmList.Controls.Clear();
                tblParmList.RowStyles.Clear();
                tblParmList.RowCount = 1;
            }

        }
        private void lvwEquipment_MouseUp(object sender, MouseEventArgs e)
        {
            FocusParmInputCtl();
        }

        private void lvwEquipment_MESItemSelectionChanging(idv.messageService.itemBase item, ListViewItem listItem, bool selected, ref bool Cancel)
        {
            if (!selected && lvwEquipment.Focused && parmInputStatus() > 0 && tblParmList.Controls.Count > 0)
            {
                if (messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo) == false)
                    Cancel = true;
            }
        }

        void FocusParmInputCtl()
        {
            foreach (Control ctl in tblParmList.Controls)
            {
                EqTypeParameter parm = ctl.Tag as EqTypeParameter;
                if (parm == null) continue;
                if (ctl.Text.Trim().Equals(""))
                {
                    ActiveControl = ctl;
                    break;
                }
            }
        }

        void txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.SendWait("{TAB}");
        }
        string parseName(string name)
        {
            return name.Replace(' ', '_');
        }
        void HandleKeyPressNumericOnly(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            byte ascii = (byte)e.KeyChar;
            if (ascii == 8)
                return;
            else if (ascii > 47 && ascii < 58)
            {

            }
            else if (ascii == 46)
            {
                if (txt.Text.IndexOf('.') >= 0 || txt.Text.Length == 0)
                    e.Handled = true;
            }
            else
                e.Handled = true;
        }
    }
}
