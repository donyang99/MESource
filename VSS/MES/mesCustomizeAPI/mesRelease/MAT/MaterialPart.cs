using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.MAT;

namespace mesRelease.MAT
{
    public class MaterialPart : materialPart<MaterialPart>
    {
        public MaterialPart() : base() { }
        public MaterialPart(string partNo) : base(partNo) { }
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
