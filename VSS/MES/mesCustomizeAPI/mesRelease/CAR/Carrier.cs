using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.CAR;
using idv.messageService;

namespace mesRelease.CAR
{
    public class CarrierType : carrierType<CarrierType>
    {
        public CarrierType() : base() { }
        public CarrierType(string name) : base(name) { }
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

    public class Carrier : carrier<Carrier>
    {
        public Carrier() : base() { }
        public Carrier(string name) : base(name) { }
        public Carrier(string name, bool byRFID) : base(name, byRFID) { }
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

        public void updateTag(string tag)
        {
            string sql = "update mes_carrier_id set tag=? where sysid=?";
            serviceHost.Client.executeSQLWithParameter(sql, tag, sysid);
        }
    }
}
