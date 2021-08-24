using System;
using System.Drawing;
using System.Windows.Forms;

namespace mesBasicData
{
    public partial class frmMain : Form
    {
        idv.mesCore.brmExtension brmExt = null;
        public frmMain()
        {
            InitializeComponent();
            functionTree1.privilegeStringPrefix = appInstance.PrivilegeString;
            appInstance.setMainStatusBar(standardStatusbar1);
            standardStatusbar1.setUser(mesRelease.USR.User.loginUser.name);
            standardStatusbar1.setVersion(Application.ProductVersion);
            Icon ico = idv.MESApplication.GetImageFromFile("mesBasicData.ico") as Icon;
            if (ico != null)
                Icon = ico;

            brmExt = new idv.mesCore.brmExtension(appInstance.Name, appInstance.PrivilegeString, this, appInstance.Logger, verifyUserPassword, getFormName);

            buildFunctionTree();

            brmExt.buildFunctionTreeWithDll();//

            functionTree1.CheckPrivilege(mesRelease.USR.User.loginUser);
            functionTree1.LoadPocket(mesRelease.USR.User.loginUserId);
            splitter1.DoubleClick += new EventHandler(splitter1_DoubleClick);
            standardStatusbar1.setVersion(idv.messageService.dynamicAssembly.assemblyVersion("mesBasicData.dll"));
        }

        bool verifyUserPassword()
        {
            if (!idv.mesCore.systemConfig.validateExecuteUser(1))//不需驗證就回傳true
                return true;
            else
                return mesRelease.USR.User.VerifyPassword();
        }
        string getFormName(string functionName)
        {
            return null;
        }

        private void splitter1_DoubleClick(object sender, EventArgs e)
        {
            functionTree1.AutoWidth();
        }

        void buildFunctionTree()
        {
            #region CAT模組
            //Function Group
            functionTree1.AddFunctionGroup("catGroup", "title.png", "CAT");
            //Tree child node
            functionTree1.AddFunction("catGroup", "LanguageMap", "language.png", "LANGUAGEMAP");
            functionTree1.AddFunction("catGroup", "FAB", "fab.png", "FAB");
            functionTree1.AddFunction("catGroup", "Division", "division.png", "DIVISION");
            functionTree1.AddFunction("catGroup", "LotType", "lottype.png", "LOTTYPE");
            if (idv.mesCore.systemConfig.componentType)
                functionTree1.AddFunction("catGroup", "ComponentType", "catComponentType.png", "COMPONENTTYPE");

            if (idv.mesCore.systemConfig.stepCode)
                functionTree1.AddFunction("catGroup", "StepCode", "catStepCode.png", "STEPCODE");

            if (idv.mesCore.systemConfig.stepStage)
                functionTree1.AddFunction("catGroup", "Stage", "stage.png", "STAGE");

            if (idv.mesCore.systemConfig.routeType)
                functionTree1.AddFunction("catGroup", "RouteType", "routeType", "ROUTETYPE");

            functionTree1.AddFunction("catGroup", "ReasonType", "reasonType", "REASONTYPE");
            functionTree1.AddFunction("catGroup", "ReasonCode", "reasonCode2.png", "REASONCODE");
            functionTree1.AddFunction("catGroup", "ReasonGroup", "reasonGroup.png", "REASONGROUP");
            functionTree1.AddFunction("catGroup", "ReasonCategory", "reasonCategory.png", "REASONCATEGORY");
            #endregion

            #region CAR模組
            if (idv.mesCore.systemConfig.carrierManagement || idv.mesCore.systemConfig.validItem("carrierMaintain"))
            {
                //Function Group
                functionTree1.AddFunctionGroup("carGroup", "title.png", "CAR");
                //Tree child node
                functionTree1.AddFunction("carGroup", "CarrierType", "carrierType.png", "CARTYPE");
                functionTree1.AddFunction("carGroup", "Carrier", "carrier.png", "CARRIER");
            }
            #endregion

            #region 機台模組 EQP
            //Function Group            
            functionTree1.AddFunctionGroup("eqpEquipmentSetup", "title.png", "EQP");//機台
            //Tree child node
            functionTree1.AddFunction("eqpEquipmentSetup", "EqState", "equipmentState.png", "EQPSTATE");//設定可用狀態   
            if (idv.mesCore.systemConfig.validItem("eqParameter"))
                functionTree1.AddFunction("eqpEquipmentSetup", "EqParameter", "eqParam", "EQPARAMETER");//設定機台參數  
            functionTree1.AddFunction("eqpEquipmentSetup", "EquipmentType", "equipmentType.png", "EQPTYPE");//機台類別
            functionTree1.AddFunction("eqpEquipmentSetup", "Equipment", "equipment.png", "EQPEQUIPMENT");//機台
            functionTree1.AddFunction("eqpEquipmentSetup", "EquipmentGroup", "equipmentGroup.png", "EQPGROUP");//機台群組            
            functionTree1.AddFunction("eqpEquipmentSetup", "EqStateChange", "changeState.png", "EQPSTATECHANGE");//機台轉換規則   
            #endregion

            #region PRP模組
            //Function Group
            functionTree1.AddFunctionGroup("prpGroup", "title.png", "PRP");
            //Tree child node            
            functionTree1.AddFunction("prpGroup", "Rule", "rule.png", "RULE");
            functionTree1.AddFunction("prpGroup", "StepDC", "stepDC.png", "STEPDC");
            functionTree1.AddFunction("prpGroup", "Step", "step.png", "STEP");
            functionTree1.AddFunction("prpGroup", "Route", "route.png", "ROUTE");
            functionTree1.AddFunction("prpGroup", "ProductType", "productType", "PRODUCTTYPE");
            functionTree1.AddFunction("prpGroup", "Product", "product.png", "PRODUCT");
            #endregion

            #region USR模組
            //Function Group
            functionTree1.AddFunctionGroup("userModule", "title.png", "USER");
            //Tree child node
            functionTree1.AddFunction("userModule", "AccessString", "accessString.png", "ACCESSSTRING");
            functionTree1.AddFunction("userModule", "UserInfo", "user.png", "USERINFO");
            functionTree1.AddFunction("userModule", "UserGroup", "userGroup.png", "USERGROUP");
            functionTree1.AddFunction("userModule", "GrantAccessString", "grantAccessString", "GRANTACCESS");
            #endregion

            #region MAT模組

            if (idv.mesCore.systemConfig.materialTracking)
            {
                functionTree1.AddFunctionGroup("matGroup", "title.png", "MAT");

                functionTree1.AddFunction("matGroup", "MaterialType", "materialType", "MATERIALTYPE");
                functionTree1.AddFunction("matGroup", "StepConsumeMaterial", "stepMaterial", "STEPCONSUMEMATERIAL");
                functionTree1.AddFunction("matGroup", "MaterialPart", "part", "MATERIALPART");
            }

            #endregion

            #region ProductParameter模組
            if (idv.mesCore.systemConfig.productParameter)
            {
                functionTree1.AddFunctionGroup("parameterGroup", "title.png", "PARM");

                functionTree1.AddFunction("parameterGroup", "Parameter", "parameter", "PARAMETER");
                functionTree1.AddFunction("parameterGroup", "StepParameter", "stepParameter", "STEPPARAMETER");
                functionTree1.AddFunction("parameterGroup", "ProductParameter", "productParameter", "PRODUCTPARAMETER");
                if (mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.specSelectProduct || mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.productSelectSpec)
                    functionTree1.AddFunction("parameterGroup", "ProductSpec", "productSpec", "PRODUCTSPEC");
                functionTree1.AddFunction("parameterGroup", "ProductSpecQuery", "productSpec", "PRODUCTSPEC");
            }
            #endregion
        }
    }
}
