using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace mesRelease
{
    public class IdName
    {
        string _Id = "";
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _Name = "";
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public override string ToString()
        {
            return _Name;
        }
    }
    public class Misc : idv.mesCore.misc
    {
        public static IdName[] GetCustomer(params string[] condition)
        {
            return new IdName[0] { };
        }

        public static IdName[] GetSpec(params string[] condition)
        {
            return new IdName[0] { };
        }
    }

    public class MESApplication : idv.MESApplication
    {
        public static bool ExecuteInputCommand(System.Windows.Forms.Control sender, string commandText)
        {
            bool returnValue = false;//回傳指令是否已處理
            string function = "";
            Dictionary<string, string> argus = new Dictionary<string, string>();
            string command = ParseCommandText(commandText, out function, argus);
            System.Windows.Forms.Form frm = sender.FindForm();
            System.Windows.Forms.Button button = null;
            if (command.Equals("F") && (function.Equals("CANCEL") || function.Equals("EXIT")))
            {
                if (function.Equals("CANCEL"))
                {
                    button = FindControl(frm, "btnClearLotId") as System.Windows.Forms.Button;
                    if (button != null)
                        button.PerformClick();
                    returnValue = true;
                }
                else if (function.Equals("EXIT"))
                {
                    //frm.Close();//現在不允許下指令離開
                    returnValue = true;
                }
            }
            else
            {
                if (WF.WorkFlow.CurrentLot == null)//沒有Lot不允許執行其它指令，並清空Lot輸入方塊
                {
                    System.Windows.Forms.TextBox txt = FindControl(frm, "txtLotId") as System.Windows.Forms.TextBox;
                    if (txt != null)
                        txt.Text = "";
                    returnValue = true;
                }
                switch (command + "@@" + function)
                {
                    case "F@@CONFIRM":
                        returnValue = true;
                        button = FindControl(frm, "btnTxnOK") as System.Windows.Forms.Button;
                        if (button != null) button.PerformClick();
                        break;
                }
            }

            if (returnValue)
            {
                System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;
                if (txt != null && !txt.ReadOnly)
                    txt.Text = "";
            }
            return returnValue;
        }

        public static string ParseCommandText(string commandText, out string function, Dictionary<string, string> argus)
        {
            string command = "";
            function = "";
            string[] tmp = commandText.Split(new char[] { '$' }, 2);
            if (tmp.Length > 0)
                command = tmp[0];
            if (tmp.Length > 1)
            {
                tmp = tmp[1].Split(',');
                if (tmp.Length > 0)
                    function = tmp[0];
                for (int i = 1; i < tmp.Length; i++)
                    argus.Add(tmp[i], tmp[i]);
            }
            return command;
        }

        public static Control FindControl(Control form, string controlName)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Name.Equals(controlName))
                    return ctrl;

                Control find = FindControl(ctrl, controlName);
                if (find != null)
                    return find;
            }
            return null;
        }

        #region 提示訊息
        static Panel _MessagePanel;
        public static Panel MessagePanel
        {
            get { return _MessagePanel; }
            set { _MessagePanel = value; }
        }
        public static void AddMessage(string message, Color foreColor)
        {
            AddMessage(message, foreColor, SystemColors.Control, 14);
        }
        public static void AddMessage(string message, Color foreColor, Color backColor, float size)
        {
            if (_MessagePanel == null) return;
            TextBox txt = new TextBox();
            txt.Font = new Font(txt.Font.FontFamily, size, FontStyle.Regular);
            txt.ForeColor = foreColor;
            txt.ReadOnly = true;
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = backColor;
            txt.Dock = DockStyle.Top;
            txt.Text = message;
            _MessagePanel.Controls.Add(txt);
            _MessagePanel.VerticalScroll.Value = 0;
        }
        public static void ClearMessage()
        {
            if (_MessagePanel == null) return;
            _MessagePanel.Controls.Clear();
        }
        #endregion
    }

    public class Serial : idv.mesCore.serial
    {
        public static int GetCartionSerial(string productId, string orderId)
        {
            //依機種,工單,by月重序
            return GetSerialNumber("carton", productId + "@" + orderId + "@" + idv.messageService.serviceHost.dateTime.Month.ToString());
        }
        public static int GetPalletSerial(string key = "")
        {
            return GetSerialNumber("pallet", key + idv.messageService.serviceHost.dateTime.Month.ToString());
        }
    }
}
