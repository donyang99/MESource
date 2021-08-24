using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.EQP.Txn;

namespace mesRelease.EQP.Txn
{
    public class EqParmDataCollect : eqParmDataCollect<EqParmDataCollect, Equipment, EquipmentHistory>
    {
        protected override void initEqParameters()
        {
            if (Count == 0)
            {
                Equipment eq = new Equipment(equipmentId);
                if (eq.sysid.Equals("")) return;
                Add(eq);
            }
            if (EqParameters.Count > 0 || EqDatas.Count == 0) return;
            EqType t = EqType.GetEqType(Item(0).type);
            foreach (EqTypeParameter parm in t.GetEqParameters())
            {
                if (parm.eqDataId.Equals("") || !EqDatas.ContainsKey(parm.eqDataId)) continue;
                EqTypeParameter p = parm.Clone();
                p.value = EqDatas[parm.eqDataId];
                AddEqParameter(p);
            }
            //foreach (KeyValuePair<string, string> kv in EqDatas)
            //{
            //    EqTypeParameter parm = t.GetEqParameterByEqDataId(kv.Key);
            //    if (parm == null) continue;
            //    EqTypeParameter p = parm.Clone();
            //    p.value = kv.Value;
            //    AddEqParameter(p);
            //}
        }
        public void AddEqParameter(params EqTypeParameter[] eqParm)
        {
            EqParameters.AddRange(eqParm);
        }

        void doCheckEqParameter(WIP.Lot lot, mesRelease.PARM.StepParameter stepParm, ref int checkResult, ref string failInfo)
        {
            List<EqTypeParameter> failList = new List<EqTypeParameter>();
            foreach (EqTypeParameter parm in EqParameters)
                failList.Add(parm);
            EqTypeParameter[] parms = failList.ToArray();
            failList.Clear();
            if (mesRelease.PARM.StepParameter.CheckEqParameter(lot, Item(0), ref stepParm, parms, failList))
            {
                checkResult = 0;//沒檢查
                if (stepParm != null)
                {
                    foreach (PARM.Parameter parm in stepParm.Items)
                    {
                        foreach (EqTypeParameter eqParm in parms)
                        {
                            if (parm.eqParmSysId.Equals(eqParm.sysid))
                            {
                                checkResult = 1;//有檢查
                                break;
                            }
                        }
                        if (checkResult == 1) break;
                    }
                }
            }
            else
            {
                checkResult = 2;//fail
                List<string> list = new List<string>();
                foreach (EqTypeParameter eqParm in failList)
                {
                    list.Add(eqParm.name);
                    foreach (PARM.Parameter parm in stepParm.Items)
                    {
                        if (parm.eqParmSysId.Equals(eqParm.sysid))
                        {
                            base.parmFailDetail += eqParm.name + "=" + eqParm.value + " (spec: " +
                                (parm.min == double.MinValue ? "" : parm.min.ToString()) + " ~ " +
                                (parm.max == double.MinValue ? "" : parm.max.ToString()) + " )" + Environment.NewLine;
                            break;
                        }
                    }
                }
                failInfo = string.Join(",", list);
                if (failInfo.Length > 254)
                    failInfo = failInfo.Substring(0, 254);
            }
        }
        public override void OnCheckEqParameter(string lotId, ref int checkResult, ref string failInfo)
        {
            mesRelease.WIP.Lot lot = new WIP.Lot(lotId);
            if (lot.sysid.Equals(""))
            {
                if (saveHistory)
                    throw new Exception("Can't find Lot[" + lotId + "]");
                return;
            }
            doCheckEqParameter(lot, null, ref checkResult, ref failInfo);
        }
        public override void OnCheckEqParameterForOrder(string orderId, ref int checkResult, ref string failInfo)
        {
                WIP.WorkOrder order = new WIP.WorkOrder(orderId);
                if (order.sysid.Equals(""))
                {
                    if (saveHistory)
                        throw new Exception("Can't find Order[" + orderId + "]");
                    return;
                }
                if (order.specSysId.Equals(""))
                {
                    mesRelease.PARM.ProductSpec spec = mesRelease.PARM.ProductSpec.GetSpecByName(order.specId);
                    if (spec == null)
                    {
                        if (saveHistory)
                            throw new Exception("Can't find ProductSpec[" + order.specId + "]");
                        return;
                    }
                    order.specSysId = spec.sysid;
                }
                foreach (string stepId in Item(0).GetUsedbySteps())
                {
                    mesRelease.PARM.StepParameter parm = mesRelease.PARM.StepParameter.GetSpecStep(order.specSysId, stepId, true);
                    if (parm == null) continue;
                    doCheckEqParameter(null, parm, ref checkResult, ref failInfo);
                    if (checkResult == 2)//check fail
                        break;
                }
        }
        public override void OnCheckEqParameterForSpec(string specId, ref int checkResult, ref string failInfo)
        {
            PARM.ProductSpec spec = PARM.ProductSpec.GetSpecByName(specId);
            if (spec == null)
            {
                if (saveHistory)
                    throw new Exception("Can't find ProductSpec[" + specId + "]");
                return;
            }
            foreach (string stepId in Item(0).GetUsedbySteps())
            {
                PARM.StepParameter parm = PARM.StepParameter.GetSpecStep(spec.sysid, stepId, true);
                if (parm == null) continue;
                doCheckEqParameter(null, parm, ref checkResult, ref failInfo);
                if (checkResult == 2)//check fail
                    break;
            }
        }

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
    }
}
