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
    //選機台
    public class TxnEventHWSETUP : TxnEvent
    {
        bool _ideFlag = false;//是否為管理界面執行操作功能
        public bool ideFlag
        {
            get { return _ideFlag; }
            set { _ideFlag = value; }
        }

        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            if (location.Equals(""))
                throw new Exception("location(EquipmentId) is required");
            locationType = LocationType.Equipment;
            foreach (ToolingId id in Items)
            {
                if (!id.location.Equals("") && locationType == LocationType.Equipment && !id.location.Equals(location))
                    throw new Exception("Tooling [" + id.name + "] is on Equipment [" + id.location + "]");

                id.setupUser = txnUser;
                id.setupDate = idv.messageService.serviceHost.dateTime;
                id.startDate = id.setupDate;//for 沒有LotStart的廠，架機時間就算開始時間(有LotStart的反正LotStart會再更新開始時間)

                if (id.controlType == ControlType.Count && id.consumeType == ConsumeType.BySetup)
                    id.currentCount++;

                if (id.runTimeFlag && (id.currentCount + id.useCount) > id.useLimit)
                    throw new Exception("Tooling [" + id.name + "] UseCount over UseLimit");
            }
            base.doTxn(serviceHost);
        }
        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {
            //if (ideFlag)//如果是MES的架機功能執行的，就不用更新機台資訊(架機功能會自己更新)
            //{
                sqlTable table = new sqlTable("mes_eqp_equipment", eDMLtype.Update);//將機台的tooling_setup_info，validated_spec_tooling欄位清空
                table.Add("tooling_setup_info", "-");//代表機台有治工具交易
                table.Add("validated_spec_tooling", "");
                table.Add("modify_date", idv.messageService.serviceHost.dateTime);                
                table.WhereClause.Add("equipment_id", location);
                table.ignoreError = true;
                executeSQL.Add(table);
            //}
        }

        //在基本資料設定用戶端裏執行此交易
        public override void GetExtraControls(toolingEventBase toolingEvent, Dictionary<Label, Control> dicControl)
        {
            ideFlag = true;
            foreach (KeyValuePair<Label, Control> kv in txnFormControl)//主要畫有將「位置」及「原因代碼」放在txnFormControl
            {
                if (kv.Key.Name.Equals("lblTarLocation"))
                {
                    ComboBox ctl = kv.Value as ComboBox;
                    kv.Key.Enabled = true;
                    ctl.Enabled = true;
                    ctl.Items.AddRange(GetEquipmentIds());
                }
            }
        }
        string[] GetEquipmentIds()
        {
            ToolingId toolId = Item(0);
            string sql = "select equipment_id from mes_eqp_equipment where eq_type in " +
                         "(select a.eq_type from mes_parm_main_step_eq_tooling a " +
                         "join mes_parm_main_step_eq_tol_part b on a.sysid=b.from_sysid " +
                         "where part_no =?)";
            List<string> list = new List<string>();
            System.Data.DataSet ds = serviceHost.Client.getDataSetWithParameter(sql, toolId.partNo);
            foreach (System.Data.DataRow row in ds.Tables[0].Rows)
                list.Add(row[0].ToString());
            return list.ToArray();
        }
    }
}
