using System;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Services;

namespace EzPOS.UI.Master_Files
{
    public partial class FrmCategories : DevExpress.XtraEditors.XtraForm
    {
        private Models.Category TempCategory;
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

            if (txtParentCategory.EditValue != null)
            {
                TempCategory.IsSubCategory = true;
                TempCategory.CategoryId = (int) txtParentCategory.EditValue;
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
            //TempEmployee = EmployeeService.GetEmployeeById(int.Parse(GVCategory.GetRowCellValue(GVCategory.FocusedRowHandle, clmnId).ToString()));
            //TempEmployee.IsActive = false;

            //if (TempEmployee.Validate() == true)
            //{
            //    if (Alerts.Confirm("Are sure want to remove this employee ?. This operation cannot be reversed!.") == DialogResult.Yes)
            //    {
            //        EmployeeService.SaveEmployee(TempEmployee);
            //        Clear();
            //    }
            //}
            //LoadData();
            //TempEmployee = new Models.Employee();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
