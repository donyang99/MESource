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
    public partial class WorkingInstruction : TextBox
    {
        [NonSerialized]
        bool _isNowMin = false;
        int minHeight, maxHeight = 200;
        Color orgColor;

        bool _autoSize = true;
        public bool autoSize
        {
            get { return _autoSize; }
            set
            {
                _autoSize = value;
                btnShow.Visible = _autoSize;
            }
        }

        public WorkingInstruction()
        {
            InitializeComponent();
            Multiline = true;
            Controls.Add(btnShow);
            this.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            btnShow.Top = Height - btnShow.Height-4;
            btnShow.Left = Width - btnShow.Width-4;
            btnShow.Font = new System.Drawing.Font("Webdings", 9);
            btnShow.Cursor = Cursors.Arrow;
            minHeight = 20;
            ReadOnly = true;
        }

        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                orgColor = value;
            }
        }

        public bool isNowMinimum
        {
            get
            {
                return _isNowMin;
            }
            set
            {
                _isNowMin = value;
                if(!_autoSize) return;
                if (_isNowMin)
                {
                    base.Size = new System.Drawing.Size(Width, minHeight);
                    btnShow.Text = "6";
                    base.BackColor = FindForm().BackColor;
                }
                else
                {
                    base.Size = new System.Drawing.Size(Width, maxHeight);
                    btnShow.Text = "5";
                    base.BackColor = orgColor;
                }
            }
        }


        public void ShowInstruction(WIP.Lot lot)
        {
            string s = "";

            if(lot != null)
            {
                WIP.WorkingInstruction[] WIs = WIP.WorkingInstruction.GetWorkingInstruction(lot);
                foreach(WIP.WorkingInstruction wi in WIs)
                {
                    if(s.Equals(""))
                        s = "<" + wi.modifyUser + ">" + Environment.NewLine + wi.instruction;
                    else
                        s += Environment.NewLine + "<" + wi.modifyUser + ">" + Environment.NewLine + wi.instruction;
                }
            }

            if(s.Equals(""))
            {
                minHeight = btnShow.Height;
                isNowMinimum = true;
            }
            else
            {
                try
                {
                    using (Graphics g = CreateGraphics())
                    {
                        float fHeight = g.MeasureString(s, Font).Height;
                        if (fHeight > MaximumSize.Height && MaximumSize.Height != 0) fHeight = MaximumSize.Height;
                        maxHeight = (int)(fHeight) + Margin.Top + Margin.Bottom;
                    }
                }
                catch { }
                isNowMinimum = false;
            }
            Text = s;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            isNowMinimum = !isNowMinimum;
        }
    }
}
