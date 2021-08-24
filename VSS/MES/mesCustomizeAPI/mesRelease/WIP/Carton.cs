using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.WIP;
using System.Data;
using idv.messageService;
using idv.messageService.sql;

namespace mesRelease.WIP
{
    public class Carton : carton<Carton, Lot>
    {
        public Carton() : base() { }
        public Carton(string name) : base(name) { }

        
        public override void retrieveLots()
        {
            if (name.Equals("")) return;
            if (_lotRetrieved || Count > 0) return;
            Items.AddRange(Lot.GetLots("batch_id", name));
            _lotRetrieved = true;
        }

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

        public override void OnAddLot(Lot item, Carton orgCarton, List<sqlTable> sqlTables)
        {

        }

        public override void OnRemoveLot(Lot item, List<sqlTable> sqlTables)
        {
            
        }

        public override void OnClearLots(List<sqlTable> sqlTables)
        {
            
        }

        //static member
        public static string GetCartonId(string productId,string orderId)
        {
            return "CARTON" + serviceHost.dateTime.ToString("yyMMdd") + Serial.GetCartionSerial(productId, orderId).ToString("0000");
        }
    }
}
