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
    public class TerminateLot : terminateLot<TerminateLot, Lot, LotHistory>
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
            if (idv.mesCore.systemConfig.carrierManagement)
                releaseCarrier(serviceHost);
            base.AfterTxn(serviceHost);
        }

        protected override void OnTxnError(Exception ex, ref bool handled)
        {
            base.OnTxnError(ex, ref handled);
        }

        public override void OnTxnSucceed()
        {
            base.OnTxnSucceed();
        }

        void releaseCarrier(IMessageGuard serviceHost)
        {
            CAR.Txn.ReleaseCarrier relCar = new CAR.Txn.ReleaseCarrier();
            relCar.txnUser = txnUser;
            relCar.checkTimeStamp = false;
            relCar.mainTxnSysId = mainTxnSysId;

            foreach (Lot lot in Items)
            {
                foreach (CAR.Carrier car in CAR.Carrier.getCarriers("", 0, 0, "", lot.name, "", 0, 0))
                    relCar.Add(car);
            }

            if (relCar.Count > 0)
                relCar.doTxn(serviceHost);
        }
    }
}
