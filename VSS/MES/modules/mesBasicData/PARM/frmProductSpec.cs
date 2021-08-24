using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mesRelease.PRP;
using mesRelease.PARM;

namespace mesBasicData
{
    public partial class frmProductSpec : Form
    {

        ProductSpec curSpec = null;
        Product curProd = null;
        bool bySpec = true;
        bool editable;
        public frmProductSpec()
        {
            InitializeComponent();
            lvwSpec.prepareColumns();
            lvwSelected.prepareColumns();
            lvwAvailable.prepareColumns();

            lvwProduct.prepareColumns();
            lvwSelectedSpec.prepareColumns();
            lvwAvailableSpec.prepareColumns();
            editable = mesRelease.USR.User.loginUser.CheckFunctionPrivilege("IDE:PARM:PRODUCTSPEC:MODIFY");
            idv.utilities.misc.SetValueChangeByUseItem(Name);
            if (mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.productSelectSpec)
                tabControl1.TabPages.Remove(pageBySpec);
            else
                tabControl1.TabPages.Remove(pageByProd);
            bySpec = tabControl1.SelectedTab == pageBySpec;
        }

        private void lvwSpec_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                lvwAvailable.UpdateMESItem(lvwSelected.GetAllMESItem());
                lvwSelected.RemoveAllMESItems();
                btnSelect.Enabled = false;
                btnUnSelect.Enabled = false;
                curSpec = null;
            }
            else
            {
                curSpec = item as ProductSpec;
                lvwSelected.UpdateMESItem(curSpec.GetProducts());
                lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
                btnSelect.Enabled =editable && true;
                btnUnSelect.Enabled = editable && true;
            }
        }
        private void lvwProduct_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                lvwAvailableSpec.UpdateMESItem(lvwSelectedSpec.GetAllMESItem());
                lvwSelectedSpec.RemoveAllMESItems();
                btnSelectSpec.Enabled = false;
                btnUnSelectSpec.Enabled = false;
                curProd = null;
            }
            else
            {
                curProd = item as Product;
                lvwSelectedSpec.UpdateMESItem(ProductSpec.GetProductSpec(item.name));
                lvwAvailableSpec.RemoveMESItem(lvwSelectedSpec.GetAllMESItem());
                btnSelectSpec.Enabled = editable && true;
                btnUnSelectSpec.Enabled = editable && true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvwAvailable.selectedMESItem == null) return;
            try
            {
                if (curSpec.AddProduct(lvwAvailable.selectedMESItem as Product))
                {
                    lvwSelected.UpdateMESItem(lvwAvailable.selectedMESItem);
                    lvwAvailable.RemoveMESItem(null);
                }
            }
            catch { }
        }
        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (lvwSelected.selectedMESItem == null) return;
            try
            {
                curSpec.RemoveProduct(lvwSelected.selectedMESItem.name);
                lvwAvailable.UpdateMESItem(lvwSelected.selectedMESItem);
                lvwSelected.RemoveMESItem(null);
            }
            catch { }
        }

        private void btnSelectSpec_Click(object sender, EventArgs e)
        {
            if (lvwAvailableSpec.selectedMESItem == null) return;
            try
            {
                if (ProductSpec.AddProductSpec(curProd.name, lvwAvailableSpec.selectedMESItem.name, ""))
                {
                    lvwSelectedSpec.UpdateMESItem(lvwAvailableSpec.selectedMESItem);
                    lvwAvailableSpec.RemoveMESItem(null);
                }
            }
            catch { }
        }
        private void btnUnSelectSpec_Click(object sender, EventArgs e)
        {
            if (lvwSelectedSpec.selectedMESItem == null) return;
            try
            {
                ProductSpec.RemoveProductSpec(curProd.name, lvwSelectedSpec.selectedMESItem.name);
                lvwAvailableSpec.UpdateMESItem(lvwSelectedSpec.selectedMESItem);
                lvwSelectedSpec.RemoveMESItem(null);
            }
            catch { }
        }

        private void lvwAvailable_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }
        private void lvwSelected_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void lvwAvailableSpec_DoubleClick(object sender, EventArgs e)
        {
            btnSelectSpec.PerformClick();
        }
        private void lvwSelectedSpec_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelectSpec.PerformClick();
        }

        private void frmProductSpec_Activated(object sender, EventArgs e)
        {
            bool productChanged = idv.utilities.misc.IsValueChanged("frmProduct", Name);
            bool prodParmChanged = idv.utilities.misc.IsValueChanged("frmProductParameter", Name);

            if (bySpec)//bySpec
            { 
                if (productChanged)
                {
                    lvwAvailable.ShowMESItems(Product.GetActiveProducts(""));
                    lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
                }
                if (prodParmChanged)
                {
                    string orgSelect = "";
                    if (lvwSpec.selectedMESItem != null)
                        orgSelect = lvwSpec.selectedMESItem.name;

                    lvwSpec.ShowMESItems(ProductSpec.GetActiveVersionSpecs(""));

                    if (!orgSelect.Equals(""))
                        lvwSpec.SelectMESItem(orgSelect);
                }
            }
            else//byProduct
            {
                if (prodParmChanged)
                {
                    lvwAvailableSpec.ShowMESItems(ProductSpec.GetActiveVersionSpecs(""));
                    lvwAvailableSpec.RemoveMESItem(lvwSelectedSpec.GetAllMESItem());
                }
                if (productChanged)
                {
                    string orgSelect = "";
                    if (lvwProduct.selectedMESItem != null)
                        orgSelect = lvwProduct.selectedMESItem.name;

                    lvwProduct.ShowMESItems(Product.GetActiveProducts(""));

                    if (!orgSelect.Equals(""))
                        lvwProduct.SelectMESItem(orgSelect);
                }
            }
        }
    }
}
