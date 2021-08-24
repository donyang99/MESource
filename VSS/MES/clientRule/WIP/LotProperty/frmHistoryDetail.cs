using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.EQP;

namespace ClientRule.LotProperty
{
    public partial class frmHistoryDetail : Form
    {
        string mainTxnSysId = "";
        string lotId = "";
        string lotComponentInfo = "";
        string txnActivity = "";
        public frmHistoryDetail()
        {
            InitializeComponent();
        }

        public void Init(DataRow row)
        {
            System.Threading.Thread t = null;
            foreach (Control ctrl in tblDetail.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (row.Table.Columns.Contains(ctrl.Name))
                    {
                        ctrl.Text = row[ctrl.Name].ToString();
                    }
                }
            }
            txtUserName.Text = row["modify_user"].ToString() + " - " + row["user_name"].ToString();
            mainTxnSysId = row["main_txn_sysid"].ToString();
            lotComponentInfo = row["component_info"].ToString();
            txnActivity = row["activity"].ToString();
            lotId = row["lot_id"].ToString();
            if (txnActivity.StartsWith("Split"))//SplitLot, SplitForScrap
            {
                t = new System.Threading.Thread(new System.Threading.ThreadStart(getSplitTxnInfo));
                t.Start();
            }
            else if (txnActivity == "MergeLot")
            {
                t = new System.Threading.Thread(new System.Threading.ThreadStart(getMergeTxnInfo));
                t.Start();
            }
            
            string sql = "select * from mes_txn_reason where txn_sysid=?";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, row["txn_sysid"].ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtReasonCode.Text = ds.Tables[0].Rows[0]["reason_code"].ToString() + " - " 
                                     + idv.utilities.cultureLanguage.getValue(ds.Tables[0].Rows[0]["reason_code"].ToString());
                txtComments.Text = ds.Tables[0].Rows[0]["comments"].ToString();
            }

            if (t != null) t.Join();
            if (lotComponentInfo == "")
                tabDetail.TabPages.RemoveByKey("pagMembers");

            if (idv.mesCore.systemConfig.validItem("eqParameter"))
            {
                int parmSeq = 0;
                if (int.TryParse(row["eq_parm_seq"].ToString(), out parmSeq) && parmSeq >= 0)
                {
                    mesRelease.EQP.Equipment eqp = new mesRelease.EQP.Equipment(row["equipment_id"].ToString());
                    if (!eqp.sysid.Equals(""))
                        showEqParameter(eqp, parmSeq);
                }
            }
            grpEqParameter.Visible = tblEqParameter.Controls.Count > 0;
            tabDetail.Height = tblDetail.Height + grpReason.Height + 36;
        }
        void showEqParameter(mesRelease.EQP.Equipment currentEqp,int seq)
        {
            if (currentEqp == null) return;

            tblEqParameter.Controls.Clear();
            tblEqParameter.RowStyles.Clear();
            tblEqParameter.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblEqParameter.RowCount = 1;
            EqTypeParameter[] parms = currentEqp.GetEqParameterData(seq);
            int curRow = 0;
            bool col2 = false;
            tblEqParameter.Visible = false;
            for (int i = 0; i < parms.Length; i++)
            {
                EqTypeParameter parm = parms[i];
                if (i % 2 == 0)
                {
                    tblEqParameter.RowCount++;
                    tblEqParameter.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    curRow++;
                    col2 = false;
                }
                else
                    col2 = true;
                Label lbl = new Label();
                string caption = idv.utilities.cultureLanguage.getValue(parm.name);
                if (caption.Equals(""))
                    lbl.Text = parm.name;
                else
                    lbl.Text = caption;
                lbl.ForeColor = SystemColors.ControlText;
                lbl.AutoSize = true;
                tblEqParameter.Controls.Add(lbl, 0 + (col2 ? 2 : 0), curRow);
                lbl.Anchor = AnchorStyles.Right;

                TextBox txt = new TextBox();
                txt.TabIndex = 1;
                txt.ReadOnly = true;
                txt.ImeMode = System.Windows.Forms.ImeMode.Off;
                txt.Text = parm.value;
                tblEqParameter.Controls.Add(txt, 1 + (col2 ? 2 : 0), curRow);
                txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            }
            tblEqParameter.Visible = true;
        }

        void getSplitTxnInfo()
        {
            try
            {
                Dictionary<string, double> childLot = new Dictionary<string, double>();
                string sql = "select * from mes_wip_lot_history where main_txn_sysid=?";
                DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, mainTxnSysId);
                string parentLotId="";
                double splitQty = 0;
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    if (r["activity"].ToString() != txnActivity) continue;
                    string txnLotId = r["lot_id"].ToString();
                    string splitParent = r["split_parent"].ToString();
                    double quantity = Convert.ToDouble(r["quantity"].ToString());
                    if (splitParent == lotId)
                        childLot.Add(txnLotId, quantity);
                    else if (txnLotId == lotId)
                    {
                        parentLotId = splitParent;
                        splitQty += quantity;
                    }
                    else
                        splitQty += quantity;
                }
                if (childLot.Count == 0)
                {
                    txtParentLotId.Text = parentLotId;
                    txtTxnQty.Text = splitQty.ToString();
                }
                else
                {
                    foreach (KeyValuePair<string, double> keyValue in childLot)
                    {
                        ListViewItem item = new ListViewItem(keyValue.Key);
                        item.SubItems.Add(keyValue.Value.ToString());
                        lvwChildLot.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        void getMergeTxnInfo()
        {
            try
            {
                Dictionary<string, double> childLot = new Dictionary<string, double>();
                string sql = "select * from mes_wip_lot_history where main_txn_sysid=?";
                DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, mainTxnSysId);
                string parentLotId = "";
                double mergeQty = 0;

                //find the parent
                Dictionary<string, double> list = new Dictionary<string, double>();
                foreach (DataRow r in ds.Tables[0].Rows)
                    list.Add(r["lot_id"].ToString(), Convert.ToDouble(r["quantity"].ToString()));
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    parentLotId = r["merge_parent"].ToString();
                    if (list.ContainsKey(parentLotId))
                    {
                        mergeQty = list[parentLotId];
                        break;
                    }
                }

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string txnLotId = r["lot_id"].ToString();
                    string mergeParent = r["merge_parent"].ToString();
                    double quantity = Convert.ToDouble(r["quantity"].ToString());
                    if (mergeParent == lotId)
                    {
                        childLot.Add(txnLotId, quantity);
                    }                   

                    if (parentLotId != txnLotId)
                        mergeQty -= quantity;
                }
                if (childLot.Count == 0)
                {
                    txtParentLotId.Text = parentLotId;
                    txtTxnQty.Text = mergeQty.ToString();
                }
                else
                {
                    foreach (KeyValuePair<string, double> keyValue in childLot)
                    {
                        ListViewItem item = new ListViewItem(keyValue.Key);
                        item.SubItems.Add(keyValue.Value.ToString());
                        lvwChildLot.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        void getMembers()
        {
            _members = true;
            string sql = "select a.*,b.component_id from mes_wip_lot_history_component a " +
                         "join mes_wip_component b on a.component_sysid=b.sysid " +
                         "where a.lot_component_info =?";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, lotComponentInfo);
            lvwComponents.Items.Clear();
            SortedDictionary<string, ListViewItem> list = new SortedDictionary<string, ListViewItem>();
            
            string sortKey = "";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(row["component_id"].ToString());
                item.SubItems.Add(row["carrier_id"].ToString());
                item.SubItems.Add(row["position"].ToString());
                item.SubItems.Add(row["integrity"].ToString());
                int i = 0;
                int.TryParse(item.SubItems[2].Text, out i);

                sortKey = item.SubItems[1].Text + i.ToString("0000");
                if (list.ContainsKey(sortKey))
                {
                    int carTemp = 0;
                    while (true)
                    {
                        sortKey = "z" + carTemp.ToString() + i.ToString("0000");
                        if (!list.ContainsKey(sortKey))
                            break;
                        carTemp++;
                    }
                }

                list.Add(sortKey, item);
            }
            foreach (ListViewItem item in list.Values)
            {
                lvwComponents.Items.Add(item);
            }
        }

        bool _members = false;
        private void tabDetail_Selected(object sender, TabControlEventArgs e)
        {
            if (tabDetail.SelectedTab == pagMembers && !_members)
            {
                getMembers();
            }
        }

        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    break;
            }
        }
    }
}
