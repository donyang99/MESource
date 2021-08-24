using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCommand;

namespace EqpParmDataCollect
{
    public class CommandInstance : ICommand
    {
        public override void Execute()
        {
            //執行交易
            mesRelease.EQP.Txn.EqParmDataCollect txn = new mesRelease.EQP.Txn.EqParmDataCollect();
            txn.equipmentId = Command.GetArgumentValue("equipmentId");
            txn.lotId = Command.GetArgumentValue("lotId");
            bool inteEQP;
            if (bool.TryParse(Command.GetArgumentValue("integrateEQP"), out inteEQP))
                txn.integrateEQP = inteEQP;
            txn.txnUser = Command.GetArgumentValue("txnUser");
            txn.sqlExtDbName = Command.GetArgumentValue("sqlExtDbName");
            if (txn.txnUser.Equals("")) txn.txnUser = "System";
            txn.saveHistory = false;
            string[] ignoreList = new string[] { "equipmentId", "lotId", "txnUser", "sqlExtDbName", "integrateEQP" };
            foreach (ItemValue item in Command.Arguments)
            {
                if (ignoreList.Contains(item.name)) continue;
                txn.EqDatas.Add(item.name, item.Value.ToString());
            }
            txn = txn.doTxn();
            if (txn.result.Equals("CANCEL"))
                Command.result = "CANCEL";
            else if (!txn.result.Equals("PASS"))
                throw new Exception(txn.errMessage);
            else
            {
                Command.AddItem("equipmentId", txn.equipmentId);
                Command.AddItem("parmCheckResult", txn.parmCheckResult);
                if (!txn.parmCheckResult)
                {
                    Command.AddItem(txn.checkBy, txn.lotId);
                    Command.AddItem("parmFailInfo", txn.parmFailInfo);
                    Command.AddItem("parmFailDetail", txn.parmFailDetail);
                }

                //將交易加入廣播交易清單中
                if (txn.Count > 0)
                {
                    Command cmd = new Command();
                    cmd.publish = true;
                    mesRelease.EQP.Equipment eq = txn.Item(0);
                    base.Command.To = eq.fab + ":" + eq.type + ":" + eq.name;
                    cmd.Add(base.Command);
                    Command.publishTxn.Add(cmd);
                }
                //執行成功
                Command.result = "PASS";
            }
        }
    }

    public class CommandInstanceBatch : ICommand
    {
        string getArguValue(ItemValue argus, string name)
        {
            ItemValue item = argus.Item(name);
            if (item == null)
                return "";
            else
                return item.Value.ToString();
        }
        public override void Execute()
        {
            List<ItemValue> lstCheckResults = new List<ItemValue>();
            List<string> lstTo = new List<string>();
            string txnUser = Command.GetArgumentValue("txnUser");
            if (txnUser.Equals(""))
                txnUser = "System";
            string sqlExtDbName = Command.GetArgumentValue("sqlExtDbName");
            bool? inteEQP = null;
            bool tmp;
            if (bool.TryParse(Command.GetArgumentValue("integrateEQP"), out tmp))
                inteEQP = tmp;
            for (int i = 0; i < Command.Count; i++)
            {
                ItemValue oArgus = Command.Item(i);
                //執行交易
                mesRelease.EQP.Txn.EqParmDataCollect txn = new mesRelease.EQP.Txn.EqParmDataCollect();
                txn.equipmentId = getArguValue(oArgus, "equipmentId");
                txn.lotId = getArguValue(oArgus, "lotId");
                txn.integrateEQP = inteEQP;
                txn.txnUser = txnUser;
                txn.sqlExtDbName = sqlExtDbName;
                txn.saveHistory = false;

                if (Command.Count > 1)
                {
                    if (i == 0)
                        txn.txnActor = idv.messageService.TransactionActor.First;
                    else if (i == Command.Count - 1)
                        txn.txnActor = idv.messageService.TransactionActor.Last;
                    else
                        txn.txnActor = idv.messageService.TransactionActor.Interior;
                }

                string[] ignoreList = new string[] { "equipmentId", "lotId", "txnUser", "sqlExtDbName", "integrateEQP" };
                foreach (ItemValue item in oArgus.Items)
                {
                    if (ignoreList.Contains(item.name)) continue;
                    txn.EqDatas.Add(item.name, item.Value.ToString());
                }
                txn = txn.doTxn();
                if (txn.result.Equals("CANCEL"))
                    Command.result = "CANCEL";
                else if (!txn.result.Equals("PASS"))
                    throw new Exception(txn.errMessage);
                else
                {
                    ItemValue chkResult = new ItemValue();
                    lstCheckResults.Add(chkResult);

                    chkResult.AddItem("equipmentId", txn.equipmentId);
                    chkResult.AddItem("parmCheckResult", txn.parmCheckResult);
                    if (!txn.parmCheckResult)
                    {
                        chkResult.AddItem(txn.checkBy, txn.lotId);
                        chkResult.AddItem("parmFailInfo", txn.parmFailInfo);
                        chkResult.AddItem("parmFailDetail", txn.parmFailDetail);
                    }

                    //將交易加入廣播交易清單中
                    if (txn.Count > 0)
                    {
                        mesRelease.EQP.Equipment eq = txn.Item(0);
                        string to = eq.fab + ":" + eq.type + ":" + eq.name;
                        if (!lstTo.Contains(to))
                            lstTo.Add(to);
                    }
                }
            }
            Command.Clear();
            foreach (ItemValue item in lstCheckResults)
                Command.Add(item);

            if (lstTo.Count > 0)
            {
                Command.To = string.Join(",", lstTo.ToArray());
                Command cmd = new Command();
                cmd.publish = true;
                cmd.Add(Command);
                Command.publishTxn.Add(cmd);
            }
            //執行成功
            Command.result = "PASS";
        }
    }
}
//===============================================
//{  
//"assemblyName":"InnEqParm",
//"className":"InnEqParm.CommandInstanceBatch",
//"sender":"auto",
//"arguments":
//{  
// "txnUser":"auto2"
//},
//"items":
//[
// {    "equipmentId": "eqA",    "eq_height": "100",    "eq_humidity": "60",    "eq_temp": "30"  },
// {    "equipmentId": "eqA",    "eq_height": "111",    "eq_humidity": "99",    "eq_temp": "30"  },
// {    "equipmentId": "eqB",    "eq_height": "222",    "eq_humidity": "98",    "eq_temp": "30"  }
//]
//}
