using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.WIP;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.WIP.Txn;

namespace mesRelease.WIP.Txn
{
    public class TrackOut : trackOut<TrackOut, Lot, LotHistory>
    {
        public override void doTxn(idv.messageService.IMessageGuard serviceHost)
        {
            base.doTxn(serviceHost);
        }

        protected override void OnTxn(IMessageGuard serviceHost, List<sqlTable> executeSQL)
        {

        }

        protected override void AfterTxn(IMessageGuard serviceHost)
        {
            equipmentTxn(serviceHost);

            if (idv.mesCore.systemConfig.carrierManagement)
                carrierTxn(serviceHost);

            base.AfterTxn(serviceHost);
        }

        protected override void OnTxnError(Exception ex, ref bool handled)
        {
            base.OnTxnError(ex, ref handled);
        }

        public override void OnTxnSucceed()
        {
            webApi = Type.GetType("WebApi.Instance, WebApiInstance");
            if (webApi != null)
                new System.Threading.Thread(sendMsgToDeviceMate).Start();

            if (changeCapacityTxn != null)
                publishTxn.Add(changeCapacityTxn);
            else if (publishEQP)
            {
                idv.mesCore.EQP.Txn.publishTxn pubTxn = new idv.mesCore.EQP.Txn.publishTxn();
                pubTxn.Add(_equipment);
                publishTxn.Add(pubTxn);
            }
            
            base.OnTxnSucceed();            
        }

        Type webApi = null;
        void sendMsgToDeviceMate()
        {
            if (!System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "deviceMate.config")) return;
            string[] lines = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "deviceMate.config");
            string url="";
            string token = "";            
            bool txnFind = false;
            string apiName = "";
            string message = "";
            foreach (string s in lines)
            {
                if (s.StartsWith("url="))
                    url = s.Replace("url=", "");
                else if (s.StartsWith("token="))
                    token = s.Replace("token=", "");
                else if (s.StartsWith("txnName="))
                {
                    if (txnFind)
                        break;
                    else if (s.Equals("txnName=" + name))
                        txnFind = true;
                }
                else if (txnFind)
                {
                    if (s.StartsWith("webapiName="))
                        apiName = s.Replace("webapiName=", "");
                    else if (s.StartsWith("message="))
                        message = s.Replace("message=", "");
                }
            }
            url += "/" + apiName;
            foreach (Lot lot in Items)
            {
                string msg = message.Replace("{Sender}", "MES");
                msg = msg.Replace("{EqpId}", lot.lastEquipmentId); 
                msg = msg.Replace("{LotId}", "");

                List<object> list = new List<object>();
                list.Add(url);
                list.Add(0);
                list.Add("message");
                list.Add(msg);
                list.Add("token");
                list.Add(token);
                webApi.InvokeMember("SendMessageToWebApi", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                       System.Reflection.BindingFlags.InvokeMethod, null, null,list.ToArray());
            }
        }

        EQP.Txn.ChangeCapacity changeCapacityTxn = null;

        void equipmentTxn(IMessageGuard serviceHost)
        {
            //change capacity
            if (changeEqCapacity)
            {
                foreach (Lot lot in Items)
                {
                    changeCapacityTxn = new EQP.Txn.ChangeCapacity();
                    changeCapacityTxn.lotId = lot.name;
                    changeCapacityTxn.txnUser = txnUser;
                    changeCapacityTxn.mainTxnSysId = mainTxnSysId;
                    changeCapacityTxn.checkTimeStamp = false;
                    changeCapacityTxn.Add(_equipment);
                    if (_equipment.consumeType == idv.mesCore.EQP.EqConsumeType.ByLot)
                        changeCapacityTxn.capacityEffected = -1;
                    else
                        changeCapacityTxn.capacityEffected = 0 - (int)Math.Ceiling(lot.quantity);

                    changeCapacityTxn.doTxn(serviceHost);
                }
            }

            //consume material
            if (idv.mesCore.systemConfig.materialConsuming)
            {
                bool isSetupInfoChanged = false;
                mesRelease.EQP.SetupInfo info = _equipment.SetupInfo;
                if (info != null)
                {
                    string orgEqpInfo = info.sysid;
                    mesRelease.MAT.StepMaterialType[] stepMaterialTypes = null;
                    string curStepId = "";
                    foreach (Lot lot in Items)
                    {
                        PARM.StepParameter sp = null;
                        if (idv.mesCore.systemConfig.productParameter)
                            sp = lot.GetCurrentStepParameter();

                        if (sp != null)
                        {
                            List<idv.mesCore.MAT.stepMaterialTypeBase> list = new List<idv.mesCore.MAT.stepMaterialTypeBase>();
                            for (int i = 0; i < sp.MaterialTypeCount; i++)//依物料類型設定的規格
                                list.Add(sp.GetMaterialType(i));
                            list.AddRange(sp.GetEqTrackMaterials(info.name));//依軌道設定的規格
                            info.applyStepMaterialSetting(list.ToArray());
                        }
                        else
                        {
                            if (curStepId != lot.stepId)
                            {
                                stepMaterialTypes = mesRelease.MAT.StepMaterialType.GetStepMaterialTypesByStep(lot.stepId);
                                curStepId = lot.stepId;
                            }
                            info.applyStepMaterialSetting(stepMaterialTypes);
                        }

                        if (info.ConsumeMaterial(lot.quantity, serviceHost))
                            isSetupInfoChanged = true;
                    }
                    if (isSetupInfoChanged)
                    {
                        publishEQP = true;
                        _equipment.setupInfo = info.sysid;
                        _equipment.setupInfoFlag = false;
                        _equipment.modifyDate = idv.messageService.serviceHost.dateTime;
                        sqlTable table = new sqlTable("mes_eqp_equipment", eDMLtype.Update, 1);
                        table.Add("setup_info", _equipment.setupInfo);
                        table.Add("setup_info_flag", "0");
                        table.Add("validated_spec_sysid", "");
                        table.Add("modify_date", _equipment.modifyDate);
                        table.WhereClause.Add("sysid", _equipment.sysid);
                        if (!orgEqpInfo.Equals(""))
                            table.WhereClause.Add("setup_info", orgEqpInfo);
                        sqlExecuter.executeSqlTable(table, serviceHost);
                    }
                }
            }
        }

        void carrierTxn(IMessageGuard serviceHost)
        {
            foreach (Lot lot in Items)
            {
                Dictionary<string, CAR.Carrier> orgCarrier = new Dictionary<string, CAR.Carrier>();
                foreach (CAR.Carrier c in CAR.Carrier.getCarriers("", 0, 0, "", lot.name, "", 0, 0))
                    orgCarrier.Add(c.name, c);

                CAR.Txn.UseCarrier useCar = new CAR.Txn.UseCarrier();
                useCar.txnUser = txnUser;
                useCar.checkTimeStamp = false;
                useCar.lotId = lot.name;
                useCar.mainTxnSysId = mainTxnSysId;

                CAR.Txn.AdjustCarrierQty adjCar = new CAR.Txn.AdjustCarrierQty();
                adjCar.txnUser = txnUser;
                adjCar.checkTimeStamp = false;
                adjCar.mainTxnSysId = mainTxnSysId;
                adjCar.status = idv.mesCore.CAR.CarrierStatus.USED.ToString();

                CAR.Txn.ReleaseCarrier relCar = new CAR.Txn.ReleaseCarrier();
                relCar.txnUser = txnUser;
                relCar.checkTimeStamp = false;
                relCar.mainTxnSysId = mainTxnSysId;

                foreach (CAR.Carrier c in lot.CarrierList)
                {
                    orgCarrier.Remove(c.name);
                    if (c.status == "IDLE" && c.componentQty != 0)
                        useCar.Add(c);
                    else
                    {
                        if (c.componentQty == 0)
                            relCar.Add(c);
                        else if (c.lotId == lot.name)
                            adjCar.Add(c);
                        else
                            useCar.Add(c);
                    }
                }

                int i = 0;
                while (i < lot.CarrierList.Count)
                {
                    if (lot.CarrierList[i].componentQty > 0)
                        i++;
                    else
                        lot.CarrierList.RemoveAt(i);
                }

                foreach (CAR.Carrier c in orgCarrier.Values)
                    relCar.Add(c);

                if (useCar.Count > 0)
                    useCar.doTxn(serviceHost);
                if (adjCar.Count > 0)
                    adjCar.doTxn(serviceHost);
                if (relCar.Count > 0)
                    relCar.doTxn(serviceHost);
            }
        }

        EQP.Equipment _equipment = null;
        protected override idv.mesCore.EQP.equipmentBase getEquipment()
        {
            if(equipmentId.Equals("")) return null;
            if (_equipment == null)
            {
                _equipment = new EQP.Equipment(equipmentId);
                if(_equipment.sysid.Equals(""))
                    _equipment = null;
            }
            return _equipment;
        }

        List<PRP.DCItem> _dcItemList = new List<PRP.DCItem>();
        public List<PRP.DCItem> dcItemList
        {
            get { return _dcItemList; }
            set { _dcItemList = value; }
        }
        protected override int dcItemCount
        {
            get { return dcItemList.Count; }
        }
        protected override idv.mesCore.PRP.dcItemBase getDCItem(int index)
        {
            return dcItemList[index];
        }
    }
}
