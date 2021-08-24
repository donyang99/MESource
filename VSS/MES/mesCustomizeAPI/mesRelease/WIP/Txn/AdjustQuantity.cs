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
    public class AdjustQuantity : adjustQuantity<AdjustQuantity, Lot, LotHistory>
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
                CarrierTxn(serviceHost);
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

        void CarrierTxn(IMessageGuard serviceHost)
        {
            foreach (Lot lot in Items)
            {
                Dictionary<string, CAR.Carrier> orgCarrier = new Dictionary<string, CAR.Carrier>();
                foreach (CAR.Carrier c in CAR.Carrier.getCarriers("", 0, 0, "", lot.name, "", 0, 0))
                    orgCarrier.Add(c.name, c);

                CAR.Txn.UseCarrier useCar = new CAR.Txn.UseCarrier();
                useCar.txnUser = txnUser;
                useCar.checkTimeStamp = false;
                useCar.lotId = lot.name;
                useCar.mainTxnSysId = mainTxnSysId;

                CAR.Txn.AdjustCarrierQty adjCar = new CAR.Txn.AdjustCarrierQty();
                adjCar.txnUser = txnUser;
                adjCar.checkTimeStamp = false;
                adjCar.mainTxnSysId = mainTxnSysId;

                CAR.Txn.ReleaseCarrier relCar = new CAR.Txn.ReleaseCarrier();
                relCar.txnUser = txnUser;
                relCar.checkTimeStamp = false;
                relCar.mainTxnSysId = mainTxnSysId;

                foreach (CAR.Carrier c in lot.CarrierList)
                {
                    orgCarrier.Remove(c.name);
                    if (c.status == "IDLE" && c.componentQty != 0)
                        useCar.Add(c);
                    else
                    {
                        if (c.componentQty == 0)
                            relCar.Add(c);
                        else if (c.lotId == lot.name)
                            adjCar.Add(c);
                        else
                            useCar.Add(c);
                    }
                }

                int i = 0;
                while (i < lot.CarrierList.Count)
                {
                    if (lot.CarrierList[i].componentQty > 0)
                        i++;
                    else
                        lot.CarrierList.RemoveAt(i);
                }

                foreach (CAR.Carrier c in orgCarrier.Values)
                    relCar.Add(c);

                if (useCar.Count > 0)
                    useCar.doTxn(serviceHost);
                if (adjCar.Count > 0)
                    adjCar.doTxn(serviceHost);
                if (relCar.Count > 0)
                    relCar.doTxn(serviceHost);
            }
        }
    }
}
