using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mesRelease.PRP
{
    public class Node : idv.mesCore.PRP.node<Node>
    {
        internal string tag = "";
        public Step GetStep()
        {
            if (nodeType == idv.mesCore.PRP.NodeType.Route) return null;
            if (nodeRef == null)
            {
                Step s;
                if (nodeRefSysId == "")
                {
                    s = new Step(name);//取得最新版
                    nodeRefSysId = s.sysid;
                    if (nodeRefSysId == "") s = null;
                }
                else
                {
                    s = new Step();
                    s.retrieveStep(nodeRefSysId); 
                }
                nodeRef = s;
            }
            Step returnStep = nodeRef as Step;
            Step.CheckStep(returnStep); //檢查站點是否為最新版
            returnStep.availablePaths = Paths();
            return returnStep;
        }

        public Route GetRoute()
        {
            return GetRoute(false);
        }
        internal Route GetRoute(bool byIssue)
        {
            if (nodeType == idv.mesCore.PRP.NodeType.Step) return null;
            bool bNeedAssignParentNode = false;
            if (nodeRef == null)
            {
                Route r;
                if (nodeRefSysId == "" || idv.mesCore.systemConfig.useStepIdAsHandle)
                {
                    r = Route.GetRoute(name, -1);//取得最新版
                    if (r != null)
                    {
                        nodeRefSysId = r.sysid;
                        if (byIssue)
                        {
                            r = new Route();
                            r.retrieveRoute(nodeRefSysId);
                        }
                    }
                }
                else
                {
                    r = new Route();
                    r.retrieveRoute(nodeRefSysId);
                }
                nodeRef = r;
                bNeedAssignParentNode = true;
            }
            Route ro = nodeRef as Route;
            if (ro.renewActiveVersion() || bNeedAssignParentNode)
            {
                foreach (idv.messageService.itemBase ib in ro.Items)
                {
                    Node n = ib as Node;
                    if (n == null) continue;
                    n.parentNode = this;
                }
            }
            return ro;
        }

        internal new string[] availablePaths()
        {
            return base.availablePaths();
        }

        internal new bool NextNodeAdd(string path, Node node, int color)
        {
            return base.NextNodeAdd(path, node, color);
        }
    }
}
