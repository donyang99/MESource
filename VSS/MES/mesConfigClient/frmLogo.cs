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
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void frmLogo_Load(object sender, EventArgs e)
        {
            getMainFormLogo();
            lblInfo.Text = "System init...";
            Refresh();
        }
        private void getMainFormLogo()
        {
            string[] file = System.IO.Directory.GetFiles(".", "bg.*", System.IO.SearchOption.AllDirectories);
            for (int i = 0; i < file.Length; i++)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(file[i]);
                try
                {
                    Image img = Image.FromFile(fi.FullName);
                    BackgroundImage = img;
                    break;
                }
                catch { }
            }
        }

        public void dispalyInformation(string info)
        {
            lblInfo.Text = info;
            Refresh();
        }
    }
}
