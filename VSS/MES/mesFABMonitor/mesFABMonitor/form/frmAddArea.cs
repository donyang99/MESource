using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesFABMonitor
{
    public partial class frmAddArea : Form
    {
        bool _result = false;
        public bool result
        {
            get { return _result; }
            set { _result = value; }
        }

        public string area
        {
            get { return txtArea.Text; }
            set { txtArea.Text = value; }
        }

        public string description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }

        public string backgroundPhoto
        {
            get { return txtBgPhoto.Text; }
            set { txtBgPhoto.Text = value; }
        }

        public frmAddArea()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "bmp|*.bmp|png|*.png|jpg|*.jpg|gif|*.gif|*|*.*";
            of.ShowDialog();
            
            if (of.FileName != "")
            {
                txtBgPhoto.Text = of.SafeFileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtArea.Text.Trim() != "")
            {
                _result = true;
                Close();
            }
        }
    }
}
