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
    public partial class ReasonCode : UserControl
    {
        mesRelease.BAS.ReasonCategory reaCate = null;
        
        bool _required = false;
        public bool required
        {
            get { return _required; }
            set
            {
                _required = value;
                if (_required)
                    cboReasonCode.BackColor = SystemColors.Info;
                else
                    cboReasonCode.BackColor = SystemColors.Window;
            }
        }

        public ReasonCode()
        {
            InitializeComponent();
        }

        bool _showCommentOnly = false;
        public bool showCommentOnly
        {
            get { return _showCommentOnly; }
            set
            {
                _showCommentOnly = value;
                if (_showCommentOnly)
                {
                    lblReasonCode.Visible = false;
                    cboReasonCode.Visible = false;
                    btnSelect.Visible = false;
                    tableLayoutPanel1.RowStyles[0].Height = 0;
                }
                else
                {
                    lblReasonCode.Visible = true;
                    cboReasonCode.Visible = true;
                    btnSelect.Visible = true;
                    tableLayoutPanel1.RowStyles[0].Height = 29;
                }
            }
        }

        public int maxDropDownItemCount
        {
            get { return cboReasonCode.MaxDropDownItems; }
            set { cboReasonCode.MaxDropDownItems = value; }
        }

        public void Init(string reasonCategory, string reasonClass)
        {
            cboReasonCode.Items.Clear();
            reaCate = new BAS.ReasonCategory(reasonCategory, reasonClass);
            if (!required)
                cboReasonCode.Items.Add(new mesRelease.BAS.ReasonCode());
            foreach (mesRelease.BAS.ReasonCode r in reaCate.Items)
                cboReasonCode.Items.Add(r);            
        }

        public string reasonCode
        {
            get
            {
                mesRelease.BAS.ReasonCode r = cboReasonCode.SelectedItem as mesRelease.BAS.ReasonCode;
                if (r != null)
                    return r.name;
                else
                    return "";
            }
        }

        public mesRelease.BAS.ReasonCode GetSelectedReason()
        {
            try
            {
                return cboReasonCode.SelectedItem as mesRelease.BAS.ReasonCode;
            }
            catch
            {
                return null;
            }
        }

        public string comments
        {
            get { return txtComments.Text; }
            set { txtComments.Text = value; }
        }

        public void SelectReasonCode(string reasonCode)
        {
            if (reasonCode.Equals(""))
            {
                cboReasonCode.SelectedIndex = -1;
                return;
            }
            foreach (mesRelease.BAS.ReasonCode r in cboReasonCode.Items)
            {
                if (r.name.Equals(reasonCode))
                {
                    cboReasonCode.SelectedItem = r;
                    return;
                }
            }
        }

        public int Count
        {
            get
            {
                int cnt = cboReasonCode.Items.Count;
                if(!required)
                    cnt--;
                return cnt;
            }
        }

        public void Clear()
        {
            reaCate = null;
            cboReasonCode.Items.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (reaCate == null) return;
            frmSelectReason frm = new frmSelectReason();
            try
            {
                frm.Init(reaCate.Items.ToArray());
                frm.ShowDialog();
                if (frm.result && frm.selectedReason != null)
                    SelectReasonCode(frm.selectedReason.name);
            }
            finally
            {
                frm.Close();
            }
        }
    }
}
