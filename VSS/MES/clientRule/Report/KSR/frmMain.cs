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

namespace ClientRule.KSR
{
    public partial class frmMain : Form
    {
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
            showFAB();
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

                cboOrderId.Items.Add("");
                string sql = "select order_id from mes_wip_order where status='Active'";
                DataSet ds = client.getDataSet(sql);
                foreach (DataRow row in ds.Tables[0].Rows)
                    cboOrderId.Items.Add(row["order_id"].ToString());

                Invoke(new MethodInvoker(setComboAutoCompleteAttribute));
            }
            catch { }
        }

        void setComboAutoCompleteAttribute()
        {
            cboOrderId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboOrderId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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

        DataSet dsHistory = null;
        void doQuery()
        {            
            try
            {
                Thread t = new Thread(new ThreadStart(getHistory));
                t.Start();

                string sql = "select /*+rule*/a.fab,";

                if (idv.mesCore.systemConfig.stepStage)
                    sql += "b.stage,c.remark";
                else
                    sql += "b.step_id stage,b.seq";
                
                sql+=",a.status,a.rule_seq,sum(a.quantity) quantity,";

                if (idv.mesCore.systemConfig.dbType == "" || idv.mesCore.systemConfig.dbType == "oracle")
                    sql += "round(sum((sysdate - a.modify_date)*24)) hours,count(a.fab) count ";
                else if (idv.mesCore.systemConfig.dbType == "postgreSQL")
                    sql += "round(sum(date_part('hours',current_timestamp - a.modify_date))) hours,count(a.fab) count ";
                else if (idv.mesCore.systemConfig.dbType == "mySql")
                    sql += "round(sum(timestampdiff(minute,a.modify_date,current_timestamp))) hours,count(a.fab) count ";
                else//select date_part('days', now() - date_of_join) as days from employee
                    sql += @"sum(datediff(""HH"",a.modify_date,GETDATE())) hours,count(a.fab) count ";

                sql += "from mes_wip_lot a join mes_prp_step b on a.step_id=b.step_id and b.issue_state='Active' ";

                if (idv.mesCore.systemConfig.stepStage)
                    sql += "join mes_misc c on b.stage=c.value and c.item='stepStage' ";

                sql += "where a.status in ('WAIT','HOLD','RUN') ";

                if (cboFAB.Text != "")
                    sql += "and a.fab='" + cboFAB.Text + "' ";

                if (cboOrderId.Text != "")
                    sql += "and a.order_id='" + cboOrderId.Text + "' ";

                if (idv.mesCore.systemConfig.stepStage)
                {
                    sql += "group by a.fab,b.stage,c.remark,a.status,a.rule_seq " +
                           "order by c.remark,a.rule_seq";
                }
                else
                {
                    sql += "group by a.fab,b.step_id,b.seq,a.status,a.rule_seq " +
                           "order by b.seq,a.rule_seq";
                }
                DataSet ds = serviceHost.Client.getDataSet(sql);

                DataTable dt = new DataTable(); DSTable dst = new DSTable();
                prepareWIP(ds, dt, dst);

                t.Join();
                prepareHistory(dsHistory, dt, dst);

                dst.FooterEnable = true;

                StringBuilder html = new StringBuilder();
                html.AppendLine("<html>").AppendLine("<title></title>").AppendLine("<head></head>").AppendLine("<body>");
                html.AppendLine("<center>").AppendLine ("<h2>Key Stage Report</h2>");
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

        void getHistory()
        {
            try
            {
                dsHistory = null;
                string sql = "select /*+rule*/a.fab," + (idv.mesCore.systemConfig.stepStage ? "b.stage" : "b.step_id stage") + ",a.activity,count(a.fab) count,sum(a.quantity) quantity " +
                             "from mes_wip_lot_history a join mes_prp_step b on a.step_id=b.step_id and b.issue_state='Active' " +
                             "where a.activity in ('ScrapLot','TrackOut') and a.modify_date between ? and ? ";
                if (cboFAB.Text != "")
                    sql += "and a.fab='" + cboFAB.Text + "' ";

                if (cboOrderId.Text != "")
                    sql += "and a.order_id='" + cboOrderId.Text + "' ";

                if (idv.mesCore.systemConfig.stepStage)
                    sql += " group by a.fab,b.stage,a.activity";
                else
                    sql += " group by a.fab,b.step_id,a.activity";

                IMessageGuard client = serviceHost.IsolationClient;

                dsHistory = client.getDataSetWithParameter(sql, dtFrom.Value, dtTo.Value);

            }
            catch { }
        }

        void prepareWIP(DataSet ds, DataTable dt, DSTable dst)
        {
            #region prepare Columns
            dt.Columns.Add("STAGE"); dst.AddColumn(0, " "); dst.AddColumn(1, " ");
            dst.AddColumnSetting(new ColumnSetting(60, HorizontalAlign.Center, HorizontalAlign.Center, ""));
            dt.Columns.Add("LOT", typeof(int)); dst.AddColumn(0, "WIP"); dst.AddColumn(1, "LOT");//total Lot Count
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("QTY", typeof(int)); dst.AddColumn(0, "WIP"); dst.AddColumn(1, "QTY");//total Quantity
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("RLOT", typeof(int)); dst.AddColumn(0, "RUN"); dst.AddColumn(1, "LOT");//running Lot Count
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("RQTY", typeof(int)); dst.AddColumn(0, "RUN"); dst.AddColumn(1, "QTY");//running Quantity
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("MLOT", typeof(int)); dst.AddColumn(0, "MOVE"); dst.AddColumn(1, "LOT");//moved Lot Count
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("MQTY", typeof(int)); dst.AddColumn(0, "MOVE"); dst.AddColumn(1, "QTY");//moved Quantity
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("HLOT", typeof(int)); dst.AddColumn(0, "HOLD"); dst.AddColumn(1, "LOT");//hold Lot Count
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("HQTY", typeof(int)); dst.AddColumn(0, "HOLD"); dst.AddColumn(1, "QTY");//hold Quantity
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("H_HOUR", typeof(double)); dst.AddColumn(0, "HOLD"); dst.AddColumn(1, "Time(h)");//avg time(h) of lot
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0.##}"));
            dt.Columns.Add("BLOT", typeof(int)); dst.AddColumn(0, "Before"); dst.AddColumn(1, "LOT");//before trackIn Lot Count
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("BQTY", typeof(int)); dst.AddColumn(0, "Before"); dst.AddColumn(1, "QTY");//before trackIn Quantity
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("B_HOUR", typeof(double)); dst.AddColumn(0, "Before"); dst.AddColumn(1, "Time(h)");//avg wait time(h) of lot
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0.##}"));
            dt.Columns.Add("ALOT", typeof(int)); dst.AddColumn(0, "After"); dst.AddColumn(1, "LOT");//after trackOut Lot Count
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("AQTY", typeof(int)); dst.AddColumn(0, "After"); dst.AddColumn(1, "QTY");//after trackOut Quantity
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Columns.Add("SCRAP", typeof(int)); dst.AddColumn(0, "Scrap"); dst.AddColumn(1, "Scrap");//scrap quantity
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}"), true);
            dt.Constraints.Add("PK", dt.Columns["STAGE"], true);
            #endregion

            string sql = "select distinct b.remark,a.stage as value from mes_prp_step a join mes_misc b on a.stage = b.value and b.item='stepStage' where a.issue_state='Active'";

            if (!idv.mesCore.systemConfig.stepStage)
                sql = "select a.seq,a.step_id as value from mes_prp_step a where a.issue_state='Active'";

            if (cboFAB.Text != "")
                sql += " and a.fab in ('ALL','" + cboFAB.Text + "')";

            sql += " order by 1";

            DataSet dsStage = serviceHost.Client.getDataSet(sql);
            foreach (DataRow row in dsStage.Tables[0].Rows)
            {
                DataRow dr;
                DataRow[] drs = dt.Select("STAGE='" + row["VALUE"].ToString() + "'");
                if (drs.Length == 0)
                {
                    dr = dt.NewRow();
                    dr["STAGE"] = row["VALUE"].ToString();
                    dt.Rows.Add(dr);
                }
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DataRow dr;
                DataRow[] drs = dt.Select("STAGE='" + row["STAGE"].ToString() + "'");
                if (drs.Length == 0)
                {
                    dr = dt.NewRow();
                    dr["STAGE"] = row["STAGE"].ToString();
                    dt.Rows.Add(dr);
                }
                else
                    dr = drs[0];

                dr["LOT"] = Convert.ToInt32(row["COUNT"]) + (dr["LOT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LOT"]));
                dr["QTY"] = Convert.ToInt32(row["QUANTITY"]) + (dr["QTY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["QTY"]));
                switch (row["STATUS"].ToString())
                {
                    case "WAIT":
                        if (Convert.ToInt32(row["RULE_SEQ"]) < 2)//before
                        {
                            dr["BLOT"] = Convert.ToInt32(row["COUNT"]) + (dr["BLOT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["BLOT"]));
                            dr["BQTY"] = Convert.ToInt32(row["QUANTITY"]) + (dr["BQTY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["BQTY"]));
                            dr["B_HOUR"] = Convert.ToInt32(row["HOURS"]) + (dr["B_HOUR"] == DBNull.Value ? 0 : Convert.ToInt32(dr["B_HOUR"]));
                        }
                        else
                        {
                            dr["ALOT"] = Convert.ToInt32(row["COUNT"]) + (dr["ALOT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ALOT"]));
                            dr["AQTY"] = Convert.ToInt32(row["QUANTITY"]) + (dr["AQTY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["AQTY"]));
                        }
                        break;
                    case "RUN":
                        dr["RLOT"] = Convert.ToInt32(row["COUNT"]) + (dr["RLOT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["RLOT"]));
                        dr["RQTY"] = Convert.ToInt32(row["QUANTITY"]) + (dr["RQTY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["RQTY"]));
                        break;
                    case "HOLD":
                        dr["HLOT"] = Convert.ToInt32(row["COUNT"]) + (dr["HLOT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["HLOT"]));
                        dr["HQTY"] = Convert.ToInt32(row["QUANTITY"]) + (dr["HQTY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["HQTY"]));
                        dr["H_HOUR"] = Convert.ToInt32(row["HOURS"]) + (dr["H_HOUR"] == DBNull.Value ? 0 : Convert.ToInt32(dr["H_HOUR"]));
                        break;
                }
            }

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["B_HOUR"] != DBNull.Value)
                    dr["B_HOUR"] = Convert.ToDouble(dr["B_HOUR"]) / Convert.ToDouble(dr["BLOT"]);
                if (dr["H_HOUR"] != DBNull.Value)
                    dr["H_HOUR"] = Convert.ToDouble(dr["H_HOUR"]) / Convert.ToDouble(dr["HLOT"]);

            }
        }

        void prepareHistory(DataSet ds, DataTable dt, DSTable dst)
        {
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DataRow dr;
                DataRow[] drs = dt.Select("STAGE='" + row["STAGE"].ToString() + "'");
                if (drs.Length == 0)
                {
                    dr = dt.NewRow();
                    dr["STAGE"] = row["STAGE"].ToString();
                    dt.Rows.Add(dr);
                }
                else
                    dr = drs[0];

                switch (row["ACTIVITY"].ToString())
                {
                    case "TrackOut":
                        dr["MLOT"] = Convert.ToInt32(row["COUNT"]) + (dr["MLOT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["MLOT"]));
                        dr["MQTY"] = Convert.ToInt32(row["QUANTITY"]) + (dr["MQTY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["MQTY"]));
                        break;
                    case "ScrapLot":
                        dr["SCRAP"] = Convert.ToInt32(row["QUANTITY"]) + (dr["SCRAP"] == DBNull.Value ? 0 : Convert.ToInt32(dr["SCRAP"]));
                        break;
                }
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
