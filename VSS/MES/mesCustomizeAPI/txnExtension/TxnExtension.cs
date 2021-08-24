using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using System.Collections.Concurrent;

namespace txnExtension
{
    public class TxnExtension : txnExtensionBase
    {
        ConcurrentDictionary<txnBase, txnExtensionBase> dicTxnExt = new ConcurrentDictionary<txnBase, txnExtensionBase>();
        public override void AfterTxn(txnBase txn)
        {
            if (txn.name.Equals("")) return;
            txnExtensionBase txnExt = null;
            try
            {
                txnExt = dynamicAssembly.CreateNewInstance(txn.name + "TxnExtension.dll", txn.name + "TxnExtension.TxnExtension", true) as txnExtensionBase;
                if (txnExt != null)
                    dicTxnExt[txn] = txnExt;
            }
            catch { }
            if (txnExt != null)
                txnExt.AfterTxn(txn);
        }

        public override void OnTxnError(txnBase txn, bool handled)
        {
            txnExtensionBase txnExt = null;
            try
            {
                if (dicTxnExt.ContainsKey(txn))
                    dicTxnExt.TryRemove(txn, out txnExt);
                else if (!txn.name.Equals(""))
                    txnExt = dynamicAssembly.CreateNewInstance(txn.name + "TxnExtension.dll", txn.name + "TxnExtension.TxnExtension", true) as txnExtensionBase;
            }
            catch { }
            if (txnExt != null)
                txnExt.OnTxnError(txn, handled);
        }

        public override void OnTxnSucceed(txnBase txn)
        {
            if (!dicTxnExt.ContainsKey(txn)) return;
            txnExtensionBase txnExt = null;
            try
            {
                dicTxnExt.TryRemove(txn, out txnExt);
            }
            catch { }
            if (txnExt != null)
                txnExt.OnTxnSucceed(txn);
        }
    }
}
