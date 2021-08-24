using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using mesRelease.CAR;
using mesRelease.WIP;

namespace mesRelease.Controls
{
    public delegate void CarrierAddedEventHandler(Carrier carrier, ref bool accept);
    public delegate void CarrierSelectionChangedEventHandler(Carrier carrier, bool selected);
    public delegate void CarrierRemovedEventHandler(Carrier carrier, ref bool accept);
    public delegate void CarrierChangedEventHandler(Carrier oldCarrier, Carrier newCarrier, ref bool accept);

    public partial class CarrierInformation : UserControl
    {
        public event CarrierAddedEventHandler CarrierAdded;
        public event CarrierSelectionChangedEventHandler CarrierSelectionChanged;
        public event CarrierRemovedEventHandler CarrierRemoved;
        public event CarrierChangedEventHandler CarrierChanged;
        public event EventHandler AfterEdit;

        public CarrierInformation()
        {
            InitializeComponent();
        }

        [NonSerialized]
        ComponentInfo _componentInfo = null;
        public ComponentInfo componentInfo
        {
            get { return _componentInfo; }
            set { _componentInfo = value; }
        }

        [NonSerialized]
        List<Carrier> _carrierList = null;
        public List<Carrier> carrierList
        {
            get { return _carrierList; }
            set { _carrierList = value; }
        }

        string _lotId = "";
        public string lotId
        {
            get { return _lotId; }
            set { _lotId = value; }
        }

        bool _allowAdd = true;
        public bool allowAdd
        {
            get { return _allowAdd; }
            set { _allowAdd = value; }
        }

        bool _allowEdit = false;
        public bool allowEdit
        {
            get { return _allowEdit; }
            set { _allowEdit = value; }
        }

        bool _allowGenerateId = false;
        public bool allowGenerateId
        {
            get { return _allowGenerateId; }
            set { _allowGenerateId = value; }
        }

        bool _allowChangeCarrier = false; //更改CarrierId時，屬於原本Carrier的Component也一併改過去
        public bool allowChangeCarrier
        {
            get { return _allowChangeCarrier; }
            set { _allowChangeCarrier = value; }
        }

        bool _allowDelete = false;
        public bool allowDelete
        {
            get { return _allowDelete; }
            set { _allowDelete = value; }
        }

        bool _showCarrierType = false;
        public bool showCarrierType
        {
            get { return _showCarrierType; }
            set { _showCarrierType = value; }
        }

        bool _prepared = false;
        public void prepare()
        {
            tblInputCarrier.Visible = _allowEdit;
            pnlEditCarrier.Visible = _allowEdit;
            btnAddCarrier.Visible = _allowAdd;
            btnDeleteCarrier.Visible = _allowDelete;
            if (!_showCarrierType)
                lvwCarrier.columnHide = new string[] { "carrierType" };
            lvwCarrier.prepareColumns();
            if (!idv.mesCore.systemConfig.componentInfo)
                btnIdentifyComponent.Hide();
            if (_carrierList == null)
                _carrierList = new List<Carrier>();
            _prepared = true;
        }

        public void ShowCarriers(List<Carrier> carList, ComponentInfo compInfo)
        {
            if (!_prepared) prepare();
            if (carList != null)
                _carrierList = carList;
            _componentInfo = compInfo;
            if (!idv.mesCore.systemConfig.componentInfo)
                btnIdentifyComponent.Hide();
            else
                btnIdentifyComponent.Visible = _componentInfo != null;
            lvwCarrier.ShowMESItems(_carrierList.ToArray());
        }

        private void txtCarrierQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtCarrierQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCarrierQty.Text == "") return;
                if (txtCarrierId.Text != "")
                    btnAddCarrier.PerformClick();
                txtCarrierId.Focus();
            }
        }

        private void txtCarrierId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCarrierId.Text == "") return;
                int qty = 0;
                if (int.TryParse(txtCarrierQty.Text, out qty))
                    btnAddCarrier.PerformClick();
                else
                    txtCarrierQty.Focus();
            }
        }

        private void txt_Enter_For_SelectAll(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        volatile bool _confirmDeleteKey = false;
        private void lvwCarrier_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (_confirmDeleteKey)
                    btnDeleteCarrier.PerformClick();
                else
                {
                    _confirmDeleteKey = true;
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(threadCancelConfirmDeleteKey));
                    t.Start();
                }
            }
        }
        void threadCancelConfirmDeleteKey()
        {
            System.Threading.Thread.Sleep(300);
            _confirmDeleteKey = false;
        }

        private void lvwCarrier_DoubleClick(object sender, EventArgs e)
        {
            btnIdentifyComponent.PerformClick();
            OnDoubleClick(e);
        }

        private void lvwCarrier_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            Carrier car = null;
            if (!selected)
            {
                txtCarrierId.Text = "";
                txtCarrierQty.Text = "";
            }
            else
            {
                car = item as mesRelease.CAR.Carrier;
                if (car == null) return;
                txtCarrierId.Text = car.name;
                txtCarrierQty.Text = car.componentQty.ToString();
            }
            if (CarrierSelectionChanged != null)
                CarrierSelectionChanged(car, selected);
        }

        private void btnIdentifyComponent_Click(object sender, EventArgs e)
        {
            Carrier car = lvwCarrier.selectedMESItem as Carrier;
            if (car == null) return;
            frmIdentifyComponents frm = new frmIdentifyComponents();
            idv.utilities.cultureLanguage.switchLanguage(frm);
            try
            {
                frm.allowGenerateId = _allowGenerateId;
                frm.Init(lotId, _componentInfo, car);
                frm.ShowDialog();
            }
            finally
            {
                frm.Close();
            }
        }

        public Carrier selectedCarrier
        {
            get { return lvwCarrier.selectedMESItem as Carrier; }
        }

        private void btnAddCarrier_Click(object sender, EventArgs e)
        {
            txtCarrierId.SelectAll();
            if (txtCarrierId.Text.Trim() == "") return;       
            int qty = 0;
            if (!int.TryParse(txtCarrierQty.Text, out qty)) return;
            Carrier car = new Carrier(txtCarrierId.Text);
            car.componentQty = qty;
            AddCarrier(car);
        }
        public bool AddCarrier(Carrier carrier)
        {
            return AddCarrier(carrier, null);
        }
        public bool AddCarrier(Carrier carrier, WipComponent[] wipComponents)
        {
            foreach (Carrier car in _carrierList)
            {
                if (car.name == carrier.name)
                    return false;
            }
            if (CarrierAdded != null)
            {
                bool accept = true;
                CarrierAdded(carrier, ref accept);
                if (!accept)
                    return false;
            }
            _carrierList.Add(carrier);
            lvwCarrier.UpdateMESItem(carrier);

            if (wipComponents != null)
            {
                foreach (WipComponent comp in wipComponents)
                {
                    comp.carrierId = carrier.name;
                    if (_componentInfo != null)
                    {
                        _componentInfo.Remove(comp.name);
                        _componentInfo.Add(comp);
                    }
                }
            }
            if (AfterEdit != null)
                AfterEdit(this, new EventArgs());
            return true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Carrier carrier = lvwCarrier.selectedMESItem as mesRelease.CAR.Carrier;
            if (carrier == null) return;
            int qty = 0;
            if (!int.TryParse(txtCarrierQty.Text, out qty)) return;
            if (txtCarrierId.Text != carrier.name && _allowChangeCarrier)
            {
                Carrier newCarrier = new Carrier(txtCarrierId.Text);
                if (CarrierChanged != null)
                {
                    bool accept = true;
                    CarrierChanged(carrier, newCarrier, ref accept);
                    if (!accept) return;

                    if (_componentInfo != null)
                    {
                        foreach (WipComponent comp in _componentInfo.GetComponentsByCarrier(carrier.name))
                            comp.carrierId = newCarrier.name;
                    }
                    _carrierList.Remove(carrier);
                    _carrierList.Add(newCarrier);
                    lvwCarrier.RemoveMESItem(carrier);
                    carrier = newCarrier;
                }
            }

            carrier.componentQty = qty;
            lvwCarrier.UpdateMESItem(carrier);
            if (AfterEdit != null)
                AfterEdit(this, new EventArgs());
        }

        private void btnDeleteCarrier_Click(object sender, EventArgs e)
        {
            Carrier car = lvwCarrier.selectedMESItem as Carrier;
            if (car == null) return;
            if (CarrierRemoved != null)
            {
                bool accept = true;
                CarrierRemoved(car, ref accept);
                if (!accept)
                    return;
            }
            RemoveCarrier(car.name, false);
        }
        public WipComponent[] RemoveCarrier(string carrierId)
        {
            return RemoveCarrier(carrierId, false);
        }
        public WipComponent[] RemoveCarrier(string carrierId, bool removeComponent)
        {
            if (_carrierList == null) return new WipComponent[] { };
            Carrier car = null;
            foreach (Carrier carrier in _carrierList)
            {
                if (carrier.name == carrierId)
                {
                    car = carrier;
                    break;
                }
            }
            if (car == null)
                return new WipComponent[] { };

            List<WipComponent> list = new List<WipComponent>();
            if (_componentInfo != null && _componentInfo.Count > 0)
                list.AddRange(_componentInfo.GetComponentsByCarrier(carrierId));
            if (removeComponent)
            {
                foreach (WipComponent comp in list)
                    _componentInfo.Remove(comp.name);
            }
            else
            {
                foreach (WipComponent comp in list)
                    comp.carrierId = "";
            }
            _carrierList.Remove(car);
            lvwCarrier.RemoveMESItem(car);
            if (AfterEdit != null)
                AfterEdit(this, new EventArgs());
            return list.ToArray();
        }

        public void RemoveNoCarrierComponent(WipComponent[] excluded)
        {
            if (_componentInfo == null) return;
            foreach (WipComponent comp in _componentInfo.GetComponentsByCarrier(""))
            {
                if (excluded != null)
                {
                    foreach (WipComponent exc in excluded)
                    {
                        if (comp.name == exc.name)
                            continue;
                    }
                }
                _componentInfo.Remove(comp.name);
            }
        }

        public void Clear()
        {
            _carrierList.Clear();          
            lvwCarrier.RemoveAllMESItems();
            _componentInfo = null;
        }
    }
}
