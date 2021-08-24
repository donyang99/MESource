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
    public class FinishLot : finishLot<FinishLot, Lot, LotHistory>
    {
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {

        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
            base.AfterTxn(serviceHost);

            //如果是FINH狀態，則ReleaseCarrier
            releaseCarrierTxn(serviceHost);
        }

        protected override void OnTxnError(Exception ex, ref bool handled)
        {
            base.OnTxnError(ex, ref handled);
        }

        public override void OnTxnSucceed()
        {
            base.OnTxnSucceed();
        }
        void releaseCarrierTxn(IMessageGuard serviceHost)
        {
            foreach (Lot lot in Items)
            {
                if (!lot.carrierId.Equals(""))
                {
                    lot.carrierId = "";
                    sqlTable table = new sqlTable("mes_wip_lot", eDMLtype.Update);
                    table.Add("carrier_id", "");
                    table.WhereClause.Add("sysid", lot.sysid);
                    sqlExecuter.executeSqlTable(table, serviceHost);
                }

                if (idv.mesCore.systemConfig.carrierManagement)
                {
                    CAR.Txn.ReleaseCarrier txn = new CAR.Txn.ReleaseCarrier();
                    txn.txnUser = txnUser;
                    txn.checkTimeStamp = false;
                    txn.mainTxnSysId = mainTxnSysId;
                    foreach (CAR.Carrier car in lot.CarrierList)
                        txn.Add(car);
                    if (txn.Count > 0)
                        txn.doTxn(serviceHost);
                }
            }
        }
    }
}
