using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.USR;

namespace mesRelease.USR
{
    public class PrivilegeString : privilegeString<PrivilegeString>
    {
        public PrivilegeString() : base() { }
        public PrivilegeString(string name) : base(name) { }
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
