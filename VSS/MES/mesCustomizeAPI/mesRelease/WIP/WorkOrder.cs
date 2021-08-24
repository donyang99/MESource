using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.WIP;

namespace mesRelease.WIP
{
    public class WorkOrder : workOrder<WorkOrder>
    {
        public WorkOrder() : base() { }
        public WorkOrder(string name) : base(name) { }

        protected override void OnNew(List<idv.messageService.sql.sqlTable> executeSQL)
        {
            
        }

        protected override void OnModify(List<idv.messageService.sql.sqlTable> executeSQL)
        {
            
        }

        protected override void OnDelete(List<idv.messageService.sql.sqlTable> executeSQL)
        {
            
        }

        public string NextLotId()
        {
            return name + "-" + (lotCount + 1).ToString("000");
        }
    }
}
