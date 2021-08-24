using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.WIP;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.WIP.Txn;

namespace mesRelease.WIP.Txn
{
    public class TrackIn : trackIn<TrackIn, Lot, LotHistory>
    {
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            if (Equipment == null && !equipmentId.Equals(""))
                Equipment = new EQP.Equipment(equipmentId);
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {

        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
            equipmentTxn(serviceHost);

            if (idv.mesCore.systemConfig.carrierManagement)
                carrierTxn(serviceHost);

            base.AfterTxn(serviceHost);
        }

        protected override void OnTxnError(Exception ex, ref bool handled)
        {
            base.OnTxnError(ex, ref handled);
        }

        public override void OnTxnSucceed()
        {
            webApi = Type.GetType("WebApi.Instance, WebApiInstance");
            if (webApi != null)
                new System.Threading.Thread(sendMsgToDeviceMate).Start();

            if (changeCapacityTxn != null)
                publishTxn.Add(changeCapacityTxn);
            else if (publishEQP)
            {
                idv.mesCore.EQP.Txn.publishTxn pubTxn = new idv.mesCore.EQP.Txn.publishTxn();
                pubTxn.Add(Equipment);
                publishTxn.Add(pubTxn);
            }

            base.OnTxnSucceed();
        }

        Type webApi = null;
        void sendMsgToDeviceMate()
        {
            if (!System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "deviceMate.config")) return;
            string[] lines = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "deviceMate.config");
            string url = "";
            string token = "";
            bool txnFind = false;
            string apiName = "";
            string message = "";
            foreach (string s in lines)
            {
                if (s.StartsWith("url="))
                    url = s.Replace("url=", "");
                else if (s.StartsWith("token="))
                    token = s.Replace("token=", "");
                else if (s.StartsWith("txnName="))
                {
                    if (txnFind)
                        break;
                    else if (s.Equals("txnName=" + name))
                        txnFind = true;
                }
                else if (txnFind)
                {
                    if (s.StartsWith("webapiName="))
                        apiName = s.Replace("webapiName=", "");
                    else if (s.StartsWith("message="))
                        message = s.Replace("message=", "");
                }
            }
            url += "/" + apiName;
            foreach (Lot lot in Items)
            {
                string msg = message.Replace("{Sender}", "MES");
                msg = msg.Replace("{EqpId}", lot.equipmentId);
                msg = msg.Replace("{LotId}", lot.name);

                List<object> list = new List<object>();
                list.Add(url);
                list.Add(0);
                list.Add("message");
                list.Add(msg);
                list.Add("token");
                list.Add(token);
                webApi.InvokeMember("SendMessageToWebApi", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                       System.Reflection.BindingFlags.InvokeMethod, null, null, list.ToArray());
            }
        }

        public EQP.Equipment Equipment
        {
            get { return base.equipment as EQP.Equipment; }
            set { base.equipment = value; }
        }

        List<PRP.DCItem> _dcItemList = new List<PRP.DCItem>();
        public List<PRP.DCItem> dcItemList
        {
            get { return _dcItemList; }
            set { _dcItemList = value; }
        }
        protected override int dcItemCount
        {
            get { return dcItemList.Count; }
        }
        protected override idv.mesCore.PRP.dcItemBase getDCItem(int index)
        {
            return dcItemList[index];
        }

        EQP.Txn.ChangeCapacity changeCapacityTxn = null;

        void equipmentTxn(IMessageGuard serviceHost)
        {
            if (changeEqCapacity)
            {
                foreach (Lot lot in Items)
                {
                    changeCapacityTxn = new EQP.Txn.ChangeCapacity();
                    changeCapacityTxn.lotId = lot.name;
                    changeCapacityTxn.txnUser = txnUser;
                    changeCapacityTxn.mainTxnSysId = mainTxnSysId;
                    changeCapacityTxn.checkTimeStamp = false;
                    changeCapacityTxn.Add(Equipment);
                    if (Equipment.consumeType == idv.mesCore.EQP.EqConsumeType.ByLot)
                        changeCapacityTxn.capacityEffected = 1;
                    else
                        changeCapacityTxn.capacityEffected = (int)Math.Ceiling(lot.quantity);

                    changeCapacityTxn.doTxn(serviceHost);
                }
            }
        }

        void carrierTxn(IMessageGuard serviceHost)
        {
            //Carreier的ProcessStart Txn應該要留給EAP
            //CAR.Txn.ProcessStart processStartTxn = new CAR.Txn.ProcessStart();
            //processStartTxn.txnUser = txnUser;
            //processStartTxn.mainTxnSysId = mainTxnSysId;
            //processStartTxn.equipmentId = Equipment.name;
            //processStartTxn.checkTimeStamp = false;

            //foreach (Lot lot in Items)
            //{
            //    foreach (CAR.Carrier car in lot.CarrierList)
            //        processStartTxn.Add(car);
            //}

            //processStartTxn.doTxn(serviceHost);

            foreach (Lot lot in Items)
            {
                foreach (CAR.Carrier car in lot.CarrierList)
                {
                    sqlTable table = new sqlTable("mes_carrier_id", eDMLtype.Update);
                    table.Add("status", idv.mesCore.CAR.CarrierStatus.WPOC.ToString());
                    table.Add("modify_user", txnUser);
                    table.Add("modify_date", txnDate);
                    table.WhereClause.Add("sysid", car.sysid);
                    idv.messageService.sql.sqlExecuter.executeSqlTable(table, serviceHost);
                }
            }
        }
    }
}
