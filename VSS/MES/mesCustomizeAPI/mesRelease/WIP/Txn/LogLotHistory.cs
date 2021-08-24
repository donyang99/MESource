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
    public class LogLotHistory : logLotHistory<LogLotHistory, Lot, LotHistory>
    {
        DateTime start = DateTime.Now;
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {
            //foreach (sqlTable t in sqlExecuter.findTables(executeSQL, "mes_wip_lot_history"))
            //{
            //    //for (int i = 0; i < 10000; i++) 
            //    //{
            //    //    sqlTable t1 = new sqlTable(t.tableName, eDMLtype.Insert);
            //    //    executeSQL.Add(t1);
            //    //    foreach (sqlColumn c in t)
            //    //    {
            //    //        if (c.name.ToUpper().Equals("TXN_SYSID"))
            //    //            t1.Add(c.name, System.Guid.NewGuid().ToString());
            //    //        else
            //    //            t1.Add(c.name, c.value);
            //    //    }
            //    //}
            //    foreach (sqlColumn c in t)
            //    {
            //        object v = c.value;
            //        List<object> lst = new List<object>();
            //        for (int i = 0; i < 10000; i++)
            //        {
            //            if (c.name.ToUpper().Equals("TXN_SYSID"))
            //                lst.Add(System.Guid.NewGuid().ToString());
            //            else
            //                lst.Add(v);
            //        }
            //        c.value = lst.ToArray();
            //    }
            //}
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
            //TimeSpan ts = DateTime.Now - start;
            //Console.WriteLine(ts);
            base.OnTxnSucceed();
        }
    }
}
