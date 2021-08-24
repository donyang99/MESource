using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.EQP;

namespace mesRelease.EQP
{
    public class State : state<State>
    {
        public State() : base() { }
        public State(string name) : base(name) { }
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
