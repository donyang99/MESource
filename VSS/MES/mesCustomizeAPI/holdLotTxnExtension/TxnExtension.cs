using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;

namespace HoldLotTxnExtension
{
    public class TxnExtension : txnExtensionBase
    {
        public override void AfterTxn(txnBase txn)
        {
            Console.WriteLine(txn.Item(0).name + "--" + txn.name + "AfterTxnHoldLotExtension-------------");
        }

        public override void OnTxnError(txnBase txn, bool handled)
        {
            Console.WriteLine(txn.Item(0).name + "--" + txn.name + "OnTxnErrorHoldLotExtension");
        }

        public override void OnTxnSucceed(txnBase txn)
        {
            Console.WriteLine(txn.Item(0).name + "--" + txn.name + "OnTxnSucceedHoldLotExtension");
        }
    }
}
