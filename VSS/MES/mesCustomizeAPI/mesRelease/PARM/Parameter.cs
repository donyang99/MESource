using System;
using System.Collections.Generic;
using System.Text;
using idv.mesCore.PARM;
using System.Data;

namespace mesRelease.PARM
{
    public class Parameter: parameter<Parameter>
    {
        public Parameter() { }
        public Parameter(string name) : base(name) { }

        protected override void OnInit(System.Data.DataRow row)
        {

        }
        protected override void OnNew(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnModify(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnDelete(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnSaveProductSpec(idv.messageService.sql.sqlTable table)
        {
            
        }
    }
}
