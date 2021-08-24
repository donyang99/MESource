using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.WIP;
using mesRelease.PRP;

namespace mesRelease.WIP
{
    public class Lot : lot<Lot>
    {
        public Lot() : base() { }
        public Lot(string name) : base(name) { }

        protected override void OnNew(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnModify(List<idv.messageService.sql.sqlTable> executeSQL)
        {
            
        }

        public override string imageKey
        {
            get
            {
                if (isDispatching) return "processing";
                return base.imageKey;
            }
        }

        protected override void OnRefresh(bool deep)
        {
            route = null;
            curStep = null;
            if (deep)
            {
                _lotComponentInfo = null;
                _CarrierList = null;
            }
        }

        public Route route = null;
        public Route GetRoute()
        {
            if (route == null || route.name != routeId || route.version != routeVersion)
            {
                if (routeVersion < 0)
                    routeVersion = -1;
                route = Route.GetRoute(routeId, routeVersion);
            }
            if (route != null)
            {
                route.renewActiveVersion();
                routeVersion = route.version;
            }
            return route;
        }
        protected override idv.mesCore.PRP.routeBase getRoute()
        {
            return GetRoute();
        }

        volatile Step curStep = null;
        public Step GetCurrentStep()
        {
            if (curStep == null || !curStep.stepHandle.Equals(nodeHandle) || !curStep.name.Equals(stepId) || !curStep.version.Equals(stepVersion))
            {
                Route r = GetRoute();
                if (r == null) return null;
                if (nodeHandle.Equals(""))
                {
                    curStep = r.FirstStep();
                    nodeHandle = curStep.stepHandle;
                }
                else
                    curStep = r.FindStep(nodeHandle);

                stepId = curStep.name;
                stepVersion = curStep.version;
            }
            return curStep;
        }
        protected override idv.mesCore.PRP.stepBase getCurStep()
        {
            return GetCurrentStep();
        }

        protected override idv.mesCore.PRP.stepBase getLastStep()
        {
            Route r = GetRoute();
            if (r == null || lastNodeHandle == "") return null;
            return r.FindStep(lastNodeHandle);
        }

        protected override idv.mesCore.PARM.stepParameterBase getCurStepParameter()
        {
            return GetCurrentStepParameter();
        }

        public PARM.StepParameter GetCurrentStepParameter()
        {
            if (string.Equals(specSysId, ""))
            {
                lock (this)
                {
                    if (string.Equals(specSysId, ""))
                    {
                        if (string.Equals(specId, "")) return null;
                        try
                        {
                            idv.messageService.IMessageGuard client = idv.messageService.serviceHost.Client;
                            specSysId = client.getValueWithParameter("select spec_sysid from mes_wip_lot where lot_id=?", name);
                            if (string.Equals(specSysId, ""))
                            {
                                specSysId = client.getValueWithParameter("select sysid from mes_parm_main where name=? and issue_state=?", specId, "Active");
                                if (string.Equals(specSysId, "")) return null;
                                client.executeSQLWithParameter("update mes_wip_lot set spec_sysid=? where lot_id=?", specSysId, name);
                            }
                        }
                        catch { }
                    }
                }
            }
            return PARM.StepParameter.GetSpecStep(specSysId, stepId, true);
        }

        public Rule GetCurrentRule()
        {
            return GetCurrentStep().Item(ruleId);
        }

        protected override idv.mesCore.PRP.ruleBase getCurRule()
        {
            return GetCurrentRule();
        }

        protected override bool next(string path)
        {
            try
            {
                Step step = GetCurrentStep();
                int seq = step.GetRuleSeq(ruleId);
                if (seq < (step.Count - 1) && path.Equals("PASS"))
                {
                    ruleSeq = (byte)(seq + 1);
                    ruleId = step.Item(ruleSeq).name;
                    return true;
                }
                else
                {
                    Step nextStep = GetRoute().NextStep(nodeHandle, path, iterate);
                    if (nextStep == null)
                        return false;
                    else
                    {
                        if (step == nextStep)
                            iterate++;
                        else
                            iterate = 1;
                        lastNodeHandle = nodeHandle;
                        curStep = nextStep;
                        nodeHandle = curStep.stepHandle;
                        stepId = curStep.name;
                        stepVersion = curStep.version;
                        ruleSeq = 0;
                        ruleId = curStep.Item(0).name;
                        if (!curStep.componentType.Equals(""))
                            componentType = curStep.componentType;
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }

        }

        public ComponentInfo ComponentInfo
        {
            get
            {
                if (_lotComponentInfo != null) return _lotComponentInfo as ComponentInfo;
                if (!callByToMessage)
                {
                    if (_lotComponentInfo == null && !idv.mesCore.systemConfig.componentInfo)
                        return null;
                    else if (componentInfo == "")
                        return null;
                    else if (_lotComponentInfo == null)
                        _lotComponentInfo = new ComponentInfo(componentInfo);
                }
                return _lotComponentInfo as ComponentInfo;
            }
            set
            {
                _lotComponentInfo = value;
            }
        }

        protected override componentInfoBase lotComponentInfo
        {
            get
            {
                return ComponentInfo;
            }
            set
            {
                _lotComponentInfo = value;
            }
        }

        public bool IsWIPForWorkingArea(string workingArea)
        {
            string curStepString = fab;
            Step step = GetCurrentStep();
            if (idv.mesCore.systemConfig.stepStage) curStepString += ":" + step.stage;
            curStepString += ":" + step.name + ":";
            if (!curStepString.StartsWith(workingArea + ":")) return false;
            return IsWIPStatus();
        }

        public override bool IsWIPStatus()
        {
            return IsWIPStatus(status);
        }

        public override bool IsCheckDcSelf()
        {
            return BAS.LotType.IsCheckDcSelf(lotType);
        }

        public override bool IsCheckDcSpec()
        {
            return BAS.LotType.IsCheckDcSpec(lotType);
        }

        public override bool IsCheckFutureHold()
        {
            return BAS.LotType.IsCheckFutureHold(lotType);
        }

        public override bool IsCheckMaterial()
        {
            return BAS.LotType.IsCheckMaterial(lotType);
        }

        public override bool IsCheckTooling()
        {
            return BAS.LotType.IsCheckTooling(lotType);
        }

        public override bool IsCheckQTime()
        {
            return BAS.LotType.IsCheckQTime(lotType);
        }

        public override bool IsCheckRecipe()
        {
            return BAS.LotType.IsCheckRecipe(lotType);
        }

        protected override void prepare()
        {
            if (Route.isRouteCached(routeId, routeVersion) && (specId.Equals("") || PARM.StepParameter.dicStepParm.ContainsKey(specSysId + "@" + stepId)))
                return;
            new System.Threading.Thread(doPrepare).Start();
        }
        void doPrepare()
        {
            try
            {
                if (!Route.isRouteCached(routeId, routeVersion))
                    Route.prepareRoute(routeId, routeVersion);
                if (!specId.Equals("") && !PARM.StepParameter.dicStepParm.ContainsKey(specSysId + "@" + stepId))
                    GetCurrentStepParameter();
            }
            catch { }
        }

        public string GetNextStepId()
        {
            return GetNextStepId("PASS");
        }
        public string GetNextStepId(string path)
        {
            try
            {
                return GetRoute().NextStep(nodeHandle, path).name;
            }
            catch { }
            return "";

        }

        List<CAR.Carrier> _CarrierList = null;
        public List<CAR.Carrier> CarrierList
        {
            get
            {
                if (!callByToMessage)
                {
                    if (_CarrierList == null)
                    {
                        _CarrierList = new List<CAR.Carrier>();
                        if (name != "" && idv.mesCore.systemConfig.carrierManagement)
                        {
                            _CarrierList.AddRange(CAR.Carrier.getCarriers("", 0, 0, "", name, "", 0, 0));
                        }
                    }
                }
                return _CarrierList;
            }
            set { _CarrierList = value; }
        }

        protected override int carrierCount
        {
            get { return CarrierList.Count; }
        }
        protected override idv.mesCore.CAR.carrierBase getCarrier(int index)
        {
            if (carrierCount > 0)
                return CarrierList[index];
            else
                return null;
        }
        protected override idv.mesCore.CAR.carrierBase getCarrier(string name)
        {
            foreach (CAR.Carrier car in CarrierList)
            {
                if (car.name == name) return car;
            }
            CAR.Carrier c = new CAR.Carrier(name);
            if (c.sysid == "") return null;
            CarrierList.Add(c);
            return c;
        }
        protected override bool removeCarrier(string name)
        {
            CAR.Carrier findCar = null;
            foreach (CAR.Carrier car in CarrierList)
            {
                if (car.name == name)
                {
                    findCar = car;
                    break;
                }
            }
            if (findCar == null)
                return false;
            else
            {
                CarrierList.Remove(findCar);
                return true;
            }
        }

        public static bool IsWIPStatus(string status)
        {
            if (status == LotStatus.WAIT.ToString() || status == LotStatus.RUN.ToString() || status == LotStatus.HOLD.ToString() ||
                status == LotStatus.BANK.ToString() || status == LotStatus.PACK.ToString())//|| status == LotStatus.CRED.ToString())
                return true;
            else
                return false;
        }
        public static string[] lotStatus
        {
            get
            {
                return new string[] { "WAIT", "RUN", "HOLD", "SCRP", "TERM", "FINH", "PACK", "INVT" };//"CRED", "BANK"
            }
        }
        public static string NextChildLotId(Lot lot)
        {
            Lot topParent = null;
            if (lot.name == lot.topParent)
                topParent = lot;
            else
                topParent = new Lot(lot.topParent);
            return topParent.name + "." + (topParent.childCount + 1).ToString("000");
        }

        public static Lot GetLotByAny(string id)
        {
            Lot[] lots = dataSetToLot(getLotDataSet("(lot_id=? or carrier_id=?)", id, id));
            foreach (Lot lot in lots)
            {
                lot.prepare();
                return lot;
            }
            return null;
        }

        internal static Lot[] DataSetToLot(System.Data.DataSet ds)
        {
            return dataSetToLot(ds);
        }
    }
}
