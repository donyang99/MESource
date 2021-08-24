using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.KAN;

namespace kanStepMove
{
    public class kanbanInstance : kanInstance
    {
        frmMain frm = new frmMain();
        public void close()
        {
            frm.Close();
        }

        public System.Windows.Forms.Form getForm()
        {
            return frm;
        }

        public void init(Dictionary<string, string> argus)
        {
            frm.init(argus);
        }

        public void timerElapsed()
        {
            frm.timerElapsed();
        }

        public void messageNotice(idv.messageService.messageBase msgItem)
        {
            frm.processMessage(msgItem);
        }
    }
}
