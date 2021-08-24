using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientRule.EqProperty
{
    public partial class frmHistoryDetail : Form
    {
        string eqSetupInfo = "";
        public frmHistoryDetail()
        {
            InitializeComponent();
        }

        public void Init(DataRow row)
        {
            System.Threading.Thread t = null;
            txtEquipmentId.Text = row["equipment_id"].ToString();
            txtActivity.Text = row["activity"].ToString();            
            txtState.Text = row["state"].ToString();
            txtPreviousState.Text = row["prevState"].ToString();
            if (row["modify_date"] != DBNull.Value && row["prevDate"] != DBNull.Value)
                txtTimeLast.Text = ((DateTime)row["modify_date"] - (DateTime)row["prevDate"]).ToString();
            txtUserName.Text = row["modify_user"].ToString() + " - " + row["user_name"].ToString();
            txtModifyDate.Text = row["modify_date"].ToString();
            txtRecipe.Text = row["recipe"].ToString();
            txtCounter.Text = row["counter"].ToString();
            txtLotId.Text = row["lot_id"].ToString();
            eqSetupInfo = row["setup_info"].ToString();

            //t = new System.Threading.Thread(new System.Threading.ThreadStart(getSetupInfo));
            //t.Start();
            
            
            string sql = "select * from mes_txn_reason where txn_sysid=?";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, row["txn_sysid"].ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtReasonCode.Text = ds.Tables[0].Rows[0]["reason_code"].ToString() + " - " 
                                     + idv.utilities.cultureLanguage.getValue(ds.Tables[0].Rows[0]["reason_code"].ToString());
                txtComments.Text = ds.Tables[0].Rows[0]["comments"].ToString();
            }

            //if (t != null) t.Join();
        }

        void getSetupInfo()
        {
            if(eqSetupInfo.Equals("")) return;
            try
            {
                idv.messageService.IMessageGuard client = idv.messageService.serviceHost.IsolationClient;

                string sql = "select * from mes_eqp_history_setup_info where eqp_setup_info=?";
                DataSet ds = client.getDataSetWithParameter(sql, eqSetupInfo);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(row["material_type"].ToString());
                    item.SubItems.Add(row["part_no"].ToString());
                    item.SubItems.Add(row["material_lot_id"].ToString());
                    item.SubItems.Add(row["position"].ToString());
                    item.SubItems.Add(row["quantity"].ToString());
                    lvwSetupInfo.Items.Add(item);
                }

            }
            catch { }
        }
    }
}
