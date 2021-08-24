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

namespace ClientRule.RecordDefect
{
    public partial class frmMain : Form
    {
        Lot currentLot = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RuleInstance.RuleResult = "CANCEL";
            currentLot = RuleInstance.GetItem(0);

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            lotInfomation1.Init(currentLot);
            lotInfomation1.LotChanged += new mesRelease.Controls.LotChangeEventHandler(lotInfomation1_LotChanged);
            t.Join();
            cultureLanguage.switchLanguage(this);
            CancelButton = btnCancel;
        }

        void lotInfomation1_LotChanged(Lot lot, ref bool accept)
        {
            if (!lot.IsWIPStatus())
            {
                idv.utilities.messageBox.showMessageById("msgStatusInvalid");
                accept = false;
            }
            else
            {
                currentLot = lot;
                initAsynchronize();
                InitReason();
                accept = true;
            }
        }

        void initAsynchronize()
        {
            try
            {
                mesRelease.BAS.ReasonCategory reaCate = new mesRelease.BAS.ReasonCategory("RecordDefect", mesRelease.WF.WorkFlow.CurrentStep);
                lvwReasonCode.ShowMESItems(reaCate.Items.ToArray());
            }
            catch { }
        }

        void InitReason()
        {
            foreach (ListViewItem item in lvwReasonCode.Items)
            {
                if (item.Checked) item.Checked = false;
                item.SubItems[1].Text = "";
            }
            txtQuantity.Text = "";
            reasonCode1.comments = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");
            mesRelease.WIP.Txn.RecordDefect txn = new mesRelease.WIP.Txn.RecordDefect();
            txn.txnUser = User.loginUser.name;
            foreach (ListViewItem item in lvwReasonCode.CheckedItems)
            {
                double d = 0;
                double.TryParse(item.SubItems[1].Text, out d);
                txn.addDefectCode(item.SubItems[0].Text, d);
            }
            txn.comments = reasonCode1.comments;

            txn.Add(currentLot);

            try
            {
                txn = txn.doTxn();
            }
            catch { }

            RuleInstance.logFunctionOut("btnOK_Click");
            if (txn.result == "PASS")
            {
                RuleInstance.RuleResult = "PASS";
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
            }
            else
            {
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            Cursor = Cursors.Default;
            lotInfomation1.ShowLot(null);
            currentLot = null;
            InitReason();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }

        bool checkBeforeTxn()
        {
            standardStatusbar1.setInformation("");
            if (currentLot == null)
            {
                messageBox.showMessageById("noItemSelected");
                return false;
            }
            if (lvwReasonCode.selectedMESItems.Length == 0)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", "&ReasonCode"), idv.mesCore.Controls.informationType.warn);
                return false;
            }

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
            {
                return false;
            }

            return true;
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lvwReasonCode.SelectedItems.Count == 0)
                {
                    messageBox.showMessageById("noItemSelected");
                    return;
                }
                lvwReasonCode.SelectedItems[0].SubItems[1].Text = txtQuantity.Text;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            else if (e.KeyChar == '.' && (txtQuantity.Text.IndexOf('.') >= 0 || txtQuantity.Text == ""))
                e.Handled = true;
        }

        private void lvwReasonCode_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                e.Item.Selected = true;
        }

        private void lvwReasonCode_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
                txtQuantity.Text = "";
            else
                txtQuantity.Text = e.Item.SubItems[1].Text;
        }
    }
}
