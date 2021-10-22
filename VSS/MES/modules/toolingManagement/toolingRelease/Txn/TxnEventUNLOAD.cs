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
    //location清空，current_count加到use_count,total_count(次數或時間，讓用戶可以輸入/修改)，current_count歸0
    public class TxnEventUNLOAD : TxnEvent
    {
        bool _ideFlag = false;//是否為管理界面執行操作功能
        public bool ideFlag
        {
            get { return _ideFlag; }
            set { _ideFlag = value; }
        }

        Dictionary<string, int> _EqToolingCount = new Dictionary<string, int>();
        public Dictionary<string, int> EqToolingCount
        {
            get { return _EqToolingCount; }
            set { _EqToolingCount = value; }
        }

        public override void doTxn(IMessageGuard serviceHost)
        {
            foreach (ToolingId id in Items)
            {
                if (!ideFlag && id.controlType == ControlType.Time && !id.startDate.Equals(DateTime.MinValue))//用上/下機算使用時間
                    id.currentCount = (int)(idv.messageService.serviceHost.dateTime - id.startDate).TotalMinutes;
                
                if (!id.location.Equals(""))
                {
                    if (_EqToolingCount.ContainsKey(id.location))
                        _EqToolingCount[id.location]++;
                    else
                        _EqToolingCount[id.location] = 1;
                }
                id.location = "";
                id.useCount += id.currentCount;
                id.totalCount += id.currentCount;
                id.currentCount = 0;
                id.setupUser = "";
                id.setupDate = DateTime.MinValue;
                id.startDate = DateTime.MinValue;
            }
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {
            //if (ideFlag)//如果是MES的架機功能執行的，就不用更新機台資訊(架機功能會自己更新)
            //{
                foreach (string eqId in _EqToolingCount.Keys.ToArray())
                {
                    string sql = "select count(tooling_id) from mes_tol_tooling_id where location = ?";
                    int count = 0;
                    int.TryParse(serviceHost.getValueWithParameter(sql, eqId), out count);
                    count = count - _EqToolingCount[eqId];//unload後機台上的tooling數量
                    if (count < 0) count = 0;

                    sqlTable table = new sqlTable("mes_eqp_equipment", eDMLtype.Update);//將機台的tooling_setup_info，validated_spec_tooling欄位清空
                    table.Add("tooling_setup_info", count > 0 ? "-" : "");//-代表機台有治工具
                    table.Add("validated_spec_tooling", "");
                    table.Add("modify_date", idv.messageService.serviceHost.dateTime);                    
                    table.WhereClause.Add("equipment_id", eqId);
                    table.ignoreError = true;
                    executeSQL.Add(table);

                    _EqToolingCount[eqId] = count;
                }
            //}
        }

        Label lblCount = null;
        TextBox txtCount = new TextBox();
        void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        //在基本資料設定用戶端裏執行此交易
        public override void GetExtraControls(toolingEventBase toolingEvent, Dictionary<Label, Control> dicControl)
        {
            ideFlag = true;
            ToolingId tolId = Item(0);
            if (tolId.controlType == ControlType.None) 
                return;
            else if (tolId.controlType == ControlType.Time && !tolId.startDate.Equals(DateTime.MinValue))
                tolId.currentCount = (int)(idv.messageService.serviceHost.dateTime - tolId.startDate).TotalMinutes;

            lblCount = new Label();
            lblCount.Text = "數量";
            lblCount.Tag = "CurrentCount";
            txtCount.KeyPress += new KeyPressEventHandler(txtCount_KeyPress);
            txtCount.MaxLength = 6;
            txtCount.BackColor = System.Drawing.SystemColors.Info;
            if (tolId.currentCount > 0)
                txtCount.Text = tolId.currentCount.ToString();//顯示當前次數，用戶可以修改

            dicControl.Add(lblCount, txtCount);
        }

        public override bool CheckBeforeTxn()
        {
            if (lblCount == null) return true;
            int curCnt = 0;
            if (int.TryParse(txtCount.Text, out curCnt))
                Item(0).currentCount = curCnt;//將用戶指定當前的使用次數assign到currentCount屬性
            else
            {
                idv.utilities.messageBox.showMessageById("requireField2", lblCount.Text);
                return false;
            }
            return true;
        }
    }
}
