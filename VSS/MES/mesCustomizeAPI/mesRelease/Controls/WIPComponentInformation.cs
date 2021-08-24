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
    public partial class WIPComponentInformation : UserControl
    {
        public WIPComponentInformation()
        {
            InitializeComponent();
        }

        int colIndex_Position = 0;
        int colIndex_Id = 1;

        string _lotId = "";
        public string lotId
        {
            get { return _lotId; }
            set { _lotId = value; }
        }

        [NonSerialized]
        Carrier _carrier = null;
        public Carrier carrier
        {
            get { return _carrier; }
            set 
            {
                _carrier = value;
                if (_carrier != null)
                {
                    txtCarrierId.Text = _carrier.name;
                    txtCarrierQty.Text = _carrier.componentQty.ToString();
                }
                else
                {
                    txtCarrierId.Text = "";
                    txtCarrierQty.Text = "";
                }
            }
        }

        [NonSerialized]
        ComponentInfo _componentInfo = null;
        public ComponentInfo componentInfo
        {
            get { return _componentInfo; }
            set { _componentInfo = value; }
        }

        int _expectedQuantity = 0;
        public int expectedQuantity
        {
            get
            {
                if (_expectedQuantity == 0 && _carrier != null)
                {
                    if (_carrier.componentQty != 0)
                        return _carrier.componentQty;
                    else
                        return _carrier.capacity;
                }
                else
                    return _expectedQuantity;
            }
            set { _expectedQuantity = value; }
        }

        bool _showCarrierInfo = false;
        public bool showCarrierInfo
        {
            get { return _showCarrierInfo; }
            set { _showCarrierInfo = value; }
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

        bool _allowMoveLocation = true;
        public bool allowMoveLocation
        {
            get { return _allowMoveLocation; }
            set { _allowMoveLocation = value; }
        }

        bool _prepared = false;
        public void prepare()
        {
            if (_carrier == null) _showCarrierInfo = false;
            tblCarrierInfo.Visible = _showCarrierInfo;
            btnGenerate.Visible = _allowGenerateId;
            tblEditComponent.Visible = _allowEdit;
            btnUp.Visible = _allowMoveLocation;
            btnDown.Visible = _allowMoveLocation;
            btnDeleteComponent.Visible = _allowEdit;
            _prepared = true;
        }

        public void ShowComponents(ComponentInfo compInfo)
        {
            ShowComponents(compInfo, null);
        }
        public void ShowComponents(ComponentInfo compInfo, Carrier car)
        {
            carrier = car;
            componentInfo = compInfo;
            if (!_prepared) prepare();

            lvwComponentId.Items.Clear();
            if (componentInfo == null) return;
            int count = 0;

            List<WipComponent> lstComponents = new List<WipComponent>();
            lstComponents.AddRange(componentInfo.GetComponentsByCarrier(txtCarrierId.Text));

            foreach (WipComponent comp in lstComponents)
            {
                if (comp.position > count)
                    count = comp.position;
            }
            if (expectedQuantity > count)
                count = expectedQuantity;

            for (short i = 0; i < count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                WipComponent comp = compInfo.GetComponent(txtCarrierId.Text, (short)(i + 1));
                if (comp == null)
                    item.SubItems.Add("");
                else
                {
                    item.SubItems.Add(comp.name);
                    item.Name = comp.name;
                    lstComponents.Remove(comp);
                }
                lvwComponentId.Items.Add(item);
            }

            //剩餘沒有顯示出來的Component(同CarrierId，同Position的)
            while (lstComponents.Count > 0)
            {
                ListViewItem item = new ListViewItem((count + 1).ToString());
                WipComponent comp = lstComponents[0];
                lstComponents.Remove(comp);
                comp.position = (short)(count + 1);
                item.SubItems.Add(comp.name);
                item.Name = comp.name;
                lvwComponentId.Items.Add(item);
                count++;
            }

            if (_componentInfo != null && _componentInfo.Count > 0)
            {
                cboComponentId.Items.Clear();
                if (txtCarrierId.Text == "")
                {
                    foreach (WipComponent comp in _componentInfo.Items)
                    {
                        if (comp.carrierId != "")
                            cboComponentId.Items.Add(comp.name);
                    }
                }
                else
                {
                    foreach (WipComponent comp in _componentInfo.Items)
                    {
                        if (comp.carrierId == "")
                            cboComponentId.Items.Add(comp.name);
                    }
                }
            }
            if (cboComponentId.Items.Count == 0)
                cboComponentId.DropDownStyle = ComboBoxStyle.Simple;
            else
                cboComponentId.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            if (cboComponentId.Text == "") return;
            cboComponentId.SelectAll();
            ListViewItem item = AddComponent(cboComponentId.Text);
            if (item != null)
            {
                item.EnsureVisible();
                item.Focused = true;
                item.Selected = true;
            }
            cboComponentId.Focus();
        }

        public bool AddComponent(WipComponent component)
        {
            ListViewItem item = AddComponent(component.name);
            if (item == null)
                return false;
            else
            {
                _componentInfo.Add(component);
                component.position = Convert.ToInt16(item.Text);
                component.carrierId = txtCarrierId.Text;
                item.EnsureVisible();
                item.Focused = true;
                item.Selected = true;
                return true;
            }
        }
        public ListViewItem AddComponent(params string[] componentId)
        {
            foreach (ListViewItem oItem in lvwComponentId.SelectedItems)
                oItem.Selected = false;
            ListViewItem item = null;
            foreach (string s in componentId)
            {
                if (lvwComponentId.Items[s] != null) continue;
                item = null;
                if (lvwComponentId.SelectedItems.Count > 0 && lvwComponentId.SelectedItems[0].SubItems[colIndex_Id].Text == "")
                    item = lvwComponentId.SelectedItems[0];
                else
                {
                    for (int i = 0; i < lvwComponentId.Items.Count; i++)
                    {
                        if (lvwComponentId.Items[i].SubItems[colIndex_Id].Text == "")
                        {
                            item = lvwComponentId.Items[i];
                            break;
                        }
                    }
                }

                if (item != null)
                {
                    item.SubItems[colIndex_Id].Text = s;
                    item.Name = s;
                }
                else
                {
                    item = new ListViewItem();
                    item.Name = s;
                    item.SubItems.Add(s);
                    lvwComponentId.Items.Add(item);
                    item.Text = (item.Index + 1).ToString();
                }
            }

            return item;
        }

        public string[] SelectedComponentId
        {
            get
            {
                List<string> list = new List<string>();
                foreach (ListViewItem item in lvwComponentId.SelectedItems)
                {
                    if (item.SubItems[colIndex_Id].Text != "")
                        list.Add(item.SubItems[colIndex_Id].Text);
                }
                return list.ToArray();
            }
        }
        public WipComponent[] GetSelectedComponent()
        {
            List<WipComponent> list = new List<WipComponent>();
            foreach (string s in SelectedComponentId)
            {
                WipComponent comp = _componentInfo.Item(s);
                if (comp != null)
                    list.Add(comp);
            }
            return list.ToArray();
        }

        public void SelectAll()
        {
            foreach (ListViewItem item in lvwComponentId.Items)
                item.Selected = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < expectedQuantity; i++)
            {
                ListViewItem item;
                if (lvwComponentId.Items.Count > i)
                    item = lvwComponentId.Items[i];
                else
                {
                    item = new ListViewItem();
                    lvwComponentId.Items.Add(item);
                    item.Text = (item.Index + 1).ToString();
                    item.SubItems.Add("");
                }
                //if (item.SubItems[colIndex_Id].Text != "") continue;
                string id = _lotId + "-";
                if (_carrier != null) id += _carrier.name + "-";
                id += (i + 1).ToString("000");
                item.SubItems[colIndex_Id].Text = id;
                item.Name = id;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            List<ListViewItem> list = new List<ListViewItem>();
            for(int i =0;i<lvwComponentId.SelectedItems.Count;i++)
                list.Add(lvwComponentId.SelectedItems[i]);
            foreach (ListViewItem item in list)
                moveUp(item);
        }
        void moveUp(ListViewItem item)
        {
            if (item.SubItems[colIndex_Id].Text == "") return;
            if (item.Index == 0) return;
            ListViewItem prevItem = lvwComponentId.Items[item.Index - 1];
            if (prevItem.SubItems[colIndex_Id].Text == "")
            {
                prevItem.SubItems[colIndex_Id].Text = item.SubItems[colIndex_Id].Text;
                prevItem.Name = item.Name;
                item.SubItems[colIndex_Id].Text = "";
                item.Name = "";
            }
            else
            {
                string prevId = prevItem.SubItems[colIndex_Id].Text;
                prevItem.SubItems[colIndex_Id].Text = item.SubItems[colIndex_Id].Text;
                item.SubItems[colIndex_Id].Text = prevId;

                prevId = prevItem.Name;
                prevItem.Name = item.Name;
                item.Name = prevId;
            }
            prevItem.Selected = true;
            prevItem.Focused = true;
            prevItem.EnsureVisible();

            item.Selected = false;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            List<ListViewItem> list = new List<ListViewItem>();
            for (int i = lvwComponentId.SelectedItems.Count - 1; i >= 0; i--)
                list.Add(lvwComponentId.SelectedItems[i]);
            foreach (ListViewItem item in list)
                moveDown(item);
        }
        void moveDown(ListViewItem item)
        {
            if (item.SubItems[colIndex_Id].Text == "") return;
            if (item.Index == lvwComponentId.Items.Count - 1) return;
            ListViewItem nextItem = lvwComponentId.Items[item.Index + 1];
            if (nextItem.SubItems[colIndex_Id].Text == "")
            {
                nextItem.SubItems[colIndex_Id].Text = item.SubItems[colIndex_Id].Text;
                nextItem.Name = item.Name;
                item.SubItems[colIndex_Id].Text = "";
                item.Name = "";
            }
            else
            {
                string nextId = nextItem.SubItems[colIndex_Id].Text;
                nextItem.SubItems[colIndex_Id].Text = item.SubItems[colIndex_Id].Text;
                item.SubItems[colIndex_Id].Text = nextId;

                nextId = nextItem.Name;
                nextItem.Name = item.Name;
                item.Name = nextId;
            }
            nextItem.Selected = true;
            nextItem.Focused = true;
            nextItem.EnsureVisible();

            item.Selected = false;
        }

        private void btnDeleteComponent_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwComponentId.SelectedItems)
                RemoveComponent(item.SubItems[colIndex_Id].Text);
        }

        void RemoveComponent(params string[] componentId)
        {
            foreach (string s in componentId)
            {
                if (s == "") continue;
                ListViewItem item = lvwComponentId.Items[s];
                if (item != null)
                {
                    item.SubItems[colIndex_Id].Text = "";
                    item.Name = "";
                }
            }
        }
        public void RemoveComponent(WipComponent component)
        {
            if (_componentInfo == null) return;
            _componentInfo.Remove(component.name);
            RemoveComponent(component.name);
        }
        public WipComponent[] RemoveComponentByCarrier(string carrierId)
        {
            List<WipComponent> list = new List<WipComponent>();
            if (_componentInfo != null)
            {
                list.AddRange(_componentInfo.GetComponentsByCarrier(carrierId));
                foreach(WipComponent comp in list)
                    RemoveComponent(comp);
            }
            return list.ToArray();
        }

        public void Confirm()
        {
            Confirm(false);
        }
        public void Confirm(bool removeNoCarrierComponent)
        {
            if (_componentInfo == null) return;
            if (txtCarrierId.Text == "")//在ComponentInfo裏，但不在ListView裏的Component將被移除
            {
                Dictionary<string, WipComponent> components = new Dictionary<string, WipComponent>();
                foreach (WipComponent component in _componentInfo.GetComponentsByCarrier(""))
                    components.Add(component.name, component);
                foreach (WipComponent component in components.Values)
                    _componentInfo.Remove(component.name);
                foreach (ListViewItem item in lvwComponentId.Items)
                {
                    if (item.SubItems[colIndex_Id].Text == "") continue;
                    WipComponent component = _componentInfo.Item(item.SubItems[colIndex_Id].Text);
                    if (component != null)//從載具移出至沒載具的Component
                    {
                        component.carrierId = "";
                        component.position = Convert.ToInt16(item.Text);
                    }
                    else
                    {
                        if (components.ContainsKey(item.SubItems[colIndex_Id].Text))
                            component = components[item.SubItems[colIndex_Id].Text];
                        else
                        {
                            component = new WipComponent();
                            component.name = item.SubItems[colIndex_Id].Text;
                        }
                        component.position = Convert.ToInt16(item.Text);
                        _componentInfo.Add(component);
                    }
                }
            }
            else//原本屬於本載具，但不在ListView裏的Component，Componet的載具將被更新為空白(因為有可能被移到其它載具，所以不從ComonentInfo裏移除
            {
                foreach (WipComponent component in _componentInfo.GetComponentsByCarrier(txtCarrierId.Text))
                    component.carrierId = "";
                
                foreach (ListViewItem item in lvwComponentId.Items)
                {
                    if (item.SubItems[colIndex_Id].Text == "") continue;

                    WipComponent component = _componentInfo.Item(item.SubItems[colIndex_Id].Text);
                    if (component != null)
                    {
                        component.carrierId = txtCarrierId.Text;
                        component.position = Convert.ToInt16(item.Text);
                    }
                    else
                    {
                        component = new WipComponent();
                        component.name = item.SubItems[colIndex_Id].Text;
                        component.carrierId = txtCarrierId.Text;
                        component.position = Convert.ToInt16(item.Text);
                        _componentInfo.Add(component);
                    }
                }

                if (removeNoCarrierComponent)
                {
                    List<WipComponent> list = new List<WipComponent>();
                    list.AddRange(_componentInfo.GetComponentsByCarrier(""));
                    foreach (WipComponent comp in list)
                        _componentInfo.Remove(comp.name);
                }
            }
        }

        private void txtComponentId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddComponent.PerformClick();
        }

        public void Clear()
        {
            lvwComponentId.Items.Clear();
        }

        volatile bool _confirmDeleteKey = false;
        private void lvwComponentId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (_confirmDeleteKey)
                    btnDeleteComponent.PerformClick();
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

        private void lvwComponentId_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }

        private void cboComponentId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddComponent.PerformClick();
        }
    }
}
