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
    public partial class OutputInfo : UserControl
    {
        int _LotCount = 0;
        double _TotalQuantity = 0;

        int _KeepCount = 500;
        public int KeepCount
        {
            get { return _KeepCount; }
            set { _KeepCount = value; }
        }

        bool _showTotalQuantity = false;
        public bool showTotalQuantity
        {
            get { return _showTotalQuantity; }
            set
            {
                _showTotalQuantity = value;
                lblTotalQuantity.Visible = _showTotalQuantity;
                txtTotalQuantity.Visible = _showTotalQuantity;
            }
        }

        public OutputInfo()
        {
            InitializeComponent();
        }

        public void ShowMessage(idv.messageService.txnBase txn)
        {
            foreach (mesRelease.WIP.Lot lot in txn.Items)
            {
                ShowMessage(lot.name, txn.result.Equals("PASS"), txn.errMessage, lot.quantity);
            }
        }

        public void ShowMessage(string lotId, bool succeed, string information)
        {
            ShowMessage(lotId, succeed, information, 1);
        }

        public void ShowMessage(string lotId, bool succeed, string information, double lotQuantity)
        {
            txtLotId.Text = lotId;
            txtInformation.Text = information;
            txtInformation.BackColor = succeed ? SystemColors.Control : Color.Yellow;

            ListViewItem li = new ListViewItem();
            li.Text = idv.messageService.serviceHost.dateTime.ToString();
            li.SubItems.Add(lotId);
            li.SubItems.Add(succeed ? "Y" : "N");
            li.SubItems.Add(information);

            li.UseItemStyleForSubItems = true;
            if (!succeed)
                li.BackColor = Color.Yellow;
            else
            {
                _LotCount++;
                _TotalQuantity += lotQuantity;
            }

            txtLotCount.Text = _LotCount.ToString();
            txtTotalQuantity.Text = _TotalQuantity.ToString();
            lvwOutputInfo.Items.Insert(0, li);

            if (lvwOutputInfo.Items.Count == 1)
            {
                lvwOutputInfo.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwOutputInfo.Columns[0].Width += 3;
                lvwOutputInfo.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwOutputInfo.Columns[1].Width += 3;
                lvwOutputInfo_Resize(null, null);
            }

            if (lvwOutputInfo.Items.Count > _KeepCount)
                lvwOutputInfo.Items.RemoveAt(lvwOutputInfo.Items.Count - 1);
        }
        private void lvwOutputInfo_Resize(object sender, EventArgs e)
        {
            colInfo.Width = lvwOutputInfo.Width - colDateTime.Width - colLotId.Width - colResult.Width - 20;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!idv.utilities.messageBox.showMessageById("msgAreYouSure", idv.utilities.messageStyle.askYesNo)) return;
            _LotCount = 0;
            _TotalQuantity = 0;
            txtLotCount.Text = "";
            txtTotalQuantity.Text = "";
        }
    }
}
