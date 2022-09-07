using System;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Models.Products;
using EzPOS.Services;
using EzPOS.Services.Products;

namespace EzPOS.UI.Products
{
    public partial class FrmCategories : DevExpress.XtraEditors.XtraForm
    {
        private Category TempCategory;
        public FrmCategories()
        {
            InitializeComponent();
            TempCategory = new Category();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Clear()
        {
            TempCategory = new Category();
            txtName.Clear();
            txtParentCategory.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TempCategory.Name = txtName.Text;

            if (chkSubCategory.Checked)
            {
                TempCategory.IsSubCategory = true;
                TempCategory.CategoryId = (int) txtParentCategory.EditValue;
            }
            else
            {
                TempCategory.IsSubCategory = false;
                TempCategory.CategoryId = null;
            }

            if (TempCategory.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this Category ?") == DialogResult.Yes)
                {
                    CategoryService.SaveCategory(TempCategory);
                    Clear();
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            var ParentCategoryList = CategoryService.GetParentCategories();
            txtParentCategory.Properties.DataSource = ParentCategoryList;

            var CategoryList = CategoryService.GetAllCategories();
            GCCategory.DataSource = CategoryList;
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            TempCategory = CategoryService.GetCategoryById(int.Parse(GVCategory.GetRowCellValue(GVCategory.FocusedRowHandle, clmnId).ToString()));
            txtName.Text = TempCategory.Name;
            txtParentCategory.EditValue = TempCategory.CategoryId;
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            TempCategory = CategoryService.GetCategoryById(int.Parse(GVCategory.GetRowCellValue(GVCategory.FocusedRowHandle, clmnId).ToString()));
            if (Alerts.Confirm("Are sure want to remove this category ?. This operation cannot be reversed!.") == DialogResult.Yes)
            {
                CategoryService.DeleteCategory(TempCategory.Id);
                Clear();
            }
            LoadData();
            TempCategory = new Category();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chkSubCategory_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkSubCategory.CheckState == CheckState.Checked)
                txtParentCategory.Enabled = true;
            else
                txtParentCategory.Enabled = false;
        }
    }
}
