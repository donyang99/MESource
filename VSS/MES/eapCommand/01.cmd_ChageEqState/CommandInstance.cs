using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCommand;

namespace eapAutoChangeState
{
    public class CommandInstance : ICommand
    {
        mesRelease.EQP.Equipment eqp = null;
        string state = "";
        string reason = "";
        public override void Execute()
        {
            //Init and Check
            Init();

            //執行交易
            mesRelease.EQP.Txn.ChangeState txn = new mesRelease.EQP.Txn.ChangeState();
            txn.state = state;
            txn.reasonCode = reason;
            txn.txnUser = Command.Sender;
            if (txn.txnUser.Equals("")) txn.txnUser = "EAP";
            txn.Add(eqp);
            txn = txn.doTxn();
            if (!txn.result.Equals("PASS"))
                throw new Exception(txn.errMessage);

            //將交易加入廣播交易清單中
            Command.publishTxn.Add(txn);
            
            //執行成功
            Command.result = "PASS";
        }

        //初始化必要資訊及檢查
        void Init()
        {
            //取得Equipment
            string temp = Command.GetArgumentValue("EqpId");
            eqp = new mesRelease.EQP.Equipment(temp);
            if (eqp.sysid.Equals(""))
                throw new Exception("Can't Find Equipment");
            
            //取得機台報上來的狀態代碼
            temp = Command.GetArgumentValue("tag");
            if (!temp.Equals("totalstatus"))
                throw new Exception("Wrong Argument - tag should be totalstatus");

            temp = Command.GetArgumentValue("now");
            
            //依EquipmentType+EqCode取得對應的狀態
            string sql = "select state from mes_auto_state_map where eq_type=? and eq_code=?";
            state = idv.messageService.serviceHost.Client.getValueWithParameter(sql, eqp.type, temp);
            if (state.Equals(""))
                state = temp;

            //取得原因代碼
            reason = Command.GetArgumentValue("reasonCode");
        }
    }
}
