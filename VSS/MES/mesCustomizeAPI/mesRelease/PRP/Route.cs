using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore;
using idv.mesCore.PRP;
using idv.utilities;

namespace mesRelease.PRP
{
    public class Route : idv.mesCore.PRP.route<Route, Node>
    {
        public Route() { }
        public Route(string name) : base(name) { }
        public Route(string name, short version) : base(name, version) { }
        internal new void retrieveRoute(string sysId)
        {
            base.retrieveRoute(sysId);
        }

        protected override void OnInit(System.Data.DataRow row)
        {

        }

        protected override void OnNew(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnModify(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnDelete(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        private bool checkRouteTypeNodePaths(Node n)
        {
            Route r = n.GetRoute();
            foreach(Node exitNode in r.Items)
            {
                if (exitNode.nodeKind == NodeKind.Exit)
                {
                    List<string> paths = new List<string>();
                    foreach (string path in exitNode.Paths())
                    {
                        if (paths.Contains(path))
                            return false;
                        paths.Add(path);
                    }
                }
                if (exitNode.nodeType == NodeType.Route)
                {
                    if (!checkRouteTypeNodePaths(exitNode))
                        return false;
                }
            }
            return true;
        }
        public void checkRouteRationality()
        {            
            string message = "";
            int tmp = 0;
            List<Node> oNodeList = new List<Node>();

            //Route.Items只包含自己流程下的node，不包含子流程下的node
            foreach (Node n in Items)
            {
                n.isRework = true;
                oNodeList.Add(n);
                //有一個(只能有一個)起始站點
                if (n.nodeKind == NodeKind.Entry)
                {
                    tmp++;
                    if (tmp > 1)
                    {
                        message = cultureLanguage.getValue("errMoreThanOneEntryNode");
                        if (message.Equals(""))
                            message = "There are more than one 【Entry】 node";
                        message = addErrMsgAddNodeInfo(message, n);
                        throw new Exception(message);
                    }
                }
                else if (n.nodeKind == NodeKind.Exit)
                {
                    //最終站不可以有PASS路徑
                    if (n.NextNode() != null)
                    {
                        message = cultureLanguage.getValue("errExitNodeWithPassPath");
                        if (message.Equals(""))
                            message = "There is a 「PASS」 path in 【Exit】 node";
                        message = addErrMsgAddNodeInfo(message, n);
                        throw new Exception(message);
                    }
                }

                //沒有PASS路徑的站點必為最終站
                if (n.NextNode() == null)
                {
                    if (n.nodeKind != NodeKind.Exit)
                    {
                        message = cultureLanguage.getValue("errLastNodeShouldBeExit");
                        if (message.Equals(""))
                            message = "【NodeKind】 of last node should be 【Exit】";
                        message = addErrMsgAddNodeInfo(message, n);
                        throw new Exception(message);
                    }
                }

                //路徑與子流程Exit Node的路徑名稱重覆
                if (n.nodeType == NodeType.Route)
                {
                    if (!checkRouteTypeNodePaths(n))
                    {
                        message = cultureLanguage.getValue("errPathNameSameWithChildExitNode");
                        if (message.Equals(""))
                            message = "Path name of Node and its Child Node is duplicate";
                        message = addErrMsgAddNodeInfo(message, n);
                        throw new Exception(message);
                    }
                }
            }

            //沒有站點落單
            foreach (Node n in Items)
            {
                foreach (string s in n.availablePaths())
                {
                    oNodeList.Remove(n);
                    oNodeList.Remove(n.NextNode(s));
                }
            }
            if (oNodeList.Count > 0)
            {
                message = cultureLanguage.getValue("errIsolationNode");
                if (message.Equals(""))
                    message = "There are some node isolated";
                message = addErrMsgAddNodeInfo(message, oNodeList[0]);
                throw new Exception(message);
            }

            //必須有起始站
            Node oNode = FirstNode();
            if (oNode == null)
            {
                message = cultureLanguage.getValue("errNoEntryNode");
                if (message.Equals(""))
                    message = "There is no 【Entry】 node";
                throw new Exception(message);
            }
            oNode.isRework = false;
            //PASS路徑從起始站點串到最終站
            oNodeList = new List<Node>();
            oNodeList.Add(oNode);
            oNode = oNode.NextNode();
            if (oNode == null)
            {
                message = cultureLanguage.getValue("errNoCompletedPassPath");
                if (message.Equals(""))
                    message = "There should be a completed route connected by PASS path";
                throw new Exception(message);
            }
            oNode.isRework = false;
            oNodeList.Add(oNode);
            do
            {
                //最後一站(沒有PASS路徑)的站點必須是Exit node
                if (oNode.NextNode() == null)
                {
                    if (oNode.nodeKind != NodeKind.Exit)
                    {
                        message = cultureLanguage.getValue("errLastNodeShouldBeExit");
                        if (message.Equals(""))
                            message = "【NodeKind】 of last node should be 【Exit】";
                        message = addErrMsgAddNodeInfo(message, oNode);
                        throw new Exception(message);
                    }
                    break;
                }

                //起始站至最終站間的站點必須是Interior的站點
                if (oNode.nodeKind != NodeKind.Interior)
                {
                    message = cultureLanguage.getValue("errInteriorNode");
                    if (message.Equals(""))
                        message = "【NodeKind】 of nodes between 【Entry node】 and 【Exit node】 should be 【Interior】";
                    message = addErrMsgAddNodeInfo(message, oNode);
                    throw new Exception(message);
                }
                oNode = oNode.NextNode();
                oNode.isRework = false;
                //過程中不可以經過已經經過的站點(會繞不出去)
                foreach (Node n in oNodeList)
                {
                    if (n == oNode)
                    {
                        message = cultureLanguage.getValue("errLoopWithoutExit");
                        if (message.Equals(""))
                            message = "There is a Loop without Exit";
                        message = addErrMsgAddNodeInfo(message, n);
                        throw new Exception(message);
                    }
                }
                oNodeList.Add(oNode);
            } while (true);

            if (systemConfig.useStepIdAsHandle)
            {
                Dictionary<string, string> nodeIds = new Dictionary<string, string>();
                foreach (Node n in Items)
                    checkNodeIdRepeat(n, nodeIds);
            }
        }
        private void checkNodeIdRepeat(Node n, Dictionary<string, string> nodeIds)
        {
            try
            {
                nodeIds.Add(n.name, n.name);
                if (n.nodeType == NodeType.Route)
                {
                    Route route = n.GetRoute();
                    foreach (Node oNode in route.Items)
                        checkNodeIdRepeat(oNode, nodeIds);
                }
            }
            catch
            {
                throw new Exception(addErrMsgAddNodeInfo("NodeId id duplicate", n));
            }
        }
        string addErrMsgAddNodeInfo(string errMsg,Node n)
        {
            string nodeDesc = cultureLanguage.getValue("node");
            if (nodeDesc.Equals("")) nodeDesc = "Node";
            return errMsg + Environment.NewLine + "(" + nodeDesc + " : " + n.name + ")";
        }

        public Step FirstStep()
        {
            return firstStep(this);
        }
        private Step firstStep(Route route)
        {
            Node n = route.FirstNode();
            if (n == null) return null;
            if (n.nodeType == idv.mesCore.PRP.NodeType.Step)
                return n.GetStep();
            else
                return firstStep(n.GetRoute());
        }

        public Node[] GetStepNodes()
        {
            renewActiveVersion();
            List<Node> stepNodes = new List<Node>();
            ListStepNodes(this, stepNodes);
            return stepNodes.ToArray();
        }
        void ListStepNodes(Route route, List<Node> list)
        {
            if (route == null) return;
            foreach (Node node in route.Items)
            {
                if (node.nodeType == NodeType.Route)
                    ListStepNodes(node.GetRoute(), list);
                else
                    list.Add(node);
            }
        }

        public override void retrieveNodes()
        {
            if (_nodesRetrieved || base.Count != 0) return;
            if (this.sysid == "") return;
            List<Node> tmpNodeList = new List<Node>();
            int iTmp = 0;
            Clear();
            //先取得所有站點
            string sql = "select a.sysid node_sysid,a.parent_sysid,a.node_id,a.node_kind " +
                         ",a.node_type,a.pos_x,a.pos_y,a.node_ref,a.handle,a.iterate,a.is_rework,b.* " +
                         ",c.sysid sysid_route,c.route_id route_id_route,c.version version_route,c.description description_route " +
                         ",c.route_type route_type_route,c.issue_state issue_state_route,c.create_user create_user_route " +
                         ",c.create_date create_date_route,c.modify_user modify_user_route,c.modify_date modify_date_route " +
                         ",c.delete_flag delete_flag_route from mes_prp_routing_node a " +
                         "left join mes_prp_step b on a.node_ref = b.sysid " +
                         "left join mes_prp_routing c on a.node_ref = c.sysid " +
                         "where a.route_sysid=? " +
                         "order by a.parent_sysid";
            DataSet ds = serviceHost.Client.getDataSetWithParameter(sql, sysid);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (systemConfig.useStepIdAsHandle && !row["parent_sysid"].Equals("-")) continue;
                Node n = new Node();
                n.sysid = row["node_sysid"].ToString();
                n.name = row["node_id"].ToString();
                n.parentNode = null;
                n.nodeKind = (NodeKind)Enum.Parse(typeof(NodeKind), row["node_kind"].ToString());
                n.nodeType = (NodeType)Enum.Parse(typeof(NodeType), row["node_type"].ToString());
                iTmp = 0;
                int.TryParse(row["pos_x"].ToString(), out iTmp);
                n.posX = iTmp;
                iTmp = 0;
                int.TryParse(row["pos_y"].ToString(), out iTmp);
                n.posY = iTmp;
                n.nodeRefSysId = row["node_ref"].ToString();
                n.handle = row["handle"].ToString();
                n.iterate = Convert.ToInt16(row["iterate"]);
                n.isRework = row["is_rework"].ToString() == "1" ? true : false;

                if (n.nodeRefSysId != "")
                {
                    if (row["node_type"].ToString() == NodeType.Step.ToString())
                    {
                        Step s = new Step();
                        s.putAttribute(row, "");
                        s.routeId = name;
                        n.nodeRef = s;
                    }
                    else
                    {
                        if (systemConfig.useStepIdAsHandle)
                            n.nodeRef = Route.GetRoute(n.name, -1);
                        else
                        {
                            Route r = new Route();
                            r.putAttribute(row, "_route");
                            n.nodeRef = r;
                        }
                    }
                }

                if (row["parent_sysid"].ToString() == "-")
                    Add(n);
                else
                {
                    Node parentNode = findNodeBySysId(row["parent_sysid"].ToString(), this);

                    if (parentNode == null)
                    {
                        n.tag = row["parent_sysid"].ToString();
                        tmpNodeList.Add(n);
                    }
                    else
                    {
                        Route parentRoute = parentNode.GetRoute();
                        if (parentRoute != null)
                        {
                            n.parentNode = parentNode;
                            parentRoute.Add(n);
                            if (n.nodeType == NodeType.Step)
                            {
                                Step s = n.GetStep();
                                if (s != null)
                                {
                                    s.routeId = parentRoute.name;
                                }
                            }
                        }
                    }
                }
            }

            if (tmpNodeList.Count > 0)
            {
                iTmp = 0;
                do
                {
                    Node childNode = tmpNodeList[iTmp];
                    Node parentNode = findNodeBySysId(childNode.tag, this);
                    if (parentNode == null)
                    {
                        iTmp++;
                    }
                    else
                    {
                        Route parentRoute = parentNode.GetRoute();
                        if (parentRoute != null)
                        {
                            childNode.parentNode = parentNode;
                            parentRoute.Add(childNode);
                            if (childNode.nodeType == NodeType.Step)
                            {
                                Step s = childNode.GetStep();
                                if (s != null)
                                {
                                    s.routeId = parentRoute.name;
                                }
                            }
                        }
                        tmpNodeList.Remove(childNode);
                    }
                    if (iTmp >= tmpNodeList.Count)
                        iTmp = 0;
                } while (tmpNodeList.Count > 0);
            }

            //再取得所有路徑後關聯node
            sql = "select * from mes_prp_routing_path " +
                         "where route_sysid=?";
            ds = serviceHost.Client.getDataSetWithParameter(sql, sysid);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Node fromNode = findNodeBySysId(dr["from_node"].ToString(), this);
                if (fromNode == null) continue;

                Node toNode = findNodeBySysId(dr["to_node"].ToString(), this);
                if (toNode == null) continue;
                int pathColor = int.Parse(dr["color"].ToString());
                fromNode.NextNodeAdd(dr["path"].ToString(), toNode, pathColor);
            }
            _nodesRetrieved = true;
        }

        public string AddPath(string path, Node fromNode, Node toNode, int color)
        {
            bool flag = false;
            foreach (string s in fromNode.availablePaths())
            {
                if (s == path)
                    flag = true;
                if (fromNode.NextNode(s) == toNode)
                    throw new Exception("there is a path already");
            }
            if (flag)
            {
                for (int i = 1; i < 10000; i++)
                {
                    path = "PATH_" + i.ToString();
                    flag = false;
                    foreach (string s in fromNode.availablePaths())
                    {
                        if (s == path)
                            flag = true;
                    }
                    if (!flag) break;
                }
            }
            fromNode.NextNodeAdd(path, toNode, color);
            return path;
        }

        //儲存當前流程下的站點訊息(不包含子流程下的)
        public void SaveNodes()
        {
            List<sqlTable> sqlList = new List<sqlTable>();
            applyTables_SaveNodes(sqlList);
            IMessageGuard mg = serviceHost.Client;
            try
            {
                mg.beginTxn();
                sqlExecuter.executeSqlTables(sqlList, mg);
                mg.commitTxn();
            }
            catch
            {
                mg.rollbackTxn();
                throw;
            }
        }
        private void applyTables_SaveNodes(List<sqlTable> sqlList)
        {
            modifyDate = serviceHost.dateTime;
            sqlTable table = new sqlTable("mes_prp_routing", eDMLtype.Update);
            table.Add("modify_user", modifyUser);
            table.Add("modify_date", modifyDate);
            table.WhereClause.Add("sysid", sysid);
            sqlList.Add(table);
            retrieveNodes();
            if (issueState != IssueState.New)
            {
                if (!systemConfig.useStepIdAsHandle)
                    throw new ArgumentException("issueState is not New");
                else//以站點名稱為識別的，已作用版本可以修改(立即作用到生產線)
                {
                    checkRouteRationality();
                    nodeSaveDetail(sqlList);
                    return;
                }
            }
            table = new sqlTable("mes_prp_routing_node", eDMLtype.Delete);
            table.WhereClause.Add("route_sysid", sysid);
            sqlList.Add(table);

            table = new sqlTable("mes_prp_routing_path", eDMLtype.Delete);
            table.WhereClause.Add("route_sysid", sysid);
            sqlList.Add(table);

            foreach (Node item in Items)
            {
                table = new sqlTable("mes_prp_routing_node", eDMLtype.Insert);
                item.sysid = System.Guid.NewGuid().ToString();

                table.Add("sysid", item.sysid);
                table.Add("route_sysid", sysid);
                table.Add("parent_sysid", "-");
                table.Add("node_id", item.name);
                table.Add("node_kind", item.nodeKind.ToString());
                table.Add("node_type", item.nodeType.ToString());
                table.Add("pos_x", item.posX);
                table.Add("pos_y", item.posY);
                table.Add("iterate", item.iterate);
                table.Add("is_rework", "1");
                sqlList.Add(table);
            }

            foreach (Node item in Items)
            {
                foreach (string s in item.availablePaths())
                {
                    table = new sqlTable("mes_prp_routing_path", eDMLtype.Insert);
                    table.Add("route_sysid", sysid);
                    table.Add("from_node", item.sysid);
                    table.Add("path", s);
                    table.Add("to_node", item.NextNode(s).sysid);
                    table.Add("color", item.PathColor(s));
                    sqlList.Add(table);
                }
            }
        }

        public void Issue()
        {
            List<sqlTable> sqlList = new List<sqlTable>();
            applyTables_Issue(sqlList);
            IMessageGuard mg = serviceHost.Client;
            try
            {
                mg.beginTxn();
                sqlExecuter.executeSqlTables(sqlList, mg);
                mg.commitTxn();
                _otherVersion = null;
            }
            catch
            {
                mg.rollbackTxn();
                throw;
            }
        }
        private void applyTables_Issue(List<sqlTable> sqlList)
        {
            retrieveNodes();
            bool bSaveDetailRouting = false;
            if (issueState == IssueState.New)
            {
                checkRouteRationality();
                bSaveDetailRouting = true;
            }

            modifyDate = serviceHost.dateTime;
            if (issueState == IssueState.Active) issueState = IssueState.Frozen;
            else issueState = IssueState.Active;

            sqlTable table;
            if (issueState == IssueState.Active)
            {
                table = new sqlTable("mes_prp_routing", eDMLtype.Update);
                table.Add("issue_state", IssueState.Frozen.ToString());
                table.Add("modify_user", modifyUser);
                table.Add("modify_date", modifyDate);
                table.Add("flag = version", "");
                table.WhereClause.Add("route_id", name);
                table.WhereClause.Add("issue_state", IssueState.Active.ToString());
                sqlList.Add(table);

                if (_otherVersion != null)
                {
                    foreach (Route r in GetOtherVersions())
                    {
                        if (r.issueState == IssueState.Active)
                            r.issueState = IssueState.Frozen;
                    }
                }
            }
            table = new sqlTable("mes_prp_routing", eDMLtype.Update, 1);
            table.Add("issue_state", issueState.ToString());
            table.Add("modify_user", modifyUser);
            table.Add("modify_date", modifyDate);
            table.WhereClause.Add("sysid", sysid);
            if (issueState == IssueState.Active)
                table.Add("flag", 998);
            else
                table.Add("flag = version", "");
            sqlList.Add(table);

            if (bSaveDetailRouting)
                nodeSaveDetail(sqlList);
        }

        //儲存包含子流程下的所有站點訊息
        private void nodeSaveDetail(List<sqlTable> sqlList)
        {
            sqlTable table = null;
            table = new sqlTable("mes_prp_routing_node", eDMLtype.Delete);
            table.WhereClause.Add("route_sysid", sysid);
            sqlList.Add(table);

            table = new sqlTable("mes_prp_routing_path", eDMLtype.Delete);
            table.WhereClause.Add("route_sysid", sysid);
            sqlList.Add(table);

            preAssignNodeHandle();

            addNodeToSqlTable("-", this, sqlList, false);
        }

        List<Node> processedNode = new List<Node>();
        private void preAssignNodeHandle()
        {
            if (systemConfig.useStepIdAsHandle)
            {
                foreach (Node oNode in Items)
                    assignNodeHandleWithStepId(oNode);
            }
            else
            {
                dicHandle.Clear();
                List<Node> nodeList = new List<Node>();//非PASS路徑的node
                foreach (Node oNode in Items)
                    oNode.handle = "";

                processedNode.Clear();
                assignNodeHandle(this.FirstNode(), nodeList);
                reAssignNodeHandle(nodeList);
            }
        }
        private void assignNodeHandle(Node theNode, List<Node> nodeList)
        {
            Node n = theNode;
            if (n == null) return;
            do
            {
                if (processedNode.Contains(n)) return;
                processedNode.Add(n);

                if (n.handle.Equals(""))
                {
                    n.nodeRef = null;
                    n.handle = GetHandle(n);
                }

                if (n.nodeType == NodeType.Route)
                {
                    Route r = n.GetRoute();
                    if (r != null)
                    {
                        foreach (Node oNode in r.Items)
                            oNode.handle = "";

                        assignNodeHandle(r.FirstNode(), nodeList);
                    }
                }

                Node temp = null;
                foreach (string s in n.availablePaths())
                {
                    if (s.Equals("PASS"))
                        temp = n.NextNode();
                    else
                    {
                        Node otherPathNode = n.NextNode(s);
                        if (!processedNode.Contains(otherPathNode))
                            nodeList.Add(otherPathNode);
                    }
                }
                n = temp;
            } while (n != null);
        }
        private void reAssignNodeHandle(List<Node> nodeList)
        {
            List<Node> nodes = new List<Node>();
            foreach (Node n in nodeList)
                assignNodeHandle(n, nodes);
            
            if (nodes.Count > 0)
                reAssignNodeHandle(nodes);
        }
        private void addNodeToSqlTable(string parentSysid, Route theRoute, List<sqlTable> sqlList, bool rework)
        {
            sqlTable table = null;
            List<Node> nodeList = new List<Node>();
            foreach (Node n in theRoute.Items)
            {
                table = new sqlTable("mes_prp_routing_node", eDMLtype.Insert);
                n.sysid = System.Guid.NewGuid().ToString();

                table.Add("sysid", n.sysid);
                table.Add("route_sysid", sysid);
                table.Add("parent_sysid", parentSysid);
                table.Add("node_id", n.name);
                table.Add("node_kind", n.nodeKind.ToString());
                table.Add("node_type", n.nodeType.ToString());
                table.Add("pos_x", n.posX);
                table.Add("pos_y", n.posY);

                if (n.nodeType == NodeType.Route)
                {
                    if (n.GetRoute() == null)
                        throw new Exception("Can't find active version for Route 【" + n.name + "】");
                    nodeList.Add(n);
                }
                else
                {
                    if (n.GetStep() == null)
                        throw new Exception("Can't find active version for Step 【" + n.name + "】");
                }
                table.Add("node_ref", n.nodeRefSysId);
                table.Add("handle", n.handle);
                table.Add("iterate", n.iterate);
                table.Add("is_rework", n.isRework || rework ? "1" : "0");

                sqlList.Add(table);
            }

            foreach (Node n in theRoute.Items)
            {
                foreach (string s in n.availablePaths())
                {
                    table = new sqlTable("mes_prp_routing_path", eDMLtype.Insert);
                    table.Add("route_sysid", this.sysid);
                    table.Add("from_node", n.sysid);
                    table.Add("path", s);
                    table.Add("to_node", n.NextNode(s).sysid);
                    table.Add("color", n.PathColor(s));
                    sqlList.Add(table);
                }
            }

            if (!systemConfig.useStepIdAsHandle)
            {
                foreach (Node n in nodeList)
                    addNodeToSqlTable(n.sysid, n.GetRoute(), sqlList, n.isRework);
            }
        }

        Dictionary<string, int> dicHandle = new Dictionary<string, int>();
        string GetHandle(Node n)
        {
            string prefix = "S:";
            if (n.nodeType == NodeType.Route)
                prefix = "R:";
            prefix += n.name + ":";
            int seq = 1;
            if (dicHandle.ContainsKey(prefix))
                seq = dicHandle[prefix] + 1;
            dicHandle[prefix] = seq;
            if (n.nodeType == NodeType.Route)
                return prefix + seq.ToString("00");
            else
                return prefix + seq.ToString("000");
        }

        private void assignNodeHandleWithStepId(Node theNode)//UseStepIdAsHandle才會呼叫
        {
            theNode.nodeRef = null;
            if (theNode.nodeType == NodeType.Step)
                theNode.handle = theNode.GetStep().name;
            else
            {
                Route route = theNode.GetRoute();
                theNode.handle = route.name;
                //foreach (Node oNode in route.Items)//改成子流程可隨時更新(抓最新的Active流程)
                //    assignNodeHandleWithStepId(oNode);
            }
        }

        public Node FindNode(string handle)
        {
            return findNodeByHandle(handle, this);
        }
        public Step FindStep(string handle)
        {
            Node n = FindNode(handle);
            if (n == null) return null;
            return n.GetStep();
        }

        public Node NextNode(string handle, string path)
        {
            Node theNode = FindNode(handle);
            if (theNode == null) return null;
            if (theNode.nodeKind == NodeKind.Exit)
            {
                if (theNode.NextNode(path) != null)//Exit Node may have non PASS path
                    return theNode.NextNode(path);
                do
                {
                    theNode = theNode.parentNode;
                    if (theNode == null) return null;
                    if (theNode.nodeKind != NodeKind.Exit)
                        break;
                    else
                    {
                        if (theNode.NextNode(path) != null)//Exit Node may have non PASS path
                            return theNode.NextNode(path);
                    }
                } while (true);
            }
            theNode = theNode.NextNode(path);
            return theNode;
        }
        public Node NextStepNode(string handle, string path)
        {
            Node n = NextNode(handle, path);
            if (n == null) return null;
            if (n.nodeType == NodeType.Step) return n;
            do
            {
                n = n.GetRoute().FirstNode();
                if (n == null) return null;
                if (n.nodeType == NodeType.Step) return n;
            } while (true);
        }
        public Step NextStep(string handle, string path)
        {
            Node n = NextStepNode(handle, path);
            if (n != null)
                return n.GetStep();
            return null;
        }
        public Step NextStep(string handle, string path, short iterate)
        {
            if (string.Equals(path, "PASS"))
            {
                Node curNode = FindNode(handle);
                if (curNode == null) return null;
                if (curNode.iterate > iterate)
                    return curNode.GetStep();
                else
                    return NextStep(handle, path);
            }
            else
                return NextStep(handle, path);
        }

        public Step[] PreviousStepsById(string name)
        {
            Step s = findStepById(name) as Step;
            if (s == null) return new Step[0];
            return PreviousSteps(s.stepHandle);
        }
        public Step[] PreviousSteps(string handle)
        {
            Step first = FirstStep();          
            List<Step> list = new List<Step>();
            findPreviousSteps(handle, first, list, new List<string>());
            return list.ToArray();
        }
        void findPreviousSteps(string findHandle, Step step, List<Step> prevSteps, List<string> skipSteps)
        {
            if (skipSteps.Contains(step.stepHandle)) return;
            skipSteps.Add(step.stepHandle);
            foreach (string path in step.availablePaths)
            {
                Step next = NextStep(step.stepHandle, path);
                if (next == null) return;
                if (next.stepHandle.Equals(findHandle))
                    prevSteps.Add(step);
                
                findPreviousSteps(findHandle, next, prevSteps, skipSteps);
            }
        }

        internal Node findNodeBySysId(string sysid, Route theRoute)
        {
            foreach (Node n in theRoute.Items)
            {
                if (n.sysid.Equals(sysid))
                    return n;

                if (!systemConfig.useStepIdAsHandle && n.nodeType == NodeType.Route && n.nodeRef != null)
                {
                    Route r = n.GetRoute();
                    Node returnNode = findNodeBySysId(sysid, r);
                    if (returnNode != null)
                        return returnNode;
                }
            }
            return null;
        }

        internal Node findNodeByHandle(string handle, Route theRoute)
        {
            foreach (Node n in theRoute.Items)
            {
                if (n.handle.Equals(handle))
                    return n;
                
                if (n.nodeType == NodeType.Route)
                {
                    Route r = n.GetRoute();
                    Node returnNode = findNodeByHandle(handle, r);
                    if (returnNode != null)
                        return returnNode;
                }
            }
            return null;
        }

        internal Step findStepById(string name, Route theRoute)
        {
            foreach (Node n in theRoute.Items)
            {
                if (n.name.Equals(name) && n.nodeType == NodeType.Step)
                    return n.GetStep();
                
                if (n.nodeType == NodeType.Route)
                {
                    Route r = n.GetRoute();
                    Step returnStep = findStepById(name, r);
                    if (returnStep != null)
                        return returnStep;
                }
            }
            return null;
        }

        public override stepBase findStepById(string name)
        {
            return findStepById(name, this);
        }

        public Step FindStepById(string name)
        {
            return findStepById(name, this);
        }

        public List<Step> GetMainSteps()
        {
            return GetMainSteps(null);
        }
        public List<Step> GetMainSteps(List<Step> otherSteps)
        {
            List<Step> mainSteps = new List<Step>();

            Step s = FirstStep();
            while (s != null)
            {
                mainSteps.Add(s);
                s = NextStep(s.stepHandle, "PASS");
            }

            if (otherSteps != null)
            {
                SortedList<string, Step> srtStep = new SortedList<string, Step>();
                int i = 1;
                foreach (Node node in GetStepNodes())//按指定的seq排序
                {
                    Step step = node.GetStep();
                    if (mainSteps.Contains(step)) continue;
                    srtStep[step.seq + i.ToString("0000")] = step;
                    i++;
                }
                otherSteps.AddRange(srtStep.Values);
            }
            return mainSteps;
        }

        public static void ClearCatch()
        {
            ClearRouteCatch(WF.WorkFlow.ClientId);
        }
    }
}
