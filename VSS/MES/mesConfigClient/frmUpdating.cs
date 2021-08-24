using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesConfigClient
{
    public partial class frmUpdating : Form
    {
        public frmUpdating()
        {
            InitializeComponent();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 6) i = 1;
            lblWait.Text = new string('.', i);
            Refresh();
        }

        private void frmUpdating_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void frmUpdating_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
