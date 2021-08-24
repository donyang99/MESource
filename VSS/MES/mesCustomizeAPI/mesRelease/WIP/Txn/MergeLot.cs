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
    public class MergeLot : mergeLot<MergeLot, Lot, LotHistory>
    {
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            if (Count == 1)
            {
                Lot lot = Item(0);
                if(lot.status==LotStatus.RUN.ToString())
                    throw new Exception("lot can't execute merge when statis is RUN");//因為機台的used capacity會不符(除非作合理性因應)
                foreach (Lot mLot in mergedLot)
                {
                    if (lot.routeId != mLot.routeId || lot.GetCurrentStep().stepHandle != mLot.GetCurrentStep().stepHandle ||
                        lot.specId != mLot.specId || lot.orderId != mLot.orderId || lot.fab != mLot.fab || lot.status != mLot.status)
                        throw new Exception("Lot:" + mLot.name + " can't be merge");
                }
            }
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {

        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
            if (idv.mesCore.systemConfig.carrierManagement)
            {
                MergedLotCarrierTxn(serviceHost);
                MainLotCarrierTxn(serviceHost);
            }
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

        void MergedLotCarrierTxn(IMessageGuard serviceHost)
        {
            CAR.Txn.ReleaseCarrier relCar = new CAR.Txn.ReleaseCarrier();
            relCar.txnUser = txnUser;
            relCar.checkTimeStamp = false;
            relCar.mainTxnSysId = mainTxnSysId;
            foreach (Lot lot in mergedLot)
            {
                foreach (CAR.Carrier c in CAR.Carrier.getCarriers("", 0, 0, "", lot.name, "", 0, 0))
                    relCar.Add(c);
            }
            if (relCar.Count > 0)
            {
                relCar.doTxn(serviceHost);
                foreach (CAR.Carrier c in relCar.Items)
                    mergedLotReleaseCarrier.Add(c.name, c.lastTxnSysId);
            }
        }
        Dictionary<string, string> mergedLotReleaseCarrier = new Dictionary<string, string>();  //如果被併批 release的carrier是主批 use的carrier
        //carrier.lastTxnSysId就要assign到主批 use的carrier物件上
        void MainLotCarrierTxn(IMessageGuard serviceHost)
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
                    if (mergedLotReleaseCarrier.ContainsKey(c.name))
                        c.lastTxnSysId = mergedLotReleaseCarrier[c.name];

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
