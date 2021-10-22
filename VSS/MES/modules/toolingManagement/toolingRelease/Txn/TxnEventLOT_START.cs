using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.TOL.Txn;
using System.Windows.Forms;
using idv.mesCore.TOL;

namespace mesRelease.TOL.Txn
{
    public class TxnEventLOT_START : TxnEvent
    {
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            if (lotId.Equals(""))
                throw new Exception("lotId is required");

            foreach (ToolingId id in Items)
            {
                id.startDate = idv.messageService.serviceHost.dateTime;

                if (id.runTimeFlag && (id.currentCount + id.useCount) >= id.useLimit)
                    throw new Exception("Tooling [" + id.name + "] UseCount over UseLimit");
            }
            
            base.doTxn(serviceHost);
        }

        Label lblLotId = new Label();
        TextBox txtLotId = new TextBox();


        //在基本資料設定用戶端裏執行此交易
        public override void GetExtraControls(toolingEventBase toolingEvent, Dictionary<Label, Control> dicControl)
        {
            lblLotId.Tag = "lotId";
            txtLotId.MaxLength = 40;
            txtLotId.BackColor = System.Drawing.SystemColors.Info;
            dicControl.Add(lblLotId, txtLotId);
        }

        public override bool CheckBeforeTxn()
        {
            if (txtLotId.Text.Trim().Equals(""))
            {
                idv.utilities.messageBox.showMessageById("requireField2", lblLotId.Text);
                return false;
            }
            lotId = txtLotId.Text;
            return true;
        }
    }
}
