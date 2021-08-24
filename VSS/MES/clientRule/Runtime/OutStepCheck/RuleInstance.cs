﻿using System;
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

//1. search OutStepCheck and replace to your <RuleName>
//   1.1 namespace of RuleInstance.cs
//   1.2 namespace of frmMain.cs(frmMain.Designer.cs also)
//2. rename solution and project name to your <RuleName>
//3. modify project property
//   3.1 Assembly name to your <RuleName>
//   3.2 Default namespace to ClientRule.<RuleName>
//4. implement idv.mesCore.mesClientRule properties in this Class
//   4.1 ruleCategory, ruleGroup and ruleOrderIndex
//5. modify GetItem(int index) in this class for return Collect Class Type
//6. base on your Rule logic, start coding with predefined PreExecute() and Execute() method
//   system will call PreExecute() and then Execute(), if PreExecute() return false
//   the rule will be terminate without calling Execute()
//   if your Rule need UI to interact with user, show form on Execute() method
//   and put the logic in the form, please refer frmMain for further coding standards
namespace ClientRule.OutStepCheck
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
            get { return ""; }//RunTime Rule的ruleCategory回傳空白(不會顯示在Client的Rule選單上)
        }
        /// <summary>
        /// ruleGroup show on client GUI as sub MenuItem belong to ruleCategory
        /// if ruleCategory is empty, ruleGroup is not necessary
        /// if ruleGroup is empty, rule will belong ruleCategory MenuItem directly
        /// </summary>
        public override string ruleGroup
        {
            get { return ""; }
        }
        /// <summary>
        /// order sequence of rule MenuItem
        /// </summary>
        public override short ruleOrderIndex
        {
            get { return 0; }
        }

        /// <summary>
        /// check data and return the result
        /// if return false, the rule will terminate immediately 
        /// </summary>
        /// <returns></returns>
        public override bool PreExecute()
        {
            string path = GetParameter("NextPathByWipReceive");//在製品接收功能傳過來的參數
            if (!path.Equals(""))
            {
                MoveOutTxn(path);
                return false;
            }
            path = GetParameter("NextPath");
            if (!path.Equals(""))
            {
                MoveOutTxn(path);
                return false;
            }

            Lot curLot = GetItem(0);
            if (curLot.GetCurrentRule().dispatchFlag)//設定為自動執行
            {
                if (!GetParameter("PreviousRule").Equals(""))//WorkFlow自動執行
                {
                    if (curLot.ruleResult.Equals("PASS") || curLot.ruleResult.Equals(""))//前一個Rule交易時判定正常過帳
                        RuleResult = "CANCEL";//退回原Rule(等待手動執行畫面)
                    else
                        MoveOutTxn(curLot.ruleResult);//立即執行交易(留下MoveOut記錄)並回傳前一個交易判定的result，讓Lot往相應的路徑往下走
                    
                    return false;
                }
                else if (!GetParameter("TriggerRule").Equals(""))//由Adhoc功能觸發的一律退回原Rule
                {
                    RuleResult = "CANCEL";
                    return false;
                }
            }

            for (int i = 0; i < RuleInstance.ItemCount; i++)
            {
                Lot lot = RuleInstance.GetItem(i);
                if ((!lot.isDispatching && !systemConfig.assemblyMode) ||
                     !lot.status.Equals(idv.mesCore.WIP.LotStatus.WAIT.ToString()))
                    return false;
            }
            return true;
        }

        void MoveOutTxn(string path)
        {
            MoveOut txn = new MoveOut();
            txn.txnUser = User.loginUserId;
            txn.result = path;
            for (int i = 0; i < ItemCount; i++)
                txn.Add(GetItem(i));

            txn.comments = GetParameter("Comments");
            try
            {
                txn = txn.doTxn();
                if (txn.result.Equals("PASS"))
                {
                    RuleResult = txn.Item(0).ruleResult;
                }
                else
                {
                    throw new Exception(txn.errMessage);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// start the Rule Execution
        /// </summary>
        public override void Execute()
        {
            frmMain frm = new frmMain();
            try
            {
                frm.standardStatusbar1.setUser(User.loginUser.name);
                frm.standardStatusbar1.setVersion(idv.messageService.dynamicAssembly.assemblyVersion(ruleName + ".dll"));
                frm.ShowDialog();
            }
            finally
            {
                frm.Close();
            }
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
