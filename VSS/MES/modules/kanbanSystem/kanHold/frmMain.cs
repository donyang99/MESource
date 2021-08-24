using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.messageService;

namespace kanHold
{
    public partial class frmMain : Form
    {
        string fab = "None";
        Dictionary<string, DataRow> dicHoldLot = new Dictionary<string, DataRow>();
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
            if (item is mesRelease.WIP.Lot)
            {
                mesRelease.WIP.Lot lot = item as mesRelease.WIP.Lot;
                if (!lot.fab.Equals(fab)) return;
                if (lot.status.Equals("HOLD"))
                {
                    if (!dicHoldLot.ContainsKey(lot.name))
                    {
                        string sql = "select a.*,b.comments from mes_wip_lot_hold_release a left join mes_txn_reason b on a.sysid=b.txn_sysid where a.lot_id=? and a.delete_flag=?";
                        foreach (DataRow row in serviceHost.Client.getDataSetWithParameter(sql, lot.name, "0").Tables[0].Rows)
                            dicHoldLot[row["lot_id"].ToString()] = row;
                    }
                }
                else
                    dicHoldLot.Remove(lot.name);
                showInfo();
            }
        }

        //看板設定的更新時間到時被呼叫
        internal void timerElapsed()
        {
            dicHoldLot.Clear();
            string sql = "select a.*,c.comments from mes_wip_lot_hold_release a join mes_wip_lot b on a.lot_id=b.lot_id " +
                         "left join mes_txn_reason c on a.sysid=c.txn_sysid " +
                         "where a.delete_flag=? and b.fab=?";
            foreach (DataRow row in serviceHost.Client.getDataSetWithParameter(sql, "0", fab).Tables[0].Rows)
                dicHoldLot[row["lot_id"].ToString()] = row;
            showInfo();
        }

        void showInfo()
        {
            lock (listView1)
            {
                txtHoldCount.Text = dicHoldLot.Count.ToString();
                listView1.Items.Clear();
                SortedList<DateTime, DataRow> srtList = new SortedList<DateTime, DataRow>();
                int isec = 0;
                foreach (DataRow row in dicHoldLot.Values)
                {
                    DateTime d = Convert.ToDateTime(row["hold_date"]);
                    while (srtList.ContainsKey(d.AddSeconds(isec)))
                        isec++;
                    srtList[d.AddSeconds(isec)] = row;
                }
                foreach (DataRow row in srtList.Values)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = row["lot_id"].ToString();
                    item.SubItems.Add(row["step_id"].ToString());
                    item.SubItems.Add(row["hold_reason"].ToString());
                    item.SubItems.Add(row["comments"].ToString());
                    item.SubItems.Add(row["hold_user"].ToString());
                    item.SubItems.Add(row["hold_date"].ToString());
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
                    double hour = (DateTime.Now - Convert.ToDateTime(row["hold_date"])).TotalHours;
                    item.SubItems[6].Text = Math.Round(hour, 2).ToString() + " (hour)";

                    if (hour > 24)
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
