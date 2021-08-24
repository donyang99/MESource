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

namespace ClientRule.EQPerformance
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
            doQuery();
        }

        DataSet dsLotHistory = null;
        void doQuery()
        {            
            try
            {
                Thread t = new Thread(new ThreadStart(getLotHistory));
                t.Start();

                string sql = "select /*+rule*/a.equipment_id,b.state fromState,a.state,a.activity,a.fab,a.modify_date from mes_eqp_history a " +
                             "join mes_eqp_history b on a.last_change_state=b.txn_sysid " +
                              "where a.activity='ChangeState' and a.modify_date between ? and ? ";

                if (cboFAB.Text != "")
                    sql += "and a.fab='" + cboFAB.Text + "' ";

                if (cboStep.Text != "")
                {
                    sql += "and a.equipment_id in (select c.equipment_id from mes_prp_step a join mes_eqp_group_link b on a.equipment_group=b.equipment_group " +
                            "join mes_eqp_equipment c on b.equipment_sysid=c.sysid where  a.step_id='" + cboStep.Text + "')";
                }

                sql += " order by a.equipment_id,a.modify_date";
                DataSet ds = serviceHost.Client.getDataSetWithParameter(sql, dtFrom.Value, dtTo.Value);

                DataTable dt = new DataTable(); DSTable dst = new DSTable();
                prepareEQP(ds, dt, dst);

                t.Join();

                prepareHistory(dsLotHistory, dt, dst);

                dst.FooterEnable = true;

                StringBuilder html = new StringBuilder();
                html.AppendLine("<html>").AppendLine("<title></title>").AppendLine("<head></head>").AppendLine("<body>");
                html.AppendLine("<center>").AppendLine ("<h2>EQP Performance Report</h2>");
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

        void getLotHistory()
        {
            try
            {
                dsLotHistory = null;
                string sql = "select /*+rule*/a.equipment_id,sum(a.quantity) quantity " +
                             "from mes_wip_lot_history a join mes_eqp_equipment b on a.equipment_id=b.equipment_id and a.activity='TrackOut' and b.issue_state='Active' " +
                             "where a.modify_date between ? and ? ";

                if (cboFAB.Text != "")
                    sql += "and b.fab='" + cboFAB.Text + "' ";

                if (cboStep.Text != "")
                {
                    sql += "and b.sysid in(select b.equipment_sysid from mes_prp_step a " +
                           "join mes_eqp_group_link b on a.equipment_group=b.equipment_group " +
                           "where  a.step_id='" + cboStep.Text + "')";
                }

                sql += " group by a.equipment_id";

                IMessageGuard client = serviceHost.IsolationClient;

                dsLotHistory = client.getDataSetWithParameter(sql, dtFrom.Value, dtTo.Value);

                dsLotHistory.Tables[0].Constraints.Add("PK", dsLotHistory.Tables[0].Columns["equipment_id"], true);
            }
            catch { }
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

            dt.Columns.Add("MOVE", typeof(int)); 
            dst.AddColumn(0, "MOVE");
            dst.AddColumnSetting(new ColumnSetting(100, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}", "MOVE"), true);
            
            dt.Columns.Add("WPH", typeof(int)); 
            dst.AddColumn(0, "WPH");
            dst.AddColumnSetting(new ColumnSetting(100, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0}", "WPH"), true);

            State[] states = State.GetStates();
            foreach (mesRelease.EQP.State state in states)
            {
                if (!state.available) continue;
                dt.Columns.Add(state.name, typeof(double));
                dst.AddColumn(0, state.name);
                ColumnSetting cs = new ColumnSetting(70, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0.00}", state.name);
                dst.AddColumnSetting(cs, true);
            }
            foreach (mesRelease.EQP.State state in states)
            {
                if (state.available) continue;
                dt.Columns.Add(state.name, typeof(double));
                dst.AddColumn(0, state.name);
                ColumnSetting cs = new ColumnSetting(70, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0.00}", state.name);
                cs.CaptionBackColor = System.Drawing.Color.Pink;
                dst.AddColumnSetting(cs, true);
            }

            dt.Columns.Add("Avail", typeof(double));
            dst.AddColumn(0, "Avail(%)");
            dst.AddColumnSetting(new ColumnSetting(100, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0.00}", "Avail"), false);

            dt.Columns.Add("Non-Avail", typeof(double));
            dst.AddColumn(0, "Non-Avail(%)");
            ColumnSetting c = new ColumnSetting(100, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0.00}", "Non-Avail");
            c.CaptionBackColor = System.Drawing.Color.Pink;
            dst.AddColumnSetting(c, false);

            //Utilization
            dt.Columns.Add("Utilization", typeof(double));
            dst.AddColumn(0, "Utilization(%)");
            dst.AddColumnSetting(new ColumnSetting(100, HorizontalAlign.Right, HorizontalAlign.Center, "{0:#,0.00}", "Utilization"), false);

            dt.Columns.Add("CREATE_DATE", typeof(DateTime));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Center, HorizontalAlign.Center, "", "CREATE_DATE"), true).DisplayFlag = false;//不顯示
            dt.Columns.Add("TOTALHOUR", typeof(double));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Center, HorizontalAlign.Center, "", "TOTALHOUR"), true).DisplayFlag = false;//不顯示
            dt.Columns.Add("AVAILHOUR", typeof(double));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Center, HorizontalAlign.Center, "", "AVAILHOUR"), true).DisplayFlag = false;//不顯示
            dt.Columns.Add("NON-AVAILHOUR", typeof(double));
            dst.AddColumnSetting(new ColumnSetting(0, HorizontalAlign.Center, HorizontalAlign.Center, "", "NON-AVAILHOUR"), true).DisplayFlag = false;//不顯示

            dt.Constraints.Add("PK", dt.Columns["EQPID"], true);
            #endregion
            //FAB, EQPID, MOVE, WPH, [STATE...], Avail, Non-Avail

            //取得所有機台
            string sql = "select fab,equipment_id,state,create_date from mes_eqp_equipment where issue_state='Active'";
            if (cboFAB.Text != "")
                sql += " and fab='" + cboFAB.Text + "'";
            if (cboStep.Text != "")
                sql += " and sysid in (select b.equipment_sysid from mes_prp_step a join mes_eqp_group_link b " +
                       "on a.equipment_group=b.equipment_group where a.step_id='" + cboStep.Text + "')";
            sql += " order by equipment_id";            
            DataSet dsEquipment = serviceHost.Client.getDataSet(sql);
            foreach (DataRow rowEQ in dsEquipment.Tables[0].Rows)
            {   //先把所有機台資料放到Table裏
                DataRow dr = dt.NewRow();
                dr["FAB"] = rowEQ["fab"].ToString();
                dr["EQPID"] = rowEQ["equipment_id"].ToString();
                dr["CREATE_DATE"] = (DateTime)rowEQ["create_date"];
                dt.Rows.Add(dr);
            }

            //取得大於查詢時間的交易機台狀態
            sql = "select a.equipment_id,a.state from mes_eqp_history a join " +
                  "(select /*+rule*/equipment_id,max(modify_date) modify_date from mes_eqp_history " +
                  "where modify_date < ? and activity ='ChangeState' group by equipment_id) b on a.equipment_id=b.equipment_id and a.modify_date=b.modify_date where 1=1";
            if (cboFAB.Text != "")
                sql += " and a.fab='" + cboFAB.Text + "'";
            if (cboStep.Text != "")
            {
                sql += " and a.equipment_id in (select c.equipment_id from mes_prp_step a join mes_eqp_group_link b on a.equipment_group=b.equipment_group " +
                       "join mes_eqp_equipment c on b.equipment_sysid=c.sysid where  a.step_id='" + cboStep.Text + "')";
            }
            dsEquipment = serviceHost.Client.getDataSetWithParameter(sql,dtFrom.Value);

            //開始算各狀態時間 (dt(Table)報表要顯示的內容，ds(DataSet)機台狀態轉換歷史記錄，dsEquipment(DataSet)機台(查詢時間前)最後的狀態轉換記錄
            foreach (DataRow dr in dt.Rows)
            {
                DateTime startDate = dtFrom.Value > (DateTime)dr["CREATE_DATE"] ? dtFrom.Value : (DateTime)dr["CREATE_DATE"];
                DateTime toDate = dtTo.Value > DateTime.Now ? DateTime.Now : dtTo.Value;

                stateTime.Clear();
                string state = "";
                foreach (DataRow row in ds.Tables[0].Select("equipment_id='" + dr["EQPID"].ToString() + "'"))
                {
                    putStateTime(row["fromstate"].ToString(), (DateTime)row["modify_date"] - startDate);
                    startDate = (DateTime)row["modify_date"];
                    state = row["state"].ToString();
                }
                if (state != "")
                    putStateTime(state, toDate - startDate);
                else
                { //(查詢期間內)沒有任何轉換狀態的交易記錄，找小於查詢期間最後一筆轉換狀態交易記錄，即查詢區間時間全部都屬於該狀態
                    DataRow[] drs = dsEquipment.Tables[0].Select("equipment_id='" + dr["EQPID"].ToString() + "'");
                    if (drs.Length != 0)
                        putStateTime(drs[0]["state"].ToString(), toDate - startDate);
                }

                //開始計算各狀態時間、比率
                if (stateTime.Count > 0)
                {
                    double availHour = 0, nonAvailHour = 0;
                    foreach (KeyValuePair<string, TimeSpan> kv in stateTime)
                    {
                        dr[kv.Key] = kv.Value.TotalHours;
                        if (State.GetState(kv.Key).available)
                            availHour += kv.Value.TotalHours;
                        else
                            nonAvailHour += kv.Value.TotalHours;
                    }
                    dr["Avail"] = (availHour / (availHour + nonAvailHour)) * 100;
                    dr["Non-Avail"] = (nonAvailHour / (availHour + nonAvailHour)) * 100;                    
                    dr["TOTALHOUR"] = availHour + nonAvailHour;
                    dr["AVAILHOUR"] = availHour;
                    dr["NON-AVAILHOUR"] = nonAvailHour;
                    if (dr["RUN"] != DBNull.Value)
                        dr["Utilization"] = (Convert.ToDouble(dr["RUN"]) / (availHour + nonAvailHour)) * 100;
                }
            }
        }
        Dictionary<string, TimeSpan> stateTime = new Dictionary<string, TimeSpan>();
        void putStateTime(string state, TimeSpan time)
        {
            if (stateTime.ContainsKey(state))
            {
                stateTime[state] += time;
            }
            else
                stateTime.Add(state, time);
        }

        void prepareHistory(DataSet ds, DataTable dt, DSTable dst)
        {
            foreach (DataRow row in dt.Rows)
            {
                DataRow drMove = ds.Tables[0].Rows.Find(row["EQPID"].ToString());
                if (drMove == null) continue;
                row["MOVE"] = drMove["quantity"];
                if (row["TOTALHOUR"] != DBNull.Value)
                    row["WPH"] = (int)(Convert.ToDouble(drMove["quantity"]) / Convert.ToDouble(row["TOTALHOUR"]));
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
