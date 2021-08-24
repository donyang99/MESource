using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace mesFABMonitor
{
    public partial class frmSummary : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private Dictionary<string, DataPoint> stateBar = new Dictionary<string, DataPoint>();
        private Dictionary<string, DataPoint> percentBar = new Dictionary<string, DataPoint>();
        private frmEqMonitor eqMonitor = null;

        public void setEqMonitor(frmEqMonitor monitor)
        {
            if (eqMonitor == monitor) return;

            if (eqMonitor != null)
            {                
                eqMonitor.equipmentStateUpdated -= new frmEqMonitor.delegateStateUpdate(eqMonitor_equipmentStateUpdated);
            }

            eqMonitor = monitor;
            eqMonitor.equipmentStateUpdated += new frmEqMonitor.delegateStateUpdate(eqMonitor_equipmentStateUpdated);
            clear();
            foreach (Control ctrl in eqMonitor.pnlFAB.Controls)
            {
                eqEntitiy ee = ctrl as eqEntitiy;
                calcState(ee.state);
            }
        }

        void eqMonitor_equipmentStateUpdated(string equipmentId, string fromState, string toState)
        {
            calcState(toState, fromState);
        }

        public void clearEqMonitor(frmEqMonitor monitor)
        {
            eqMonitor = null;
        }

        public frmSummary()
        {
            InitializeComponent();
            HideOnClose = true;
            getEqStates();
        }

        private void getEqStates()
        {
            int i=0;
            chtStateCount.Series[0].IsValueShownAsLabel = true;
            chtStateCount.Series[0].YValuesPerPoint = 1;
            chtStatePercent.Series[0].IsValueShownAsLabel = true;
            chtStatePercent.Series[0].YValuesPerPoint = 1;
            foreach (mesRelease.EQP.State st in mesRelease.EQP.State.GetStates())
            {
                i++;
                frmMain.stateColor.Add(st.name, Color.FromArgb(st.color));

                DataPoint p = new DataPoint();
                p.Color = Color.FromArgb(st.color);
                p.XValue = (double)i;                
                p.AxisLabel = st.name;
                chtStateCount.Series[0].Points.Add(p);
                stateBar.Add(st.name, p);

                p = new DataPoint();
                p.Color = Color.FromArgb(st.color);
                p.XValue = (double)i;
                p.AxisLabel = st.name;
                p.LabelForeColor = Color.FromArgb(255 - p.Color.R, 255 - p.Color.G, 255 - p.Color.B);
                chtStatePercent.Series[0].Points.Add(p);
                percentBar.Add(st.name, p);
            }
        }

        public void calcState(string currentState) 
        {
            calcState(currentState, null);
        }

        public void calcState(string currentState, string previousStatus)
        {
            if (currentState == previousStatus) return;
            try
            {
                DataPoint p = stateBar[currentState];
                p.SetValueY(p.YValues[0] + 1);

            }
            catch { }
            if (previousStatus != null && previousStatus != "")
            {
                try
                {
                    DataPoint p = stateBar[previousStatus];
                    p.SetValueY(p.YValues[0] - 1);
                }
                catch { }
            }

            double total = 0;
            double maxValue = 0;
            foreach (DataPoint p in stateBar.Values)
            {
                total += p.YValues[0];
                if (p.YValues[0] > maxValue)
                    maxValue = p.YValues[0];
            }
            if (maxValue < 10) maxValue = 10;
            chtStateCount.ChartAreas[0].AxisY.Maximum = maxValue;

            if (total > 0)
            {
                foreach (DataPoint p in stateBar.Values)
                {
                    try { percentBar[p.AxisLabel].SetValueY(double.Parse((p.YValues[0] / total * 100).ToString("0.00"))); }
                    catch { }
                }
                chtStatePercent.ChartAreas[0].RecalculateAxesScale();
            }            
        }

        public void clear()
        {
            foreach (DataPoint p in stateBar.Values)
            {
                p.SetValueY(0);
            }
            chtStateCount.ChartAreas[0].RecalculateAxesScale();
        }

    }
}
