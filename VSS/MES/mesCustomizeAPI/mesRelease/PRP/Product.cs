using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using idv.messageService;

namespace mesRelease.PRP
{
    public class Product : idv.mesCore.PRP.product<Product, Route>
    {
        public Product() { }
        public Product(string name) : base(name) { }
        protected override void OnInit(DataRow row)
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
