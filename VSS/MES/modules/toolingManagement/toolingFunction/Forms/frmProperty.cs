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
    public partial class frmProperty : Form
    {
        ToolingId curItem = null;

        public frmProperty()
        {
            InitializeComponent();
        }
        private void frmProperty_Load(object sender, EventArgs e)
        {
            dtFrom.Value = DateTime.Now.Date.AddDays(-7);
            dtTo.Value = DateTime.Now.Date.AddDays(1).AddSeconds(-1);
        }
        public void ShowToolingId(ToolingId tooling)
        {
            curItem = tooling;
            if (curItem == null)
            {
                txtToolingType.Text = "";
                txtToolingPart.Text = "";
                txtPartDesc.Text = "";
                txtToolingId.Text = "";
                txtOwnDept.Text = "";
                txtStatus.Text = "";
                txtLocation.Text = "";
                return;
            }
            txtToolingType.Text = curItem.toolingType;
            txtToolingPart.Text = curItem.partNo;
            txtPartDesc.Text = curItem.partDescription;
            txtToolingId.Text = curItem.name;
            txtOwnDept.Text = curItem.ownerDept;
            txtStatus.Text = curItem.status;
            txtLocation.Text = curItem.location;
        }

        private void btnQueryHistory_Click(object sender, EventArgs e)
        {
            lvwHistory.Items.Clear();
            if (curItem == null) return;
            string sql = "select event_name,location,lot_id,status,current_count,use_count,reason_code,comments,modify_user,modify_date " +
                         "from mes_tol_tooling_history where tooling_id=? and modify_date between ? and ? order by modify_date desc";
            DataSet ds = serviceHost.Client.getDataSetWithParameter(sql, curItem.name, dtFrom.Value, dtTo.Value);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(dr["event_name"].ToString());
                foreach (ColumnHeader col in lvwHistory.Columns)
                {
                    if (col.Name.Equals("event_name")) continue;
                    item.SubItems.Add(dr[col.Name].ToString());
                }
                item.Tag = dr;
                lvwHistory.Items.Add(item);
            }
        }

        private void btnExportHistory_Click(object sender, EventArgs e)
        {
            if (lvwHistory.Items.Count == 0) return;
            Type tt = Type.GetType("mesRelease.utilities.ExcelAgent, mesRelease");
            object returnValue = tt.InvokeMember("WriteToFile", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                   System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { lvwHistory });
            if (Convert.ToBoolean(returnValue))
                idv.utilities.messageBox.showMessageById("msgExecuteSucceed", idv.utilities.messageStyle.success);
        }


    }
}
