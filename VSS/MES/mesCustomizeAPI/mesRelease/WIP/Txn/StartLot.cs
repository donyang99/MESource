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
    public class StartLot : startLot<StartLot, Lot, LotHistory>
    {
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            base.doTxn(serviceHost);
        }

        protected override void OnInit(Lot lot)
        {
            
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {
            
        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
            if (carrierList.Count > 0)
            {
                CAR.Txn.UseCarrier useCar = new CAR.Txn.UseCarrier();
                foreach (CAR.Carrier c in carrierList)
                    useCar.Add(c);
                useCar.txnUser = txnUser;
                useCar.checkTimeStamp = false;
                useCar.lotId = lotId;
                useCar.mainTxnSysId = mainTxnSysId;
                useCar.doTxn(serviceHost);
            }
            base.AfterTxn(serviceHost);

            Dictionary<string, WorkOrder> tmpOrderList = new Dictionary<string, WorkOrder>();
            foreach (Lot lot in Items)
            {
                if (lot.orderId != "")
                {
                    WorkOrder tmpOrder = null;
                    if (tmpOrderList.ContainsKey(lot.orderId))
                        tmpOrder = tmpOrderList[lot.orderId];
                    else
                    {
                        tmpOrder = new WorkOrder();
                        tmpOrder.name = lot.orderId;
                        tmpOrderList.Add(tmpOrder.name, tmpOrder);
                    }
                    tmpOrder.startQuantity += (int)lot.quantity;
                    tmpOrder.lotCount++;
                }
            }

            foreach (WorkOrder tmpOrder in tmpOrderList.Values)
            {
                WorkOrder order = new WorkOrder(tmpOrder.name);
                if (order.sysid != "")
                    order.UpdateLotCount(tmpOrder.lotCount, tmpOrder.startQuantity);
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

        protected override componentInfoBase generateComponentInfo(string lotId, short componentQty, string carrierId)
        {
            ComponentInfo info = new ComponentInfo();
            for (short i = 1; i <= componentQty; i++)
            {
                WipComponent c = new WipComponent();
                c.carrierId = carrierId;
                c.position = i;
                c.name = lotId + "-" + i.ToString("000");
                c.originalLot = lotId;
                info.Add(c);
            }
            info.createUser = txnUser;
            return info;
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

        protected override int carrierCount
        {
            get { return carrierList.Count; }
        }
        protected override idv.mesCore.CAR.carrierBase getCarrier(int index)
        {
            return carrierList[index];
        }
    }
}
