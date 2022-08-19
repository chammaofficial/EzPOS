using EzPOS.Helpers;
using EzPOS.Services;
using System;
using System.Windows.Forms;
using EzPOS.Models;


namespace EzPOS.UI.Master_Files
{
    public partial class FrmProducts : DevExpress.XtraEditors.XtraForm
    {
        private Product tempProduct;
        public FrmProducts()
        {
            InitializeComponent();
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
                    ProductService.SaveProduct(tempProduct);
                    Clear();
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            GCProduct.DataSource = ProductService.GetProducts();
            txtBrand.Properties.DataSource = ProductService.GetBrands();
            txtMainCategory.Properties.DataSource = ProductService.GetMainCategories();
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            tempProduct = ProductService.GetProductById(int.Parse(GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, clmnId).ToString()));
            txtName.Text = tempProduct.Name;
            txtDescription.Text = tempProduct.Description;
            txtBrand.EditValue = tempProduct.BrandId;
            txtMainCategory.EditValue = tempProduct.CategoryId;
            txtSubCategory.Properties.DataSource = ProductService.GetSubCategories(tempProduct.CategoryId);
            txtSubCategory.EditValue = tempProduct.SubCategoryId;
            txtModelNo.Text = tempProduct.ModelNo;
            chkHasSerials.Checked = tempProduct.HasSerial;
            chkExpiring.Checked = tempProduct.IsExpiring;
            txtMaxOrderLevel.Text = tempProduct.MaxOrderLevel.ToString();
            txtReOrderLevel.Text = tempProduct.ReOrderLevel.ToString(); 
            txtCustomBarcode.Text = tempProduct.CustomBarcode;
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            tempProduct = ProductService.GetProductById(int.Parse(GVProduct.GetRowCellValue(GVProduct.FocusedRowHandle, clmnId).ToString()));
            tempProduct.IsActive = false;

            if (tempProduct.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to remove this product ?. This operation cannot be reversed!.") == DialogResult.Yes)
                {
                    ProductService.SaveProduct(tempProduct);
                    Clear();
                }
            }
            LoadData();
            tempProduct = new Models.Product();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtMainCategory_Leave(object sender, EventArgs e)
        {
            if (txtMainCategory.EditValue != null)
            {
                txtSubCategory.Properties.DataSource = ProductService.GetSubCategories((int)txtMainCategory.EditValue);
            }
        }
    }
}
