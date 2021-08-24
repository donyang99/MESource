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
    public class ChangeProduct : changeProduct<ChangeProduct, Lot, LotHistory>
    {
        string _newOrderId = "";
        public string newOrderId
        {
            get { return _newOrderId; }
            set { _newOrderId = value; }
        }

        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        { 
            Dictionary<string, double> oldOrderStartQty = new Dictionary<string, double>();
            Dictionary<string, int> oldOrderLotCount = new Dictionary<string, int>();
            double newOrderStartQty = 0;
            int newOrderLotCount = 0;
            if (!newOrderId.Equals(""))
            {
                WorkOrder newOrder = new WorkOrder(newOrderId);
                if (newOrder.sysid.Equals(""))
                    throw new Exception("Order not found - " + newOrderId);
                foreach (Lot lot in Items)
                {
                    newOrderStartQty = newOrderStartQty + lot.quantity;//轉到新工單的量
                    newOrderLotCount++;//轉到新工單的批數

                    if (oldOrderStartQty.ContainsKey(lot.orderId))//原工單轉出量
                        oldOrderStartQty[lot.orderId] = oldOrderStartQty[lot.orderId] + lot.quantity;
                    else
                        oldOrderStartQty[lot.orderId] = lot.quantity;

                    if (oldOrderLotCount.ContainsKey(lot.orderId))//原工單轉出批數
                        oldOrderLotCount[lot.orderId] = oldOrderLotCount[lot.orderId] + 1;
                    else
                        oldOrderLotCount[lot.orderId] = 1;

                    //更新lot表資訊
                    sqlTable table = new sqlTable("mes_wip_lot", eDMLtype.Update);
                    table.Add("order_id", newOrderId);
                    table.Add("fab", newOrder.fab);
                    table.Add("order_type", newOrder.orderType);
                    table.WhereClause.Add("lot_id", lot.name);
                    executeSQL.Add(table);
                }
                //新工單
                sqlTable order = new sqlTable("mes_wip_order", eDMLtype.Update);
                order.WhereClause.Add("order_id", newOrderId);
                order.Add("start_quantity=start_quantity+" + ((int)newOrderStartQty).ToString(), null);
                order.Add("lot_count=lot_count+" + newOrderLotCount.ToString(), null);
                order.Add("modify_date", idv.messageService.serviceHost.dateTime);
                executeSQL.Add(order);

                //舊工單
                foreach (string orderId in oldOrderStartQty.Keys)
                {
                    order = new sqlTable("mes_wip_order", eDMLtype.Update);
                    order.WhereClause.Add("order_id", orderId);
                    order.Add("start_quantity=start_quantity-" + ((int)oldOrderStartQty[orderId]).ToString(), null);
                    order.Add("lot_count=lot_count-" + oldOrderLotCount[orderId].ToString(), null);
                    order.Add("modify_date", idv.messageService.serviceHost.dateTime);
                    executeSQL.Add(order);
                }
            }

            //拋ERP/WMS相關邏輯
        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
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

        protected override bool checkProductRouteStep
        {
            get
            {
                mesRelease.PRP.Route r = mesRelease.PRP.Route.GetRoute(routeId, routeVersion);
                if (r == null) return false;
                routeVersion = r.version;
                mesRelease.PRP.Step s = r.FindStep(stepHandle);
                if (s == null) return false;
                stepId = s.name;
                stepVersion = s.version;
                ruleId = s.Item(0).name;
                return true;
            }
        }

        public override string specSysId
        {
            get
            {
                if (!callByToMessage)
                {
                    if (base.specSysId == null)
                    {
                        if (specId == "")
                            base.specSysId = "";
                        else
                        {
                            PARM.ProductSpec spec = new PARM.ProductSpec(specId);
                            if (spec.sysid != "")
                                base.specSysId = spec.sysid;
                            else
                                return "";
                        }
                    }
                }
                return base.specSysId;
            }
            set
            {
                if (value != "")
                    base.specSysId = value;
            }
        }
    }
}
