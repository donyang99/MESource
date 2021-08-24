using System;
using System.Collections.Generic;
using idv.mesCore.PARM;
using System.Text;
using System.Data;
using System.Linq;

namespace mesRelease.PARM
{
    public class SpecMaterial : specMaterial<SpecMaterial>
    {
        protected override void OnSaveProductSpec(List<idv.messageService.sql.sqlTable> sqlList)
        {
            
        }

        public static SpecMaterial[] GetSpecMaterials(string specSysId, string stepId)
        {
            Dictionary<string, SpecMaterial> dic = new Dictionary<string, SpecMaterial>();

            string sql = "select /*+rule*/ a.*,b.* from mes_parm_main_step_material a left join mes_parm_main_step_mat_part b " +
                         "on a.sysid=b.from_sysid where a.main_step_sysid = ? " +
                         "order by a.material_type,b.seq";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, specSysId + "@" + stepId);

            SpecMaterial item = null;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                sql = row["material_type"].ToString();
                if (dic.ContainsKey(sql))
                    item = dic[sql];
                else
                {
                    item = new SpecMaterial();
                    item.sysid = row["sysid"].ToString();
                    item.stepSysId = row["main_step_sysid"].ToString();
                    item.name = sql;
                    item.stepId = stepId;
                    dic[sql] = item;
                }
                item.putAttribute(row, "");
            }
           
            return dic.Values.ToArray();
        }
    }
}
