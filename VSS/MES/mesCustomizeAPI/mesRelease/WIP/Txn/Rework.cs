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
    public class Rework:rework<Rework,Lot,LotHistory>
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
        }

        protected override void OnTxnError(Exception ex, ref bool handled)
        {
            base.OnTxnError(ex, ref handled);
        }

        public override void OnTxnSucceed()
        {
            base.OnTxnSucceed();
        }

        protected override bool checkRouteStep
        {
            get
            {
                mesRelease.PRP.Route r = mesRelease.PRP.Route.GetRoute(routeId, routeVersion);
                if (r == null) return false;
                mesRelease.PRP.Step s = r.FindStep(stepHandle);
                if (s == null) return false;
                stepId = s.name;
                stepVersion = s.version;
                ruleId = s.Item(0).name;
                return true;
            }
        }
    }
}
