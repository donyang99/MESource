using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.WIP;
using System.Data;
using idv.messageService;
using idv.messageService.sql;
using idv.messageService.sql.query;

namespace mesRelease.WIP
{
    public class Pallet : pallet<Pallet, Carton>
    {
        public Pallet() : base() { }
        public Pallet(string name) : base(name) { }

        public override void retrieveCartons()
        {
            if (name.Equals("") || useId.Equals("")) return;
            if (_cartonRetrieved || Count > 0) return;
            Items.AddRange(Carton.GetCartonByPalletUseId(useId));
            _cartonRetrieved = true;
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

        public override void OnAddCarton(Carton item, Pallet orgPallet, List<sqlTable> sqlTables)
        {
            
        }

        public override void OnRemoveCarton(Carton item, List<sqlTable> sqlTables)
        {
            
        }

        public override void OnClearCartons(List<sqlTable> sqlTables)
        {
            
        }

        //static member
        public static string GetPalletId(string key = "")
        {
            return "PALLET" + serviceHost.dateTime.ToString("yyMMdd") + Serial.GetPalletSerial(key).ToString("0000");
        }

        public static Lot[] GetLotsByPalletUseId(string palletUseId)
        {
            //select /*+rule*/a.*,b.fab order_fab from mes_wip_lot a left join mes_wip_order b on a.order_id= b.order_id
            sqlQuery main = new sqlQuery("mes_wip_lot", "a");
            main.sqlHint="/*+rule*/";
            main.AddQueryColumn("*");

            sqlQuery query = new sqlQuery("mes_wip_order","b");
            query.AddQueryColumn("fab", "order_fab");
            query.AddJoinCondition("order_id", "order_id");
            main.AddJoinTable(query);

            query = new sqlQuery("mes_wip_carton", "c");
            query.AddJoinCondition("batch_id", "carton_id");
            query.WhereClause.Add("pallet_use_id", palletUseId);
            main.AddJoinTable(query);

            return Lot.DataSetToLot(main.GetDataSet());
        }
    }
}
