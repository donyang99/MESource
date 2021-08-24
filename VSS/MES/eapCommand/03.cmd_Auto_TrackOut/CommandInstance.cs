using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCommand;

namespace eapAutoTrackOut
{
    public class CommandInstance : ICommand
    {
        mesRelease.WIP.Lot lot = null;
        mesRelease.EQP.Equipment eqp = null;
        mesRelease.Controls.StepDC stepDC = new mesRelease.Controls.StepDC();
        string comments = "";
        bool haveNextRule = false;
        bool checkResult = false;
        string judgePath = "";

        public override void Execute()
        {
            //Init and Check
            Init();

            //執行交易
            mesRelease.WIP.Txn.TrackOut txn = new mesRelease.WIP.Txn.TrackOut();
            txn.txnUser = "EAP01";
            txn.equipmentId = eqp.name;
            txn.comments = comments;
            txn.Add(lot);
            txn.changeEqCapacity = !idv.mesCore.systemConfig.assemblyMode;

            if (string.IsNullOrWhiteSpace(judgePath)) judgePath = "PASS";
            txn.result = judgePath;

            if (haveNextRule || judgePath.StartsWith("HOLD"))
                txn.dispatchPath = "PASS";
            else
                txn.dispatchPath = judgePath;

            if (stepDC.Count > 0)
                txn.dcItemList.AddRange(stepDC.GetDCItems());

            txn = txn.doTxn();
            if (!txn.result.Equals("PASS"))
                throw new Exception(txn.errMessage);

            if (mesRelease.WF.WorkFlow.DispatchLotToNext(txn, "PASS"))//如果當前Rule是自動執行的Rule, 就會自動執行
            {
                //將交易加入廣播交易清單中
                Command.publishTxn.Add(txn);
                
                //執行成功
                Command.result = "PASS";        
            }
        }

        //初始化必要資訊及檢查
        void Init()
        {
            //取得Lot
            string temp = Command.GetArgumentValue("LotId");
            lot = new mesRelease.WIP.Lot(temp);
            if (lot.sysid.Equals(""))
                throw new Exception("Can't Find Lot");
            else if (!lot.IsWIPStatus())
                throw new Exception("Wrong Lot Status");
            else if (lot.status.Equals(idv.mesCore.WIP.LotStatus.HOLD.ToString()))
                throw new Exception("Lot is Hold");

            System.Threading.Thread t = new System.Threading.Thread(initAsync);
            t.Start();

            comments= Command.GetArgumentValue("Comment");

            mesRelease.PRP.Step step = lot.GetCurrentStep();
            haveNextRule = step.Count > (step.GetRuleSeq(lot.ruleId) + 1);

            //取得Equipment
            temp = Command.GetArgumentValue("EqpId");
            if (string.IsNullOrWhiteSpace(temp))
                temp = lot.equipmentId;
            else if (!string.IsNullOrWhiteSpace(lot.equipmentId) && !string.Equals(temp, lot.equipmentId))
                throw new Exception($"Wrong EquipmentId, EqpId Arug={temp}, lot.equipmentId={ lot.equipmentId}");

            eqp = new mesRelease.EQP.Equipment(temp);
            if (eqp.sysid.Equals(""))
                throw new Exception("Can't Find Equipment");

            t.Join();

            if (stepDC.AssignFromContains("Equipment"))
                stepDC.ApplyValues(eqp);

            checkResult = mesRelease.WF.WorkFlow.TxnBegin(lot, eqp, stepDC, ref judgePath, true);
            if (!checkResult)
            {
                if (!judgePath.StartsWith("HOLD") && !lot.GetCurrentStep().availablePaths.Contains(judgePath))
                    throw new Exception(idv.utilities.cultureLanguage.getValue("msgJudgePathNotExist", judgePath));
            }
        }

        void initAsync()
        {
            ItemValue dcItems = Command.GetArgument("DCItems");
            stepDC.Init(lot.GetCurrentStep(), idv.mesCore.PRP.DcItemTiming.TrackOut);
            stepDC.Init(lot);
            stepDC.ApplyValues(lot);
            if (stepDC.AssignFromContains("WorkOrder"))
                stepDC.ApplyValues(new mesRelease.WIP.WorkOrder(lot.orderId));
            if (stepDC.AssignFromContains("Step"))
                stepDC.ApplyValues(lot.GetCurrentStep());

            foreach (ItemValue item in dcItems.Items)
                stepDC.PutDcItemValue(item.name, item.Value.ToString());//賦上資料收集值
        }
    }
}
