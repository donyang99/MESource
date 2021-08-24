using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.utilities;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.WIP.Txn;
using idv.mesCore.WF;
using idv.mesCore.WIP;
using idv.mesCore.EQP;
using mesRelease.WIP;
using mesRelease.EQP;

namespace mesRelease.WF
{
    public delegate void MESItemNoticeEventHandler(itemBase mesItem, Type type);
    public enum DisplayErrorStyle { ShowMessage, ShowInOutputInfo, MessagePanel, ThrowException }
    public class WorkFlow : workFlow<WorkFlow, Lot>
    {
        void finishTxn(IMessageGuard serviceHost)
        {
            if (finishedLots.Count == 0) return;

            WIP.Txn.FinishLot txn = new WIP.Txn.FinishLot();
            txn.checkTimeStamp = false;

            foreach (Lot lot in finishedLots)
                txn.Add(lot);

            txn.txnUser = finishedLots[0].modifyUser;

            //DbTxnInfo dbTxn = serviceHost as DbTxnInfo;
            //if (dbTxn != null && dbTxn.OnDbTxn)
            txn.doTxn(serviceHost);
            //else
            //    txn.doTxn();
        }

        bool isFinished(string lotId)
        {
            foreach (Lot lot in finishedLots)
            {
                if (lot.name.Equals(lotId))
                    return true;
            }
            return false;
        }
        void doFutureHold(IMessageGuard serviceHost)
        {
            if (Count == 0) return;
            idv.mesCore.WIP.FutureActionTiming timing = FutureActionTiming.BeforeTrackIn;
            bool continueExecute = false;
            if (stepChanged)
                continueExecute = true;
            else
            {
                Lot tmpLot = Item(0) as Lot;
                if (tmpLot.ruleSeq == 0) return;
                PRP.Step curStep = tmpLot.GetCurrentStep();
                PRP.Rule prevRule = curStep.Item(tmpLot.ruleSeq - 1);
                if (prevRule.name.ToUpper().IndexOf("TRACKOUT") >= 0)//前一個rule有TrackOut字眼
                {
                    timing = FutureActionTiming.AfterTrackOut;
                    continueExecute = true;
                }
                else if (!prevRule.dispatchFlag)
                {        //前一個rule為手動過帳

                    bool allDispatch = true;
                    //當前及後續rule皆為自動過帳
                    for (int i = tmpLot.ruleSeq; i < curStep.Count; i++)
                    {
                        if (!curStep.Item(i).dispatchFlag)
                            allDispatch = false;
                    }
                    if (allDispatch)
                    {
                        timing = FutureActionTiming.AfterTrackOut;
                        continueExecute = true;
                    }
                }
            }
            if (!continueExecute) return;
            List<FutureHoldInfo> futureList = new List<FutureHoldInfo>();
            List<Lot> checkLot = new List<Lot>();
            foreach (Lot lot in Items)
            {
                if (isFinished(lot.name)) continue;
                if (lot.IsCheckFutureHold())
                    checkLot.Add(lot);
            }
            futureList.AddRange(FutureHoldInfo.GetFutureHoldInfo(serviceHost, timing, checkLot.ToArray()));

            foreach (FutureHoldInfo info in futureList)
            {
                mesRelease.WIP.Txn.HoldLot hold = new WIP.Txn.HoldLot();
                hold.reasonCode = info.reasonCode;
                hold.txnUser = info.createUser;
                hold.futureHoldSysId = info.sysid;
                hold.Add(info.targetLot);
                //hold.checkTimeStamp = false;
                hold.ignoreSucceedCall = true;
                hold.doTxn(serviceHost);

                foreach (Lot lot in hold.Items)
                {
                    if (Item(lot.name) != null)
                    {
                        Remove(lot.name);
                        Add(lot);
                    }
                }

                if (info.targetKind == idv.mesCore.WIP.TargetKind.Lot)
                    info.DeActive(serviceHost);
            }
        }

        protected override void StepPathNotFound(lotBase lot, string path, IMessageGuard serviceHost)
        {
            mesRelease.WIP.Txn.HoldLot hold = new WIP.Txn.HoldLot();
            hold.reasonCode = "PathNotFound";
            hold.comments = "Invalid path - " + path;
            hold.txnUser = "System";
            hold.Add(lot);
            //hold.checkTimeStamp = false;
            hold.ignoreSucceedCall = true;
            hold.doTxn(serviceHost);
        }

        protected override void OnBatchDispatch(sqlTable lotTable)
        {
            
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {
            //廣播開始派工,或取消派工 不用作任何動作
            //if (action == DispatchAction.Publish || (action == DispatchAction.DispatchLot && result.Equals("CANCEL"))) return;
        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
            base.AfterTxn(serviceHost);
            //廣播開始派工,或取消派工 不用作任何動作
            if (action == DispatchAction.Publish || (action == DispatchAction.DispatchLot && result.Equals("CANCEL"))) return;

            //執行未來扣押
            doFutureHold(serviceHost);

            //將Finish的Lot執行完工交易
            finishTxn(serviceHost);
        }

        public static string DispatchLot(Lot lot)
        {
            //組裝業不會從此function執行有畫面過帳的rule，自動執行的rule執行失敗時，重新執行用
            if (idv.mesCore.systemConfig.assemblyMode)
            {
                if (lot.GetCurrentRule().dispatchFlag)
                {
                    return Dispatch(lot, ClientId, false, true, true, "");
                }
                return "CANCEL";
            }
            else
            {
                if (!CheckLotQTime(lot)) return "CANCEL";
                return Dispatch(lot);
            }
        }

        public static string DispatchLot(Lot lot, string equipmentId)
        {
            //組裝業不會從此function執行有畫面過帳的rule，自動執行的rule執行失敗時，重新執行用
            if (idv.mesCore.systemConfig.assemblyMode)
            {
                if (lot.GetCurrentRule().dispatchFlag)
                {
                    parameter parm = new parameter();
                    parm.key = "equipmentId";
                    parm.value = equipmentId;
                    return Dispatch(lot, ClientId, false, true, true, "", parm);
                }
                return "CANCEL";
            }
            else
            {
                if (!CheckLotQTime(lot)) return "CANCEL";
                parameter parm = new parameter();
                parm.key = "equipmentId";
                parm.value = equipmentId;
                return Dispatch(lot, parm);
            }
        }

        static bool IsCheckQTimeRule(Lot lot)//當前是否為檢查QTime的位置
        {
            if (!lot.status.Equals(idv.mesCore.WIP.LotStatus.WAIT.ToString()))//不是WAIT狀態就不是檢查QTime的時機
                return false;

            PRP.Rule curRule = lot.GetCurrentRule();
            if (curRule.dispatchFlag)//自動執行的Rule就不是檢查QTime的時機
                return false;

            string trackInRule = "";//TrackIn Rule的 Rule Name
            string trackOutRule = "";//TrackOut Rule的 RuleName
            foreach (PRP.Rule rule in lot.GetCurrentStep().Items)
            {
                if (rule.name.ToLower().IndexOf("trackin") >= 0)
                    trackInRule = rule.name;
                else if (rule.name.ToLower().IndexOf("trackout") >= 0)
                    trackOutRule = rule.name;
            }
            if (trackInRule.Equals(curRule.name)) return true;//有TrackInRule且當前Rule即為TrackInRule
            if (trackInRule.Equals("") && trackOutRule.Equals(curRule.name)) return true;//沒有TrackIn,有TrackOut且當前即為TrackOut

            return false;
        }
        static bool CheckLotQTime(Lot lot)
        {
            if (!IsCheckQTimeRule(lot) || !mesRelease.BAS.LotType.IsCheckQTime(lot.lotType))
                return true;
            string txnReason = "Over_QTime";

            bool reply = false;
            qTimeMonitor qTime = CheckQTime(lot);
            if (qTime.isOverQTime)
            {
                string msg = "Lot:" + qTime.lotId + "";
                qTimeMonitor qMonitor = null;
                string errMsg = "";
                if (QTimeBackStep(qTime.OverQTimeList, txnReason, ref lot, ref qMonitor, ref errMsg))
                {
                    if (qMonitor.type == qTimeType.Within)
                        msg += Environment.NewLine + cultureLanguage.getValue("overQTime", qMonitor.qTimeOnSetting.ToString());
                    else
                        msg += Environment.NewLine + cultureLanguage.getValue("lessQTime", qMonitor.qTimeOnSetting.ToString());
                    msg += "," + cultureLanguage.getValue("wasKickBack", qMonitor.fromStepId);
                }
                if (QTimeHold(qTime.OverQTimeList, txnReason, ref lot, ref qMonitor, ref errMsg))
                {
                    if (qMonitor.type == qTimeType.Within)
                        msg += Environment.NewLine + cultureLanguage.getValue("overQTime", qMonitor.qTimeOnSetting.ToString());
                    else
                        msg += Environment.NewLine + cultureLanguage.getValue("lessQTime", qMonitor.qTimeOnSetting.ToString());
                    msg += "," + cultureLanguage.getValue("wasHeld");
                }
                if (qTime.action != qTimeAction.None)
                    qTime.CloseAll(mesRelease.USR.User.loginUserId, serviceHost.Client);
                if (qMonitor == null)
                {
                    if (qTime.type == qTimeType.Within)
                        msg += Environment.NewLine + cultureLanguage.getValue("overQTime", qTime.qTimeOnSetting.ToString());
                    else
                        msg += Environment.NewLine + cultureLanguage.getValue("lessQTime", qTime.qTimeOnSetting.ToString());
                }
                messageBox.showMessage(msg, messageStyle.error);
                reply = false;
            }
            else
            {
                reply = true;
                qTime.CloseAll(mesRelease.USR.User.loginUserId, serviceHost.Client);
            }
            return reply;
        }
        static bool QTimeBackStep(qTimeMonitor[] qMonitorList, string reasonCode, ref Lot lot, ref qTimeMonitor qMonitor, ref string errMsg)
        {
            errMsg = "";
            foreach (qTimeMonitor qTime in qMonitorList)
            {
                if (qTime.action == qTimeAction.BackStep || qTime.action == qTimeAction.BackAndHold)
                {
                    mesRelease.WIP.Txn.RepositionStep repStep = new WIP.Txn.RepositionStep();
                    repStep.reasonCode = reasonCode;
                    repStep.stepHandle = qTime.fromStepHandle;
                    repStep.txnUser = "System";
                    repStep.comments = qTime.fromStepId + " >> " + qTime.toStepId + "(" + qTime.type.ToString() + ") : " + qTime.qTime.ToString() + " minutes" + Environment.NewLine +
                                       qTime.fromStepId + " TrackOutDate : " + qTime.startDate.ToString() + Environment.NewLine +
                                       qTime.toStepId + " Now : " + serviceHost.dateTime.ToString();
                    repStep.Add(lot);
                    repStep = repStep.doTxn();
                    if (!repStep.result.Equals("PASS"))
                    {
                        errMsg = repStep.errMessage;
                        return true;
                    }
                    lot = repStep.Item(0);
                    qMonitor = qTime;
                    if (lot.GetCurrentRule().dispatchFlag)
                    {
                        WorkFlow.DispatchLot(lot);
                        lot.Refresh();
                    }
                    return true;
                }
            }
            return false;
        }
        static bool QTimeHold(qTimeMonitor[] qMonitorList, string reasonCode, ref Lot lot, ref qTimeMonitor qMonitor, ref string errMsg)
        {
            errMsg = "";
            foreach (qTimeMonitor qTime in qMonitorList)
            {
                if (qTime.action == qTimeAction.Hold || qTime.action == qTimeAction.BackAndHold)
                {
                    mesRelease.WIP.Txn.HoldLot hold = new WIP.Txn.HoldLot();
                    hold.reasonCode = reasonCode;
                    hold.txnUser = "System";
                    hold.Add(lot);
                    hold.comments = qTime.fromStepId + " >> " + qTime.toStepId + "(" + qTime.type.ToString() + ") : " + qTime.qTime.ToString() + " minutes" + Environment.NewLine +
                                    qTime.fromStepId + " TrackOutDate : " + qTime.startDate.ToString() + Environment.NewLine +
                                    qTime.toStepId + " Now : " + serviceHost.dateTime.ToString();
                    hold = hold.doTxn();
                    lot = hold.Item(0);
                    qMonitor = qTime;
                    errMsg = hold.errMessage;
                    return true;
                }
            }
            return false;
        }

        static string _curWorkingArea = "";
        public static string CurrentWorkingArea
        {
            get { return _curWorkingArea; }
            set { _curWorkingArea = value; }
        }

        static string _curFAB = "";
        public static string CurrentFAB
        {
            get
            {
                if (!_curFAB.Equals(""))
                    return _curFAB;
                return _loginFAB;
            }
            set { _curFAB = value; }
        }

        static string _loginFAB = "";
        public static string loginFAB
        {
            get { return _loginFAB; }
            set { _loginFAB = value; }
        }

        static string _curStage = "";
        public static string CurrentStage
        {
            get { return _curStage; }
            set { _curStage = value; }
        }

        static string _curStep = "";
        public static string CurrentStep
        {
            get { return _curStep; }
            set { _curStep = value; }
        }

        static Lot _curLot = null;
        public static Lot CurrentLot
        {
            get { return _curLot; }
            set
            {
                bool changed = false;
                if (_curLot != value)
                {
                    if (_curLot == null || value == null)
                        changed = true;
                    else if (!_curLot.name.Equals(value.name))
                        changed = true;
                }
                _curLot = value;
                if (changed)
                    NotifyMesItemSelectionChanged(_curLot, typeof(Lot));
            }
        }

        static Equipment _curEqp = null;
        public static Equipment CurrentEquipment
        {
            get { return _curEqp; }
            set
            {
                bool changed = false;
                if (_curEqp != value)
                {
                    if (_curEqp == null || value == null)
                        changed = true;
                    else if (!_curEqp.name.Equals(value.name))
                        changed = true;
                }
                _curEqp = value;
                if (changed)
                    NotifyMesItemSelectionChanged(_curEqp, typeof(Equipment));
            }
        }

        static PRP.Product _CurrentProduct = null;
        public static PRP.Product CurrentProduct(string productId, bool force)
        {
            if (force || _CurrentProduct == null || !_CurrentProduct.name.Equals(productId))
            {
                _CurrentProduct = new PRP.Product(productId);
                if (_CurrentProduct.sysid.Equals(""))
                    _CurrentProduct = null;
            }
            return _CurrentProduct;
        }
        public static PRP.Product CurrentProduct(string productId)
        {
            return CurrentProduct(productId, false);
        }

        static WIP.WorkOrder _CurrentOrder = null;
        public static WIP.WorkOrder CurrentOrder(string orderId, bool force)
        {
            if (force || _CurrentOrder == null || !_CurrentOrder.name.Equals(orderId))
                _CurrentOrder = WIP.WorkOrder.GetOrder(orderId);

            return _CurrentOrder;
        }
        public static WIP.WorkOrder CurrentOrder(string orderId)
        {
            return CurrentOrder(orderId, false);
        }

        public static event MESItemNoticeEventHandler MESItemUpdated;
        public static void NotifyMESItemUpdated(itemBase mesItem, Type type)
        {
            if (MESItemUpdated == null) return;
            MESItemUpdated(mesItem, type);
        }

        //for Assembly Industry
        public static event MESItemNoticeEventHandler MesItemSelectionChanged;
        public static void NotifyMesItemSelectionChanged(itemBase mesItem, Type type)
        {
            if (MesItemSelectionChanged == null) return;
            MesItemSelectionChanged(mesItem, type);
        }

        public static bool DispatchLotToNext(Lot lot, string path)
        {
            return DispatchLotToNext(lot, path, new parameter[0]);
        }
        public static bool DispatchLotToNext(Lot lot, string path, params parameter[] parameters)
        {
            if (path.Equals("CANCEL")) return true;
            string result = DispatchToNext(lot, path, parameters);
            return !result.Equals("ERROR");
        }

        public static bool DispatchLotToNext(Lot[] lots, string path)
        {
            return DispatchLotToNext(lots, path, new parameter[0]);
        }
        public static bool DispatchLotToNext(Lot[] lots, string path, params parameter[] parameters)
        {
            if (path.Equals("CANCEL")) return true;
            string result = DispatchToNext(lots, path, parameters);
            return !result.Equals("ERROR");
        }

        public static bool DispatchLotToNext(Lot lot, string path, string nextPath)
        {
            return DispatchLotToNext(lot, path, nextPath, new parameter[0]);
        }
        public static bool DispatchLotToNext(Lot lot, string path, string nextPath, params parameter[] parameters)
        {
            if (path.Equals("CANCEL")) return true;
            List<parameter> list = new List<parameter>();
            list.AddRange(parameters);
            parameter p = new parameter();
            p.key = "NextPath";
            p.value = nextPath;
            list.Add(p);
            string result = DispatchToNext(lot, path, list.ToArray());
            return !result.Equals("ERROR");
        }

        public static bool DispatchLotToNext(Lot[] lots, string path, string nextPath)
        {
            return DispatchLotToNext(lots, path, nextPath, new parameter[0]);
        }
        public static bool DispatchLotToNext(Lot[] lots, string path, string nextPath, params parameter[] parameters)
        {
            if (path.Equals("CANCEL")) return true;
            List<parameter> list = new List<parameter>();
            list.AddRange(parameters);
            parameter p = new parameter();
            p.key = "NextPath";
            p.value = nextPath;
            list.Add(p);
            string result = DispatchToNext(lots, path, list.ToArray());
            return !result.Equals("ERROR");
        }

        static DisplayErrorStyle _disErrStyle = DisplayErrorStyle.ShowMessage;
        public static DisplayErrorStyle DisErrStyle
        {
            get { return _disErrStyle; }
            set { _disErrStyle = value; }
        }

        static Controls.OutputInfo _OutputInfo = null;
        public static Controls.OutputInfo TheOutputInfoControl
        {
            get { return _OutputInfo; }
            set { _OutputInfo = value; }
        }

        public static void ShowTxnMessage(string lotId, bool succeed, string message)
        {
            ShowTxnMessage(lotId, succeed, message, DisplayErrorStyle.ShowMessage);
        }
        public static void ShowTxnMessage(string lotId, bool succeed, string message, DisplayErrorStyle disStyle)
        {
            if (_disErrStyle == DisplayErrorStyle.ShowInOutputInfo && _OutputInfo == null)
                disStyle = DisplayErrorStyle.ShowMessage;
            if (_disErrStyle == DisplayErrorStyle.ShowInOutputInfo)
            {
                _OutputInfo.ShowMessage(lotId, succeed, message);
            }
            else if (_disErrStyle == DisplayErrorStyle.ShowMessage)
            {
                if (succeed)
                    messageBox.showMessage(message, messageStyle.confirmation);
                else
                    messageBox.showMessage(message, messageStyle.error);
            }
            else if (_disErrStyle == DisplayErrorStyle.MessagePanel)
            {
                if (succeed)
                    mesRelease.MESApplication.AddMessage(message, System.Drawing.Color.Blue);
                else
                    mesRelease.MESApplication.AddMessage(message, System.Drawing.Color.Red);
            }
            else
            {
                if (!succeed)
                    throw new Exception(message);
            }
        }

        public static bool RuleBegin(Lot lot, idv.mesCore.mesClientRule rule, string stepId)
        {
            CurrentLot = null;
            if (!lot.fab.Equals(CurrentFAB) || !lot.stepId.Equals(stepId))
            {
                idv.MESApplication.PlayNGSound();
                if (!lot.fab.Equals(CurrentFAB))
                    ShowTxnMessage(lot.name, false, cultureLanguage.getValue("msgWrongInfo", "&fab"));//廠別不正確
                else
                    ShowTxnMessage(lot.name, false, cultureLanguage.getValue("msgWrongInfo", "&step"));//站點不正確
                return false;
            }
            if (lot.status.Equals(LotStatus.HOLD.ToString()) || !lot.IsWIPStatus() || (rule != null && !lot.ruleId.Equals(rule.ruleName)))
            {
                idv.MESApplication.PlayNGSound();
                if (lot.status.Equals(LotStatus.HOLD.ToString()) || !lot.IsWIPStatus())
                    ShowTxnMessage(lot.name, false, cultureLanguage.getValue("msgStatusInvalid2", lot.status));//狀態不正確
                else
                    ShowTxnMessage(lot.name, false, cultureLanguage.getValue("msgWrongInfo", "&CurrentRule"));//過帳功能不正確
                return false;
            }

            if (!CurrentEquipment.reservedBy.Trim().Equals("") && !CurrentEquipment.reservedBy.Equals(lot.orderId))
            {
                idv.MESApplication.PlayNGSound();
                ShowTxnMessage(lot.name, false, cultureLanguage.getValue("msgWrongOrder", CurrentEquipment.reservedBy));
                return false;
            }

            bool reply = false;
            string errMessage = "";
            List<sqlTable> list = new List<sqlTable>();

            reply = RuleBegin(lot, rule, stepId, list, ref errMessage);

            if (list.Count > 0)
            {
                IMessageGuard client = serviceHost.Client;
                try
                {
                    client.beginTxn();
                    sqlExecuter.executeSqlTables(list, client);
                    client.commitTxn();
                }
                catch
                {
                    client.rollbackTxn();
                }
            }

            if (reply)
                CurrentLot = lot;
            else if (!errMessage.Equals(""))
            {
                idv.MESApplication.PlayNGSound();
                ShowTxnMessage(lot.name, false, errMessage);
            }

            return reply;
        }
        static bool RuleBegin(Lot lot, idv.mesCore.mesClientRule rule, string stepId, List<sqlTable> sqlList, ref string errMessage)
        {
            bool reply = CheckLotQTime(lot);

            //記錄曾檢查什麼，及檢查的結果
            //sqlTable

            return reply;
        }

        public static bool TxnBegin(Lot lot, Controls.StepDC stepDc)
        {
            string judgePath = "";
            return TxnBegin(lot, stepDc, ref judgePath);
        }
        public static bool TxnBegin(Lot lot, Controls.StepDC stepDc, ref string judgePath)
        {
            return TxnBegin(lot, CurrentEquipment, stepDc, ref judgePath);
        }
        public static bool TxnBegin(Lot lot, Equipment eqp, Controls.StepDC stepDc)
        {
            string judgePath = "";
            return TxnBegin(lot, eqp, stepDc, ref judgePath);
        }
        public static bool TxnBegin(Lot lot, Equipment eqp, Controls.StepDC stepDc, ref string judgePath)
        {
            return TxnBegin(lot, eqp, stepDc, ref judgePath, true);
        }
        public static bool TxnBegin(Lot lot, Equipment eqp, Controls.StepDC stepDc, ref string judgePath, bool checkEqCondition)
        {
            List<sqlTable> list = new List<sqlTable>();
            PRP.DCItem[] dcItems = new PRP.DCItem[] { };
            List<PRP.DCItem> failDcItem = new List<PRP.DCItem>();
            string errMessage = "";
            bool showMsgbox = judgePath == null;
            bool reply = true;
            if (stepDc != null && stepDc.Count > 0)
            {
                if (stepDc.ValidateInputValue(false, false, ref errMessage, failDcItem))
                    dcItems = stepDc.GetDCItems();
                else
                {
                    reply = false;
                    if (failDcItem.Count > 0)
                    {
                        judgePath = failDcItem[0].checkFailPath;
                        errMessage = failDcItem[0].GetCheckFailMessage();
                    }
                }
            }

            if (reply) reply = PARM.StepParameter.CheckStepParameter(lot, eqp, dcItems, ref errMessage, failDcItem, checkEqCondition);
            if (!reply && failDcItem.Count > 0)
            {
                judgePath = failDcItem[0].checkFailPath;
                errMessage = failDcItem[0].GetCheckFailMessage();
            }

            if (reply) reply = TxnBegin(lot, dcItems, list, ref errMessage);


            if (list.Count > 0)
            {
                IMessageGuard client = serviceHost.IsolationClient;
                try
                {
                    client.beginTxn();
                    sqlExecuter.executeSqlTables(list, client);
                    client.commitTxn();
                }
                catch
                {
                    client.rollbackTxn();
                }
            }

            if (!reply && (showMsgbox || string.IsNullOrWhiteSpace(judgePath)))
            {
                if (serviceHost.atServer)
                    throw new Exception(errMessage);
                else
                {
                    idv.MESApplication.PlayNGSound();
                    ShowTxnMessage(lot.name, false, errMessage);
                }
            }

            return reply;
        }

        static bool TxnBegin(Lot lot, PRP.DCItem[] dcItems, List<sqlTable> sqlList, ref string errMessage)
        {

            return true;
        }
    }
}
