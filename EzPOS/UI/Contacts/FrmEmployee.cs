using System;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models.Contacts;
using EzPOS.Services;
using EzPOS.Services.Contacts;

namespace EzPOS.UI.Contacts
{
    public partial class FrmEmployee : DevExpress.XtraEditors.XtraForm
    {
        private Employee TempEmployee;
        public FrmEmployee()
        {
            InitializeComponent();
            TempEmployee = new Employee();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Clear()
        {
            TempEmployee = new Employee();
            txtName.Clear();
            txtAddress.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtNic.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TempEmployee.Name = txtName.Text;
            TempEmployee.Address = txtAddress.Text;
            TempEmployee.Nic = txtNic.Text;
            TempEmployee.Email = txtEmail.Text;
            TempEmployee.Mobile = txtMobile.Text;
            TempEmployee.BranchId = Session.LoginBranch.Id;
            TempEmployee.IsActive = true;
            if (TempEmployee.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this employee ?") == DialogResult.Yes)
                {
                    EmployeeService.SaveEmployee(TempEmployee);
                    Clear();
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            var EmployeeList = EmployeeService.GetAllActiveEmployeesByBranch();
            GCEmployee.DataSource = EmployeeList;
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            TempEmployee = EmployeeService.GetEmployeeById(int.Parse(GVEmployee.GetRowCellValue(GVEmployee.FocusedRowHandle, clmnId).ToString()));
            txtName.Text = TempEmployee.Name;
            txtAddress.Text = TempEmployee.Address;
            txtEmail.Text = TempEmployee.Email;
            txtMobile.Text = TempEmployee.Mobile;
            txtNic.Text = TempEmployee.Nic;

        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            TempEmployee = EmployeeService.GetEmployeeById(int.Parse(GVEmployee.GetRowCellValue(GVEmployee.FocusedRowHandle, clmnId).ToString()));
            TempEmployee.IsActive = false;

            if (TempEmployee.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to remove this employee ?. This operation cannot be reversed!.") == DialogResult.Yes)
                {
                    EmployeeService.SaveEmployee(TempEmployee);
                    Clear();
                }
            }
            LoadData();
            TempEmployee = new Employee();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
