using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.WIP.Txn;

namespace mesRelease.WIP.Txn
{
    public class LotHistory : lotHistory<Lot>
    {
        public override void OnSaveHistory(sqlTable executeSQL, IMessageGuard serviceHost)
        {

        }
    }
}
