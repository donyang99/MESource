using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cmExt
{
    public partial class MsgForm : Form
    {
        bool _result = false;
        public bool result
        {
            get { return _result; }
        }

        public string message
        {
            set { txtMessage.Text = value; }
        }

        idv.utilities.messageStyle _style = idv.utilities.messageStyle.confirmation;
        public idv.utilities.messageStyle style
        {
            set { _style = value; }
        }

        public MsgForm()
        {
            InitializeComponent();
        }

        public void ShowModel()
        {
            if (_style == idv.utilities.messageStyle.askYesNo)
            {
                btnOK.Tag = "buttonYes";
                btnCancel.Tag = "buttonNo";
            }
            else if (_style == idv.utilities.messageStyle.confirmation)
            { 
            
            }
            else if (_style == idv.utilities.messageStyle.error)
            { 
            
            }
            idv.utilities.cultureLanguage.switchLanguageSync(this);
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _result = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _result = false;
            Close();
        }
    }
}
