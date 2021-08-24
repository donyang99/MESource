using System;
using System.Collections.Generic;
using System.Text;
using mesRelease.PARM;

namespace mesFABMonitor
{
    public static class misc
    {
        static Dictionary<string, double> dicProcessTime = new Dictionary<string, double>();
        public static double GetStandardProcessTime(string specSysId, string stepId)
        {
            if (!dicProcessTime.ContainsKey(specSysId + "@" + stepId))
            {
                StepParameter sp = mesRelease.PARM.StepParameter.GetSpecStep(specSysId, stepId);
                if (sp == null)
                    dicProcessTime.Add(specSysId + "@" + stepId, 0);
                else
                    dicProcessTime.Add(specSysId + "@" + stepId, sp.stdProcessTime);
            }
            return dicProcessTime[specSysId + "@" + stepId];
        }
    }
}
