using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace mesRelease.utilities
{
    public static class TestAssistant
    {
        public static void InputData(Control[] input, Button click)
        {
            btn = click;
            MethodInvoker m = new MethodInvoker(ClickButton);
            InputData(input, m);
        }
        static Button btn = null;
        static void ClickButton()
        {
            btn.PerformClick();
        }

        public static void InputData(Control[] input, Delegate method, params object[] parms)
        {
            try
            {
                DataSet ds = GetTestData();
                if (ds == null) return;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    for (int i = 0; i < input.Length; i++)
                        input[i].Text = row[i].ToString();

                    DateTime now = DateTime.Now;
                    method.DynamicInvoke(parms);
                    TimeSpan ts = DateTime.Now - now;
                    if (ts.TotalMilliseconds > 3000)
                    {
                        if (MessageBox.Show("似乎有問題發生，是否繼續", "", MessageBoxButtons.YesNo) == DialogResult.No)
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        static DataSet GetTestData()
        {
            string sql = frmTestData.GetSql();
            if (!sql.Equals(""))
                return idv.messageService.serviceHost.Client.getDataSet(sql);
            return null;

        }
    }
}
