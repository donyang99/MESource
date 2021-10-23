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
    public class ToolingEvent : toolingEvent<ToolingEvent>
    {
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
            base.OnModify(sqlList);
        }

        protected override void OnDelete(List<sqlTable> sqlList)
        {
            base.OnDelete(sqlList);
        }
    }
}
