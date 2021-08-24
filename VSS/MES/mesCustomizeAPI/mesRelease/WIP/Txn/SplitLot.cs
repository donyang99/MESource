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
    public class SplitLot : splitLot<SplitLot, Lot, LotHistory>
    {
        bool _allowStatusRUN = false; //For Scrap(Split and then Scrap)
        public bool allowStatusRUN
        {
            get { return _allowStatusRUN; }
            set { _allowStatusRUN = value; }
        }

        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            if (Count == 1)
            {
                Lot lot = Item(0);
                if (lot.status == LotStatus.RUN.ToString() && !allowStatusRUN)
                    throw new Exception("lot can't split when statis is RUN");//因為機台的used capacity會不符(除非作合理性因應)
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
                ParentLotCarrierTxn(serviceHost);
                ChildLotCarrierTxn(serviceHost);
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

        List<SplitLotInfo> _splitInfo = new List<SplitLotInfo>();
        public List<SplitLotInfo> splitInfo
        {
            get { return _splitInfo; }
            set { _splitInfo = value; }
        }

        protected override int splitInfoCount
        {
            get { return splitInfo.Count; }
        }

        protected override splitLotInfo<Lot> getSplitLotInfo(int index)
        {
            return splitInfo[index];
        }

        Dictionary<string, string> parentReleaseCarrier = new Dictionary<string, string>();  //如果parent release的carrier是child use的carrier
                                                                                             //carrier.lastTxnSysId就要assign到child use的carrier物件上
        void ParentLotCarrierTxn(IMessageGuard serviceHost)
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
                {
                    relCar.doTxn(serviceHost);
                    foreach (CAR.Carrier c in relCar.Items)
                        parentReleaseCarrier.Add(c.name, c.lastTxnSysId);
                }
            }
        }

        void ChildLotCarrierTxn(IMessageGuard serviceHost)
        {
            foreach (SplitLotInfo info in splitInfo)
            {
                if (info.carrierList.Count > 0)
                {
                    CAR.Txn.UseCarrier useCar = new CAR.Txn.UseCarrier();
                    useCar.txnUser = txnUser;
                    useCar.checkTimeStamp = false;
                    useCar.lotId = info.childLotId;
                    useCar.mainTxnSysId = mainTxnSysId;

                    foreach (CAR.Carrier c in info.carrierList)
                    {
                        if (parentReleaseCarrier.ContainsKey(c.name))
                            c.lastTxnSysId = parentReleaseCarrier[c.name];
                        useCar.Add(c);
                    }

                    useCar.doTxn(serviceHost);
                }
            }
        }
    }
}
