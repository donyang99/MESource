using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.messageService;
using mesRelease.ALM;

namespace mesFABMonitor
{
    public partial class frmEqMonitor : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public delegate void delegateStateUpdate(string equipmentId, string fromState, string toState);
        public event delegateStateUpdate equipmentStateUpdated;
        private Image bkImage = null;

        private string _areaId = "";
        public string areaId
        {
            get { return _areaId; }
        }

        public frmEqMonitor()
        {
            InitializeComponent();
            pnlFAB.Location = new Point(2, 2);            
        }
        public frmEqMonitor(string areaId,string imageFile)
            : this()
        {
            this.Text = areaId;
            _areaId = areaId;
            try
            {
                bkImage = Image.FromFile(".\\img\\" + imageFile);
                pnlFAB.BackgroundImage = bkImage;
                pnlFAB.Size = bkImage.Size;                
            }
            catch 
            { }
            loadEquipments();
        }

        public void loadEquipments()
        {
            //IMessageGuard conn = serviceHost.Client;
            //string sql = "select a.area_id,b.pos_x,b.pos_y,b.width,b.height,b.graph_type ,c.* " +
            //             "from fms_area a join fms_area_equipment b on a.sysid=b.area_sysid " +
            //             "join mes_eqp_equipment c on b.equipment_sysid =c.sysid " +
            //             "where a.area_id='" + _areaId + "' and c.delete_flag='0'";
            try
            {
                //DataSet ds = conn.getDataSet(sql);
                DataSet ds = mesRelease.EQP.Equipment.getEquipmentDataSetForFabMonitor(_areaId);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    eqEntitiy ee = new eqEntitiy();
                    mesRelease.EQP.Equipment eq = new mesRelease.EQP.Equipment();
                    eq.putAttribute(dr, "");
                    ee.SetEquipment(eq);
                    try
                    {
                        ee.Location = new Point(int.Parse(dr["pos_x"].ToString()), int.Parse(dr["pos_y"].ToString()));
                    }
                    catch { }
                    try
                    {
                        ee.Size = new Size(int.Parse(dr["width"].ToString()), int.Parse(dr["height"].ToString()));
                    }
                    catch { }
                    ee.Name = ee.equipmentId;
                    pnlFAB.Controls.Add(ee);
                }
            }
            catch { }
        }

        public void OnEquipmentUpdate(mesRelease.EQP.Equipment eqp)
        {
            eqEntitiy ee = pnlFAB.Controls[eqp.name] as eqEntitiy;
            if (ee == null) return;
            if (ee.SetEquipment(eqp))
            {
                if (equipmentStateUpdated != null)
                    equipmentStateUpdated(ee.equipmentId, ee.previousState, ee.state);
            }
        }

        public void OnEqAlarmOccurred(AlarmMessage alarmMessage)
        {
            switch (alarmMessage.status)
            {
                case idv.mesCore.ALM.AlarmStatus.New: //new open
                    updateErrorInfo(alarmMessage);
                    break;
                case idv.mesCore.ALM.AlarmStatus.Clear:
                    removeErrorInfo(alarmMessage);
                    break;
                default:
                    updateErrorInfo(alarmMessage);
                    break;
            }
        }

        public void OnEqAlarmInfoRetrieved(AlarmMessage[] alarmMessages)
        {
            foreach (Control ctrl in pnlFAB.Controls)
            {
                eqEntitiy ee = ctrl as eqEntitiy;
                if (ee != null)
                    ee.clearErrorInfo();
            }
            foreach (AlarmMessage alarmMessage in alarmMessages)
                updateErrorInfo(alarmMessage);
            
        }

        private void removeErrorInfo(AlarmMessage alarmMessage)
        { 
            eqEntitiy ee = pnlFAB.Controls[alarmMessage.objectId] as eqEntitiy;
            if (ee != null)
            {
                ee.removeErrorInfo(alarmMessage.sysid);
            }
        }

        private void updateErrorInfo(AlarmMessage alarmMessage)
        {
            eqEntitiy ee = pnlFAB.Controls[alarmMessage.objectId] as eqEntitiy;
            if (ee != null)
            {
                eqEntitiy.errorInfo err = ee.getErrorInfo(alarmMessage.sysid);
                if (err == null)
                {
                    err = new eqEntitiy.errorInfo();
                    ee.addErrorInfo(err);                    
                }
                err.alarmInfo = alarmMessage;
            }
        }

        public void OnLotUpdate(mesRelease.WIP.Lot lot)
        {
            foreach (Control ctrl in pnlFAB.Controls)
            {
                eqEntitiy ee = ctrl as eqEntitiy;
                if (ee != null)
                {
                    ee.updateLotTrackInfo(lot);
                }
            }
        }

        public void OnLotTrackInEqRetrieved(System.Data.DataTable trackInfo)
        {
            string equipmentId = "";
            foreach (Control ctrl in pnlFAB.Controls)
            {
                eqEntitiy ee = ctrl as eqEntitiy;
                if (ee != null)
                {
                    ee.clearTrackInfo();
                }
            }

            foreach (DataRow dr in trackInfo.Rows)
            {
                if (dr["quantity"].ToString() == "0") continue;
                if (!mesRelease.WIP.Lot.IsWIPStatus(dr["status"].ToString())) continue;
                equipmentId = dr["equipment_id"].ToString();

                eqEntitiy ee = pnlFAB.Controls[equipmentId] as eqEntitiy;
                if (ee != null)
                {
                    eqEntitiy.trackInfo info = new eqEntitiy.trackInfo();
                    info.lotId = dr["lot_id"].ToString();
                    info.quantity = Convert.ToDouble(dr["quantity"]);
                    info.status = dr["status"].ToString();
                    info.trackInSysId = dr["track_in_sysid"].ToString();

                    try
                    {
                        if (dr["spec_sysid"].ToString() != "")
                        {
                            info.standardTime = mesFABMonitor.misc.GetStandardProcessTime(dr["spec_sysid"].ToString(), dr["step_id"].ToString());
                        }
                        info.trackInDate = (DateTime)dr["track_in_date"];
                        info.calcRemainTime();
                    }
                    catch { }
                    
                    ee.addTrackInfo(info);
                }
            }
        }

        public void OnMainFormNotice(string name, string message)
        {

        }

        private void mnuHideBGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem selMenu = sender as ToolStripMenuItem;
            if (selMenu == mnuHideBGToolStripMenuItem)
            {
                if (selMenu.Checked)
                {
                    selMenu.Checked = false;
                    pnlFAB.BackgroundImage = bkImage;
                }
                else
                {
                    selMenu.Checked = true;
                    pnlFAB.BackgroundImage = null;
                }
            }
        }

        public void refresh()
        {
            if (frmMain.includeLotInfo)
            {
                foreach (Control ctrl in pnlFAB.Controls)
                {
                    eqEntitiy ee = ctrl as eqEntitiy;
                    if (ee != null)
                        ee.refresh();
                }
            }
        }
    }
}
