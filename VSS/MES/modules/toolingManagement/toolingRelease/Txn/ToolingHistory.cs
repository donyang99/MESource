using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.TOL.Txn;

namespace mesRelease.TOL.Txn
{
    public class ToolingHistory : toolingHistory<ToolingId>
    {
        public override void OnSaveHistory(sqlTable executeSQL, IMessageGuard serviceHost)
        {

        }
    }
}
