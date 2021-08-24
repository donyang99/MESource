using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.EQP.Txn;

namespace mesRelease.EQP.Txn
{
    /// <summary>
    /// recipe, resetCounter, reasonCode, txnUser, txnDate. 
    /// </summary>
    public class Setup : setup<Setup, Equipment, EquipmentHistory>
    {
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {

        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
            base.AfterTxn(serviceHost);
        }

        protected override void OnTxnError(Exception ex, ref bool handled)
        {
            base.OnTxnError(ex, ref handled);
        }

        public override void OnTxnSucceed()
        {
            base.OnTxnSucceed();
        }

        SetupInfo _setupInfo = null;
        public SetupInfo setupInfo
        {
            get { return _setupInfo; }
            set { _setupInfo = value; }
        }

        protected override idv.mesCore.EQP.setupInfoBase getSetupInfo()
        {
            return setupInfo;
        }
    }
}
