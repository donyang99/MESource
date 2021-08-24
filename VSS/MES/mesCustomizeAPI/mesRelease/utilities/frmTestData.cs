using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesRelease.utilities
{
    public partial class frmTestData : Form
    {
        public frmTestData()
        {
            InitializeComponent();
        }
        bool _result = false;
        public bool Result
        {
            get { return _result; }
            set { _result = value; }
        }
        public string SQL
        {
            get { return txtSql.Text; }
            set { txtSql.Text = value; }
        }

        private void frmTestData_Load(object sender, EventArgs e)
        {
            LoadTestData();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            txtSql.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.Trim().Equals("") && !txtSql.Text.Trim().Equals(""))
            {
                ListViewItem item = lvwSelect.Items[txtName.Text];
                if (item == null)
                {
                    item = new ListViewItem(txtName.Text);
                    item.Name = item.Text;
                    lvwSelect.Items.Add(item);
                }
                item.Tag = txtSql.Text;
                SaveTestData();
            }
            Result = true;
            Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.InitialDirectory = filePath;
            dia.Filter = "config|*.config";
            dia.FileName = fileName;

            if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(dia.FileName);
                if (fi.Exists)
                {
                    filePath = fi.Directory.FullName;
                    fileName = fi.Name;
                    LoadTestData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwSelect.SelectedItems.Count == 0) return;
            if (MessageBox.Show("是否確定?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                lvwSelect.SelectedItems[0].Remove();
                SaveTestData();
            }
        }

        void LoadTestData()
        {
            if (!filePath.EndsWith("\\")) filePath += "\\";
            if (!System.IO.File.Exists(filePath + fileName)) return;
            lvwSelect.Items.Clear();
            foreach (string line in System.IO.File.ReadAllText(filePath + fileName).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] info = line.Split(new char[] { '=' }, 2);
                ListViewItem item = new ListViewItem(info[0]);
                item.Name = item.Text;
                if (info.Length > 1)
                    item.Tag = info[1];
                else
                    item.Tag = "";
                lvwSelect.Items.Add(item);
            }
        }

        void SaveTestData()
        {
            string s = "";
            foreach (ListViewItem item in lvwSelect.Items)
                s += item.Text + "=" + item.Tag.ToString() + Environment.NewLine;
            if (!filePath.EndsWith("\\"))
                filePath += "\\";
            try
            {
                System.IO.File.WriteAllText(filePath + fileName, s);
            }
            catch { }
        }

        private void lvwSelect_DoubleClick(object sender, EventArgs e)
        {
            if (lvwSelect.SelectedItems.Count > 0)
            {
                txtName.Text = lvwSelect.SelectedItems[0].Name;
                if (lvwSelect.SelectedItems[0].Tag != null)
                    txtSql.Text = lvwSelect.SelectedItems[0].Tag.ToString();
            }
        }
        //static member
        static string filePath = AppDomain.CurrentDomain.BaseDirectory;
        static string fileName = "TestData.config";
        static string lastSql = "";
        public static string GetSql()
        {
            frmTestData frm = new frmTestData();
            try
            {
                frm.SQL = lastSql;
                frm.ShowDialog();
                if (frm.Result)
                {
                    lastSql = frm.SQL;
                    return lastSql;
                }
            }
            catch
            { }
            finally
            {
                frm.Close();
            }
            return "";
        }
    }
}
