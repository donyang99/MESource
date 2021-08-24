using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using idv.messageService.sql;
using idv.mesCore.WIP;

namespace mesRelease.WIP
{
    public class ComponentInfo : componentInfo<WipComponent>
    {
        public ComponentInfo() : base() { }
        public ComponentInfo(string lotComponentInfo) : base(lotComponentInfo) { }
        protected override void OnInit(DataRow row)
        {

        }
        protected override void OnNew(List<sqlTable> executeSQL)
        {

        }
        protected override void OnModify(List<sqlTable> executeSQL)
        {

        }
        protected override void OnDelete(List<sqlTable> executeSQL)
        {

        }
    }
}
