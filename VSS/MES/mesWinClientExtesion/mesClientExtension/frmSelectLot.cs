using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;
using mesRelease.EQP;
using mesRelease.PARM;
using idv.mesCore.WIP.Txn.Info;
using idv.utilities;
using System.Threading;

namespace mesWinClient.Ext
{
    public partial class frmSelectLot : Form
    {
        public bool Result { get; set; }
        public Lot SelectedLot { get; set; }
        Lot[] _availableLots = null;        
        Thread t = null;
        frmWaiting frmWait = new frmWaiting();
        public Lot[] AvailableLots
        {
            get { return _availableLots; }
            set
            {
                _availableLots = value;
                if (_availableLots.Length <= 1) return;
                t = new Thread(new ThreadStart(prepareLots));
                t.Start();
                frmWait.ShowText(cultureLanguage.getValue("calcWeight"));
                frmWait.Show();
            }
        }
        public Equipment Eqp { get; set; }

        void prepareLots()
        {
            try
            {
                getMoveInDate();
            }
            catch { }
            try
            {
                checkProductParameter();
            }
            catch { }
            try
            {
                calcDueDate();
            }
            catch { }
        }

                            //LotPriority *10
        void getMoveInDate()//先進站，先進機。權重1分
        {
            SortedList<DateTime, Lot> list = new SortedList<DateTime, Lot>();
            foreach (Lot lot in _availableLots)
            { 
                lotTrackingInfo info=lot.GetLotTrackingInfo();
                DateTime date;
                if (info == null)
                    date = DateTime.Now;
                else
                    date = info.moveInDate;

                while (list.ContainsKey(date))
                    date = date.AddMinutes(1);

                lot.addProperty("moveInDate", date);
                list.Add(date, lot);
            }
            Lot[] lots = new Lot[list.Values.Count];
            list.Values.CopyTo(lots, 0);
            for (int i = 0; i < lots.Length; i++)
                lots[i].addProperty("weight", (double)(lots.Length - i) + (10 - lots[i].priority) * 10);
        }

                                    //機台上的材料為可用的材料。每個相同50分，不同0分
        void checkProductParameter()//機台Recipe為可用Recipe。相同100分，不同0分
        {
            if (!idv.mesCore.systemConfig.productParameter) return;
            SetupInfo eqSetupInfo = Eqp.SetupInfo;
            foreach (Lot lot in _availableLots)
            {
                if (lot.specSysId.Equals("")) continue;
                StepParameter parm = lot.GetCurrentStepParameter();
                if (parm == null) continue;
                //recipe
                if (!Eqp.recipe.Equals(""))
                {
                    EqRecipe lotRecipe = parm.GetEqRecipe(Eqp.type);
                    if (lotRecipe != null && lotRecipe.recipe.Equals(Eqp.recipe))
                        lot.addProperty("weight", lot.getPropertyInDouble("weight") + 100);
                }

                if (eqSetupInfo == null) continue;
                //material
                foreach (SetupMaterial material in eqSetupInfo.Items)
                {
                    SpecMaterial specMaterial = parm.GetMaterialType(material.name);
                    if (specMaterial == null || specMaterial.Count == 0) continue;
                    if (specMaterial.usePartNo(material.partNo))
                        lot.addProperty("weight", lot.getPropertyInDouble("weight") + 50);
                }
            }
        }

        void calcDueDate()//DueDate越近先進機。權重2分
        {
            SortedList<DateTime, Lot> list = new SortedList<DateTime, Lot>();
            foreach (Lot lot in _availableLots)
            {
                DateTime date = lot.dueDate;

                while (list.ContainsKey(date))
                    date = date.AddMinutes(1);

                list.Add(date, lot);
            }
            Lot[] lots = new Lot[list.Values.Count];
            list.Values.CopyTo(lots, 0);
            for (int i = 0; i < lots.Length; i++)
                lots[i].addProperty("weight", lots[i].getPropertyInDouble("weight") + (double)(lots.Length - i) * 2);
        }

        public frmSelectLot()
        {
            InitializeComponent();
            string lotColumnNames = "name,status,moveInDate,quantity,unit,lotType,productId,routeId,stepId,orderId,specId,customerId,customerDueDate,dueDate";
            string lotColumnTags = "lotId,status,moveInDate,quantity,unit,lotType,productId,routeId,stepId,orderId,specId,customerId,customerDueDate,dueDate";

            lvwLot.columnNames = lotColumnNames.Split(',');
            lvwLot.columnTags = lotColumnTags.Split(',');            
            lvwLot.prepareColumns();
            cultureLanguage.switchLanguage(this);
        }

        public void ShowLots(ImageList imgList)
        {
            try
            {
                t.Join();
                SortedList<double, Lot> sortList = new SortedList<double, Lot>();
                foreach (Lot lot in _availableLots)
                {
                    double weight = 0;
                    try
                    {
                        weight = Convert.ToDouble(lot.getProperty("weight"));
                    }
                    catch { }


                    while (sortList.ContainsKey(weight))
                        weight += 0.01;
                    sortList.Add(weight, lot);
                }
                Lot[] lots = new Lot[sortList.Values.Count];
                sortList.Values.CopyTo(lots, 0);
                Array.Reverse(lots);
                lvwLot.SmallImageList = imgList;
                lvwLot.ShowMESItems(lots);
            }
            catch { }
            finally
            {
                frmWait.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedLot = null;
            Result = false;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedLot = lvwLot.selectedMESItem as Lot;
            if (SelectedLot == null) return;
            Result = true;
            Close();
        }

        private void lvwLot_DoubleClick(object sender, EventArgs e)
        {
            btnOK.PerformClick();
        }
    }
}
