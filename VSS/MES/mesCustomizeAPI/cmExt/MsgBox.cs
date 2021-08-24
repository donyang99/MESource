using System;
using System.Collections.Generic;
using System.Text;
using idv.utilities;

namespace cmExt
{
    public class MsgBox: IMessageBox
    {
        public bool ShowMessage(string message, messageStyle msgStyle)
        {
            bool returnValue = false;
            MsgForm frm = new MsgForm();
            try
            {
                frm.message = message;
                frm.style = msgStyle;
                frm.ShowModel();
                returnValue = frm.result;
            }
            catch
            { }
            return returnValue;
        }
    }
}
