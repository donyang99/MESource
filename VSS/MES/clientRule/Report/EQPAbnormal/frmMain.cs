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
using System.Threading;
using System.Web.UI.WebControls;
using idv.messageService;

namespace ClientRule.EQPAbnormal
{
    public partial class frmMain : Form
    {
        DataSet dsStep = null;
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {                        
            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            if (DateTime.Now.Hour > 19)
            {
                dtFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 30, 0);
                DateTime now = DateTime.Now.AddDays(1);
                dtTo.Value = new DateTime(now.Year, now.Month, now.Day, 7, 29, 29, 999);
            }
            else if (DateTime.Now.Hour > 7)
            {
                dtFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 30, 0);
                dtTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 29, 29, 999);
            }
            else
            {
                DateTime now = DateTime.Now.AddDays(-1);
                dtFrom.Value = new DateTime(now.Year, now.Month, now.Day, 19, 30, 0);
                dtTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 29, 59, 999);
            }
            
            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                idv.messageService.IMessageGuard client = idv.messageService.serviceHost.IsolationClient;

                cboStep.Items.Add("");
                string sql = "select step_id,fab from mes_prp_step where issue_state='Active'";
                dsStep = client.getDataSet(sql);
                showFAB();

                Invoke(new MethodInvoker(setComboAutoCompleteAttribute));
            }
            catch { }
        }
        private void cboFAB_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in dsStep.Tables[0].Rows)
            {
                if (cboFAB.Text == "" || cboFAB.Text == row["fab"].ToString() || row["fab"].ToString() == "ALL")
                    cboStep.Items.Add(row["step_id"].ToString());
            }
        }

        void setComboAutoCompleteAttribute()
        {
            cboStep.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboStep.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        void showFAB()
        {
            cboFAB.Enabled = false;

            cboFAB.Items.AddRange(mesRelease.BAS.Fab.GetFabNames());

            if (cboFAB.Items.Count == 1)
                cboFAB.SelectedIndex = 0;
            else
            {
                if (mesRelease.WF.WorkFlow.CurrentFAB != "")
                    cboFAB.Text = mesRelease.WF.WorkFlow.CurrentFAB;
                else if (User.loginUser.fab != "")
                    cboFAB.Text = User.loginUser.fab;
                else
                    cboFAB.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }
        
        private void btnQuery_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            doQuery();
        }

        void doQuery()
        {
            try
            {
                string sql = "select /*+rule*/a.equipment_id,a.state,b.state currentState,a.activity,a.fab,a.modify_user,a.modify_date,a.txnstamp txnstamp_his,b.txnstamp,c.reason_code,c.comments " +
                             "from mes_eqp_history a join mes_eqp_equipment b on a.equipment_id=b.equipment_id " +
                                                    "join mes_txn_reason c on a.txn_sysid=c.txn_sysid " +
                              "where a.activity='ChangeState' and a.state='DOWN' and a.modify_date between ? and ? ";

                if (cboFAB.Text != "")
                    sql += "and b.fab='" + cboFAB.Text + "' ";

                if (cboStep.Text != "")
                {
                    sql += "and b.equipment_id in (select c.equipment_id from mes_prp_step a join mes_eqp_group_link b on a.equipment_group=b.equipment_group " +
                            "join mes_eqp_equipment c on b.equipment_sysid=c.sysid where  a.step_id='" + cboStep.Text + "')";
                }

                sql += " order by b.equipment_id,a.modify_date";
                DataSet ds = serviceHost.Client.getDataSetWithParameter(sql, dtFrom.Value, dtTo.Value);

                DataTable dt = new DataTable(); DSTable dst = new DSTable();
                prepareEQP(ds, dt, dst);

                StringBuilder html = new StringBuilder();
                html.AppendLine("<html>").AppendLine("<title></title>").AppendLine("<head></head>").AppendLine("<body>");
                html.AppendLine("<center>").AppendLine("<h2>EQP Abnormal Report</h2>");
                html.Append("<table><tr style='font-size:8pt'>");
                html.Append("<td align ='right'>").Append("Date: ").Append(dtFrom.Value.ToString() + " ~ ").Append(dtTo.Value.ToString());
                html.AppendLine("<tr><td>");
                html.AppendLine(dst.Render(dt));
                html.Append("</table>");
                html.AppendLine("</center>");
                webBrowser1.DocumentText = html.ToString();
            }
            catch { }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        void prepareEQP(DataSet ds, DataTable dt, DSTable dst)
        {
            #region prepare Columns
            dt.Columns.Add("FAB", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("fab"));
            dst.AddColumnSetting(new ColumnSetting(60, HorizontalAlign.Center, HorizontalAlign.Center, "", "FAB"));

            dt.Columns.Add("EQPID", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("equipmentId"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "EQPID"));

            dt.Columns.Add("STATE", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("state"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "STATE"));

            dt.Columns.Add("REASON", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("reasonCode"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "REASON"));

            dt.Columns.Add("MODIFYUSER", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("modifyUser"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "MODIFYUSER"));

            dt.Columns.Add("MODIFYDATE", typeof(DateTime));
            dst.AddColumn(0, cultureLanguage.getValue("modifyDate"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "MODIFYDATE"));

            dt.Columns.Add("TIMELAST", typeof(TimeSpan));
            dst.AddColumn(0, cultureLanguage.getValue("timeLast"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "", "TIMELAST"));

            dt.Columns.Add("CURSTATE", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("currentState"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "CURSTATE"));

            dt.Columns.Add("COMMENT", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("comments"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "COMMENT"));
            #endregion

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DataRow dr = dt.NewRow();

                dr["FAB"] = row["fab"].ToString();
                dr["EQPID"] = row["equipment_id"].ToString();
                dr["STATE"] = row["state"].ToString();
                dr["REASON"] = row["reason_code"].ToString();
                dr["MODIFYUSER"] = row["modify_user"].ToString() + " - " + User.GetUserName(row["modify_user"].ToString());
                dr["MODIFYDATE"] = row["modify_date"];
                dr["CURSTATE"] = row["currentstate"].ToString();
                if (row["txnstamp"].ToString() == (Convert.ToInt32(row["txnstamp_his"])+1).ToString())
                {
                    TimeSpan ts = (DateTime.Now - (DateTime)row["modify_date"]);
                    dr["TIMELAST"] = new TimeSpan(ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
                }
                dr["COMMENT"] = row["comments"].ToString();
                dt.Rows.Add(dr);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.ShowPrintDialog();
            }
            catch { }
        }        
    }
}
