using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesRelease.Controls
{
    public partial class routeCombo : UserControl
    {
        public delegate void MESStepSelectionChangedHandler(mesRelease.PRP.Step step);
        public event MESStepSelectionChangedHandler MESStepSelectionChanged;

        Point _defaultSize = new Point(300, 400);
        int _comboDefaultWidth = 0;
        mesRelease.PRP.Route _route = null;
        mesRelease.PRP.Step _step = null;
        TreeNode _lastNode = null;
        List<PRP.Step> stepList = new List<PRP.Step>();//comboBox selectIndex對應的Step
        bool _showHandle = false;
        bool _complexMode = false;
        bool _required = false;
        bool _passPathOnly = false;
        public void setSize(Point size)
        {
            _defaultSize = size;
        }
        public routeCombo()
        {
            InitializeComponent();
            Leave += new EventHandler(routeCombo_Leave);
            cboStepId.KeyPress += new KeyPressEventHandler(cboStepId_KeyPress);
            tvwStep.KeyPress += new KeyPressEventHandler(tvwStep_KeyPress);
            btnOK.KeyPress += new KeyPressEventHandler(tvwStep_KeyPress);
            btnCancel.KeyPress += new KeyPressEventHandler(tvwStep_KeyPress);
        }

        void tvwStep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                btnCancel.PerformClick();
        }

        void cboStepId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (complexMode)
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Escape)
                btnCancel.PerformClick();
        }

        void routeCombo_Leave(object sender, EventArgs e)
        {
            btnCancel.PerformClick();
        }
        
        public void Init(mesRelease.PRP.Route route, string startHandle)
        {
            _route = route;
            _step = null;
            _lastNode = null;
            cboStepId.Text = "";
            if (complexMode)
                showInTreeView(startHandle);
            else
                showInCombo(startHandle);
        }
        public bool complexMode
        {
            get { return _complexMode; }
            set { _complexMode = value; }
        }
        public bool showHandle
        {
            get { return _showHandle; }
            set { _showHandle = value; }
        }
        public bool required
        {
            get { return _required; }
            set 
            { 
                _required = value;
                if (_required)
                    cboStepId.BackColor = SystemColors.Info;
                else
                    cboStepId.BackColor = SystemColors.Window;
            }
        }
        public bool passPathOnly
        {
            get { return _passPathOnly; }
            set { _passPathOnly = value; }
        }

        public TreeNode searchChildNode(TreeNode parentNode, string name, bool stepId)
        {
            foreach (TreeNode node in parentNode.Nodes)
            {
                PRP.Step step = node.Tag as PRP.Step;
                if (step != null)
                {
                    if (stepId)
                    {
                        if (name == step.name)
                            return node;
                    }
                    else
                    {
                        if (name == step.stepHandle)
                            return node;
                    }
                }
                TreeNode n = searchChildNode(node, name, stepId);
                if (n != null)
                    return n;
            }
            return null;
        }

        public override string Text
        {
            get
            {
                return cboStepId.Text;
            }
            set
            {

                if (complexMode)
                {
                    tvwStep.SelectedNode = null;
                    foreach (TreeNode node in tvwStep.Nodes)
                    {
                        PRP.Step step = node.Tag as PRP.Step;
                        if (step != null)
                        {
                            if (step.name == value)
                            {
                                tvwStep.SelectedNode = node;
                                break;
                            }
                        }
                        TreeNode n = searchChildNode(node, value, true);
                        if (n != null)
                        {
                            tvwStep.SelectedNode = n;
                            break;
                        }
                    }
                    if (tvwStep.SelectedNode != null)
                    {
                        _lastNode = tvwStep.SelectedNode;
                        _step = _lastNode.Tag as PRP.Step;
                    }
                    else
                    {
                        _lastNode = null;
                        _step = null;
                    }
                    if (MESStepSelectionChanged != null)
                        MESStepSelectionChanged(_step);
                    showTextByTreeNode();
                }
                else
                {
                    if (_showHandle)
                    {
                        bool find = false;
                        foreach (object o in cboStepId.Items)
                        {
                            if (o.ToString().StartsWith(value))
                            {
                                find = true;
                                cboStepId.SelectedItem = o;
                                break;
                            }
                        }
                        if (!find)
                            cboStepId.Text = "";
                    }
                    else
                        cboStepId.Text = value;
                }
            }
        }

        void showRouteStepInComboBox(PRP.Route r, PRP.Node startNode)
        {
            List<PRP.Node> processed = new List<PRP.Node>();
            List<PRP.Node> lstNonPassNode = new List<PRP.Node>();
            List<PRP.Node> lstRouteNode = new List<PRP.Node>();
            PRP.Node n = null;
            if (startNode == null)
                n = r.FirstNode();
            else
            {
                //起始站點不一定是主流程裏的站點，先找到起始站點是流程裏的哪個Node底下
                PRP.Node findNode = null;
                foreach (PRP.Node curNode in r.Items)
                {
                    PRP.Node tmpNode = startNode;
                    while (tmpNode != null)
                    {
                        if (tmpNode.handle.Equals(curNode.handle))
                        {
                            findNode = tmpNode;
                            break;
                        }
                        tmpNode = tmpNode.parentNode;
                    }

                    if (findNode != null)
                        break;
                }
                if (findNode != null && !startNode.handle.Equals(findNode.handle))//startNode是在當前流程裏的子Node
                {
                    showRouteStepInComboBox(findNode.GetRoute(), startNode);//把子流程資訊加到Combo中
                    startNode = findNode;
                }

                n = r.FirstNode();
                while (n != null)
                {
                    if (n.handle.Equals(startNode.handle))
                        break;
                    processed.Add(n);
                    n = n.NextNode();
                }
                processed.Add(startNode);
                n = startNode.NextNode();
            }

            while (n != null)
            {
                processed.Add(n);
                if (n.nodeType == idv.mesCore.PRP.NodeType.Route)
                    showRouteStepInComboBox(n.GetRoute(), null);
                else
                    stepList.Add(n.GetStep());

                PRP.Node nextN = null;
                foreach (string path in n.availablePaths())
                {
                    if (path.Equals("PASS"))//先加PASS串成的站點
                        nextN = n.NextNode(path);
                    else
                    {
                        PRP.Node otherPath = n.NextNode(path);//其它路徑站點後面處理
                        if (!lstNonPassNode.Contains(otherPath))
                            lstNonPassNode.Add(otherPath);
                    }
                }
                n = nextN;
            }

            while (lstNonPassNode.Count > 0 && !passPathOnly)
            {
                List<PRP.Node> lstTmp = new List<PRP.Node>();
                foreach (PRP.Node node in lstNonPassNode)
                {
                    PRP.Node nd = node;
                    while (nd != null)
                    {
                        if (processed.Contains(nd)) break;
                        processed.Add(nd);

                        if (nd.nodeType == idv.mesCore.PRP.NodeType.Route)
                            lstRouteNode.Add(nd);
                        else
                            stepList.Add(nd.GetStep());

                        PRP.Node nextN = null;
                        foreach (string path in nd.availablePaths())
                        {
                            if (path.Equals("PASS"))//先加PASS串成的站點
                                nextN = nd.NextNode(path);
                            else
                            {
                                PRP.Node otherPath = nd.NextNode(path);//其它路徑站點後面處理
                                if (!lstTmp.Contains(otherPath))
                                    lstTmp.Add(otherPath);
                            }
                        }
                        nd = nextN;
                    }
                }
                lstNonPassNode = lstTmp;
            }

            foreach (PRP.Node node in lstRouteNode)
            {
                showRouteStepInComboBox(node.GetRoute(), null);
            }
        }
        void showInCombo(string startHandle)
        {
            stepList.Clear();
            stepList.Add(null);

            showRouteStepInComboBox(_route, _route.findNodeByHandle(startHandle, _route));
            doAddStepId();
            //BeginInvoke(new MethodInvoker(doAddStepId));
        }
        void doAddStepId()
        {
            cboStepId.Items.Clear();
            foreach (mesRelease.PRP.Step s in stepList)
            {
                if (s == null)
                    cboStepId.Items.Add("");
                else
                {
                    if (showHandle)
                        cboStepId.Items.Add(s.name + " (" + s.stepHandle + ")");
                    else
                        cboStepId.Items.Add(s.name);
                }
            }
        }

        bool firstShow = false;
        void showInTreeView(string startHandle)
        {
            tvwStep.Nodes.Clear();
            TreeNode root = tvwStep.Nodes.Add(_route.name, _route.name, "route");

            showRouteStepInTreeView(_route, _route.findNodeByHandle(startHandle, _route), root.Nodes);

            root.ExpandAll();
            if (!firstShow)
            {
                firstShow = true;
                tvwStep.SelectedNode = root;
            }
        }
        void showRouteStepInTreeView(PRP.Route r, PRP.Node startNode, TreeNodeCollection treeNodes)
        {
            List<PRP.Node> processed = new List<PRP.Node>();
            List<PRP.Node> lstNonPassNode = new List<PRP.Node>();
            List<PRP.Node> lstRouteNode = new List<PRP.Node>();
            PRP.Node n = null;
            if (startNode == null)
                n = r.FirstNode();
            else
            {
                //起始站點不一定是主流程裏的站點，先找到起始站點是流程裏的哪個Node底下
                PRP.Node findNode = null;
                foreach (PRP.Node curNode in r.Items)
                {
                    PRP.Node tmpNode = startNode;
                    while (tmpNode != null)
                    {
                        if (tmpNode.handle.Equals(curNode.handle))
                        {
                            findNode = tmpNode;
                            break;
                        }
                        tmpNode = tmpNode.parentNode;
                    }

                    if (findNode != null)
                        break;
                }
                if (findNode != null && !startNode.handle.Equals(findNode.handle))//startNode是在當前流程裏的子Node
                {
                    showRouteStepInTreeView(findNode.GetRoute(), startNode, treeNodes);//把子流程資訊加到root節點中
                    startNode = findNode;
                }

                n = r.FirstNode();
                while (n != null)
                {
                    if (n.handle.Equals(startNode.handle))
                        break;
                    processed.Add(n);
                    n = n.NextNode();
                }
                processed.Add(startNode);
                n = startNode.NextNode();
            }
            while (n != null)
            {
                processed.Add(n);

                TreeNode tn = treeNodes.Add(nodeText(n));
                tn.Name = n.handle;
                if (n.nodeType == idv.mesCore.PRP.NodeType.Route)
                {
                    tn.ImageKey = "route";
                    lstRouteNode.Add(n);
                }
                else
                {
                    tn.ImageKey = "step";
                    tn.Tag = n.GetStep();
                }
                tn.SelectedImageKey = tn.ImageKey;

                PRP.Node nextN = null;
                foreach (string path in n.availablePaths())
                {
                    if (path.Equals("PASS"))//先加PASS串成的站點
                        nextN = n.NextNode(path);
                    else
                    {
                        PRP.Node otherPath = n.NextNode(path);//其它路徑站點後面處理
                        if (!lstNonPassNode.Contains(otherPath))
                            lstNonPassNode.Add(otherPath);
                    }
                }
                n = nextN;
            }

            while (lstNonPassNode.Count > 0 && !passPathOnly)
            {
                List<PRP.Node> lstTmp = new List<PRP.Node>();
                foreach (PRP.Node node in lstNonPassNode)
                {
                    PRP.Node nd = node;
                    while (nd != null)
                    {
                        if (processed.Contains(nd)) break;
                        processed.Add(nd);

                        TreeNode tn = treeNodes.Add(nodeText(nd));
                        tn.Name = nd.handle;
                        if (nd.nodeType == idv.mesCore.PRP.NodeType.Route)
                        {
                            tn.ImageKey = "route";
                            lstRouteNode.Add(nd);
                        }
                        else
                        {
                            tn.ImageKey = "step";
                            tn.Tag = nd.GetStep();
                        }
                        tn.SelectedImageKey = tn.ImageKey;

                        PRP.Node nextN = null;
                        foreach (string path in nd.availablePaths())
                        {
                            if (path.Equals("PASS"))//先加PASS串成的站點
                                nextN = nd.NextNode(path);
                            else
                            {
                                PRP.Node otherPath = nd.NextNode(path);//其它路徑站點後面處理
                                if (!lstTmp.Contains(otherPath))
                                    lstTmp.Add(otherPath);
                            }
                        }
                        nd = nextN;
                    }
                }
                lstNonPassNode = lstTmp;
            }

            foreach (PRP.Node node in lstRouteNode)
            {
                TreeNode tn = treeNodes[node.handle];
                if (tn != null)
                    showRouteStepInTreeView(node.GetRoute(), null, tn.Nodes);
            }
        }
        string nodeText(PRP.Node node)
        {
            if (showHandle)
                return node.name + " (" + node.handle + ")";
            else
                return node.name;
        }

        public mesRelease.PRP.Route route
        {
            get { return _route; }
        }

        public mesRelease.PRP.Step selectedStep
        {
            get { return _step; }
            set
            {
                if (complexMode)
                {
                    tvwStep.SelectedNode = null;
                    if (value != null)
                    {
                        foreach (TreeNode node in tvwStep.Nodes)
                        {
                            PRP.Step step = node.Tag as PRP.Step;
                            if (step != null)
                            {
                                if (step.stepHandle == value.stepHandle)
                                {
                                    tvwStep.SelectedNode = node;
                                    break;
                                }
                            }
                            TreeNode n = searchChildNode(node, value.stepHandle, false);
                            if (n != null)
                            {
                                tvwStep.SelectedNode = n;
                                break;
                            }
                        }
                    }
                    if (tvwStep.SelectedNode != null)
                    {
                        _lastNode = tvwStep.SelectedNode;
                        _step = _lastNode.Tag as PRP.Step;
                    }
                    else
                    {
                        _lastNode = null;
                        _step = null;
                    }
                    if (MESStepSelectionChanged != null)
                        MESStepSelectionChanged(_step);
                    showTextByTreeNode();
                }
                else
                {
                    cboStepId.SelectedItem = null;
                    for (int i = 0; i < stepList.Count; i++)
                    {
                        PRP.Step step = stepList[i];
                        if (step == null) continue;
                        if (step.stepHandle == value.stepHandle)
                        {
                            _step = step;
                            cboStepId.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        public mesRelease.PRP.Step SelectStepByHandle(string stepHandle)
        {
            if (complexMode)
            {
                tvwStep.SelectedNode = null;

                foreach (TreeNode node in tvwStep.Nodes)
                {
                    PRP.Step step = node.Tag as PRP.Step;
                    if (step != null)
                    {
                        if (step.stepHandle == stepHandle)
                        {
                            tvwStep.SelectedNode = node;
                            break;
                        }
                    }
                    TreeNode n = searchChildNode(node, stepHandle, false);
                    if (n != null)
                    {
                        tvwStep.SelectedNode = n;
                        break;
                    }
                }
                
                if (tvwStep.SelectedNode != null)
                {
                    _lastNode = tvwStep.SelectedNode;
                    _step = _lastNode.Tag as PRP.Step;
                }
                else
                {
                    _lastNode = null;
                    _step = null;
                }
                if (MESStepSelectionChanged != null)
                    MESStepSelectionChanged(_step);
                showTextByTreeNode();
            }
            else
            {
                cboStepId.SelectedItem = null;
                for (int i = 0; i < stepList.Count; i++)
                {
                    PRP.Step step = stepList[i];
                    if (step == null) continue;
                    if (step.stepHandle == stepHandle)
                    {
                        _step = step;
                        cboStepId.SelectedIndex = i;
                        break;
                    }
                }
            }
            return _step;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tvwStep.SelectedNode == null) return;
            PRP.Step step = tvwStep.SelectedNode.Tag as PRP.Step;
            if (step == null) return;
            _step = step;
            _lastNode = tvwStep.SelectedNode;
            if (MESStepSelectionChanged != null)
                MESStepSelectionChanged(_step);
            btnCancel.PerformClick();
        }

        private void cboStepId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (complexMode) return;
            if (cboStepId.SelectedIndex == -1)
                _step = null;
            else
                _step = stepList[cboStepId.SelectedIndex];
            if (MESStepSelectionChanged != null)
                MESStepSelectionChanged(_step);
        }

        private void cboStepId_DropDown(object sender, EventArgs e)
        {
            if (!_complexMode) return;
            _comboDefaultWidth = cboStepId.Width;
            Size = new System.Drawing.Size(_defaultSize);
            tvwStep.Visible = true;
            btnOK.Visible = true;
            btnCancel.Visible = true;
            tvwStep.Dock = DockStyle.Fill;
            btnOK.BringToFront();
            btnCancel.BringToFront();
            tvwStep.SelectedNode = _lastNode;
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(sendKeyENTER));
            t.Start();
        }

        void sendKeyENTER()
        {
            System.Threading.Thread.Sleep(20);
            SendKeys.SendWait("{ENTER}");
            cboStepId.Visible = false;
            tvwStep.Focus();
        }

        private void tvwStep_DoubleClick(object sender, EventArgs e)
        {
            btnOK.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tvwStep.Hide();
            btnOK.Hide();
            btnCancel.Hide();
            showTextByTreeNode();
            cboStepId.Visible = true;
            Size = new Size(_comboDefaultWidth, cboStepId.Size.Height);
        }
        void showTextByTreeNode()
        {
            if (_step == null)
                cboStepId.SelectedIndex = -1;
            else
            {
                cboStepId.Items.Clear();
                if (showHandle)
                    cboStepId.Items.Add(_step.name + " (" + _step.stepHandle + ")");
                else
                    cboStepId.Items.Add(_step.name);
                cboStepId.SelectedIndex = 0;
            }
        }
    }
}
