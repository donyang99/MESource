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
    public class CancelTrackIn:cancelTrackIn<CancelTrackIn,Lot,LotHistory>
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
            if (changeEqCapacity)
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
            if (txn != null)
                publishTxn.Add(txn);
            base.OnTxnSucceed();
        }

        mesRelease.EQP.Txn.ChangeCapacity txn = null;
        mesRelease.EQP.Equipment eq = null;
        void equipmentTxn(IMessageGuard serviceHost)
        {
            foreach (Lot lot in Items)
            {
                txn = new EQP.Txn.ChangeCapacity();
                txn.mainTxnSysId = mainTxnSysId;
                txn.txnUser = txnUser;
                txn.txnDate = txnDate;
                txn.checkTimeStamp = false;

                if (eq == null)
                {
                    eq = new EQP.Equipment(equipmentId);
                    if (eq.sysid == "") throw new Exception("Can't find equipment");
                }
                txn.Add(eq);
                if (eq.consumeType == idv.mesCore.EQP.EqConsumeType.ByComponentQty)
                    txn.capacityEffected = 0 - (int)Math.Ceiling(lot.quantity);
                else
                    txn.capacityEffected = -1;

                txn.doTxn(serviceHost);
            }
        }

        void carrierTxn(IMessageGuard serviceHost)
        {
            foreach (Lot lot in Items)
            {
                foreach (CAR.Carrier car in lot.CarrierList)
                {
                    sqlTable table = new sqlTable("mes_carrier_id", eDMLtype.Update);
                    table.Add("status", idv.mesCore.CAR.CarrierStatus.USED.ToString());
                    table.Add("modify_user", txnUser);
                    table.Add("modify_date", txnDate);
                    table.WhereClause.Add("sysid", car.sysid);
                    idv.messageService.sql.sqlExecuter.executeSqlTable(table, serviceHost);
                }
            }
        }
    }
}
