using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using idv.utilities;
using mesRelease.EQP;
using mesRelease.WIP;
using mesRelease.ALM;

namespace mesFABMonitor
{
    public partial class eqEntitiy : Label
    {
        public class errorInfo : Label
        {
            public errorInfo()
            {
                Random r = new Random();
                if (r.Next(2) == 1)
                    this.Dock = DockStyle.Left;
                else
                    this.Dock = DockStyle.Right;
                this.BackColor = Color.Red;
                this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }

            public string alarmId { get { return _alarmInfo.sysid; } }
            public string alarmType { get { return _alarmInfo.alarmType; } }
            public string message { get { return _alarmInfo.message; } }
            public string status { get { return _alarmInfo.status.ToString(); } }
            public string reasonCode { get { return _alarmInfo.reasonCode; } }
            public string comment { get { return _alarmInfo.comments; } }
            public DateTime createDate { get { return _alarmInfo.createDate; } }
            public string modifyUser { get { return _alarmInfo.modifyUser; } }
            public DateTime modifyDate { get { return _alarmInfo.modifyDate; } }
            public string groupHisKey { get { return _alarmInfo.groupHisKey; } }

            AlarmMessage _alarmInfo = null;
            public AlarmMessage alarmInfo
            {
                get { return _alarmInfo; }
                set
                {
                    _alarmInfo = value;
                    if (_alarmInfo.status == idv.mesCore.ALM.AlarmStatus.Action)
                        BackColor = Color.Yellow;
                    else
                        BackColor = Color.Red;
                }
            }
        }

        public class trackInfo : ProgressBar
        {
            public trackInfo()
            {
                this.Dock = DockStyle.Bottom;
                Click += new EventHandler(trackInfo_Click);
            }

            void trackInfo_Click(object sender, EventArgs e)
            {
                if (mesRelease.USR.User.loginUser != null)
                    mesRelease.WF.WorkFlow.ExecuteRule(new Lot(lotId), "LotProperty");
            }

            public string lotId { get; set; }
            public double quantity { get; set; }
            public string status { get; set; }
            public DateTime trackInDate { get; set; }
            public string trackInSysId { get; set; }
            public double standardTime { get; set; }//minute

            public int expectTime { get; set; }//預估生產花費時間
            public int passTime { get; set; }
            public int remainTime
            {
                get
                {
                    int _remainTime = expectTime - passTime;
                    if (_remainTime < 0) _remainTime = 0;
                    return _remainTime;
                }
            }

            public void calcRemainTime()
            {
                passTime = Convert.ToInt32((DateTime.Now - trackInDate).TotalMinutes);
                if (standardTime == 0 || trackInDate == DateTime.MinValue) return;
                try
                {
                    expectTime = Convert.ToInt32(standardTime * quantity);
                    Maximum = expectTime;
                    if (passTime > Maximum)
                        Value = Maximum;
                    else
                        Value = passTime;
                    if (Value == Maximum)
                        this.ForeColor = Color.Red;
                    else if ((Maximum - Value) < frmMain.lotWarningTime)
                        this.ForeColor = Color.Yellow;
                    else
                        this.ForeColor = Color.SeaGreen;
                }
                catch { }
            }
        }

        private List<errorInfo> _errorInfo = new List<errorInfo>();
        private List<trackInfo> _trackInfo = new List<trackInfo>();

        string _previousState = "";
        public string previousState
        {
            get { return _previousState; }           
        }
        Equipment _equipment = new Equipment();
        public Equipment equipment
        {
            get { return _equipment; }
        }

        public string equipmentId
        {
            get { return _equipment.name; }
        }
        public string equipmentType
        {
            get { return _equipment.type; }
        }
        public string state
        {
            get { return _equipment.state; }            
        }
        public string owner
        {
            get { return _equipment.owner; }
        }
        public DateTime modifyDate
        {
            get { return _equipment.modifyDate; }
        }

        #region for 跟form(control)不同thread不能加控制項
        private delegate void EditControlHandler(Control ctl);
        private void addControl(Control ctl)
        {
            Controls.Add(ctl);
        }
        private void removeControl(Control ctl)
        {
            Controls.Remove(ctl);
        }
        private void clearErrorInfoControl()
        {
            for (int i = 0; i < Controls.Count; )
            {
                errorInfo err = Controls[i] as errorInfo;
                if (err == null)
                    i++;
                else
                    Controls.RemoveAt(i);                
            }
        }
        private void clearTrackInfoControl()
        {
            for (int i = 0; i < Controls.Count; )
            {
                trackInfo info = Controls[i] as trackInfo;
                if (info == null)
                    i++;
                else
                    Controls.RemoveAt(i);
            }
        }
        #endregion

        public eqEntitiy()
        {
            InitializeComponent();
            MouseEnter +=new EventHandler(eqEntitiy_MouseEnter);
            TextAlign = ContentAlignment.TopCenter;
        }

        public bool SetEquipment(Equipment eqp)
        {
            if (_equipment.modifyDate == eqp.modifyDate)
                return false;
            else
            {
                _previousState = _equipment.state;
                _equipment = eqp;
                if (Text != _equipment.name)
                    Text = _equipment.name;
                try
                {
                    BackColor = frmMain.stateColor[_equipment.state];
                    //讓字型顏色跟背景顏色為互補色
                    ForeColor = Color.FromArgb(255 - this.BackColor.R, 255 - this.BackColor.G, 255 - this.BackColor.B);
                }
                catch { }
                return true;
            }
        }

        public void addErrorInfo(errorInfo err)
        {
            Invoke(new EditControlHandler(addControl), err);
            _errorInfo.Add(err);
            err.Width = 7;
            err.MouseEnter += new EventHandler(err_MouseEnter);
        }

        public void addTrackInfo(trackInfo info)
        {
            Invoke(new EditControlHandler(addControl), info);
            _trackInfo.Add(info);
            info.Height = Height / 8;
            if (info.Height < 6) info.Height = 6;
            info.BackColor = SystemColors.Control;
            info.MouseEnter += new EventHandler(trackInfo_MouseEnter);
        }

        public void clearErrorInfo()
        {
            if (_errorInfo.Count == 0) return;
            Invoke(new MethodInvoker(clearErrorInfoControl));
            _errorInfo.Clear();
        }

        public void clearTrackInfo()
        {
            if (_trackInfo.Count == 0) return;
            Invoke(new MethodInvoker(clearTrackInfoControl));
            _trackInfo.Clear();
        }

        public void removeErrorInfo(string alarmId)
        {
            try
            {
                errorInfo er = null;
                foreach (errorInfo err in _errorInfo)
                {
                    if (err.alarmId == alarmId)
                    {
                        Invoke(new EditControlHandler(removeControl), err);
                        er = err;
                        break;
                    }
                }
                if (er != null)
                    _errorInfo.Remove(er);
            }
            catch { }
        }

        public errorInfo getErrorInfo(string alarmId)
        {
            foreach (errorInfo err in _errorInfo)
            {
                if (err.alarmId == alarmId)
                {
                    return err;
                }
            }
            return null;
        }

        public void removeTrackInfo(string lotId)
        {
            trackInfo tr = null;
            foreach (trackInfo info in _trackInfo)
            {
                if (info.lotId == lotId)
                {
                    Invoke(new EditControlHandler(removeControl), info);
                    tr = info;                    
                    break;
                }
            }
            if (tr != null)
                _trackInfo.Remove(tr);
        }

        public trackInfo getTrackInfo(string lotId)
        {
            foreach (trackInfo info in _trackInfo)
            {
                if (info.lotId == lotId)
                {
                    return info;
                }
            }
            return null;
        }

        public void updateLotTrackInfo(Lot lot)
        {
            if (lot.equipmentId != "")
            {
                if (lot.equipmentId != equipmentId || lot.quantity == 0 || !lot.IsWIPStatus()) return;
                trackInfo tif = getTrackInfo(lot.name);
                if (tif == null)
                {
                    trackInfo info = new trackInfo();
                    info.lotId = lot.name;
                    info.quantity = lot.quantity;
                    info.status = lot.status;
                    info.trackInSysId = lot.GetLotTrackingInfo().trackInSysId;

                    try
                    {
                        if (lot.specSysId != "")
                        {
                            info.standardTime = mesFABMonitor.misc.GetStandardProcessTime(lot.specSysId, lot.stepId);
                        }
                        info.trackInDate = lot.GetLotTrackingInfo().trackInDate;
                        info.calcRemainTime();
                    }
                    catch { }

                    addTrackInfo(info);
                }
                else
                {
                    tif.quantity = lot.quantity;
                    tif.status = lot.status;
                }
            }
            else
            {
                if (lot.lastEquipmentId == equipmentId)
                    removeTrackInfo(lot.name);
            }
        }

        void err_MouseEnter(object sender, EventArgs e)
        {            
            errorInfo err = sender as errorInfo;
            if (err != null)
            {
                string msg = cultureLanguage.getValue("alarmType") + " :" + err.alarmType + Environment.NewLine +
                             cultureLanguage.getValue("message") + " :" + err.message + Environment.NewLine +
                             cultureLanguage.getValue("status") + " :" + err.status.ToString() + Environment.NewLine +
                             cultureLanguage.getValue("reasonCode") + " :" + err.reasonCode;

                if (err.comment != "")
                    msg += Environment.NewLine + cultureLanguage.getValue("comments") + " :" + err.comment;
                toolTip1.SetToolTip(err, msg);
            }
        }

        void trackInfo_MouseEnter(object sender, EventArgs e)
        {
            trackInfo info = sender as trackInfo;
            if (info != null)
            {
                string msg = cultureLanguage.getValue("lotId") + " :" + info.lotId + Environment.NewLine +
                             cultureLanguage.getValue("status") + " :" + info.status.ToString() + Environment.NewLine +
                             cultureLanguage.getValue("quantity") + " :" + info.quantity.ToString() + Environment.NewLine +
                             cultureLanguage.getValue("trackInDate") + " :" + info.trackInDate.ToString() + Environment.NewLine +
                             cultureLanguage.getValue("processTime") + " :" + new TimeSpan(0, info.passTime, 0).ToString();
                if (info.standardTime != 0)
                    msg += Environment.NewLine + cultureLanguage.getValue("remainTime") + " :" + new TimeSpan(0, info.remainTime, 0).ToString();
                toolTip1.SetToolTip(info, msg);
            }
        }

        void eqEntitiy_MouseEnter(object sender, EventArgs e)
        {
            string msg = this.equipmentId + Environment.NewLine +
                       cultureLanguage.getValue("state") + " :" + state;
            if (_errorInfo.Count > 0)
                msg += Environment.NewLine + cultureLanguage.getValue("alarm") + " :" + _errorInfo.Count.ToString();
            if (_trackInfo.Count > 0)
                msg += Environment.NewLine + cultureLanguage.getValue("lotId") + " :" + _trackInfo.Count.ToString();
            toolTip1.SetToolTip(this, msg);
        }

        private void eqEntitiy_DoubleClick(object sender, EventArgs e)
        {
            if (mesRelease.USR.User.loginUser != null)
                mesRelease.WF.WorkFlow.ExecuteRule(_equipment, "EqProperty");
        }

        public void refresh()
        {
            foreach (trackInfo info in _trackInfo)
                info.calcRemainTime();
        }
    }    
}
