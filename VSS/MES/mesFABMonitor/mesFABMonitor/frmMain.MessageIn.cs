using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using mesRelease.WF;
using mesRelease.WIP;
using mesRelease.EQP;
using mesRelease.ALM;

namespace mesFABMonitor
{
    public delegate void EquipmentUpdateHandler(mesRelease.EQP.Equipment eqp);
    public delegate void LotTrackInfoRetrievedHandler(System.Data.DataTable table);
    public delegate void LotUpdateHandler(mesRelease.WIP.Lot lot);
    public delegate void EqAlarmInfoRetrievedHandler(AlarmMessage[] alarmMessages);
    public delegate void EqAlarmOccurredHandler(AlarmMessage alarmMessage);
    partial class frmMain
	{
        public event EquipmentUpdateHandler EquipmentUpdate;
        public event LotTrackInfoRetrievedHandler LotTrackInfoRetrieved;
        public event LotUpdateHandler LotUpdate;
        public event EqAlarmInfoRetrievedHandler EqAlarmInfoRetrieved;
        public event EqAlarmOccurredHandler EqAlarmOccurred;

        void MessageIn(messageBase item)
        {
            messageInHandler handler = new messageInHandler(processMessageIn);
            handler.BeginInvoke(item, null, null);
        }

        delegate void messageInHandler(messageBase item);
        void processMessageIn(messageBase item)
        {
            if (item is AlarmMessage)
            {
                processAlarmMessage(item as AlarmMessage);
                return;
            }
            else if (item is serverCommand)
                processServerCommand(item as serverCommand);
            else if (item is WorkFlow)
                processWorkFlow(item as WorkFlow);
            else
            {
                if (item is Equipment)
                    processEquipmentUpdate(item as Equipment);
                else if (item is Lot)
                    processLotUpdated(item as Lot);
            }

            if (!(item is serverCommand))
            {
                item.To = "";
                item.serverFlag = false;
            }
        }

        void processEquipmentUpdate(Equipment eq)
        {
            if (EquipmentUpdate != null)
                EquipmentUpdate(eq);
        }

        void processLotUpdated(Lot lot)
        {
            if (LotUpdate != null)
                LotUpdate(lot);
        }

        void processAlarmMessage(AlarmMessage alarm)
        {
            if ("EqAbnormal,EqParmCheck".IndexOf(alarm.alarmType) == -1) return;
            if (EqAlarmOccurred != null)
                EqAlarmOccurred(alarm);

            if (lvwAlarmInfo != null)
            {
                if (alarm.status == idv.mesCore.ALM.AlarmStatus.Clear)
                    lvwAlarmInfo.RemoveMESItem(alarm);
                else
                {
                    lvwAlarmInfo.UpdateMESItem(alarm);
                    System.Windows.Forms.ListViewItem item = lvwAlarmInfo.Items[alarm.sysid];
                    if (item != null)
                    {
                        if (item.Selected)
                            item.Selected = false;
                        item.Selected = true;
                    }
                }
            }
        }

        void processServerCommand(serverCommand cmd)
        {
            serverCommandArgument arg = null;
            switch (cmd.name)
            {
                case "ping":
                    cmd.reply = "OK";
                    break;
                case "close":
                    arg = cmd.Item("exeName");
                    if (arg == null || arg.value.Equals("ALL") || arg.value.Equals(AppDomain.CurrentDomain.FriendlyName))
                        close();
                    break;
                case "restart":
                    arg = cmd.Item("exeName");
                    if (arg == null || arg.value.Equals("ALL") || arg.value.Equals(AppDomain.CurrentDomain.FriendlyName))
                    {
                        close();
                        System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.FriendlyName);
                    }
                    break;
            }

            if (cmd.requestReply)
            {
                cmd.requestReply = false;
                cmd.serverFlag = false;
                cmd.To = cmd.sender;
                cmd.sender = WorkFlow.ClientId;
                cmd.send();
            }
        }

        void processWorkFlow(WorkFlow wf)
        {
            try
            {
                List<idv.mesCore.WF.parameter> list = new List<idv.mesCore.WF.parameter>();
                foreach (KeyValuePair<string, string> entry in wf.Parameters)
                {
                    idv.mesCore.WF.parameter p = new idv.mesCore.WF.parameter();
                    p.key = entry.Key;
                    p.value = entry.Value;
                }
                if (wf.Count > 0)
                    WorkFlow.Dispatch(wf.Item(0) as Lot, list.ToArray());
            }
            catch { }
        }

        void close()
        {
            if (WorkFlow.isExecutingRule) return;
            System.Windows.Forms.Application.Exit();
        }


        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            retrieveAllAlarmInfo();
            retrieveLotTrackInfoAndEqAlarmInfo();            
        }
        void retrieveLotTrackInfoAndEqAlarmInfo()
        {
            serviceHost.suspendNotice = true;
            if (includeLotInfo)
            {
                string sql = "select a.*,b.track_in_date,b.track_in_qty,b.track_in_sysid from mes_wip_lot a join mes_wip_lot_tracking b " +
                                             " on a.lot_tracking_sysid=b.sysid where a.equipment_id is not null";
                System.Data.DataSet ds = serviceHost.Client.getDataSet(sql);
                if (LotTrackInfoRetrieved != null)
                    LotTrackInfoRetrieved(ds.Tables[0]);
            }
            if (includeEQAlarmInfo)
            {
                if (EqAlarmInfoRetrieved != null)
                {
                    List<AlarmMessage> list = new List<AlarmMessage>();
                    foreach (AlarmMessage item in lvwAlarmInfo.GetAllMESItem())
                        list.Add(item);
                    EqAlarmInfoRetrieved(list.ToArray());
                }
            }
            serviceHost.suspendNotice = false;
        }

        void retrieveAllAlarmInfo()
        {
            if (includeEQAlarmInfo)
            {
                serviceHost.suspendNotice = true;
                lvwAlarmInfo.RemoveAllMESItems();
                string types = "alarm_type in ('EqAbnormal','EqParmCheck')";
                KeyValuePair<string, object> condition = new KeyValuePair<string, object>(types, null);
                lvwAlarmInfo.ShowMESItems(AlarmMessage.GetActiveAlarmMessages(condition));
                serviceHost.suspendNotice = false;
            }
        }
	}
}
