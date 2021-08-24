using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;

namespace mesRelease.Controls
{
    public partial class frmIdentifyComponents : Form
    {
        bool _allowGenerateId = false;
        public bool allowGenerateId
        {
            get { return _allowGenerateId; }
            set { _allowGenerateId = value; }
        }

        public frmIdentifyComponents()
        {
            InitializeComponent();
        }

        public void Init(string lotId, ComponentInfo info, mesRelease.CAR.Carrier car)
        {
            wipComponentInformation1.allowGenerateId = _allowGenerateId;
            wipComponentInformation1.lotId = lotId;
            wipComponentInformation1.ShowComponents(info, car);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            wipComponentInformation1.Confirm();
            Close();
        }
    }
}
