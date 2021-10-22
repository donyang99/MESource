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
    public class TxnEventLOT_COMPLETE : TxnEvent
    {
        int _lotQuantity = 0;
        public int lotQuantity
        {
            get { return _lotQuantity; }
            set { _lotQuantity = value; }
        }

        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            if (lotId.Equals(""))
                throw new Exception("lotId is required");
            if (lotQuantity <= 0)
                throw new Exception("lotQuantity is required");
            foreach (ToolingId id in Items)
            {
                if (id.controlType == ControlType.Time && !id.startDate.Equals(DateTime.MinValue) && !idv.mesCore.systemConfig.assemblyMode)
                    id.currentCount += (int)(idv.messageService.serviceHost.dateTime - id.startDate).TotalMinutes;
                else if (id.controlType == ControlType.Count)
                {
                    if (id.consumeType == ConsumeType.ByLot)
                        id.currentCount++;
                    else if (id.consumeType == ConsumeType.ByQty)
                        id.currentCount += lotQuantity;
                }
                if (!idv.mesCore.systemConfig.assemblyMode)//assemblyMode=true時不會有LOT_START(每次過帳只有TrackOut(呼叫LOT_COMPLETE)
                    id.startDate = DateTime.MinValue;
                else
                { 
                    if(id.runTimeFlag && (id.currentCount + id.useCount) > id.useLimit)
                        throw new Exception("Tooling [" + id.name + "] UseCount over UseLimit");
                }
            }
            base.doTxn(serviceHost);
        }

        Label lblLotId = new Label();
        TextBox txtLotId = new TextBox();

        Label lblQuantity = new Label();
        TextBox txtQuantity = new TextBox();
        void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        //在基本資料設定用戶端裏執行此交易
        public override void GetExtraControls(toolingEventBase toolingEvent, Dictionary<Label, Control> dicControl)
        {
            dicControl.Add(new Label(), null);//右邊那個位置不用(新增加的控件從下一列開始排)

            lblLotId.Tag = "lotId";
            txtLotId.Enabled = false;
            txtLotId.Text = getLastTxnLotId();
            dicControl.Add(lblLotId, txtLotId);

            lblQuantity.Text = "數量";
            lblQuantity.Tag = "lotQuantity";
            txtQuantity.KeyPress += new KeyPressEventHandler(txtQuantity_KeyPress);
            txtQuantity.MaxLength = 6;
            txtQuantity.BackColor = System.Drawing.SystemColors.Info;
            dicControl.Add(lblQuantity, txtQuantity);
        }
        string getLastTxnLotId()
        {
            string sql = "select lot_id from mes_tol_tooling_history where txn_sysid=?";
            return serviceHost.Client.getValueWithParameter(sql, Item(0).lastTxnSysId);
        }

        public override bool CheckBeforeTxn()
        {
            int qty = 0;
            if (int.TryParse(txtQuantity.Text, out qty))
                lotQuantity = qty;
            else
            {
                idv.utilities.messageBox.showMessageById("requireField2", lblQuantity.Text);
                return false;
            }
            lotId = txtLotId.Text;
            return true;
        }
    }
}
