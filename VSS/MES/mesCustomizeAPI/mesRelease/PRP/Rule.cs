using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.PRP;

namespace mesRelease.PRP
{
    public class Rule : rule<Rule>
    {
        public Rule() : base() { }
        public Rule(string name) : base(name) { }
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
    }
}
