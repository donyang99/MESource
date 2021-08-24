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
    public class ScrapLot : scrapLot<ScrapLot, Lot, LotHistory>
    {
        bool _allowStatusRUN = false; //For Scrap(Split and then Scrap)
        public bool allowStatusRUN
        {
            get { return _allowStatusRUN; }
            set { _allowStatusRUN = value; }
        }

        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            if (quantity == 0)
            {
                foreach (lotBase lot in Items)
                {
                    if (!lot.equipmentId.Equals("") && !idv.mesCore.systemConfig.assemblyMode && !allowStatusRUN)//因為機台的used capacity會不符(除非作合理性因應)
                        throw new Exception("lot can't be scrapped when lot still in equipment");
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
                if (quantity == 0)
                    AllScrapCarrierTxn(serviceHost);
                else
                    PartialScrapCarrierTxn(serviceHost);
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

        ComponentInfo _componentInfo = null;
        public ComponentInfo componentInfo
        {
            get { return _componentInfo; }
            set { _componentInfo = value; }
        }

        protected override componentInfoBase getComponentInfo()
        {
            return componentInfo;
        }

        List<CAR.Carrier> _carrierList = new List<CAR.Carrier>();
        public List<CAR.Carrier> carrierList
        {
            get { return _carrierList; }
            set { _carrierList = value; }
        }

        public void AddCarrier(string name, int quantity)
        {
            CAR.Carrier car = new CAR.Carrier();
            car.name = name;
            car.componentQty = quantity;
            carrierList.Add(car);
        }

        protected override int carrierCount
        {
            get { return carrierList.Count; }
        }
        protected override idv.mesCore.CAR.carrierBase getCarrier(int index)
        {
            return carrierList[index];
        }

        void AllScrapCarrierTxn(IMessageGuard serviceHost)
        {
            CAR.Txn.ReleaseCarrier relCar = new CAR.Txn.ReleaseCarrier();
            relCar.txnUser = txnUser;
            relCar.checkTimeStamp = false;
            relCar.mainTxnSysId = mainTxnSysId;
            foreach (Lot lot in Items)
            {
                foreach (CAR.Carrier c in lot.CarrierList)
                    relCar.Add(c);
            }
            if (relCar.Count > 0)
                relCar.doTxn(serviceHost);
        }

        void PartialScrapCarrierTxn(IMessageGuard serviceHost)
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
