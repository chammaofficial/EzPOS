using System;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Services;

namespace EzPOS.UI.Master_Files
{
    public partial class FrmCustomer : DevExpress.XtraEditors.XtraForm
    {
        private Models.Customer TempCustomer;
        public FrmCustomer()
        {
            InitializeComponent();
            TempCustomer = new Models.Customer();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Clear()
        {
            TempCustomer = new Models.Customer();
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
            TempCustomer.Name = txtName.Text;
            TempCustomer.Address = txtAddress.Text;
            TempCustomer.Nic = txtNic.Text;
            TempCustomer.Email = txtEmail.Text;
            TempCustomer.Mobile = txtMobile.Text;
            TempCustomer.IsActive = true;
            if (TempCustomer.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this customer ?") == DialogResult.Yes)
                {
                    CustomerService.SaveCustomer(TempCustomer);
                    Clear();
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            var CustomerList = CustomerService.GetAllActiveCustomers();
            GCCustomer.DataSource = CustomerList;
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            TempCustomer = CustomerService.GetCustomerById(int.Parse(GVCustomer.GetRowCellValue(GVCustomer.FocusedRowHandle, clmnId).ToString()));
            TempCustomer.IsActive = false;

            if (TempCustomer.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to remove this customer ?. This operation cannot be reversed!.") == DialogResult.Yes)
                {
                    CustomerService.SaveCustomer(TempCustomer);
                    Clear();
                }
            }
            LoadData();
            TempCustomer = new Models.Customer();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            TempCustomer = CustomerService.GetCustomerById(int.Parse(GVCustomer.GetRowCellValue(GVCustomer.FocusedRowHandle, clmnId).ToString()));
            txtName.Text = TempCustomer.Name;
            txtAddress.Text = TempCustomer.Address;
            txtEmail.Text = TempCustomer.Email;
            txtMobile.Text = TempCustomer.Mobile;
            txtNic.Text = TempCustomer.Nic;
        }
    }
}
