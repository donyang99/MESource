using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;
using idv.mesCore.PARM;
using System.Linq;
using System.Data;
using idv.utilities;

namespace mesRelease.PARM
{
    public class StepParameter : stepParameter<StepParameter, Parameter>
    {
        public StepParameter() { }
        public StepParameter(string name) : base(name) { }

        protected override void OnInit(System.Data.DataRow row)
        {

        }

        protected override void OnModify(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnDelete(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnSaveProductSpec(idv.messageService.sql.sqlTable table)
        {

        }

        public SpecMaterial GetMaterialType(int index)
        {
            return _specMaterial[index] as SpecMaterial;
        }
        public SpecMaterial GetMaterialType(string name)
        {
            foreach (specMaterialBase item in _specMaterial)
            {
                if (item.name == name)
                    return item as SpecMaterial;
            }
            return null;
        }
        public void AddMaterialType(SpecMaterial materialType)
        {
            if (GetMaterialType(materialType.name) == null)
                _specMaterial.Add(materialType);
        }

        public EqRecipe GetEqRecipe(int index)
        {
            return _eqRecipe[index] as EqRecipe;
        }
        public EqRecipe GetEqRecipe(string eqType)
        {
            foreach (eqRecipeBase item in _eqRecipe)
            {
                if (item.name == eqType)
                    return item as EqRecipe;
            }
            return null;
        }
        public void AddEqRecipe(EqRecipe eqRecipe)
        {
            if (GetEqRecipe(eqRecipe.name) == null)
                _eqRecipe.Add(eqRecipe);
        }

        public EqTrackMaterial[] GetEqTrackMaterials(string eqType)
        {
            SortedList<short, EqTrackMaterial> list = new SortedList<short, EqTrackMaterial>();
            foreach (EqTrackMaterial item in _eqTrackMaterial)
            {
                if (item.name.Equals(eqType))
                {
                    while (list.ContainsKey(item.seq))
                        item.seq++;
                    list.Add(item.seq, item);
                }
            }
            return list.Values.ToArray();
        }
        public EqTrackMaterial GetEqTrackMaterial(string eqType, string track)
        {
            foreach (EqTrackMaterial item in _eqTrackMaterial)
            {
                if (item.name.Equals(eqType) && item.track.Equals(track))
                    return item;
            }
            return null;
        }
        public void AddEqTrackMaterial(EqTrackMaterial trackMaterial)
        {
            if (GetEqTrackMaterial(trackMaterial.name, trackMaterial.track) == null)
                _eqTrackMaterial.Add(trackMaterial);
        }
        public void InitEqTrackMaterial(string eqType)
        {
            mesRelease.EQP.EqType type = mesRelease.EQP.EqType.GetEqType(eqType);
            foreach (string track in type.tracks)
            {
                if (GetEqTrackMaterial(eqType, track) == null)
                {
                    EqTrackMaterial mat = new EqTrackMaterial();
                    mat.name = eqType;
                    mat.track = track;
                    _eqTrackMaterial.Add(mat);
                }
            }
        }

        public EqTooling[] GetEqToolings(string eqType)
        {
            SortedList<string, EqTooling> list = new SortedList<string, EqTooling>();
            foreach (EqTooling item in _eqTooling)
            {
                if (item.name.Equals(eqType))
                    list[item.toolingType] = item;
            }
            return list.Values.ToArray();
        }
        public EqTooling GetEqTooling(string eqType, string toolingType)
        {
            foreach (EqTooling item in _eqTooling)
            {
                if (item.name.Equals(eqType) && item.toolingType.Equals(toolingType))
                    return item;
            }
            return null;
        }
        public void AddEqTooling(EqTooling eqTooling)
        {
            if (GetEqTooling(eqTooling.name, eqTooling.toolingType) == null)
                _eqTooling.Add(eqTooling);
        }
        public void InitEqTooling(string eqType)
        {
            mesRelease.EQP.EqType type = mesRelease.EQP.EqType.GetEqType(eqType);
            foreach (string tolType in type.toolingTypes)
            {
                if (GetEqTooling(eqType, tolType) == null)
                {
                    EqTooling et = new EqTooling();
                    et.name = eqType;
                    et.toolingType = tolType;
                    _eqTooling.Add(et);
                }
            }
        }

        bool _specInfoRetrieved = false;
        public void RetrieveSpecInformation()
        {
            if (_specInfoRetrieved) return;
            _specInfoRetrieved = true;

            threadSucceed = false;
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(retrieveSpecInformationThread));
            t.Start();

            foreach (Parameter param in Parameter.GetParameters(sysid))
                Add(param);
            
            foreach (SpecMaterial material in SpecMaterial.GetSpecMaterials(mainSysId, name))
                AddMaterialType(material);

            if (idv.mesCore.systemConfig.validItem("toolingManagement"))
            {
                foreach (EqTooling tool in EqTooling.GetEqToolings(sysid))
                    AddEqTooling(tool);
            }
            
            t.Join();
            if (!threadSucceed)
            {
                ClearEqRecipe();
                ClearEqTrackMaterial();
                retrieveSpecInformationThread();
            }
        }

        bool threadSucceed = false;
        void retrieveSpecInformationThread()
        {
            try
            {
                foreach (EqRecipe recipe in EqRecipe.GetEqRecipes(sysid))
                    AddEqRecipe(recipe);
                foreach (EqTrackMaterial trackMaterial in EqTrackMaterial.GetEqTrackMaterials(sysid))
                    AddEqTrackMaterial(trackMaterial);
                threadSucceed = true;
            }
            catch { }
        }

        public bool CheckDCItem(PRP.DCItem dcItem)
        {
            foreach (Parameter parm in Items)
            {
                if (parm.dcItemSysid.Equals(dcItem.sysid))
                    return parm.CheckValue(dcItem.itemValue);
            }
            return true;
        }
        public bool CheckEqParm(EQP.EqTypeParameter eqParmData)
        {
            foreach (Parameter parm in Items)
            {
                if (parm.eqParmSysId.Equals(eqParmData.sysid))
                    return parm.CheckValue(eqParmData.value);
            }
            return true;
        }

        public bool CheckRecipe(string equipmentType, string recipe)
        {
            EqRecipe rcp = GetEqRecipe(equipmentType);
            if (rcp != null && !rcp.Equals("") && !rcp.recipe.Equals(recipe))
                return false;
            return true;
        }

        public bool CheckMaterial(string equipmentType, string track, string materialType, string materialPartNo)
        {
            specMaterialBase material = null;

            if (!track.Equals(""))
                material = GetEqTrackMaterial(equipmentType, track);
            else
                material = GetMaterialType(materialType);

            if (material == null || !material.usePartNo(materialPartNo))
                return false;
            return true;
        }

        public bool CheckMaterial(string equipmentType, EQP.SetupInfo setupInfo)
        {
            EQP.SetupMaterial material = null;
            return CheckMaterial(equipmentType, setupInfo, ref material);
        }
        public bool CheckMaterial(string equipmentType, EQP.SetupInfo setupInfo, ref EQP.SetupMaterial wrongMaterial)
        {
            if (setupInfo == null) setupInfo = new EQP.SetupInfo();
            if (MaterialTypeCount > 0)
            {
                //依物料類型上料
                for (int i = 0; i < MaterialTypeCount; i++)
                {
                    SpecMaterial specMat = GetMaterialType(i);
                    EQP.SetupMaterial[] setupMats = setupInfo.Item(specMat.name);//取得該材料類型的架機物料
                    if (setupMats.Length == 0 && specMat.required)
                    {
                        wrongMaterial = new EQP.SetupMaterial();
                        wrongMaterial.name = specMat.name;
                        return false;
                    }

                    foreach (EQP.SetupMaterial material in setupMats)
                    {
                        if (!CheckMaterial(equipmentType, "", material.name, material.partNo))
                        {
                            wrongMaterial = material;
                            return false;
                        }
                    }
                }
            }
            else
            {   //依軌道上料
                foreach (EqTrackMaterial eqTrack in GetEqTrackMaterials(equipmentType))
                {
                    if (!eqTrack.required) continue;//沒設定可用料號則不用檢查
                    EQP.SetupMaterial[] setupMats = setupInfo.ItemByPosition(eqTrack.track);
                    if (setupMats.Length == 0)
                    {
                        wrongMaterial = new EQP.SetupMaterial();
                        wrongMaterial.position = eqTrack.track;
                        return false;
                    }

                    foreach (EQP.SetupMaterial material in setupMats)
                    {
                        if (!CheckMaterial(equipmentType, material.position, "", material.partNo))
                        {
                            wrongMaterial = material;
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public bool CheckTooling(string equipmentType, string toolingType, string toolingPartNo)
        {
            EqTooling eqTool = GetEqTooling(equipmentType, toolingType);
            if (eqTool != null)
                return eqTool.partNOs.Contains(toolingPartNo);

            return false;
        }

        //Static Members
        internal static ConcurrentDictionary<string, StepParameter> dicStepParm = new ConcurrentDictionary<string, StepParameter>();//順序不是後加的排在後

        public static int parmCacheCount = 50;
        public static int parmCacheHour = 2;
        public static StepParameter GetSpecStep(string specSysId, string stepId, bool retrieveInfo)
        {
            string key = specSysId + "@" + stepId;
            StepParameter sp = null;
            lock (key)
            {
                if (!dicStepParm.ContainsKey(key))
                {
                    sp = StepParameter.GetSpecStep(specSysId, stepId);
                    if (sp == null) return null;

                    if (retrieveInfo)
                        sp.RetrieveSpecInformation();
                    dicStepParm[key] = sp;
                    sp.createDate = DateTime.Now;
                    if (dicStepParm.Count > parmCacheCount)
                    {
                        lock (dicStepParm)
                        {
                            List<string> lstStepParm = new List<string>();
                            foreach (StepParameter p in dicStepParm.Values)
                            {
                                if ((DateTime.Now - p.createDate).TotalHours > parmCacheHour)
                                    lstStepParm.Add(p.mainSysId + "@" + p.name);
                            }
                            foreach(string s in lstStepParm)
                            {
                                StepParameter o = null;
                                dicStepParm.TryRemove(s, out  o);
                                o = null;
                            }
                        }
                    }
                }
                else
                {
                    sp = dicStepParm[key];
                    if ((DateTime.Now - sp.createDate).TotalSeconds > 3)
                    {
                        string sql = "select modify_date from mes_parm_main_step where sysid = ?";
                        DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, key);
                        if (!ds.Tables[0].Rows[0]["modify_date"].Equals(sp.modifyDate))
                        {
                            sp = StepParameter.GetSpecStep(specSysId, stepId);
                            sp.RetrieveSpecInformation();

                            dicStepParm[key] = sp;
                        }
                        sp.createDate = DateTime.Now;
                    }
                }
            }

            return sp;
        }

        public static bool CheckEqParameter(WIP.Lot lot, EQP.Equipment eqp, EQP.EqTypeParameter[] eqParameterData, List<EQP.EqTypeParameter> failEqParmList)
        {
            StepParameter stepParm = null;
            return CheckEqParameter(lot, eqp, ref stepParm, eqParameterData, failEqParmList);
        }
        internal static bool CheckEqParameter(WIP.Lot lot, EQP.Equipment eqp, ref StepParameter stepParameter, EQP.EqTypeParameter[] eqParameterData, List<EQP.EqTypeParameter> failEqParmList)
        {
            if ((lot == null && stepParameter == null) || eqp == null || !idv.mesCore.systemConfig.validItem("eqParameter")) return true;
            if (eqParameterData == null) eqParameterData = eqp.GetEqParameterData();
            if (eqParameterData.Length == 0) return true;
            if (stepParameter == null) stepParameter = lot.GetCurrentStepParameter();
            if (stepParameter == null) return true;
            bool returnValue = true;
            foreach (EQP.EqTypeParameter eqParm in eqParameterData)
            {
                if (!eqParm.value.Equals("") && !stepParameter.CheckEqParm(eqParm))
                {
                    if (failEqParmList != null) failEqParmList.Add(eqParm);
                    returnValue = false;
                }
            }
            return returnValue;
        }

        public static bool CheckStepParameter(WIP.Lot lot, EQP.Equipment eqp, PRP.DCItem[] dcItems, ref string errMessage)
        {
            return CheckStepParameter(lot, eqp, dcItems, ref errMessage, null);
        }
        public static bool CheckStepParameter(WIP.Lot lot, EQP.Equipment eqp, PRP.DCItem[] dcItems, ref string errMessage, List<PRP.DCItem> checkFailItemsWithPath)
        {
            return CheckStepParameter(lot, eqp, dcItems, ref errMessage, checkFailItemsWithPath, true);
        }
        public static bool CheckStepParameter(WIP.Lot lot, EQP.Equipment eqp, PRP.DCItem[] dcItems, ref string errMessage, List<PRP.DCItem> checkFailItemsWithPath, bool checkEqCondition)
        {
            errMessage = "";
            if (!mesRelease.BAS.LotType.GetLotType(lot.lotType).IsNeedSpec()) return true;

            if (lot.specId.Equals(""))
            {
                errMessage = cultureLanguage.getValue("msgCantFindLot2", "&productParameter");
                return false;
            }

            StepParameter stepParm = null;
            List<EQP.EqTypeParameter> failEqParmList = new List<EQP.EqTypeParameter>();
            if (checkEqCondition && !CheckEqParameter(lot, eqp, ref stepParm, null, failEqParmList))
            {
                List<string> list = new List<string>();
                foreach (EQP.EqTypeParameter tParm in failEqParmList)
                    list.Add(tParm.name);
                errMessage = cultureLanguage.getValue("msgEqParmCheckFail", string.Join(",", list.ToArray()));
                return false;
            }
            
            SortedList<byte, PRP.DCItem> failDcitemList = new SortedList<byte, PRP.DCItem>();//若有多個有failPath的dcItem檢查失敗放這裏
            if (dcItems.Length > 0 && lot.IsCheckDcSpec())
            {
                if (stepParm == null)
                    stepParm = lot.GetCurrentStepParameter();
                if (stepParm == null) return true;
                foreach (mesRelease.PRP.DCItem dcItem in dcItems)
                {
                    if (!stepParm.CheckDCItem(dcItem) && dcItem.required)
                    {
                        errMessage = dcItem.GetCheckFailMessage();
                        if (dcItem.checkFailPath.Trim().Equals(""))//沒有檢查失敗要跑的路徑
                            return false;
                        else
                        {
                            byte key = dcItem.checkSeq;
                            while (failDcitemList.ContainsKey(key))
                                key++;
                            failDcitemList.Add(key, dcItem);
                        }
                    }
                }
            }

            bool validatedSpecSysIdChecked = false;
            string specSysIdTooling = "";
            bool specSysIdPass = false;
            bool specSysIdToolingPass = false;
            if (!lot.specSysId.Equals(""))
            {
                validatedSpecSysIdChecked = true;
                specSysIdPass = isSpecSysIdValidated(lot.specSysId, eqp, ref specSysIdTooling);
                specSysIdToolingPass = lot.specSysId.Equals(specSysIdTooling);
                if (specSysIdPass && failDcitemList.Count == 0 && (specSysIdToolingPass || !lot.IsCheckTooling()))
                    return true;
            }

            if (stepParm == null)
                stepParm = lot.GetCurrentStepParameter();
            if (stepParm == null && failDcitemList.Count == 0) return true;

            if (!validatedSpecSysIdChecked)
            {
                specSysIdPass = isSpecSysIdValidated(lot.specSysId, eqp, ref specSysIdTooling);
                specSysIdToolingPass = lot.specSysId.Equals(specSysIdTooling);
                if (specSysIdPass && failDcitemList.Count == 0 && (specSysIdToolingPass || !lot.IsCheckTooling()))
                    return true;
            }

            if (stepParm != null)
            {
                Dictionary<string, string> dicInfo = new Dictionary<string, string>();
                if (!specSysIdPass && checkEqCondition)
                {
                    if (lot.IsCheckRecipe())
                    {
                        EqRecipe r = stepParm.GetEqRecipe(eqp.type);
                        if (r != null && !r.recipe.Equals("") && !r.recipe.Equals(eqp.recipe))
                        {
                            errMessage = cultureLanguage.getValue("msgWrongRecipe", eqp.recipe, r.recipe);
                            return false;
                        }
                    }

                    if (lot.IsCheckMaterial())
                    {
                        EQP.SetupInfo setupInfo = eqp.SetupInfo;
                        EQP.SetupMaterial setupMat = null;
                        if (!stepParm.CheckMaterial(eqp.type, setupInfo, ref setupMat))
                        {
                            if (setupMat.position.Equals(""))
                                errMessage = cultureLanguage.getValue("msgWrongSetupOnMatType", setupMat.name);
                            else
                                errMessage = cultureLanguage.getValue("msgWrongSetupOnTrack", cultureLanguage.getValue("materialPartNo"), setupMat.position);

                            return false;
                        }
                    }

                    if (lot.IsCheckMaterial() && lot.IsCheckRecipe())
                        dicInfo["updateSpecSysid"] = "Y";
                }

                if (!specSysIdToolingPass && checkEqCondition && lot.IsCheckTooling())
                {
                    EqTooling[] parmEqTooling = stepParm.GetEqToolings(eqp.type);//站點參數裏設定的治工具規格
                    if (parmEqTooling.Length > 0)
                    {
                        //if (eqp.toolingSetupInfo.Equals(""))//肯定沒有架治工具
                        //{
                        //    errMessage = cultureLanguage.getValue("msgWrongEqTooling", parmEqTooling[0].toolingType);
                        //    return false;
                        //}
                        Type tToolingId = Type.GetType("mesRelease.TOL.ToolingId, toolingRelease");
                        object returnValue = tToolingId.BaseType.InvokeMember("GetToolings", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { "", "", eqp.name, "", false });

                        idv.messageService.itemBase[] toolingIds = returnValue as idv.messageService.itemBase[];
                        foreach (PARM.EqTooling eqTool in parmEqTooling)
                        {
                            bool findToolType = false;
                            foreach (idv.messageService.itemBase tooling in toolingIds)
                            {
                                if (eqTool.toolingType.Equals(tooling.getPropertyInString("toolingType")))
                                {
                                    findToolType = true;
                                    if (!eqTool.partNOs.Contains(tooling.getPropertyInString("partNo")))
                                    {
                                        errMessage = cultureLanguage.getValue("msgWrongEqTooling", eqTool.toolingType);
                                        return false;
                                    }
                                }
                            }
                            if (!findToolType)
                            {
                                errMessage = cultureLanguage.getValue("msgWrongEqTooling", eqTool.toolingType);
                                return false;
                            }
                        }
                        dicInfo["updateToolingSpecSysid"] = "Y";
                    }
                }

                if (dicInfo.Count > 0)
                {
                    dicInfo["specSysId"] = lot.specSysId;
                    dicInfo["equpmentId"] = eqp.name;
                    new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(updateEqValidatedSpecSysId)).Start(dicInfo);
                }
            }

            if (failDcitemList.Count == 0)
                return true;
            else
            {
                if (checkFailItemsWithPath != null)
                    checkFailItemsWithPath.AddRange(failDcitemList.Values);

                foreach (PRP.DCItem dcItem in failDcitemList.Values)//顯示主要有路徑的資料收集項目
                {
                    errMessage = dcItem.GetCheckFailMessage();
                    break;
                }
                return false;
            }
        }

        static bool isSpecSysIdValidated(string specSysId, EQP.Equipment eqp,ref string specSysIdTooling)
        {
            //一次性同時把setupInfo, lastSetupDate撈出來，賦予機台，讓機台檢查是否上料已有異動不必再撈一次資料
            string sql = "select validated_spec_sysid,setup_info,last_setup_date from mes_eqp_equipment where equipment_id=?";
            if (idv.mesCore.systemConfig.validItem("toolingManagement"))
                sql = "select validated_spec_sysid,validated_spec_tooling,setup_info,last_setup_date from mes_eqp_equipment where equipment_id=?";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, eqp.name);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                try
                {
                    string setupInfo = row["setup_info"].ToString();
                    DateTime lastSetupDate = DateTime.Now;
                    if (!row["last_setup_date"].Equals(DBNull.Value))
                    {
                        lastSetupDate = Convert.ToDateTime(row["last_setup_date"]);
                        eqp.SetSeupInfoChangeCheckInfo(setupInfo, lastSetupDate);
                    }
                }
                catch { }
                if (idv.mesCore.systemConfig.validItem("toolingManagement"))
                    specSysIdTooling = row["validated_spec_tooling"].ToString();
                return row["validated_spec_sysid"].ToString().Equals(specSysId);
            }
            return false;
        }

        static void updateEqValidatedSpecSysId(object dicInfo)
        {
            string specSysId = "";
            string equpmentId = "";
            bool updateSpecSysid = false;
            bool updateToolingSpecSysid = false;
            Dictionary<string, string> dic = dicInfo as Dictionary<string, string>;
            if (dic.ContainsKey("specSysId")) specSysId = dic["specSysId"];
            if (specSysId.Equals("")) return;
            if (dic.ContainsKey("equpmentId")) equpmentId = dic["equpmentId"];
            if (dic.ContainsKey("updateSpecSysid")) updateSpecSysid = dic["updateSpecSysid"].Equals("Y");
            if (dic.ContainsKey("updateToolingSpecSysid")) updateToolingSpecSysid = dic["updateToolingSpecSysid"].Equals("Y");
            
            idv.messageService.sql.sqlTable table = new idv.messageService.sql.sqlTable("mes_eqp_equipment", idv.messageService.sql.eDMLtype.Update);
            table.WhereClause.Add("equipment_id", equpmentId);
            if (updateSpecSysid)
                table.Add("validated_spec_sysid", specSysId);
            if (updateToolingSpecSysid)
                table.Add("validated_spec_tooling", specSysId);
            table.ignoreError = true;
            if (table.Count > 0)
                idv.messageService.sql.sqlExecuter.executeSqlTable(table, idv.messageService.serviceHost.Client);
        }
    }
}
