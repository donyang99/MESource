using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mesRelease.WIP.Txn
{
    public class ChangeEquipment : TrackIn
    {
        Dictionary<Lot, string> orgEQP = new Dictionary<Lot, string>();
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            //交易前先記錄Lot所在的機台
            foreach (Lot lot in Items)
            {
                if (!lot.equipmentId.Equals(""))
                    orgEQP[lot] = lot.equipmentId;
            }
            base.doTxn(serviceHost);
        }
        protected override void AfterTxn(idv.messageService.IMessageGuard serviceHost)
        {
            base.AfterTxn(serviceHost);

            equipmentTxn(serviceHost);
        }

        Dictionary<string, EQP.Txn.ChangeCapacity> dicChangeCapacityTxn = new Dictionary<string, EQP.Txn.ChangeCapacity>();
        void equipmentTxn(idv.messageService.IMessageGuard serviceHost)
        {
            if (changeEqCapacity)
            {
                foreach (KeyValuePair<Lot,string> lotEq in orgEQP)
                {
                    EQP.Equipment orgEqp = new EQP.Equipment(lotEq.Value);
                    EQP.Txn.ChangeCapacity changeCapacityTxn = new EQP.Txn.ChangeCapacity();
                    changeCapacityTxn.lotId = lotEq.Key.name;
                    changeCapacityTxn.txnUser = txnUser;
                    changeCapacityTxn.mainTxnSysId = mainTxnSysId;
                    changeCapacityTxn.checkTimeStamp = false;

                    changeCapacityTxn.Add(orgEqp);
                    if (orgEqp.consumeType == idv.mesCore.EQP.EqConsumeType.ByLot)
                        changeCapacityTxn.capacityEffected = -1;
                    else
                        changeCapacityTxn.capacityEffected = 0 - (int)Math.Ceiling(lotEq.Key.quantity);

                    changeCapacityTxn.doTxn(serviceHost);
                    dicChangeCapacityTxn[orgEqp.name] = changeCapacityTxn;
                }
            }
        }

        public override void OnTxnSucceed()
        {
            base.OnTxnSucceed();

            if (dicChangeCapacityTxn.Count > 0)
                publishTxn.AddRange(dicChangeCapacityTxn.Values);//for 廣播
        }
    }
}
