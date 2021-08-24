using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.messageService;

namespace kanStepMove
{
    public partial class frmMain : Form
    {
        class moveInfo
        {
            Label _ctlEqpId = new Label();
            public Label ctlEqpId
            {
                get { return _ctlEqpId; }
                set { _ctlEqpId = value; }
            }
            public string eqpId
            {
                get { return _ctlEqpId.Text; }
                set { _ctlEqpId.Text = value; }
            }

            Label _ctlState = new Label();
            public Label ctlState
            {
                get { return _ctlState; }
                set { _ctlState = value; }
            }
            public string state
            {
                get { return _ctlState.Text; }
                set 
                { 
                    _ctlState.Text = value;
                    if (value.Equals("DOWN"))
                    {
                        _ctlState.BackColor = Color.Red;
                        _ctlState.ForeColor = Color.White;
                    }
                    else
                    {
                        _ctlState.BackColor = _ctlState.Parent.BackColor;
                        _ctlState.ForeColor = Color.DarkGreen;
                    }
                }
            }

            Label _ctlCount = new Label();
            public Label ctlCount
            {
                get { return _ctlCount; }
                set { _ctlCount = value; }
            }
            int _count = 0;
            public int count
            {
                get
                {
                    return _count;
                }
                set
                {
                    _count = value;
                    _ctlCount.Text = _count.ToString();
                }
            }

            Label _ctlQuantity = new Label();
            public Label ctlQuantity
            {
                get { return _ctlQuantity; }
                set { _ctlQuantity = value; }
            }
            double _quantity = 0;
            public double quantity
            {
                get
                {
                    return _quantity;
                }
                set
                {
                    _quantity = value;
                    _ctlQuantity.Text = ((int)_quantity).ToString();
                }
            }

            public moveInfo()
            {
                List<Label> list = new List<Label>();
                list.Add(_ctlEqpId);
                list.Add(_ctlState);
                list.Add(_ctlCount);
                list.Add(_ctlQuantity);

                foreach (Label lbl in list)
                {
                    lbl.Margin = new Padding(3, 0, 0, 0);
                    lbl.Padding = new Padding(0);
                    lbl.Anchor = AnchorStyles.Left;
                    lbl.AutoSize = true;
                }
                _ctlCount.BackColor = Color.Green;
                _ctlCount.ForeColor = Color.White;
                _ctlQuantity.BackColor = Color.Blue;
                _ctlQuantity.ForeColor = Color.White;
            }

            public void reset()
            {
                count = 0;
                quantity = 0;
            }
        }
        string fab = "";
        mesRelease.PRP.Step step = null;
        SortedDictionary<string, moveInfo> eqCurMove = new SortedDictionary<string, moveInfo>();
        DateTime curShift = DateTime.MinValue;//當前班別
        public frmMain()
        {
            InitializeComponent();
        }

        //看板載入時被呼叫
        internal void init(Dictionary<string, string> argus)
        {
            fab = argus["fab"];//取得執行參數
            step = new mesRelease.PRP.Step(argus["stepId"]);
            tblEqp.RowCount = 0;
            tblEqp.RowStyles.Clear();
            tblEqp.Controls.Clear();
            foreach (mesRelease.EQP.Equipment eq in mesRelease.EQP.EqGroup.GetEquipments(step.equipmentGroup, true))
            {
                if (eq.fab.Equals(fab))
                {
                    moveInfo info = new moveInfo();
                    tblEqp.RowCount += 1;
                    tblEqp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    Label lbl = new Label();
                    lbl.Tag = "equipmentId";
                    lbl.Anchor = AnchorStyles.Left;
                    lbl.Margin = new Padding(3, 3, 0, 3);
                    lbl.Padding = new Padding(0);
                    lbl.AutoSize = true;
                    tblEqp.Controls.Add(lbl, 0, tblEqp.RowCount - 1);
                    tblEqp.Controls.Add(info.ctlEqpId, 1, tblEqp.RowCount - 1);

                    lbl = new Label();
                    lbl.Tag = "state";
                    lbl.Anchor = AnchorStyles.Left;
                    lbl.Margin = new Padding(3, 3, 0, 3);
                    lbl.Padding = new Padding(0);
                    lbl.AutoSize = true;
                    tblEqp.Controls.Add(lbl, 2, tblEqp.RowCount - 1);
                    tblEqp.Controls.Add(info.ctlState, 3, tblEqp.RowCount - 1);

                    lbl = new Label();
                    lbl.Text = "LotCount";
                    lbl.Anchor = AnchorStyles.Left;
                    lbl.Margin = new Padding(3, 3, 0, 3);
                    lbl.Padding = new Padding(0);
                    lbl.AutoSize = true;
                    tblEqp.Controls.Add(lbl, 4, tblEqp.RowCount - 1);
                    tblEqp.Controls.Add(info.ctlCount, 5, tblEqp.RowCount - 1);

                    lbl = new Label();
                    lbl.Tag = "quantity";
                    lbl.Anchor = AnchorStyles.Left;
                    lbl.Margin = new Padding(3, 3, 0, 3);
                    lbl.Padding = new Padding(0);
                    lbl.AutoSize = true;
                    tblEqp.Controls.Add(lbl, 6, tblEqp.RowCount - 1);
                    tblEqp.Controls.Add(info.ctlQuantity, 7, tblEqp.RowCount - 1);
                    info.eqpId = eq.name;
                    info.state = eq.state;
                    eqCurMove[eq.name] = info;
                }
            }
            txtFab.Text = fab;
            txtStepId.Text = step.name;
            timerElapsed();
        }

        //MES有Lot, Equipment異動時被呼叫
        internal void processMessage(messageBase item)
        {
            if (item is mesRelease.EQP.Equipment)
            {
                mesRelease.EQP.Equipment eq = item as mesRelease.EQP.Equipment;
                if (eqCurMove.ContainsKey(eq.name))
                    eqCurMove[eq.name].state = eq.state;
            }
            else if (item is mesRelease.WIP.Lot)
            {
                mesRelease.WIP.Lot lot = item as mesRelease.WIP.Lot;
                if (lot.stepId.Equals(step.name) && lot.fab.Equals(fab) && eqCurMove.ContainsKey(lot.lastEquipmentId) && lot.txnName.Equals("TrackOut"))
                {
                    lock (eqCurMove)
                    {
                        getShiftDate();
                        moveInfo info = eqCurMove[lot.lastEquipmentId];
                        info.count++;
                        info.quantity += lot.quantity;
                        showInfo();
                    }
                }
            }
        }

        DateTime getShiftDate()//取得當前時間所屬班別
        {
            DateTime now = DateTime.Now;
            DateTime theShift = now;
            if (now.Hour < 8 && now.Minute < 30)//7點半前屬於前天晚班
            {
                theShift = theShift.AddDays(-1);
                theShift = new DateTime(theShift.Year, theShift.Month, theShift.Day, 19, 30, 0);
            }
            else if ((now.Hour >= 19 && now.Minute >= 30) || now.Hour > 20)
                theShift = new DateTime(theShift.Year, theShift.Month, theShift.Day, 19, 30, 0);
            else
                theShift = new DateTime(theShift.Year, theShift.Month, theShift.Day, 7, 30, 0);

            if (curShift != theShift)
            {
                foreach (moveInfo s in eqCurMove.Values)
                    s.reset();
                curShift = theShift;
                txtShift.Text = curShift.ToString();
            }
            return curShift;
        }

        //看板設定的更新時間到時被呼叫
        internal void timerElapsed()
        {
            lock (eqCurMove)
            {
                getShiftDate();

                string sql = "select  equipment_id,count(equipment_id) count,sum(quantity) quantity from mes_wip_lot_history " +
                             "where activity ='TrackOut' and fab=? and step_id=? and modify_date > ? " +
                             "group by equipment_id";
                sql = "select a.state,b.* from mes_eqp_equipment a join ( " + sql + " ) b on a.equipment_id=b.equipment_id";
                DataSet ds = serviceHost.Client.getDataSetWithParameter(sql, fab, step.name, curShift);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (!eqCurMove.ContainsKey(row["equipment_id"].ToString())) continue;
                    moveInfo info = eqCurMove[row["equipment_id"].ToString()];
                    info.eqpId = row["equipment_id"].ToString();
                    info.state = row["state"].ToString();

                    int tmp = 0;
                    int.TryParse(row["count"].ToString(), out tmp);
                    info.count = tmp;

                    double d = 0;
                    double.TryParse(row["quantity"].ToString(), out d);
                    info.quantity = d;
                }
                showInfo();
            }
        }

        void showInfo()
        {
            int count = 0;
            double qty = 0;
            foreach (string k in eqCurMove.Keys)
            {
                moveInfo info = eqCurMove[k];
                count += info.count;
                qty += info.quantity;
            }
            txtStepLotCount.Text = count.ToString();
            txtStepQuantity.Text = ((int)qty).ToString();
        }
    }
}
