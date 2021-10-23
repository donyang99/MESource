using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore;
using idv.mesCore.TOL;

namespace mesRelease.TOL
{
    public class ToolingId : toolingId<ToolingId>
    {
        public ToolingId() : base() { }
        public ToolingId(string name) : base(name) { }

        protected override void OnInit(System.Data.DataRow row)
        {
            base.OnInit(row);
        }

        protected override void OnNew(List<sqlTable> sqlList)
        {
            base.OnNew(sqlList);
        }

        protected override void OnModify(List<sqlTable> sqlList)
        {
            Txn.ToolingHistory his = new Txn.ToolingHistory();
            his.mainTxnSysId = System.Guid.NewGuid().ToString();
            his.eventName = "MODIFY";
            his.item = this;
            his.saveHistory(sqlList, serviceHost.Client);
        }

        protected override void OnDelete(List<sqlTable> sqlList)
        {
            base.OnDelete(sqlList);
        }
    }
}
