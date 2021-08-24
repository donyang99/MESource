using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.EQP.Txn;

namespace mesRelease.EQP.Txn
{
    /// <summary>
    /// capacityEffected, lotId, reasonCode, txnUser, txnDate. 
    /// </summary>
    public class ChangeCapacity : changeCapacity<ChangeCapacity, Equipment, EquipmentHistory>
    {
        ChangeState changeStateTxn = null;
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            if (capacityEffected > 0)
            {
                changeStateTxn = new ChangeState();
                foreach (Equipment e in Items)
                {
                    if (e.state == "IDLE")
                        changeStateTxn.Add(e);
                }
                if (changeStateTxn.Count > 0)
                {
                    changeStateTxn.lotId = lotId;
                    changeStateTxn.mainTxnSysId = mainTxnSysId;
                    changeStateTxn.txnUser = txnUser;
                    changeStateTxn.txnDate = idv.messageService.serviceHost.dateTime.AddSeconds(-1);
                    changeStateTxn.state = "RUN";
                    changeStateTxn.doTxn(serviceHost);
                    changeStateTxn.OnTxnSucceed();
                }
                changeStateTxn = null;
            }
            else if (capacityEffected < 0)
            {
                changeStateTxn = new ChangeState();
                foreach (Equipment e in Items)
                {
                    if ((e.capacityUsed + capacityEffected) <= 0 && e.state == "RUN")
                        changeStateTxn.Add(e);
                }
                if (changeStateTxn.Count > 0)
                {
                    changeStateTxn.lotId = lotId;
                    changeStateTxn.mainTxnSysId = mainTxnSysId;
                    changeStateTxn.txnUser = txnUser;
                    changeStateTxn.txnDate = idv.messageService.serviceHost.dateTime.AddSeconds(1);
                    changeStateTxn.state = "IDLE";
                }
                else
                    changeStateTxn = null;
            }

            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {

        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
            base.AfterTxn(serviceHost);
            if (changeStateTxn != null)
            {
                changeStateTxn.doTxn(serviceHost);
                changeStateTxn.OnTxnSucceed();
            }
        }

        protected override void OnTxnError(Exception ex, ref bool handled)
        {
            base.OnTxnError(ex, ref handled);
        }

        public override void OnTxnSucceed()
        {
            base.OnTxnSucceed();
        }
    }
}
