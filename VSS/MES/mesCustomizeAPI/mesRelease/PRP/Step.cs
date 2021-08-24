using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using idv.messageService;

namespace mesRelease.PRP
{
    public class Step : idv.mesCore.PRP.step<Step, Rule>
    {
        public Step() { }
        public Step(string name) : base(name) { }
        public Step(string name, short version) : base(name, version) { }
        internal new void retrieveStep(string sysId)
        {
            base.retrieveStep(sysId);
        }

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

        internal new void putAttribute(DataRow row, string affix)
        {
            base.putAttribute(row, affix);
        }

        public DCItem[] DCItemsGet()
        {
            List<DCItem> list = new List<DCItem>();
            string sql = "select a.*,b.* from mes_prp_step_dc_link a join mes_prp_step_dc_item b on a.dc_item_sysid=b.sysid where a.step_id=? and b.delete_flag='0' order by seq";
            DataSet ds = serviceHost.Client.getDataSetWithParameter(sql, name);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DCItem item = new DCItem();
                item.putAttribute(row, "");
                item.required = row["required"].ToString() == "1" ? true : false;
                int tmp = 0;
                int.TryParse(row["timing"].ToString(), out tmp);
                item.timing = (idv.mesCore.PRP.DcItemTiming)tmp;
                item.checkFailPath = row["check_fail_path"].ToString();
                tmp = 0;
                int.TryParse(row["check_seq"].ToString(), out tmp);
                item.checkSeq = (byte)tmp;
                if (row.Table.Columns.Contains("message"))
                    item.message = row["message"].ToString();
                list.Add(item);                
            }
            return list.ToArray();
        }
        public void DCItemsSet(DCItem[] items)
        {
            List<idv.messageService.sql.sqlTable> tables = new List<idv.messageService.sql.sqlTable>();
            idv.messageService.sql.sqlTable table = new idv.messageService.sql.sqlTable("mes_prp_step_dc_link", idv.messageService.sql.eDMLtype.Delete);
            table.WhereClause.Add("step_id", name);
            tables.Add(table);
            int i = 0;
            if (items != null)
            {
                foreach (DCItem item in items)
                {
                    table = new idv.messageService.sql.sqlTable("mes_prp_step_dc_link", idv.messageService.sql.eDMLtype.Insert);
                    table.Add("step_id", name);
                    table.Add("dc_item_sysid", item.sysid);
                    table.Add("seq", i);
                    table.Add("required", item.required ? "1" : "0");
                    table.Add("timing", ((int)item.timing).ToString());
                    table.Add("check_fail_path", item.checkFailPath);
                    table.Add("check_seq", item.checkSeq);
                    if (item.message != null && !item.message.Trim().Equals(""))
                        table.Add("message", item.message);
                    tables.Add(table);
                    i++;
                }
            }
            IMessageGuard mg = serviceHost.Client;
            try
            {
                mg.beginTxn();
                idv.messageService.sql.sqlExecuter.executeSqlTables(tables, mg);
                mg.commitTxn();
            }
            catch
            {
                mg.rollbackTxn();
                throw;
            }
        }

        #region Material Tracking

        List<MAT.StepMaterialType> stepMaterialType = new List<MAT.StepMaterialType>();
        bool materialRetrieved = false;

        public void addMaterialType(MAT.StepMaterialType materialType)
        {
            materialRetrieved = true;
            if (materialType.stepId == name)
                stepMaterialType.Add(materialType);
            
        }
        public void removeMaterialType(string materialTypeName)
        {
            for (int i = 0; i < stepMaterialType.Count; i++)
            {
                if (stepMaterialType[i].name == materialTypeName)
                {
                    stepMaterialType.RemoveAt(i);
                    break;
                }
            }
        }

        public int MaterialTypeCount
        {
            get
            {
                retrieveStepMaterialTypes();
                return stepMaterialType.Count;
            }
        }
        public MAT.StepMaterialType GetMaterialType(int index)
        {
            retrieveStepMaterialTypes();
            if (index >= 0 && index < MaterialTypeCount)
                return stepMaterialType[index];
            else
                return null;
        }
        public MAT.StepMaterialType GetMaterialType(string  materialTypeName)
        {
            retrieveStepMaterialTypes();
            foreach (MAT.StepMaterialType materialType in stepMaterialType)
            {
                if (materialType.name == materialTypeName)
                    return materialType;
            }
            return null;
        }
        public MAT.StepMaterialType[] GetMaterialTypes()
        {
            retrieveStepMaterialTypes();
            return stepMaterialType.ToArray();
        }

        void retrieveStepMaterialTypes()
        {
            if (materialRetrieved || !idv.mesCore.systemConfig.materialTracking) return;
            materialRetrieved = true;
            stepMaterialType.Clear();
            stepMaterialType.AddRange(MAT.StepMaterialType.GetStepMaterialTypesByStep(name));
        }

        #endregion
    }
}
