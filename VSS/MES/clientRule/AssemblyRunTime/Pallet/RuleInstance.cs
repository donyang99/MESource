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
using WeifenLuo.WinFormsUI.Docking;

//1. search Pallet and replace to your <RuleName>
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
namespace ClientRule.Pallet
{
    public class RuleInstance : idv.mesCore.mesClientRule
    {
        /// <summary>
        /// Order,WIP,EQP is default option, user can define other Category
        /// ruleCategory show on client GUI as MenuItem(top level)
        /// if ruleCategory is empty, this rule won't show on client GUI
        /// </summary>
        public override string ruleCategory//RunTime Rule的ruleCategory回傳空白(不會顯示在Client的Rule選單上)
        {
            get 
            {
                if (!systemConfig.assemblyMode)//非組裝模式，從選單上執行功能
                    return "Order";
                else                           //組裝模式，設定為站點功能(選機台執行功能)
                    return "";
            }
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
            get { return 900; }
        }

        /// <summary>
        /// check data and return the result
        /// if return false, the rule will terminate immediately 
        /// </summary>
        /// <returns></returns>
        public override bool PreExecute()
        {
            if (!systemConfig.assemblyMode) 
            {
                if (WorkFlow.CurrentStep.Equals("")) return false;
                foreach (idv.mesCore.mesMessageBase item in items)
                {
                    if (item is Lot)
                    {
                        if ((item as Lot).isDispatching)//非組裝模式，不能由Dispatch執行
                            return false;
                    }
                }
                //站點必需包含當前(Pallet)Rule
                step = new mesRelease.PRP.Step(WorkFlow.CurrentStep);
                if (step.Item(ruleName) == null)
                    return false;
                else
                    return true;
            }
            return true;
        }
        /// <summary>
        /// start the Rule Execution
        /// </summary>
        public override void Execute()
        {
            try
            {
                _MainForm = new frmMain();
                if (!systemConfig.assemblyMode)
                {
                    _MainForm.SetCurrentStep(step);
                    _MainForm.ShowDialog();
                    _MainForm.Close();
                    _MainForm = null;
                }
                else
                    _MainForm.Tag = "";//站點RuleTime功能，不賦值(顯示站點名稱)
            }
            catch
            {
                _MainForm.Close();
                _MainForm = null;
            }
        }
        mesRelease.PRP.Step step = null;
        frmMain _MainForm = null;
        public override WeifenLuo.WinFormsUI.Docking.DockContent GetForm()
        {
            if (_MainForm == null)
                _MainForm = new frmMain();

            step = new mesRelease.PRP.Step(WorkFlow.CurrentStep);
            _MainForm.SetCurrentStep(step);
            return _MainForm;
        }

        public static Lot GetItem(int index)
        {
            if (_clientRule != null)
                return (Lot)_clientRule.getItem(index);
            return null;
        }

        #region add by designer and no need to modify
        internal static idv.mesCore.mesClientRule _clientRule = null;
        public static idv.mesCore.mesClientRule ClientRule
        {
            get { return _clientRule; }
        }
        public static string RuleName
        {
            get
            {
                if(_clientRule != null)
                    return _clientRule.ruleName;
                return "";
            }
        }
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
            if(stdStatusbar != null)
                stdStatusbar.setVersion(System.Reflection.Assembly.GetAssembly(this.GetType()).GetName().Version.ToString());
        }
        public override void Dispose()
        {
            try
            {
                if(_MainForm != null)
                    _MainForm.Close();
            }
            catch { }
            _MainForm = null;
            _clientRule = null;
            base.Dispose();
        }

        #region logger
        public static NLog.Logger Logger
        {
            get
            {
                if(_clientRule == null) return null;
                return _clientRule.logger;
            }
        }

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

        #region statusbar
        public static void StatusbarShowMessage(string message)
        {
            if(_clientRule == null || _clientRule.stdStatusbar == null) return;
            _clientRule.stdStatusbar.setInformation(message);
        }
        public static void StatusbarShowMessage(string message, idv.mesCore.Controls.informationType infoType)
        {
            if(_clientRule == null || _clientRule.stdStatusbar == null) return;
            _clientRule.stdStatusbar.setInformation(message, infoType);
        }

        public static void StatusbarShowMessageById(string key)
        {
            if(_clientRule == null || _clientRule.stdStatusbar == null) return;
            _clientRule.stdStatusbar.setInformationById(key);
        }
        public static void StatusbarShowMessageById(string key, idv.mesCore.Controls.informationType infoType)
        {
            if(_clientRule == null || _clientRule.stdStatusbar == null) return;
            _clientRule.stdStatusbar.setInformationById(key, infoType);
        }
        public static void StatusbarShowMessageById(string key, idv.mesCore.Controls.informationType infoType, params string[] args)
        {
            if(_clientRule == null || _clientRule.stdStatusbar == null) return;
            _clientRule.stdStatusbar.setInformationById(key, infoType, args);
        }
        #endregion

        #endregion
    }
}
