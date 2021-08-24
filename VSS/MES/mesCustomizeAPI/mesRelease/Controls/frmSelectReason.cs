using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesRelease.Controls
{
    public partial class frmSelectReason : Form
    {
        bool _result = false;
        public bool result
        {
            get { return _result; }
        }

        public frmSelectReason()
        {
            InitializeComponent();
        }

        public void Init(idv.messageService.itemBase[] reasonCodes)
        {
            lvwReasonCode.prepareColumns();
            lvwReasonCode.ShowMESItems(reasonCodes);
            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        public mesRelease.BAS.ReasonCode selectedReason
        {
            get
            {
                return lvwReasonCode.selectedMESItem as mesRelease.BAS.ReasonCode;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _result = true;
            Close();
        }

        private void lvwReasonCode_DoubleClick(object sender, EventArgs e)
        {
            btnOK.PerformClick();
        }
    }
}
