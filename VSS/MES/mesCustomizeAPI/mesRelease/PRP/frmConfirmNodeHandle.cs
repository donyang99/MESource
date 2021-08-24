using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.PRP;

namespace mesRelease.PRP
{

    public partial class frmConfirmNodeHandle : Form
    {
        Route _curRoute = null;
        bool _result = false;
        public bool result
        {
            get { return _result; }
            set { _result = value; }
        }
        public frmConfirmNodeHandle()
        {
            InitializeComponent();
        }

        public void Init(Route route)
        {
            _curRoute = route;
            foreach (Route r in _curRoute.GetOtherVersions())
            {
                if (_curRoute.version == r.version) continue;
                tmpRouteVersion tmpR = new tmpRouteVersion();
                tmpR.route = r;
                cboVersion.Items.Add(tmpR);
            }
            if (cboVersion.Items.Count > 0)
            {
                cboVersion.SelectedIndex = cboVersion.Items.Count - 1;
                btnQuery_Click(null, null);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            result = false;
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            result = true;
            Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            processedNode = new List<Node>();
            tvwFromRoute.Nodes.Clear();
            tmpRouteVersion tmpR = cboVersion.SelectedItem as tmpRouteVersion;
            if (tmpR == null) return;
            Route route = tmpR.route;
            route.retrieveNodes();
            Dictionary<Node, TreeNodeCollection> dicNonPassNode = new Dictionary<Node, TreeNodeCollection>();
            routeNodeToTreeNode(tvwFromRoute.Nodes, route.FirstNode(), dicNonPassNode, Color.Black);

            while (dicNonPassNode.Count > 0)
            {
                Dictionary<Node, TreeNodeCollection> dicNonPassNode2 = new Dictionary<Node, TreeNodeCollection>();
                foreach (KeyValuePair<Node, TreeNodeCollection> kv in dicNonPassNode)
                    routeNodeToTreeNode(kv.Value, kv.Key, dicNonPassNode2, Color.Blue);
                dicNonPassNode = dicNonPassNode2;
            }
            tvwFromRoute.ExpandAll();
        }

        List<Node> processedNode = new List<Node>();
        void routeNodeToTreeNode(TreeNodeCollection treeNodes,Node routeNode,Dictionary<Node,TreeNodeCollection> dicNonPassNode,Color nodeColor)
        {
            if (processedNode.Contains(routeNode)) return;
            processedNode.Add(routeNode);
            TreeNode tvNode = treeNodes.Add(routeNode.name, routeNode.name + "(" + routeNode.handle + ")");
            tvNode.ImageKey = "step";
            tvNode.ForeColor = nodeColor;
            tvNode.Tag = routeNode;
            foreach (string path in routeNode.availablePaths())
            {
                if (path.Equals("PASS"))
                    routeNodeToTreeNode(treeNodes, routeNode.NextNode(path), dicNonPassNode, nodeColor);
                else
                    dicNonPassNode[routeNode.NextNode(path)] = treeNodes;
            }
            if (routeNode.nodeType == idv.mesCore.PRP.NodeType.Route)
            {
                tvNode.ImageKey = "route";
                Route route = routeNode.GetRoute();
                routeNodeToTreeNode(tvNode.Nodes, route.FirstNode(), dicNonPassNode, nodeColor);
            }
            tvNode.SelectedImageKey = tvNode.ImageKey;
        }
    }

    internal class tmpRouteVersion
    {
        internal Route route = null;
        public override string ToString()
        {
            return route.version.ToString();
        }
    }
}
