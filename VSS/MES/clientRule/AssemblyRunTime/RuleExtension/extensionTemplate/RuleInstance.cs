using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using mesRelease.EQP;
using mesRelease.WIP;
using mesRelease.PRP;
using idv.mesCore.Controls;
using idv.messageService;
using idv.messageService.sql;
using mesRelease.Controls;
using ruleExtension;

namespace step_Assembly
{    
    public class RuleInstance : ruleExtension.RuleExtension
    {
        extensionForm frm = null;
        extensionForm GetFormByRule(string ruleName)
        {
            //依Rule 回傳相應的Form
            if ((ruleName.Equals("TrackIn") && !idv.mesCore.systemConfig.assemblyMode)
                || (ruleName.Equals("AssemblyTrackOut") && idv.mesCore.systemConfig.assemblyMode))
                return new frmTrackOut();
            else
                return null;
        }

        public override void RuleStart(string fab, Step step, Equipment eqp, string ruleName, StepDC stepDC, NextStepInfo nextStep, ReasonCode reasonPanel, Panel pnlLeft, Panel pnlBottom, NLog.Logger logger)
        {
            base.RuleStart(fab, step, eqp, ruleName, stepDC, nextStep, reasonPanel, pnlLeft, pnlBottom, logger);

            frm = GetFormByRule(ruleName);

            if (frm == null) return;

            frm.RuleInfo = this;

            Panel pnl = frm.GetLeftContent();
            if(pnl != null)
            {
                if (pnl.Height > pnlLeft.Height)
                    pnlLeft.Height = pnl.Height;
                pnl.Parent = pnlLeft;
                pnl.Dock = DockStyle.Fill;
            }
            
            pnl = frm.GetBottomContent();
            if(pnl != null)
            {
                if (pnl.Height > pnlBottom.Height)
                    pnlBottom.Height = pnl.Height;
                pnl.Parent = pnlBottom;
                pnl.Dock = DockStyle.Fill;
            }
            
            frm.RuleStart();
        }

        public override void RuleEnd()
        {
            if (frm == null) return;

            Panel pnl = frm.GetLeftContent();
            if(pnl != null)            
                pnl.Parent = frm;

            pnl = frm.GetBottomContent();
            if(pnl != null)
                pnl.Parent = frm;

            frm.RuleEnd();

            try
            {                
                frm.Close();
                frm.Dispose();
            }
            catch { }
            frm = null;
            base.RuleEnd();
        }


        public override bool LotRetrieved(Lot lot)
        {
            if (frm == null) return true;
  
            return frm.LotRetrieved(lot);
        }

        public override bool CheckBeforeTxn(txnBase txn, List<sqlTable> executeSQL, List<object> objectList)
        {
            if (frm == null) return true;

            return frm.CheckBeforeTxn(txn, executeSQL, objectList);
        }

        public override void ActionAfterTxn(string result)
        {
            if (frm == null) return;

            frm.ActionAfterTxn(result);
        }

        public override bool SetFocus()
        {
            if (frm == null) return false;

            return frm.SetFocus();
        }
    }
}
