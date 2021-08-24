using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.EQP;

namespace mesRelease.EQP
{
    public class Equipment : equipment<Equipment>
    {
        public Equipment() : base() { }
        public Equipment(string name) : base(name) { }

        protected override void OnInit(System.Data.DataRow row)
        {

        }
        protected override void OnNew(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnModify(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnDelete(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnRefresh(bool deep)
        {
            if (deep)
            {
                _eqpSetupInfo = null;
            }
        }

        public SetupInfo SetupInfo
        {
            get
            {
                if (!callByToMessage)
                {
                    if (_eqpSetupInfo != null && IsSetupInfoChanged()) _eqpSetupInfo = null;
                    if (_eqpSetupInfo == null && !idv.mesCore.systemConfig.materialTracking)
                        return null;
                    else if (setupInfo.Equals(""))
                        return null;
                    else if (_eqpSetupInfo == null)
                        _eqpSetupInfo = new SetupInfo(type, setupInfo);
                }
                return _eqpSetupInfo as SetupInfo;
            }
            set
            {
                _eqpSetupInfo = value;
            }
        }

        protected override setupInfoBase eqpSetupInfo
        {
            get
            {
                return SetupInfo;
            }
            set
            {
                _eqpSetupInfo = value;
            }
        }

        public override setupInfoBase GetSetupInfo()
        {
            return SetupInfo;
        }

        protected override stateBase getStateBase()
        {
            return State.GetState(state);
        }

        public List<EqTypeParameter[]> GetEqParameterDataHis(DateTime dateFrom, DateTime dateTo)
        {
            List<EqTypeParameter[]> returnList = new List<EqTypeParameter[]>();

            if (parameterCount == 0) return returnList;
            EqType t = EqType.GetEqType(type);
            List<EqTypeParameter> list = new List<EqTypeParameter>();

            SortedDictionary<string, idv.messageService.sql.query.SqlQuery> dicTable = new SortedDictionary<string, idv.messageService.sql.query.SqlQuery>();

            foreach (EqTypeParameter tParm in t.GetEqParameters())
            {
                list.Add(tParm.Clone());
                idv.messageService.sql.query.SqlQuery table = null;
                if (dicTable.ContainsKey(tParm.tableName))
                    table = dicTable[tParm.tableName];
                else
                {
                    table = new idv.messageService.sql.query.SqlQuery(tParm.tableName + "_his", "t" + dicTable.Count.ToString());
                    dicTable.Add(tParm.tableName, table);
                }
                table.AddQueryColumn(tParm.columnName, tParm.tableName + "_" + tParm.columnName);
            }
            if (list.Count == 0) return returnList;
            idv.messageService.sql.query.SqlQuery mainTable = null;

            foreach (idv.messageService.sql.query.SqlQuery table in dicTable.Values)
            {
                if (mainTable == null)
                {
                    mainTable = table;
                    mainTable.AddQueryColumn("lot_id");
                    mainTable.AddQueryColumn("eq_parm_seq");
                    mainTable.AddQueryColumn("check_result");
                    mainTable.AddQueryColumn("fail_info");
                    mainTable.AddQueryColumn("modify_user");
                    mainTable.AddQueryColumn("modify_date");
                }
                else
                {
                    table.AddJoinCondition("equipment_id", "equipment_id");
                    table.AddJoinCondition("eq_parm_seq", "eq_parm_seq");
                    mainTable.AddJoinTable(table);
                }
            }
            mainTable.WhereClause.Add("equipment_id", name);
            mainTable.WhereClause.Add("modify_date >=", dateFrom);
            mainTable.WhereClause.Add("modify_date <=", dateTo);
            mainTable.AddOrderColumn("modify_date", idv.messageService.sql.query.sqlOrderByType.DESC, 0);

            System.Data.DataSet ds = mainTable.GetDataSet();

            List<EqTypeParameter> lstTemp = new List<EqTypeParameter>();
            foreach (System.Data.DataRow row in ds.Tables[0].Rows)
            {
                EqTypeParameter p = null;
                lstTemp.Clear();
                foreach (EqTypeParameter tParm in list)
                {
                    p = tParm.Clone();
                    p.value = row[tParm.tableName + "_" + tParm.columnName].ToString();
                    lstTemp.Add(p);
                }
                p = new EqTypeParameter();
                p.name = "LOTID";
                p.value = row["lot_id"].ToString();
                lstTemp.Add(p);

                p = new EqTypeParameter();
                p.name = "SEQ";
                p.value = row["eq_parm_seq"].ToString();
                lstTemp.Add(p);

                p = new EqTypeParameter();
                p.name = "CHECKRESULT";
                p.value = row["check_result"].ToString();
                lstTemp.Add(p);

                p = new EqTypeParameter();
                p.name = "FAILINFO";
                p.value = row["fail_info"].ToString();
                lstTemp.Add(p);

                p = new EqTypeParameter();
                p.name = "MODIFYUSER";
                p.value = row["modify_user"].ToString();
                lstTemp.Add(p);

                p = new EqTypeParameter();
                p.name = "MODIFYDATE";
                p.value = row["modify_date"].ToString();
                lstTemp.Add(p);
                returnList.Add(lstTemp.ToArray());
            }
            return returnList;
        }
        public EqTypeParameter[] GetEqParameterData(int seq = -1)
        {
            if (parameterCount == 0) return new EqTypeParameter[] { };
            EqType t = EqType.GetEqType(type);
            List<EqTypeParameter> list = new List<EqTypeParameter>();

            SortedDictionary<string, idv.messageService.sql.query.SqlQuery> dicTable = new SortedDictionary<string, idv.messageService.sql.query.SqlQuery>();

            foreach (EqTypeParameter tParm in t.GetEqParameters())
            {
                list.Add(tParm.Clone());
                idv.messageService.sql.query.SqlQuery table = null;
                if (dicTable.ContainsKey(tParm.tableName))
                    table = dicTable[tParm.tableName];
                else
                {
                    if (seq == -1)
                        table = new idv.messageService.sql.query.SqlQuery(tParm.tableName, "t" + dicTable.Count.ToString());
                    else
                        table = new idv.messageService.sql.query.SqlQuery(tParm.tableName + "_his", "t" + dicTable.Count.ToString());
                    dicTable.Add(tParm.tableName, table);
                }
                table.AddQueryColumn(tParm.columnName, tParm.tableName + "_" + tParm.columnName);
            }
            if (list.Count == 0) return new EqTypeParameter[] { };
            idv.messageService.sql.query.SqlQuery mainTable = null;

            foreach (idv.messageService.sql.query.SqlQuery table in dicTable.Values)
            {
                if (mainTable == null)
                {
                    mainTable = table;
                    mainTable.AddQueryColumn("lot_id");
                    mainTable.AddQueryColumn("eq_parm_seq");
                    mainTable.AddQueryColumn("check_result");
                    mainTable.AddQueryColumn("fail_info");
                    mainTable.AddQueryColumn("modify_user");
                    mainTable.AddQueryColumn("modify_date");
                }
                else
                {
                    table.AddJoinCondition("equipment_id", "equipment_id");
                    if (seq != -1)
                        table.AddJoinCondition("eq_parm_seq", "eq_parm_seq");
                    mainTable.AddJoinTable(table);
                }
            }
            mainTable.WhereClause.Add("equipment_id", name);
            if(seq!=-1)
                mainTable.WhereClause.Add("eq_parm_seq", seq);

            System.Data.DataSet ds = mainTable.GetDataSet();
            foreach (System.Data.DataRow row in ds.Tables[0].Rows)
            {
                foreach (EqTypeParameter tParm in list)
                    tParm.value = row[tParm.tableName + "_" + tParm.columnName].ToString();
                
                EqTypeParameter p = new EqTypeParameter();
                p.name = "LOTID";
                p.value = row["lot_id"].ToString();
                list.Add(p);

                p = new EqTypeParameter();
                p.name = "SEQ";
                p.value = row["eq_parm_seq"].ToString();
                list.Add(p);

                p = new EqTypeParameter();
                p.name = "CHECKRESULT";
                p.value = row["check_result"].ToString();
                list.Add(p);

                p = new EqTypeParameter();
                p.name = "FAILINFO";
                p.value = row["fail_info"].ToString();
                list.Add(p);

                p = new EqTypeParameter();
                p.name = "MODIFYUSER";
                p.value = row["modify_user"].ToString();
                list.Add(p);

                p = new EqTypeParameter();
                p.name = "MODIFYDATE";
                p.value = row["modify_date"].ToString();
                list.Add(p);
                break;
            }
            return list.ToArray();
        }
    }
}
