using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.WIP;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.WIP.Txn;

namespace mesRelease.WIP.Txn
{
    public class Packing : packing<Packing, Lot, LotHistory>
    {
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {
            base.OnTxn(serviceHost, executeSQL);
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

        public override void initCarton()
        {
            _carton = Carton.GetCartonById(cartonId);
        }

        EQP.Equipment _equipment = null;
        protected override idv.mesCore.EQP.equipmentBase getEquipment()
        {
            if (equipmentId.Equals("")) return null;
            if (_equipment == null)
            {
                _equipment = new EQP.Equipment(equipmentId);
                if (_equipment.sysid.Equals(""))
                    _equipment = null;
            }
            return _equipment;
        }

        List<PRP.DCItem> _dcItemList = new List<PRP.DCItem>();
        public List<PRP.DCItem> dcItemList
        {
            get { return _dcItemList; }
            set { _dcItemList = value; }
        }
        protected override int dcItemCount
        {
            get { return dcItemList.Count; }
        }
        protected override idv.mesCore.PRP.dcItemBase getDCItem(int index)
        {
            return dcItemList[index];
        }
    }
}
