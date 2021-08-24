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
    public partial class TrackOutType : UserControl
    {
        public TrackOutType()
        {
            InitializeComponent();
        }

        private void rdoOK_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            if (rdo == rdoOK)
            {

            }
            else if (rdo == rdoNG)
            {
                cboPath.Enabled = rdo.Checked;
            }
        }

        string _route = "";
        Dictionary<string, string> dicPath = new Dictionary<string, string>();//顯示文字/路徑名
        public void ShowTrackOutPath(mesRelease.WIP.Lot lot)
        {
            rdoOK.Checked = true;
            if (cboPath.Items.Count > 1) cboPath.SelectedIndex = -1;
            if (lot == null) return;
            if (_route.Equals(lot.routeId + "." + lot.routeVersion)) return;
            _route = lot.routeId + "." + lot.routeVersion;
            cboPath.Items.Clear();
            dicPath.Clear();
            mesRelease.PRP.Step step = lot.GetCurrentStep();
            if (step == null) return;
            foreach (string path in step.availablePaths)
            {
                if (path.Equals("PASS")) continue;
                string desc = idv.utilities.cultureLanguage.getValue(path);
                if (desc.Equals("")) desc = path;
                cboPath.Items.Add(desc);
                dicPath[desc] = path;
            }
            if (cboPath.Items.Count == 1)
                cboPath.SelectedIndex = 0;
            rdoNG.Enabled = cboPath.Items.Count > 0;
        }

        public string TrackOutPath
        {
            get
            {
                if (rdoOK.Checked)
                    return "PASS";
                else
                {
                    if (dicPath.ContainsKey(cboPath.Text))
                        return dicPath[cboPath.Text];
                    else
                        return "";
                }
            }
            set
            {
                if (value.Equals("PASS"))
                    rdoOK.Checked = true;
                else
                {
                    cboPath.SelectedIndex = -1;
                    foreach (KeyValuePair<string, string> kv in dicPath)
                    {
                        if (kv.Value.Equals(value) || kv.Key.Equals(value))
                        {
                            cboPath.Text = kv.Key;
                            rdoNG.Checked = true;
                            break;
                        }
                    }
                }
            }
        }

        public bool ContainPath(string pathName)
        {
            return dicPath.Values.Contains(pathName);
        }
    }
}
