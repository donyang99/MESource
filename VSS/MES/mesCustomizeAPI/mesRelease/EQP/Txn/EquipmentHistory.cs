using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.EQP.Txn;

namespace mesRelease.EQP.Txn
{
    public class EquipmentHistory : equipmentHistory<Equipment>
    {
        public override void OnSaveHistory(sqlTable executeSQL, IMessageGuard serviceHost)
        {
            
        }
    }
}
