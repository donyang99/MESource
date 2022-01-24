using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.utilities;
using idv.mesCore.Controls;
using mesRelease.TOL;
using idv.messageService;

namespace toolingFunction
{
    public partial class frmCopyEvent : Form
    {
        bool _result = false;
        public bool result
        {
            get { return _result; }
            set { _result = value; }
        }

        public string FromType
        {
            get { return cboFromType.Text; }
        }

        public string ToType
        {
            get { return cboToType.Text; }
        }

        List<ToolingType> allTypes = new List<ToolingType>();
        public void SetToolingTypes(ComboBox cbo)
        {
            foreach (ToolingType t in cbo.Items)
                allTypes.Add(t);
        }

        public frmCopyEvent()
        {
            InitializeComponent();
        }

        private void frmCopyEvent_Load(object sender, EventArgs e)
        {
            string[] definedType = ToolingEvent.GetDefinedTypes();
            foreach (ToolingType t in allTypes)
            {
                if (definedType.Contains(t.name))
                    cboFromType.Items.Add(t.name);
                else
                    cboToType.Items.Add(t.name);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboFromType.Text.Equals(""))
            {
                messageBox.showMessageById("requireField2", lblFromType.Text);
                return;
            }
            else if (cboToType.Text.Equals(""))
            {
                messageBox.showMessageById("requireField2", lblToType.Text);
                return;
            }
            result = true;
            Hide();
        }
    }
}
