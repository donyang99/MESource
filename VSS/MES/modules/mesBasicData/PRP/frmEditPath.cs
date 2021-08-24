using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesBasicData
{
    public partial class frmEditPath : Form
    {
        private bool _result = false;

        public bool Result
        {
            get { return _result; }
        }
        public string PathName
        {
            get { return cboPathName.Text; }
            set { cboPathName.Text = value; }
        }
        public Color color
        {
            get { return lblColor.BackColor; }
            set { lblColor.BackColor = value; }
        }

        public ComboBox.ObjectCollection PathList
        {
            set
            {
                cboPathName.Items.Clear();
                foreach (object s in value)
                {
                    cboPathName.Items.Add(s);
                }
            }
        }
        public frmEditPath()
        {
            InitializeComponent();
            lblColor.BackColor = Color.Black;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _result = true;
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _result = false;
            this.Hide();
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblColor.BackColor;
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            lblColor.BackColor = colorDialog1.Color;
        }
    }
}
