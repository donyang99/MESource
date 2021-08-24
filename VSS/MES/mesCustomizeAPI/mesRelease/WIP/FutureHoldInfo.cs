using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.WIP;

namespace mesRelease.WIP
{
    public class FutureHoldInfo : futureHoldInfo<FutureHoldInfo>
    {
        protected override void OnNew(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnModify(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnDelete(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        internal new Lot targetLot
        {
            get { return base.targetLot as Lot; }
        }
    }
}
