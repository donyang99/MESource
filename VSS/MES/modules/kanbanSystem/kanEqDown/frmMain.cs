using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.messageService;

namespace kanEqDown
{
    public partial class frmMain : Form
    {
        string fab = "None";
        Dictionary<string, DataRow> dicItems = new Dictionary<string, DataRow>();
        public frmMain()
        {
            InitializeComponent();
        }

        //看板載入時被呼叫
        internal void init(Dictionary<string, string> argus)
        {
            //取得執行參數
            if (argus.ContainsKey("fab"))
                fab = argus["fab"];
            txtFab.Text = fab;
            listView1.Columns[0].Width = 250;
            listView1.Columns[1].Width = 200;
            listView1.Columns[2].Width = 200;
            listView1.Columns[3].Width = 350;
            listView1.Columns[4].Width = 200;
            listView1.Columns[5].Width = 300;
            listView1.Columns[6].Width = 200;
            timerElapsed();
        }

        //MES有Lot, Equipment異動時被呼叫
        internal void processMessage(messageBase item)
        {
            if (item is mesRelease.EQP.Equipment)
            {
                mesRelease.EQP.Equipment eqp = item as mesRelease.EQP.Equipment;
                if (!eqp.fab.Equals(fab)) return;
                if (eqp.state.Equals("DOWN"))
                {
                    if (!dicItems.ContainsKey(eqp.name))
                    {
                        string sql = "select a.equipment_id,a.state,c.reason_code,c.comments,b.modify_user,b.modify_date " +
                                     "from mes_eqp_equipment a left join mes_eqp_history b on a.last_change_state=b.txn_sysid left join mes_txn_reason c on a.last_change_state=c.txn_sysid " +
                                     "where a.equipment_id=?";
                        foreach (DataRow row in serviceHost.Client.getDataSetWithParameter(sql, eqp.name).Tables[0].Rows)
                            dicItems[row["equipment_id"].ToString()] = row;
                    }
                }
                else
                    dicItems.Remove(eqp.name);
                showInfo();
            }
        }

        //看板設定的更新時間到時被呼叫
        internal void timerElapsed()
        {
            dicItems.Clear();
            string sql = "select a.equipment_id,a.state,c.reason_code,c.comments,b.modify_user,b.modify_date " +
                         "from mes_eqp_equipment a left join mes_eqp_history b on a.last_change_state=b.txn_sysid left join mes_txn_reason c on a.last_change_state=c.txn_sysid " +
                         "where a.fab=? and a.state=?";
            foreach (DataRow row in serviceHost.Client.getDataSetWithParameter(sql, fab, "DOWN").Tables[0].Rows)
                dicItems[row["equipment_id"].ToString()] = row;
            showInfo();
        }

        void showInfo()
        {
            lock (listView1)
            {
                txtHoldCount.Text = dicItems.Count.ToString();
                listView1.Items.Clear();
                SortedList<DateTime, DataRow> srtList = new SortedList<DateTime, DataRow>();
                int isec = 0;
                foreach (DataRow row in dicItems.Values)
                {
                    DateTime d = Convert.ToDateTime(row["modify_date"]);
                    while (srtList.ContainsKey(d.AddSeconds(isec)))
                        isec++;
                    srtList[d.AddSeconds(isec)] = row;
                }
                foreach (DataRow row in srtList.Values)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = row["equipment_id"].ToString();
                    item.SubItems.Add(row["state"].ToString());
                    item.SubItems.Add(row["reason_code"].ToString());
                    item.SubItems.Add(row["comments"].ToString());
                    item.SubItems.Add(row["modify_user"].ToString());
                    item.SubItems.Add(row["modify_date"].ToString());
                    item.SubItems.Add("");//持續時間
                    item.Tag = row;
                    item.UseItemStyleForSubItems = true;
                    listView1.Items.Add(item);
                }
                if (listView1.Items.Count > 0)
                    showLastTime();
            }
        }

        System.Timers.Timer tLastTime = null;
        void showLastTime()
        {
            if (tLastTime == null)
            {
                tLastTime = new System.Timers.Timer(60000);
                tLastTime.Elapsed += new System.Timers.ElapsedEventHandler(tLastTime_Elapsed);
                tLastTime.Start();
            }
            
            lock (listView1)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    DataRow row = item.Tag as DataRow;
                    double hour = (DateTime.Now - Convert.ToDateTime(row["modify_date"])).TotalHours;
                    item.SubItems[6].Text = Math.Round(hour, 2).ToString() + " (hour)";

                    if (hour > 1)
                    {
                        item.ForeColor = Color.White;
                        item.BackColor = Color.Red;
                    }
                    else
                    {
                        item.ForeColor = Color.Black;
                        item.BackColor = Color.LightYellow;
                    }
                }
            }
        }

        void tLastTime_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            showLastTime();
        }
    }
}
