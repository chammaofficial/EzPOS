using System;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Services;

namespace EzPOS.UI.Employee
{
    public partial class FrmEmployee : DevExpress.XtraEditors.XtraForm
    {
        private Models.Employee TempEmployee;
        public FrmEmployee()
        {
            InitializeComponent();
            TempEmployee = new Models.Employee();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            TempEmployee = new Models.Employee();
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
            TempEmployee.Branch = Session.LoginBranch;
            TempEmployee.Mobile = txtMobile.Text;
        }
    }
}
