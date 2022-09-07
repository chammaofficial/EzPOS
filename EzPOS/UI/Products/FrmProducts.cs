using System;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Models.Products;
using EzPOS.Services;
using EzPOS.Services.Products;

namespace EzPOS.UI.Products
{
    public partial class FrmProducts : DevExpress.XtraEditors.XtraForm
    {
        private Product tempProduct;
        private ProductService service;
        public FrmProducts()
        {
            InitializeComponent();
            service = new ProductService(new POSContext());
            tempProduct = new Product();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Clear()
        {
            tempProduct = new Product();
            txtName.Clear();
            txtDescription.Clear();
            txtBrand.Clear();
            txtSubCategory.Clear();
            txtMainCategory.Clear();
            txtModelNo.Clear();
            chkExpiring.Checked = false;
            chkExpiring.Checked = false;
            txtMaxOrderLevel.Clear();
            txtReOrderLevel.Clear();
            txtCustomBarcode.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            tempProduct.Name = txtName.Text;
            tempProduct.Description = txtDescription.Text;

            if (txtBrand.EditValue != null)
            {
                tempProduct.BrandId = (int) txtBrand.EditValue;
            }

            if (txtMainCategory.EditValue != null)
            {
                tempProduct.CategoryId = (int) txtMainCategory.EditValue;
            }

            if (txtSubCategory.EditValue != null)
            {
                tempProduct.SubCategoryId = (int)txtSubCategory.EditValue;
            }

            if (txtUnit.EditValue != null)
            {
                tempProduct.UnitId = (int)txtUnit.EditValue;
            }

            tempProduct.HasWarranty = chkWarranty.Checked;
            tempProduct.HasSerial = chkHasSerials.Checked;
            tempProduct.IsExpiring = chkExpiring.Checked;
            tempProduct.IsActive = true;
            tempProduct.ReOrderLevel = decimal.Parse(txtReOrderLevel.Text);
            tempProduct.CustomBarcode = txtCustomBarcode.Text;
            tempProduct.MaxOrderLevel = decimal.Parse(txtMaxOrderLevel.Text);
            tempProduct.ModelNo = txtModelNo.Text;
           
            if (tempProduct.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this product ?") == DialogResult.Yes)
                {
                    service.SaveProduct(tempProduct);
                    Clear();
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            GCProduct.DataSource = service.GetProducts();
            txtBrand.Properties.DataSource = service.GetBrands();
            txtMainCategory.Properties.DataSource = service.GetMainCategories();
            txtUnit.Properties.DataSource = service.GetUnits();
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            tempProduct = service.GetProductById(int.Parse(GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, clmnId).ToString()));
            txtName.Text = tempProduct.Name;
            txtDescription.Text = tempProduct.Description;
            txtBrand.EditValue = tempProduct.BrandId;
            txtMainCategory.EditValue = tempProduct.CategoryId;
            txtSubCategory.Properties.DataSource = service.GetSubCategories(tempProduct.CategoryId);
            txtSubCategory.EditValue = tempProduct.SubCategoryId;
            txtUnit.EditValue = tempProduct.UnitId;
            txtModelNo.Text = tempProduct.ModelNo;
            chkHasSerials.Checked = tempProduct.HasSerial;
            chkExpiring.Checked = tempProduct.IsExpiring;
            chkWarranty.Checked = tempProduct.HasWarranty;
            txtMaxOrderLevel.Text = tempProduct.MaxOrderLevel.ToString();
            txtReOrderLevel.Text = tempProduct.ReOrderLevel.ToString(); 
            txtCustomBarcode.Text = tempProduct.CustomBarcode;
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            tempProduct = service.GetProductById(int.Parse(GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, clmnId).ToString()));
            tempProduct.IsActive = false;

            if (tempProduct.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to remove this product ?. This operation cannot be reversed!.") == DialogResult.Yes)
                {
                    service.SaveProduct(tempProduct);
                    Clear();
                }
            }
            LoadData();
            tempProduct = new Product();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtMainCategory_Leave(object sender, EventArgs e)
        {
            if (txtMainCategory.EditValue != null)
            {
                txtSubCategory.Properties.DataSource = service.GetSubCategories((int)txtMainCategory.EditValue);
            }
        }
    }
}
