using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.CAR.Txn;

namespace mesRelease.CAR.Txn
{
    public class TxnSample : txnTemplate<TxnSample, Carrier, CarrierHistory>
    {
        string _sampleProperty = "";
        public string sampleProperty
        {
            get { return _sampleProperty; }
            set { _sampleProperty = value; }
        }

        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {
            foreach (Carrier item in base.Items)
            {
                item.modifyUser = txnUser;
                item.modifyDate = txnDate;
                item.status = "MyStatus";
                item.location = sampleProperty;

                if (saveHistory)
                {
                    CarrierHistory his = new CarrierHistory();
                    his.item = item;
                    his.activity = name;
                    his.mainTxnSysId = mainTxnSysId;
                    his.groupHistKey = groupHistKey;
                    his.saveHistory(executeSQL, serviceHost);
                    item.lastTxnSysId = his.txnSysId;
                    if (reasonCode != "" || comments != "")
                        idv.mesCore.BAS.reasonCodeBase.saveTxnReason(his.txnSysId, reasonCode, comments, executeSQL);
                }

                sqlTable table = new sqlTable("mes_carrier_id", eDMLtype.Update, 1);
                table.Add("status", item.status);
                table.Add("modify_user", item.modifyUser);
                table.Add("modify_date", item.modifyDate);
                table.Add("location", item.location);
                table.Add("last_txn_sysid", item.lastTxnSysId);
                table.Add("txnstamp=txnstamp+1", null);
                table.WhereClause.Add("sysid", item.sysid);
                if (checkTimeStamp)
                    table.WhereClause.Add("txnstamp", item.txnStamp);
                
                executeSQL.Add(table);
            }
        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
            base.AfterTxn(serviceHost);
        }

        protected override void OnTxnError(Exception ex, ref bool handled)
        {
            result = "ERROR";//只要不是PASS，txn就會rollback
            errMessage = ex.Message;
            handled = true;//不會觸發Exception(呼叫者可在txn.result, txn.errMessage得到執行結果)
            base.OnTxnError(ex, ref handled);
        }

        public override void OnTxnSucceed()
        {
            base.OnTxnSucceed();
        }
    }
}
