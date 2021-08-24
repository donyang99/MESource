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

namespace ClientRule.HoldLotReport
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
                IMessageGuard client = serviceHost.IsolationClient;

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
            Thread t;
            t = new Thread(new ThreadStart(doQuery));
            t.Start();
        }

        void doQuery()
        {            
            try
            {
                Thread t = new Thread(new ThreadStart(prepareHoldInformationByHoldDate));
                t.Start();

                string sql = "select /*+rule*/b.fab,a.*,c.comments holdComments,d.comments releaseComments from mes_wip_lot_hold_release a " +
                             "join mes_wip_lot b on a.lot_id=b.lot_id "+
                             "join mes_txn_reason c on a.sysid=c.txn_sysid left join mes_txn_reason d on a.release_txn_sysid=d.txn_sysid " +
                             "where a.delete_flag='0' ";//仍在扣押原因

                if (cboFAB.Text != "")
                    sql += "and b.fab='" + cboFAB.Text + "'";

                if (cboStep.Text != "")
                    sql += "and a.step_id='" + cboStep.Text + "'";

                sql += " order by b.fab,a.step_id,a.lot_id";
                DataSet ds = serviceHost.Client.getDataSet(sql);

                DataTable dt = new DataTable(); DSTable dst = new DSTable();
                prepareHoldInformation(ds, dt, dst);

                //dst.FooterEnable = true;

                StringBuilder html = new StringBuilder();
                html.AppendLine("<html>").AppendLine("<title></title>").AppendLine("<head></head>").AppendLine("<body>");
                html.AppendLine("<center>").AppendLine("<h2>HoldLot Report</h2>").AppendLine("</center>");
                html.Append("<table><tr style='font-size:8pt'>");
                html.Append("<td align ='right'>").Append("Date: ").Append(dtFrom.Value.ToString() + " ~ ").Append(dtTo.Value.ToString());
                html.Append("<tr><td align ='left'><p>").Append(cultureLanguage.getValue("Hold")+cultureLanguage.getValue("Status")).AppendLine("</p>");

                html.AppendLine("<tr><td align ='left'>");
                html.AppendLine(dst.Render(dt));

                html.AppendLine("<tr><td>");

                html.Append("<tr><td align ='left'><p>").Append(cultureLanguage.getValue("holdDate"));
                html.Append(dtFrom.Value.ToString() + " ~ ").Append(dtTo.Value.ToString()).AppendLine("</p>");
                html.AppendLine("<tr><td align ='left'>");
                t.Join();
                if (dsTableByHoldDate != null)
                    html.AppendLine(dsTableByHoldDate.Render(dtByHoldDate));

                html.Append("<tr><td align ='left'><p>").Append(cultureLanguage.getValue("releaseDate"));
                html.Append(dtFrom.Value.ToString() + " ~ ").Append(dtTo.Value.ToString()).AppendLine("</p>");
                html.AppendLine("<tr><td align ='left'>");
                if (dsTableByReleaseDate != null)
                    html.AppendLine(dsTableByReleaseDate.Render(dtByReleaseDate));

                html.Append("</table>");
                webBrowser1.DocumentText = html.ToString();
            }
            catch { }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        void prepareHoldInformation(DataSet ds, DataTable dt, DSTable dst)
        {
            #region prepare Columns
            dt.Columns.Add("FAB", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("fab"));
            dst.AddColumnSetting(new ColumnSetting(60, HorizontalAlign.Left, HorizontalAlign.Center, "", "FAB"));

            dt.Columns.Add("STEPID", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("stepId"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "STEPID"));

            dt.Columns.Add("LOTID", typeof(string)); 
            dst.AddColumn(0, cultureLanguage.getValue("lotId"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "LOTID"));

            dt.Columns.Add("HOLDREASON", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("ReasonCode"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDREASON"));

            dt.Columns.Add("HOLDUSER", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("holdUser"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDUSER"));

            dt.Columns.Add("HOLDDATE", typeof(DateTime));
            dst.AddColumn(0, cultureLanguage.getValue("holdDate"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDDATE"));

            dt.Columns.Add("HOLDTIME", typeof(TimeSpan));
            dst.AddColumn(0, cultureLanguage.getValue("timeLast"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "", "HOLDTIME"));

            dt.Columns.Add("OWNERDEPT", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("ownerDept"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "OWNERDEPT"));

            dt.Columns.Add("HOLDCOMMENT", typeof(string));
            dst.AddColumn(0, cultureLanguage.getValue("comments"));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDCOMMENT"));
            #endregion

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DataRow dr = dt.NewRow();
                dr["FAB"] = row["fab"].ToString();
                dr["STEPID"] = row["step_id"].ToString();
                dr["LOTID"] = row["lot_id"].ToString();
                dr["HOLDREASON"] = row["hold_reason"].ToString() + " - " + cultureLanguage.getValue(row["hold_reason"].ToString());
                dr["HOLDUSER"] = row["hold_user"].ToString() + " - " + User.GetUserName(row["hold_user"].ToString());
                dr["HOLDDATE"] = row["hold_date"];
                dr["HOLDCOMMENT"] = row["holdcomments"];
                TimeSpan ts = (DateTime.Now - (DateTime)row["hold_date"]);
                dr["HOLDTIME"] = new TimeSpan(ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
                mesRelease.BAS.ReasonCode r = mesRelease.BAS.ReasonCode.getReasonCode(row["hold_reason"].ToString());
                if (r != null)
                    dr["OWNERDEPT"] = r.ownerDept;
                dt.Rows.Add(dr);
            }
        }

        //查詢區間內被扣押(且已release)
        DSTable dsTableByHoldDate = null;
        DataTable dtByHoldDate = null;
        void prepareHoldInformationByHoldDate()
        {
            try
            {
                string sql = "select /*+rule*/b.fab,a.*,c.comments holdComments,d.comments releaseComments from mes_wip_lot_hold_release a " +
                             "join mes_wip_lot b on a.lot_id=b.lot_id " +
                             "join mes_txn_reason c on a.sysid=c.txn_sysid left join mes_txn_reason d on a.release_txn_sysid=d.txn_sysid " +
                             "where a.hold_date between ? and ? and a.delete_flag='1' ";

                if (cboFAB.Text != "")
                    sql += "and b.fab='" + cboFAB.Text + "'";

                if (cboStep.Text != "")
                    sql += "and a.step_id='" + cboStep.Text + "'";

                sql += " order by b.fab,a.step_id,a.lot_id";

                DataSet ds = null;

                IMessageGuard client = serviceHost.IsolationClient;

                ds = client.getDataSetWithParameter(sql, dtFrom.Value, dtTo.Value);
                prepareHoldInformationByReleaseDate(client);

                dsTableByHoldDate = new DSTable();
                dtByHoldDate = new DataTable();

                #region prepare Columns
                dtByHoldDate.Columns.Add("FAB", typeof(string));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("fab"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(60, HorizontalAlign.Left, HorizontalAlign.Center, "", "FAB"));

                dtByHoldDate.Columns.Add("STEPID", typeof(string));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("stepId"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "STEPID"));

                dtByHoldDate.Columns.Add("LOTID", typeof(string));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("lotId"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "LOTID"));

                dtByHoldDate.Columns.Add("HOLDREASON", typeof(string));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("ReasonCode"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDREASON"));

                dtByHoldDate.Columns.Add("HOLDUSER", typeof(string));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("holdUser"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDUSER"));

                dtByHoldDate.Columns.Add("HOLDDATE", typeof(DateTime));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("holdDate"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDDATE"));

                dtByHoldDate.Columns.Add("HOLDCOMMENT", typeof(string));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("comments"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDCOMMENT"));

                dtByHoldDate.Columns.Add("RELEASEREASON", typeof(string));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("releaseReason"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "RELEASEREASON"));

                dtByHoldDate.Columns.Add("RELEASEUSER", typeof(string));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("releaseUser"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "RELEASEUSER"));

                dtByHoldDate.Columns.Add("RELEASEDATE", typeof(DateTime));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("releaseDate"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "RELEASEDATE"));

                dtByHoldDate.Columns.Add("RELEASECOMMENT", typeof(string));
                dsTableByHoldDate.AddColumn(0, cultureLanguage.getValue("comments"));
                dsTableByHoldDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "RELEASECOMMENT"));
                #endregion

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow dr = dtByHoldDate.NewRow();
                    dr["FAB"] = row["fab"].ToString();
                    dr["STEPID"] = row["step_id"].ToString();
                    dr["LOTID"] = row["lot_id"].ToString();
                    dr["HOLDREASON"] = row["hold_reason"].ToString() + " - " + cultureLanguage.getValue(row["hold_reason"].ToString());
                    dr["HOLDUSER"] = row["hold_user"].ToString() + " - " + User.GetUserName(row["hold_user"].ToString());
                    dr["HOLDDATE"] = row["hold_date"];
                    dr["HOLDCOMMENT"] = row["holdcomments"];

                    dr["RELEASEREASON"] = row["release_reason"].ToString() + " - " + cultureLanguage.getValue(row["release_reason"].ToString());
                    dr["RELEASEUSER"] = row["release_user"].ToString() + " - " + User.GetUserName(row["release_user"].ToString());
                    dr["RELEASEDATE"] = row["release_date"];
                    dr["RELEASECOMMENT"] = row["releasecomments"];
                    dtByHoldDate.Rows.Add(dr);
                }
            }
            catch { }
        }

        //查詢區間內放行
        DSTable dsTableByReleaseDate = null;
        DataTable dtByReleaseDate = null;
        void prepareHoldInformationByReleaseDate(IMessageGuard client)
        {
            try
            {
                string sql = "select /*+rule*/b.fab,a.*,c.comments holdComments,d.comments releaseComments from mes_wip_lot_hold_release a " +
                             "join mes_wip_lot b on a.lot_id=b.lot_id " +
                             "join mes_txn_reason c on a.sysid=c.txn_sysid left join mes_txn_reason d on a.release_txn_sysid=d.txn_sysid " +
                             "where a.hold_date not between ? and ? and a.release_date between ? and ? and a.delete_flag='1' ";

                if (cboFAB.Text != "")
                    sql += "and b.fab='" + cboFAB.Text + "'";

                if (cboStep.Text != "")
                    sql += "and a.step_id='" + cboStep.Text + "'";

                sql += " order by b.fab,a.step_id,a.lot_id";

                DataSet ds = null;
                ds = client.getDataSetWithParameter(sql, dtFrom.Value, dtTo.Value, dtFrom.Value, dtTo.Value);

                dsTableByReleaseDate = new DSTable();
                dtByReleaseDate = new DataTable();

                #region prepare Columns
                dtByReleaseDate.Columns.Add("FAB", typeof(string));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("fab"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(60, HorizontalAlign.Left, HorizontalAlign.Center, "", "FAB"));

                dtByReleaseDate.Columns.Add("STEPID", typeof(string));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("stepId"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "STEPID"));

                dtByReleaseDate.Columns.Add("LOTID", typeof(string));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("lotId"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "LOTID"));

                dtByReleaseDate.Columns.Add("HOLDREASON", typeof(string));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("ReasonCode"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDREASON"));

                dtByReleaseDate.Columns.Add("HOLDUSER", typeof(string));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("holdUser"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDUSER"));

                dtByReleaseDate.Columns.Add("HOLDDATE", typeof(DateTime));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("holdDate"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDDATE"));

                dtByReleaseDate.Columns.Add("HOLDCOMMENT", typeof(string));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("comments"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "HOLDCOMMENT"));

                dtByReleaseDate.Columns.Add("RELEASEREASON", typeof(string));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("releaseReason"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "RELEASEREASON"));

                dtByReleaseDate.Columns.Add("RELEASEUSER", typeof(string));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("releaseUser"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "RELEASEUSER"));

                dtByReleaseDate.Columns.Add("RELEASEDATE", typeof(DateTime));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("releaseDate"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "RELEASEDATE"));

                dtByReleaseDate.Columns.Add("RELEASECOMMENT", typeof(string));
                dsTableByReleaseDate.AddColumn(0, cultureLanguage.getValue("comments"));
                dsTableByReleaseDate.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Left, HorizontalAlign.Center, "", "RELEASECOMMENT"));
                #endregion

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow dr = dtByReleaseDate.NewRow();
                    dr["FAB"] = row["fab"].ToString();
                    dr["STEPID"] = row["step_id"].ToString();
                    dr["LOTID"] = row["lot_id"].ToString();
                    dr["HOLDREASON"] = row["hold_reason"].ToString() + " - " + cultureLanguage.getValue(row["hold_reason"].ToString());
                    dr["HOLDUSER"] = row["hold_user"].ToString() + " - " + User.GetUserName(row["hold_user"].ToString());
                    dr["HOLDDATE"] = row["hold_date"];
                    dr["HOLDCOMMENT"] = row["holdcomments"];

                    dr["RELEASEREASON"] = row["release_reason"].ToString() + " - " + cultureLanguage.getValue(row["release_reason"].ToString());
                    dr["RELEASEUSER"] = row["release_user"].ToString() + " - " + User.GetUserName(row["release_user"].ToString());
                    dr["RELEASEDATE"] = row["release_date"];
                    dr["RELEASECOMMENT"] = row["releasecomments"];
                    dtByReleaseDate.Rows.Add(dr);
                }
            }
            catch { }
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
