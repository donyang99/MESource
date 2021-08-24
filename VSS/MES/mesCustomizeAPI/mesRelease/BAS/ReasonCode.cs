using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.BAS;

namespace mesRelease.BAS
{
    public class ReasonCode : reasonCode<ReasonCode>
    {
        public ReasonCode() : base() { }
        public ReasonCode(string name) : base(name) { }
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

    public class ReasonGroup : reasonGroup<ReasonGroup, ReasonCode>
    {
        public ReasonGroup() : base() { }
        public ReasonGroup(string name) : base(name) { }
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

    public class ReasonCategory : reasonCategory<ReasonCategory, ReasonCode>
    {
        public ReasonCategory() : base() { }
        public ReasonCategory(string name, string reasonClass) : base(name, reasonClass) { }
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
