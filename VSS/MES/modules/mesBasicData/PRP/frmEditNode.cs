using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.mesCore.PRP;

namespace mesBasicData
{
    public partial class frmEditNode : Form
    {
        private bool _result = false;
        private NodeKind _nodeKind = NodeKind.Interior;

        public bool Result
        {
            get { return _result; }
        }
        public string NodeName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public NodeKind NodeKind
        {
            get { return _nodeKind; }
            set
            {
                _nodeKind = value;
                if (_nodeKind == NodeKind.Entry)
                    rdoEntry.Checked = true;
                else if (_nodeKind == NodeKind.Interior)
                    rdoInterior.Checked = true;
                else if (_nodeKind == NodeKind.Exit)
                    rdoExit.Checked = true;
            }
        }

        public short nodeIterate
        {
            get
            {
                return Convert.ToInt16(txtIterate.Text);
            }
            set
            {
                txtIterate.Text = value.ToString();
            }
        }

        public void setIteratVisible(bool visible)
        {
            lblIterate.Visible = visible;
            txtIterate.Visible = visible;
        }

        public frmEditNode()
        {
            InitializeComponent();
        }

        private void Radio_CheckedChanged()
        {
            if (rdoEntry.Checked)
                _nodeKind = NodeKind.Entry;
            else if (rdoInterior.Checked)
                _nodeKind = NodeKind.Interior;
            else if (rdoExit.Checked)
                _nodeKind = NodeKind.Exit;
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (short.TryParse(txtIterate.Text, out short v))
            {
                if (v <= 0)
                    return;
            }
            else
                return;
            Radio_CheckedChanged();
            _result = true;
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _result = false;
            this.Hide();
        }
    }
}
