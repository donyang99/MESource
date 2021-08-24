using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCommand;

namespace mesCommandTemplate
{
    public class CommandInstance : ICommand
    {
        public override void Execute()
        {
            //取得執行參數
            string argu1 = Command.GetArgumentValue("argu1");
            int argu2 = 0;
            ItemValue argu = Command.GetArgument("argu2");
            if (argu != null)
                argu2 = Convert.ToInt32(argu.Value);
            
            //執行邏輯並將回傳資訊
            
            //單一值            
            string sysDate = idv.messageService.serviceHost.Client.getValue("select sysdate from dual");
            Command.AddItem("sysDate", sysDate);
            Command.AddItem("someItemName", 100);
            //集合物件
            ItemValue lot = Command.AddItem("lotId", "Lot001");
            lot.AddItem("Name", "Lot001");
            lot.AddItem("Order", "Order001");
            lot.AddItem("Quantity", 25);

            ItemValue childLotIds = Command.AddItem("childLots", null);
            childLotIds.AddItem("Lot001-02");
            childLotIds.AddItem("Lot001-05");

            //執行成功
            Command.result = "PASS";
        }
    }
}
