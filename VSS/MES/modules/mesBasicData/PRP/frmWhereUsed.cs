using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesBasicData
{
    public partial class frmWhereUsed : Form
    {
        public frmWhereUsed()
        {
            InitializeComponent();
        }

        public void Init(params string[] values)
        {
            foreach (string s in values)
                mesListView1.Items.Add(s);
            idv.utilities.cultureLanguage.switchLanguageSync(mesListView1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void ShowWhereUsed(params string[] values)
        {
            frmWhereUsed frm = new frmWhereUsed();
            try
            {
                frm.Init(values);
                frm.ShowDialog();
            }
            catch { }
            finally
            {
                frm.Close();
            }
        }
    }
}
