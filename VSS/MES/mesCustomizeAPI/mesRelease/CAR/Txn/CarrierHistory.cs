using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.CAR.Txn;

namespace mesRelease.CAR.Txn
{
    public class CarrierHistory : carrierHistory<Carrier>
    {
        public override void OnSaveHistory(sqlTable executeSQL, IMessageGuard serviceHost)
        {
            
        }
    }
}
