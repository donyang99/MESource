using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.utilities;
using mesRelease.PRP;
using idv.mesCore.Controls;
using idv.mesCore.PRP;

namespace mesBasicData
{
    public partial class frmDrawRoute : Form
    {
        Route _curRoute = null;
        routeButton _previousButton = null;
        object _selectedObject = null;
        bool _addPath = false;
        string _viewPath = "";
        bool _modified = false;
        public frmDrawRoute()
        {
            InitializeComponent();
            lvwRoute.prepareColumns();
            lvwStep.prepareColumns();
            cultureLanguage.switchLanguage(this);
        }

        void initData()
        {
            lvwStep.ShowMESItems(Step.GetActiveVersionSteps(""));
            lvwRoute.ShowMESItems(Route.GetActiveVersionRoutes(""));
            foreach (idv.messageService.itemBase item in lvwRoute.GetAllMESItem())
            {
                if (item.name == _curRoute.name)
                {
                    lvwRoute.RemoveMESItem(item);
                    break;
                }
            }
        }

        public void Init(Route route, string viewPath)
        {
            _curRoute = route;
            if (_curRoute == null) return;
            txtRoute.Text = _curRoute.name;
            txtVersion.Text = _curRoute.version.ToString();
            txtRouteType.Text = _curRoute.routeType;
            txtDescription.Text = _curRoute.description;
            if (!idv.mesCore.systemConfig.routeType)
            {
                lblRouteType.Visible = false;
                txtRouteType.Visible = false;
                tableLayoutPanel1.Controls.Remove(lblRouteType);
                tableLayoutPanel1.Controls.Remove(txtRouteType);
                tableLayoutPanel1.SetColumn(lblDescription, 4);
                tableLayoutPanel1.SetColumn(txtDescription, 5);
                tableLayoutPanel1.SetColumnSpan(txtDescription, 3);
            }
            if (viewPath.IndexOf('>') == -1 && (_curRoute.issueState == idv.mesCore.IssueState.New || idv.mesCore.systemConfig.useStepIdAsHandle))
            {
                for (int i = 0; i < tblRoutePanelAction.Items.Count; i++)
                    tblRoutePanelAction.Items[i].Enabled = true;
                initData();
            }
            else
            {
                tabControl1.Visible = false;
                routePanel1.Dock = DockStyle.None;
                routePanel1.Dock = DockStyle.Fill;
                //routePanel1.Enabled = false;
            }
            routePanel1.gridSize = scrSize.Value;
            routePanel1.drawRouting(_curRoute);
            _viewPath = viewPath;
            Text += " - " + _viewPath;
        }

        private void tblRoutePanelAction_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "buttonSave":
                    if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("save"))) return;
                    //if (_curRoute.issueState != idv.mesCore.IssueState.New) return;
                    if (!routePanel1.generateRouteFromRoutePanel(new Route())) return;
                    routePanel1.generateRouteFromRoutePanel(_curRoute);
                    _curRoute.modifyUser = mesRelease.USR.User.loginUserId;
                    try
                    {
                        _curRoute.SaveNodes();
                        _modified = false;
                        messageBox.showMessageById("msgExecuteSucceed");
                    }
                    catch(Exception ex)
                    {
                        messageBox.showMessage(ex.Message, messageStyle.error);
                    }
                    break;
                case "buttonValid":
                    Route r = new Route();
                    if (!routePanel1.generateRouteFromRoutePanel(r)) return;
                    try
                    {
                        r.checkRouteRationality();
                        messageBox.showMessageById("msgExecuteSucceed");
                    }
                    catch(Exception ex)
                    {
                        messageBox.showMessage(ex.Message, messageStyle.confirmation);
                    }
                    break;
                case "buttonModify":
                    if (_selectedObject == null) break;
                    _addPath = false;
                    doRoutePanelEditAction();
                    break;
                case "buttonDelete":
                    if (_selectedObject == null) break;
                    if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
                    _addPath = false;
                    doRoutePanelDeleteAction();
                    break;
                case "buttonAddPath":
                    _addPath = !_addPath;
                    break;
                case "buttonClear":
                    if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("buttonClear"))) return;
                    _addPath = false;
                    routePanel1.clear();
                    break;
                case "buttonView":
                    doRoutePanelViewAction();                    
                    break;
            }

            ToolStripButton button = tblRoutePanelAction.Items["buttonAddPath"] as ToolStripButton;
            button.Checked = _addPath;
            ToolStripComboBox combo = tblRoutePanelAction.Items["cboPathName"] as ToolStripComboBox;
            combo.Visible = _addPath;
            if (_addPath)
            {
                _previousButton = null;
                _selectedObject = null;
                ActiveControl = null;
            }
        }

        private void doRoutePanelDeleteAction()
        {
            _modified = true;
            line l = _selectedObject as line;
            if (l != null)
            {
                routePanel1.removeLine(l);
                routePanel1.Refresh();
                return;
            }
            routeButton btn = _selectedObject as routeButton;
            if (btn != null)
            {
                routePanel1.removeRouteButton(btn);
            }
        }

        private void doRoutePanelEditAction()
        {
            _modified = true;
            line l = _selectedObject as line;
            if (l != null)
            {
                frmEditPath frm = new frmEditPath();
                try
                {
                    ToolStripComboBox combo = tblRoutePanelAction.Items["cboPathName"] as ToolStripComboBox;

                    frm.PathList = combo.Items;
                    frm.color = l.color;
                    frm.PathName = l.caption;
                    cultureLanguage.switchLanguage(frm);
                    frm.ShowDialog();
                    if (frm.Result)
                    {
                        l.caption = frm.PathName;
                        l.color = frm.color;
                        l.captionColor = frm.color;
                        routePanel1.Refresh();
                    }
                }
                catch { }
                finally
                {
                    frm.Close();
                }

                return;
            }
            routeButton btn = _selectedObject as routeButton;
            if (btn != null)
            {
                frmEditNode frm = new frmEditNode();
                try
                {

                    frm.NodeKind = btn.nodeKind;
                    frm.NodeName = btn.nodeName;
                    frm.nodeIterate = btn.iterate;
                    frm.setIteratVisible(btn.node.nodeType == NodeType.Step);
                    cultureLanguage.switchLanguage(frm);
                    frm.ShowDialog();
                    if (frm.Result)
                    {
                        btn.iterate = frm.nodeIterate;
                        btn.nodeKind = frm.NodeKind;
                        routePanel1.Refresh();
                    }
                }
                catch { }
                finally
                {
                    frm.Close();
                }
            }
        }

        private void doRoutePanelViewAction()
        {
            routeButton button = _selectedObject as routeButton;
            if (button == null) return;
            Node n = button.node as Node;
            if (_curRoute.issueState == idv.mesCore.IssueState.New)
                n.nodeRef = null;

            if (button.node.nodeType ==  NodeType.Step)
            {
                frmViewStep frm = new frmViewStep();
                try
                {
                    n.GetStep().retrieveRules();
                    frm.Init(n.GetStep());
                    frm.ShowDialog();
                }
                finally
                {
                    frm.Close();
                }
            }
            else
            {
                Single gridSize = routePanel1.gridSize;
                frmDrawRoute frm = new frmDrawRoute();
                try
                {
                    n.GetRoute().retrieveNodes();
                    frm.Init(n.GetRoute(), _viewPath + " > " + n.GetRoute().name);
                    frm.ShowDialog();
                }
                finally
                {
                    frm.Close();
                    routePanel1.gridSize = gridSize;
                }
            }
        }

        private void scrSize_ValueChanged(object sender, EventArgs e)
        {
            routePanel1.gridSize = scrSize.Value;
        }

        private void lvw_MouseDown(object sender, MouseEventArgs e)
        {            
            if (e.Button != MouseButtons.Left) return;
            ListView listView = sender as ListView;
            if (listView == null) return;
            ListViewItem li = listView.GetItemAt(e.X, e.Y);
            if (li == null) return;
            li.Selected = true;
            listView.DoDragDrop(li, DragDropEffects.Move);
        }

        private void routePanel1_CellClick(int col, int row, routeButton button)
        {
            if (_selectedObject != button)
            {
                if (_selectedObject != null && _selectedObject.GetType() == typeof(line))
                {
                    routePanel1.selectLine(null);
                    //routePanel1.Refresh();
                }
            }
            _selectedObject = button;
            if (!_addPath) return;
            if (_previousButton == null)
            {
                _previousButton = button;
            }
            else
            {
                if (_previousButton == button) return;
                if (button == null)
                    _previousButton = null;
                else
                {
                    string pathName = "";
                    Color color = Color.Black;
                    try
                    {
                        ToolStripComboBox combo = tblRoutePanelAction.Items["cboPathName"] as ToolStripComboBox;
                        pathName = combo.Text;
                        if (pathName == "")
                        {
                            frmEditPath frm = new frmEditPath();
                            frm.PathList = combo.Items;
                            cultureLanguage.switchLanguage(frm);
                            frm.ShowDialog();
                            if (frm.Result)
                            {
                                pathName = frm.PathName;
                                color = frm.color;
                            }

                            frm.Close();
                        }
                    }
                    catch { }
                    try
                    {
                        routePanel1.addLine(_previousButton, button, color, pathName);
                        routePanel1.Invalidate(true);
                        _modified = true;
                    }
                    catch { }
                    _previousButton = null;
                }
            }
        }

        private void routePanel1_CellDragDrop(int col, int row, object dragObject)
        {
            _modified = true;
            ListViewItem item = dragObject as ListViewItem;
            if (item == null)
            {
                if (_addPath)
                    tblRoutePanelAction.Items["buttonAddPath"].PerformClick();
                return;
            }
            Node nd = new Node();
            nd.name = (item.Tag as idv.messageService.itemBase).name;
            nd.nodeKind = idv.mesCore.PRP.NodeKind.Interior;

            if (item.ListView == lvwStep)
                nd.nodeType = idv.mesCore.PRP.NodeType.Step;
            else
                nd.nodeType = idv.mesCore.PRP.NodeType.Route;

            routePanel1.selectLine(null);

            _selectedObject = routePanel1.addRouteButton(col, row, nd);
        }

        private void routePanel1_LineClick(line line)
        {
            _selectedObject = line;
            _previousButton = null;
        }

        private void frmDrawRoute_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_modified && buttonSave.Enabled)
            {
                if (!messageBox.showMessageById("quitWithoutSave", messageStyle.askYesNo))
                    e.Cancel = true;
            }
        }

        private void scrFont_ValueChanged(object sender, EventArgs e)
        {
            routePanel1.fontSizePlus = scrFont.Value;
        }
    }
}
