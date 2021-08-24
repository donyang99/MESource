using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.messageService;

namespace mesFABMonitor
{
    public partial class frmArea : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public delegate void areaSelectEventHandler(object sender, string areaId, string imageFile);
        public event areaSelectEventHandler areaSelected;

        public frmArea()
        {
            InitializeComponent();
            HideOnClose = true;
            getAreas();
        }

        private void getAreas()
        {
            lvwArea.Items.Clear();
            IMessageGuard conn = serviceHost.Client;
            try
            {
                DataSet ds = conn.getDataSet("select * from fms_area where delete_flag = '0'");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ListViewItem li = new ListViewItem();
                    li.Name = dr["area_id"].ToString();
                    li.Text = li.Name;
                    li.SubItems.Add(dr["description"].ToString());
                    li.SubItems.Add(dr["image_file"].ToString());
                    lvwArea.Items.Add(li);
                }
            }
            catch { }
        }

        private void lvwArea_Resize(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            try
            {
                lv.Columns[1].Width = lv.Width - lv.Columns[0].Width - 10;
            }
            catch { }
        }

        private void lvwArea_DoubleClick(object sender, EventArgs e)
        {
            try
            {                
                ListView lv = sender as ListView;
                ListViewItem li = lv.SelectedItems[0];
                if (areaSelected != null)
                    areaSelected.Invoke(this, li.Text, li.SubItems[2].Text);

                if (li.ImageKey != "")
                {
                    li.ImageKey = "";
                    lv.Refresh();
                }
            }
            catch { }
        }

        public void setError(string areaId)
        {
            try
            {
                lvwArea.Items[areaId].ImageKey = "error";
            }
            catch { }
        }
        public void setWarn(string areaId)
        {
            try
            {
                if (lvwArea.Items[areaId].ImageKey != "error")
                {
                    lvwArea.Items[areaId].ImageKey = "warn";
                }
            }
            catch { }
        }
        public void setNormal(string areaId)
        {
            try
            {
                if (lvwArea.Items[areaId].ImageKey != "")
                {
                    lvwArea.Items[areaId].ImageKey = "";
                    lvwArea.Refresh();
                }
            }
            catch { }
        }
       
    }
}
