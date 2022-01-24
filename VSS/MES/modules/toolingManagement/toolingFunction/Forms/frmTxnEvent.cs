using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.TOL;
using mesRelease.TOL.Txn;
using idv.messageService;

namespace toolingFunction
{
    public partial class frmTxnEvent : Form
    {
        ToolingEvent tolEvt = null;
        TxnEvent txnEvent = null;
        internal List<ToolingId> ToolingList = new List<ToolingId>();

        bool _Result = false;
        public bool Result
        {
            get { return _Result; }
            set { _Result = value; }
        }

        public frmTxnEvent()
        {
            InitializeComponent();
        }
        public frmTxnEvent(ToolingEvent toolingEvent, TxnEvent txn)
            : this()
        {
            tolEvt = toolingEvent;
            txnEvent = txn;
            txn.txnFormControl[lblTarLocation] = cboTarLocation;
            txn.txnFormControl[lblReasonCode] = cboReasonCode;
        }

        bool firstActive = true;
        private void frmTxnEvent_Activated(object sender, EventArgs e)
        {
            if (!firstActive) return;
            firstActive = false;
            if (cboTarLocation.Enabled)
                cboTarLocation.Focus();
            else if (firCtrl != null)
                firCtrl.Focus();
        }

        public void ShowForm()
        {
            new System.Threading.Thread(showLastEventInfo).Start();
            Tag = "toolingEvent" + tolEvt.name;            
            ToolingId tol = ToolingList[0];
            txtToolingType.Text = tol.toolingType;
            txtToolingPart.Text = tol.partNo;
            txtPartDesc.Text = tol.partDescription;
            txtToolingId.Text = tol.name;
            txtStatus.Text = tol.status;
            txtLocation.Text = tol.location;

            txtEvent.Text = tolEvt.name;
            txtUserId.Text = idv.mesCore.USR.userBase.loginUserId;
            if (tolEvt.locationList.Count == 0)
            {
                lblTarLocation.Enabled = false;
                cboTarLocation.Enabled = false;
            }
            else
                cboTarLocation.Items.AddRange(tolEvt.locationList.ToArray());

            if (tolEvt.reasonGroup.Equals(""))
            {
                lblReasonCode.Visible = false;
                cboReasonCode.Visible = false;
            }
            else
            {
                Type tt = Type.GetType("mesRelease.BAS.ReasonGroup, mesRelease");
                idv.mesCore.BAS.reasonGroupBase reasonGroup = Activator.CreateInstance(tt, tolEvt.reasonGroup) as idv.mesCore.BAS.reasonGroupBase;
                if (!reasonGroup.sysid.Equals(""))
                {
                    tt.InvokeMember("retrieveReasonCodes", System.Reflection.BindingFlags.InvokeMethod, null, reasonGroup, null);
                    foreach (idv.mesCore.BAS.reasonCodeBase code in reasonGroup.Items)
                        cboReasonCode.Items.Add(code);
                }
            }
            foreach (ToolingId id in ToolingList)
                txnEvent.Add(id);
            executeExtraControls();
            idv.utilities.cultureLanguage.switchLanguageSync(this);
            ShowDialog();
        }
        Control firCtrl = null;
        void executeExtraControls()
        {
            Dictionary<Label, Control> dic = new Dictionary<Label, Control>();
            txnEvent.GetExtraControls(tolEvt, dic);
            if(dic.Count == 0) return;

            int addRowCount = 0;
            if (dic.Count > 1)
            {
                addRowCount = dic.Count / 2;
                tblEventInfo.RowCount += addRowCount;
                for (int i = 0; i < addRowCount; i++)
                    tblEventInfo.RowStyles.Insert(2, new RowStyle());

                //還要自己把插入的row下面的控件自己調整row，shit
                tblEventInfo.SetRow(lblComments, addRowCount + 3);
                tblEventInfo.SetRow(txtComments, addRowCount + 3);
                tblEventInfo.SetRow(lblReasonCode, addRowCount + 2);
                tblEventInfo.SetRow(cboReasonCode, addRowCount + 2);
            }

            tblEventInfo.SuspendLayout();
            int count = 0;
            int row = 1;
            int tabIndex = 5;
            foreach (KeyValuePair<Label, Control> kv in dic)
            {
                Label lbl = kv.Key;
                Control ctl = kv.Value;
                lbl.AutoSize = true;
                lbl.Anchor = AnchorStyles.Left;
                if (ctl != null)
                {
                    ctl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    ctl.TabIndex = tabIndex++;
                    if (firCtrl == null && ctl.Enabled)
                        firCtrl = ctl;
                }

                if (count == 0)
                {
                    if (ctl != null)//允許右邊不放任何控件(用戶指定為null即可)
                    {
                        tblEventInfo.Controls.Add(lbl, 2, row);
                        tblEventInfo.Controls.Add(ctl, 3, row);
                    }
                }
                else
                {
                    int remainder = count % 2;
                    if (remainder == 1)
                    {
                        row++;
                        tblEventInfo.Controls.Add(lbl, 0, row);
                        tblEventInfo.Controls.Add(ctl, 1, row);
                    }
                    else
                    {
                        if (ctl != null)
                        {
                            tblEventInfo.Controls.Add(lbl, 2, row);
                            tblEventInfo.Controls.Add(ctl, 3, row);
                        }
                    }
                }
                if (lbl.Font.Equals(grpEventInfo.Font) && lbl.ForeColor == grpEventInfo.ForeColor)
                {
                    lbl.ForeColor = SystemColors.ControlText;
                    lbl.Font = new Font(grpEventInfo.Font, FontStyle.Regular);
                }
                if (ctl != null && ctl.Font.Equals(grpEventInfo.Font))
                    ctl.Font = new Font(grpEventInfo.Font, FontStyle.Regular);
                count++;
            }
            tblEventInfo.ResumeLayout();
        }

        void showLastEventInfo()
        {
            string sql = "select * from mes_tol_tooling_history where txn_sysid=?";
            DataSet ds = serviceHost.Client.getDataSetWithParameter(sql, ToolingList[0].lastTxnSysId);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                txtLastEventName.Text = row["event_name"].ToString();
                //string eventDesc = idv.utilities.cultureLanguage.getValue("toolingEvent" + txtLastEventName.Text);
                //if (!eventDesc.Equals(""))
                //    txtLastEventName.Text += "( " + eventDesc + " )";
                txtLastEventDate.Text = row["modify_date"].ToString();
                txtLastEventUser.Text = row["modify_user"].ToString();
                txtLastEventReason.Text = row["reason_code"].ToString();
                txtLastEventComments.Text = row["comments"].ToString();
                break;
            }
        }

        bool checkBeforeTxn()
        {
            if (cboTarLocation.Enabled && cboTarLocation.Text.Equals(""))
            {
                idv.utilities.messageBox.showMessageById("requireField2", lblTarLocation.Text);
                return false;
            }
            if (cboReasonCode.Visible && cboReasonCode.Text.Equals(""))
            {
                idv.utilities.messageBox.showMessageById("requireField2", lblReasonCode.Text);
                return false;
            }
            return true;           
        }
        bool doTxn()
        {
            if (cboTarLocation.Enabled)
            {
                txnEvent.location = cboTarLocation.Text;
                txnEvent.locationType = idv.mesCore.TOL.LocationType.Storage;
            }
            if (cboReasonCode.Visible)
                txnEvent.reasonCode = cboReasonCode.Text;

            txnEvent.comments = txtComments.Text.Trim();
            txnEvent.txnUser = txtUserId.Text;            
            try
            {
                if (!txnEvent.CheckBeforeTxn()) return false;
                txnEvent = txnEvent.doTxn();

                if (txnEvent.result.Equals("PASS"))
                {
                    ToolingList.Clear();
                    foreach (ToolingId id in txnEvent.Items)
                        ToolingList.Add(id);
                    return true;
                }
                else
                {
                    idv.utilities.messageBox.showMessage(txnEvent.errMessage, idv.utilities.messageStyle.error);
                    return false;
                }
            }
            catch(Exception ex)
            {
                idv.utilities.messageBox.showMessage(ex.ToString(), idv.utilities.messageStyle.error);
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkBeforeTxn())
                return;
            if (!doTxn())
                return;
            Result = true;
            Close();
        }
    }
}
