using System;
using System.Collections.Generic;
using System.Text;

namespace idv.messageService
{
    public class ServiceExtension : IserviceExtension
    {
        public void ServiceStarted()
        {
            //Service成功啟動時被叫用
        }
        public void ServiceFaulted()
        {
            //Service發生報錯時被叫用
        }

        public void MessageReceived(messageBase message)
        {
            //收到訊息廣播請求時叫用
        }

        public void TxnReceived(txnBase txn)
        {
            //收到交易請求時叫用
        }

        public void ClientConnect(string machineId, string appId, ref bool accept)
        {
            //用戶端連線時叫用。指定accept=false可拒絕該用戶端連線
        }

        public void ClientRequestDelay(string clientId, DateTime preDateTime, string msg)
        {
            //Console.WriteLine("ClientRequestDelay-----" + Environment.NewLine +
            //                  "ClientId=" + clientId + Environment.NewLine +
            //                  "PreDateTime=" + preDateTime.ToString() + "(" + (DateTime.Now - preDateTime).TotalSeconds.ToString("0.0000") + ")" + Environment.NewLine +
            //                  "MsgLength=" + msg.Length.ToString());
        }
    }
}
