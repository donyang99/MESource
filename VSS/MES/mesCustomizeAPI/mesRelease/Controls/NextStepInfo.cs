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
    public partial class NextStepInfo : UserControl
    {
        mesRelease.WIP.Lot _lot = null;

        bool _ignorePASSPath = false;
        public bool ignorePASSPath
        {
            get { return _ignorePASSPath; }
            set { _ignorePASSPath = value; }
        }

        List<string> _IgnorePath = new List<string>();
        public List<string> IgnorePath
        {
            get { return _IgnorePath; }
            set { _IgnorePath = value; }
        }   

        public NextStepInfo()
        {
            InitializeComponent();
        }
        public void Init(mesRelease.WIP.Lot lot)
        {
            _lot = lot;
            lvwPaths.Items.Clear();
            lvwPaths.Enabled = true;
            try
            {
                mesRelease.PRP.Step step = lot.GetCurrentStep();
                foreach (string path in step.availablePaths)
                {
                    if (path.Equals("PASS") && _ignorePASSPath) continue;
                    if (_IgnorePath.Contains(path)) continue; 
                    string description = idv.utilities.cultureLanguage.getValue(path);
                    ListViewItem item = lvwPaths.Items.Add(path);
                    item.SubItems.Add(description);
                    PRP.Step nextStep = lot.GetRoute().NextStep(lot.GetCurrentStep().stepHandle, path, lot.iterate);
                    description = idv.utilities.cultureLanguage.getValue(nextStep.name);
                    if (description != "")
                        item.SubItems.Add(nextStep.name + " - " + description);
                    else
                        item.SubItems.Add(nextStep.name);
                    item.Tag = nextStep;
                }
                
                //for 最後一站，且有非PASS路徑
                if (!_ignorePASSPath)
                {
                    mesRelease.PRP.Route r = lot.GetRoute();
                    mesRelease.PRP.Node n = r.findNodeByHandle(step.stepHandle, r);
                    if (n != null && n.nodeKind == idv.mesCore.PRP.NodeKind.Exit)
                    {
                        if (r.NextStep(step.stepHandle, "PASS", lot.iterate) == null && lvwPaths.Items.Count > 0)
                        {
                            ListViewItem item = lvwPaths.Items.Add("PASS");
                            item.SubItems.Add(idv.utilities.cultureLanguage.getValue("PASS"));
                            item.SubItems.Add("");
                        }
                    }
                }

                if (lvwPaths.Items.Count == 1)
                {
                    lvwPaths.Items[0].Selected = true;
                    Lock();
                }
                else if (lvwPaths.Items.Count == 0)
                {
                    Lock();
                }
            }
            catch { }
            foreach (ColumnHeader h in lvwPaths.Columns)
            {
                h.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                if (h.Width < 75)
                    h.Width = 75;
                else if (h.Width > 300)
                    h.Width = 300;
            }
        }

        public void SelectPath(string path)
        {
            foreach (ListViewItem item in lvwPaths.Items)
            {
                if (item.Text == path)
                {
                    item.Selected = true;
                    item.Focused = true;
                    break;
                }
            }
        }

        public string[] availablePaths
        {
            get
            {
                List<string> list = new List<string>();
                foreach (ListViewItem item in lvwPaths.Items)
                    list.Add(item.Text);
                return list.ToArray();
            }
        }

        public string selectedPath
        {
            get { return txtPath.Text; }
        }

        public PRP.Step selectedStep
        {
            get
            {
                if (lvwPaths.SelectedItems.Count == 0)
                    return null;
                else
                    return lvwPaths.SelectedItems[0].Tag as PRP.Step;
            }
        }

        public void Lock()
        {
            lvwPaths.Enabled = false;
        }

        private void lvwPaths_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                txtPath.Text = "";
                txtInstruction.Text = "";
            }
            else
            {
                txtPath.Text = e.Item.Text;
                PRP.Step step = e.Item.Tag as PRP.Step;
                if (step != null)
                    showNextInstruction(step.name);
            }
        }

        int spliterX = 0;
        public bool InstructionVisible
        {
            get { return pnlWI.Visible; }
            set 
            {
                if (pnlWI.Visible == value) return;
                pnlWI.Visible = value;
                if (pnlWI.Visible)
                    panel1.Width = spliterX;
                else
                {
                    spliterX = panel1.Width;
                    panel1.Width = Width;
                }
            }
        }

        void showNextInstruction(string stepId)
        {
            if (!pnlWI.Visible) return;
            WIP.WorkingInstruction[] WIs = WIP.WorkingInstruction.GetWorkingInstruction(_lot, stepId);
            string s = "";
            foreach (WIP.WorkingInstruction wi in WIs)
            {
                if (s == "")
                    s = "<" + wi.modifyUser + ">" + Environment.NewLine + wi.instruction;
                else
                    s += Environment.NewLine + "<" + wi.modifyUser + ">" + Environment.NewLine + wi.instruction;
            }
            txtInstruction.Text = s;
        }

        public Color BackColor2
        {
            get
            {
                return lvwPaths.BackColor;
            }
            set
            {
                lvwPaths.BackColor = value;
            }
        }

        public void Clear()
        {
            txtPath.Text = "";
            lvwPaths.Items.Clear();
        }
    }
}
