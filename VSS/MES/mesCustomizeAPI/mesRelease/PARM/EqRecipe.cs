using System;
using System.Collections.Generic;
using idv.mesCore.PARM;
using System.Text;
using System.Data;

namespace mesRelease.PARM
{
    public class EqRecipe : eqRecipe<EqRecipe>
    {
        protected override void OnSaveProductSpec(idv.messageService.sql.sqlTable table)
        {
            
        }

        public static EqRecipe[] GetEqRecipes(string mainStepSysId)
        {
            List<EqRecipe> list = new List<EqRecipe>();
            string sql = "select /*+rule*/ * from mes_parm_main_step_recipe where main_step_sysid = ?";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, mainStepSysId);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                EqRecipe item = new EqRecipe();
                item.putAttribute(row, "");
                list.Add(item);
            }
            return list.ToArray();
        }
        public static EqRecipe GetEqRecipe(string specSysId, string stepId, string eqType)
        {
            string sql = "select /*+rule*/ * from mes_parm_main_step_recipe where sysid = ?";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, specSysId + "@" + stepId + "@" + eqType);
            if (ds.Tables[0].Rows.Count > 0)
            {
                EqRecipe item = new EqRecipe();
                item.putAttribute(ds.Tables[0].Rows[0], "");
                return item;
            }
            return null;
        }
    }
}
