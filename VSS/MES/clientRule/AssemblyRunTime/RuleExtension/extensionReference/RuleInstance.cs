using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using mesRelease.EQP;
using mesRelease.WIP;
using mesRelease.PRP;
using idv.mesCore.Controls;
using mesRelease.Controls;

namespace step_1630
{
    //專案名稱需改為step_[stepId]，例如step_1000, step_packing
    public class RuleInstance : ruleExtension.RuleExtension
    {
        step_Assembly.RuleInstance ruleExtAssembly = null;
        public override void RuleStart(string fab, Step step, Equipment eqp, string ruleName, StepDC stepDC, NextStepInfo nextStep, ReasonCode reasonPanel, Panel pnlLeft, Panel pnlBottom, NLog.Logger logger)
        {
            ruleExtAssembly = new step_Assembly.RuleInstance();
            ruleExtAssembly.InputDataCompleted += new EventHandler(ruleExt1600_InputDataCompleted);
            ruleExtAssembly.RuleStart(fab, step, eqp, ruleName, stepDC, nextStep, reasonPanel, pnlLeft, pnlBottom, logger);
        }

        void ruleExt1600_InputDataCompleted(object sender, EventArgs e)
        {
            this.InputDataComplete();
        }

        public override void RuleEnd()
        {
            ruleExtAssembly.RuleEnd();
        }

        public override bool LotRetrieved(Lot lot)
        {
            return ruleExtAssembly.LotRetrieved(lot);
        }

        public override bool CheckBeforeTxn(txnBase txn, List<sqlTable> executeSQL, List<object> objectList)
        {
            return ruleExtAssembly.CheckBeforeTxn(txn, executeSQL, objectList);
        }

        public override void ActionAfterTxn(string result)
        {
            ruleExtAssembly.ActionAfterTxn(result);
        }

        public override bool SetFocus()
        {
            return ruleExtAssembly.SetFocus();
        }
    }
}
