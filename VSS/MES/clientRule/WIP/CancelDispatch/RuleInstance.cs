using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore;
using idv.mesCore.WF;
using mesRelease.WF;
using mesRelease.WIP;
using mesRelease.WIP.Txn;
using mesRelease.EQP;
using mesRelease.USR;
using idv.utilities;

namespace ClientRule.CancelDispatch
{
    public class RuleInstance : idv.mesCore.mesClientRule
    {
        /// <summary>
        /// Order,WIP,EQP is default option, user can define other Category
        /// ruleCategory show on client GUI as MenuItem(top level)
        /// if ruleCategory is empty, this rule won't show on client GUI
        /// </summary>
        public override string ruleCategory
        {
            get { return "WIP"; }//RunTime Rule的ruleCategory回傳空白(不會顯示在Client的Rule選單上)
        }
        /// <summary>
        /// ruleGroup show on client GUI as sub MenuItem belong to ruleCategory
        /// if ruleCategory is empty, ruleGroup is not necessary
        /// if ruleGroup is empty, rule will belong ruleCategory MenuItem directly
        /// </summary>
        public override string ruleGroup
        {
            get { return "SpecialFunction"; }
        }
        /// <summary>
        /// order sequence of rule MenuItem
        /// </summary>
        public override short ruleOrderIndex
        {
            get { return 990; }
        }

        /// <summary>
        /// check data and return the result
        /// if return false, the rule will terminate immediately 
        /// </summary>
        /// <returns></returns>
        public override bool PreExecute()
        {
            for (int i = 0; i < RuleInstance.ItemCount; i++)
            {
                if (!RuleInstance.GetItem(i).isDispatching)
                {
                    messageBox.showMessageById("msgStatusInvalid");
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// start the Rule Execution
        /// </summary>
        public override void Execute()
        {
            logFunctionIn("Execute");
            if (messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("CancelDispatch")))
            {
                for (int i = 0; i < RuleInstance.ItemCount; i++)
                    WorkFlow.DispatchCancel(RuleInstance.GetItem(i));
            }
            logFunctionOut("Execute");
        }

        public static Lot GetItem(int index)
        {
            if (_clientRule != null)
                return (Lot)_clientRule.getItem(index);
            return null;
        }

        #region add by designer and no need to modify
        static idv.mesCore.mesClientRule _clientRule = null;
        public static string RuleResult
        {
            get
            {
                if (_clientRule != null)
                    return _clientRule.ruleResult;
                return "";
            }
            set
            {
                if (_clientRule != null)
                    _clientRule.ruleResult = value;
            }
        }
        public static int ItemCount
        {
            get
            {
                if (_clientRule != null)
                    return _clientRule.itemCount;
                return 0;
            }
        }
        public static void AddItem(Lot item)
        {
            if (_clientRule != null)
                _clientRule.addItem(item);
        }
        public static void ClearItems()
        {
            if (_clientRule != null)
                _clientRule.clearItems();
        }
        public static int ParameterCount
        {
            get
            {
                if (_clientRule != null)
                    return _clientRule.parameterCount;
                return 0;
            }
        }
        public static string GetParameter(string key)
        {
            if (_clientRule != null)
                return _clientRule.getParameter(key);
            return "";
        }
        public static void AddParameter(string key, string value)
        {
            if (_clientRule != null)
                _clientRule.addParameter(key, value);
        }
        public static string GetParameterKey(int index)
        {
            if (_clientRule != null)
                return _clientRule.getParameterKey(index);
            return "";
        }
        public static string GetParameterValue(int index)
        {
            if (_clientRule != null)
                return _clientRule.getParameterValue(index);
            return "";
        }

        public static void Feedback(idv.messageService.txnBase txn)
        {
            if (_clientRule != null)
            {
                _clientRule.clearItems();
                foreach (idv.messageService.itemBase item in txn.Items)
                    _clientRule.addItem(item);
                _clientRule.errMessage = txn.errMessage;
            }
        }

        public override void Init()
        {
            _clientRule = this;
        }
        public override void Dispose()
        {
            _clientRule = null;
            base.Dispose();
        }

        #region logger
        internal static void logFunctionIn(string functionName, params string[] itemValues)
        {
            if (_clientRule == null) return;
            log.logFunctionIn(_clientRule.logger, functionName, itemValues);
        }

        internal static void logFunctionOut(string functionName, params string[] itemValues)
        {
            if (_clientRule == null) return;
            log.logFunctionOut(_clientRule.logger, functionName, itemValues);
        }

        internal static void logError(string functionName, Exception ex)
        {
            if (_clientRule == null) return;
            log.logError(_clientRule.logger, functionName, ex);
        }

        internal static void logWarn(string functionName, Exception ex)
        {
            if (_clientRule == null) return;
            log.logWarn(_clientRule.logger, functionName, ex);
        }
        internal static void logWarn(string functionName, params string[] itemValues)
        {
            if (_clientRule == null) return;
            log.logWarn(_clientRule.logger, functionName, itemValues);
        }

        internal static void logObjectInfo(string functionName, idv.messageService.itemBase item)
        {
            if (_clientRule == null) return;
            log.logObjectInfo(_clientRule.logger, functionName, item);
        }
        internal static void logObjectInfo(string functionName, idv.messageService.itemBase item, NLog.LogLevel logLevel)
        {
            if (_clientRule == null) return;
            log.logObjectInfo(_clientRule.logger, functionName, item, logLevel);
        }

        internal static void logInfomation(string what, params string[] itemValues)
        {
            if (_clientRule == null) return;
            log.logInfomation(_clientRule.logger, what, itemValues);
        }
        #endregion

        #endregion
    }
}
