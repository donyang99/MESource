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
    public class TxnEvent : txnEvent<TxnEvent, ToolingId, ToolingHistory>
    {
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {

        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
            base.AfterTxn(serviceHost);
        }

        protected override void OnTxnError(Exception ex, ref bool handled)
        {
            base.OnTxnError(ex, ref handled);
        }

        public override void OnTxnSucceed()
        {
            base.OnTxnSucceed();
        }

        //static member
        public static ToolingId[] ExecuteToolingEvent(string eventName, params string[] toolingId)
        {
            ToolingId[] ids = ToolingId.GetToolings(toolingId);
            if (ids.Length == 0) throw new Exception("Can not find toolingId");

            ToolingEvent[] evt = ToolingEvent.GetToolingEvents(ids[0].toolingType, ids[0].status, eventName, true);
            if (evt.Length == 0) throw new Exception("Can not find toolingEvent");

            return ExecuteToolingEvent(evt[0], ids);
        }
    }

    //類別名稱TxnEvent+事件名，繼承TxnEvent類，可客製個別事件
    public class TxnEventSAMPLE : TxnEvent
    {
        TextBox txtCount = new TextBox();
        void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        //實作GetExtraControls方法，可在交易畫面加入要顯示的資訊
        public override void GetExtraControls(toolingEventBase toolingEvent, Dictionary<Label, Control> dicControl)
        {
            Label lblCount = new Label();
            lblCount.Text = "數量";
            txtCount.KeyPress += new KeyPressEventHandler(txtCount_KeyPress);
            txtCount.MaxLength = 3;
            dicControl.Add(lblCount, txtCount);

            lblCount = new Label();
            lblCount.Tag = "lotId";
            ComboBox cbo = new ComboBox();
            cbo.Items.Add("a");
            dicControl.Add(lblCount, cbo);//將要顯示在主畫面的資訊加入在dicControl裏 

            foreach (KeyValuePair<Label, Control> kv in txnFormControl)//主要畫有將「位置」及「原因代碼」放在txnFormControl
            {
                if (kv.Key.Name.Equals("lblTarLocation"))
                {
                    Control ctl = kv.Value;
                }
            }
        }

        //實作CheckBeforeTxn方法，可對交易對象的參數賦值，回傳false代表檢查不通過(交易不會被執行)
        public override bool CheckBeforeTxn()
        {
            if (txtCount.Text.Equals(""))
            {
                return false;
            }
            location = "";
            return true;
        }
    }
}
