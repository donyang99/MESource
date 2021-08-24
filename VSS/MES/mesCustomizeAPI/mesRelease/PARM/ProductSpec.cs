using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using idv.mesCore.PARM;
using mesRelease.PARM;
using mesRelease.EQP;
using mesRelease.PRP;
using mesRelease.MAT;

namespace mesRelease.PARM
{
    public class ProductSpec : productSpec<ProductSpec, StepParameter>
    {
        public ProductSpec() { }
        public ProductSpec(string name) : base(name) { }
        public ProductSpec(string name, short version) : base(name, version) { }

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

        List<PRP.Product> _product = null;
        public PRP.Product[] GetProducts()
        {
            if (_product == null)
            {
                string sql = "select a.* from mes_prp_product a join mes_parm_product_spec b " +
                             "on a.product_id=b.product_id and a.issue_state='Active' " +
                             "where b.spec_name=?";
                DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, name);
                _product = new List<PRP.Product>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    PRP.Product prod = new PRP.Product();
                    prod.putAttribute(row, "");
                    _product.Add(prod);
                }
            }
            return _product.ToArray();
        }
        public bool AddProduct(PRP.Product product)
        {
            foreach (PRP.Product prod in GetProducts())
            {
                if (prod.name == product.name)
                    return false;
            }
            if (AddProductSpec(product.name, name, ""))
            {
                _product.Add(product);
                return true;
            }
            else
                return false;
        }
        public void RemoveProduct(string productId)
        {
            RemoveProductSpec(productId, name);
            if (_product != null)
            {
                PRP.Product product = null;
                foreach (PRP.Product prod in _product)
                {
                    if (prod.name == productId)
                    {
                        product = prod;
                        break;
                    }
                }
                if (product != null)
                    _product.Remove(product);
            }
        }

        //static members

        #region Import ProductParameter from Excel(Tab format)
        public static ProductSpec[] Import(string path)
        {
            System.Data.DataTable table = GetData(path);
            List<ProductSpec> list = new List<ProductSpec>();

            ProductSpec spec = null;
            StepParameter stepParm = null;
            SpecMaterial specMat = null;
            EqType eqType = null;
            EqTrackMaterial trackMat = null;
            EqTooling eqTool = null;

            foreach (System.Data.DataRow row in table.Rows)
            {
                if (!row["SpecId"].Equals("") && (spec == null || !spec.name.Equals(row["SpecId"])))
                {
                    spec = new ProductSpec();
                    spec.name = row["SpecId"].ToString();
                    list.Add(spec);
                    stepParm = null;
                }

                if (!row["StepId"].Equals("") && (stepParm == null || !stepParm.name.Equals(row["StepId"])))
                {
                    stepParm = new StepParameter();
                    stepParm.name = row["StepId"].ToString();
                    stepParm.stdProcessTime = GetDouble(row["StdProcessTime"].ToString());
                    spec.Add(stepParm);

                    Step step = new Step(stepParm.name);
                    if (step.sysid.Equals(""))
                        ThrowException("step", stepParm.name);

                    foreach (StepMaterialType t in StepMaterialType.GetStepMaterialTypesByStep(stepParm.name))
                    {
                        SpecMaterial mat = new SpecMaterial();
                        mat.name = t.name;
                        mat.required = false;
                        stepParm.AddMaterialType(mat);
                    }
                    specMat = null;
                    eqType = null;
                    trackMat = null;
                    eqTool = null;
                }

                Parameter parm = GetParameter(row);
                if (parm != null)
                    stepParm.Add(parm);

                if (!row["MaterialType"].Equals("") && (specMat == null || !specMat.name.Equals(row["MaterialType"])))
                {
                    specMat = stepParm.GetMaterialType(row["MaterialType"].ToString());
                    if (specMat == null)
                        ThrowException("materialType", row["MaterialType"].ToString() + " (" + stepParm.name + ")");

                    specMat.required = true;
                }

                if (!row["EquipmentType"].Equals("") && (eqType == null || !eqType.name.Equals(row["EquipmentType"])))
                {
                    eqType = new EqType(row["EquipmentType"].ToString());
                    if (eqType.sysid.Equals(""))
                        ThrowException("EquipmentType", row["EquipmentType"].ToString());

                    if (eqType.trackCount > 0)
                    {
                        stepParm.InitEqTrackMaterial(eqType.name);
                        stepParm.ClearMaterialType();
                        specMat = null;
                    }

                    if (idv.mesCore.systemConfig.validItem("toolingManagement"))
                        stepParm.InitEqTooling(eqType.name);

                    if (!row["Recipe"].Equals(""))
                    {
                        EqRecipe eqRecipe = new EqRecipe();
                        eqRecipe.name = eqType.name;
                        eqRecipe.recipe = row["Recipe"].ToString();
                        stepParm.AddEqRecipe(eqRecipe);
                    }

                    trackMat = null;
                    eqTool = null;
                }
                if (!row["Track"].Equals("") && (trackMat == null || !trackMat.track.Equals(row["Track"])) && eqType != null)
                {
                    trackMat = stepParm.GetEqTrackMaterial(eqType.name, row["Track"].ToString());
                    if (trackMat == null)
                        ThrowException("track", row["Track"].ToString() + " (" + eqType.name + ")");
                }
                if (idv.mesCore.systemConfig.validItem("toolingManagement"))
                {
                    if (!row["ToolingType"].Equals("") && (eqTool == null || !eqTool.toolingType.Equals(row["ToolingType"])) && eqType != null)
                    {
                        eqTool = stepParm.GetEqTooling(eqType.name, row["ToolingType"].ToString());
                        if (eqTool == null)
                            ThrowException("ToolingType", row["ToolingType"].ToString() + " (" + eqType.name + ")");

                        string sql = "SELECT b.tooling_type FROM mes_tol_tooling_type_link a join mes_tol_tooling_type b on a.type_sysid=b.sysid where a.eq_type=? and b.tooling_type=?";
                        sql = idv.messageService.serviceHost.Client.getValueWithParameter(sql, eqType.name, eqTool.toolingType);
                        if (sql.Equals(""))
                            ThrowException("ToolingType", eqTool.toolingType + " (" + eqType.name + ")");
                    }
                }

                string partNo = row["PartNo"].ToString();
                double consumeRate = GetDouble(row["ConsumeRate"].ToString());

                if (!partNo.Equals(""))
                {
                    if (MaterialPart.GetMaterialPart(partNo) == null)
                        ThrowException("materialPart", partNo);

                    if (trackMat != null)
                        trackMat.Add(partNo, consumeRate);
                    else if (specMat != null)
                        specMat.Add(partNo, consumeRate);
                }

                if (eqTool != null)
                {
                    string toolingPart = row["ToolingPartNo"].ToString();
                    if (!toolingPart.Equals(""))
                    {
                        if (idv.messageService.serviceHost.Client.getValueWithParameter("select part_no from mes_tol_part where part_no=?", toolingPart).Equals(""))
                            ThrowException("ToolingPartNo", toolingPart);

                        eqTool.Add(toolingPart);
                    }
                }
            }
            return list.ToArray();
        }
        static double GetDouble(string value)
        {
            double d = 0;
            double.TryParse(value, out d);
            return d;
        }
        static Parameter GetParameter(DataRow row)
        {
            if (row["Parameter"].ToString().Equals("")) return null;
            Parameter parm = new Parameter(row["Parameter"].ToString());
            if (parm.sysid.Equals(""))
                throw new Exception("Can not find Parameter - " + row["Parameter"].ToString());
            if (parm.parmType == ParameterType.Range)
            {
                parm.max = GetDouble(row["Max"].ToString());
                parm.min = GetDouble(row["Min"].ToString());
            }
            else
                parm.value = row["Value"].ToString();

            return parm;
        }

        static DataTable GetData(string path)
        {
            DataTable table = mesRelease.utilities.ExcelAgent.ImportFromExcel(path);
            List<string> columns = new List<string>();
            columns.AddRange("SpecId,StepId,StdProcessTime,Parameter,Value,Max,Min,MaterialType,EquipmentType,Recipe,Track,PartNo,ConsumeRate".Split(','));
            foreach (DataColumn col in table.Columns)
                columns.Remove(col.ColumnName);
            if (columns.Count > 0)
                throw new Exception("invalidFormat");
            return table;
        }
        //static DataTable GetData(string path)
        //{
        //    DataTable table = null;
        //    using (System.IO.TextReader reader = new System.IO.StreamReader(path, Encoding.Default))
        //    {
        //        do
        //        {
        //            string s = reader.ReadLine();
        //            if (s == null) break;
        //            if (table == null)
        //            {
        //                if (!s.ToUpper().StartsWith("SpecId\tStepId\tStdProcessTime\tParameter\tValue\tMax\tMin\tMaterialType\tEquipmentType\tRecipe\tTrack\tPartNo\tConsumeRate".ToUpper()))
        //                    throw new Exception("invalidFormat");

        //                table = new DataTable();
        //                foreach (string col in s.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries))
        //                    table.Columns.Add(col.Trim());
        //            }
        //            else
        //            {
        //                string[] values = s.Split('\t');
        //                try
        //                {
        //                    DataRow row = table.NewRow();
        //                    for (int i = 0; i < table.Columns.Count; i++)
        //                        row[i] = values[i].Trim();
        //                    table.Rows.Add(row);
        //                }
        //                catch
        //                {

        //                }
        //            }
        //        } while (true);
        //    }
        //    return table;
        //}
        static void ThrowException(string objectType, string objectName)
        {
            string message = idv.utilities.cultureLanguage.getValue("msgCantFindLot2", "&" + objectType) + " - " + objectName;
            throw new Exception(message);
        }
        #endregion
    }
}
