using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.TOL.Txn;
using System.Windows.Forms;
using idv.mesCore.TOL;

namespace mesRelease.TOL.Txn
{
    //location清空
    public class TxnEventLEND : TxnEvent
    {
        public override void doTxn(IMessageGuard serviceHost)
        {
            foreach (ToolingId id in Items)
                id.location = "";

            base.doTxn(serviceHost);
        }
    }
}
