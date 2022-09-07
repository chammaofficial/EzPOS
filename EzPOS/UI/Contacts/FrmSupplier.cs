using System;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Models.Contacts;
using EzPOS.Services;
using EzPOS.Services.Contacts;

namespace EzPOS.UI.Contacts
{
    public partial class FrmSupplier : DevExpress.XtraEditors.XtraForm
    {
        private Supplier TempSupplier;
        public FrmSupplier()
        {
            InitializeComponent();
            TempSupplier = new Supplier();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Clear()
        {
            TempSupplier = new Supplier();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtContactPerson.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtOther.Clear();
            txtRemark.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TempSupplier.Name = txtName.Text;
            TempSupplier.Address = txtAddress.Text;
            TempSupplier.Phone = txtPhone.Text;
            TempSupplier.ContactPerson = txtContactPerson.Text;
            TempSupplier.Mobile = txtMobile.Text;
            TempSupplier.Email = txtEmail.Text;
            TempSupplier.Other = txtOther.Text;
            TempSupplier.Remark = txtRemark.Text;
            TempSupplier.IsActive = true;

            if (TempSupplier.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this supplier ?") == DialogResult.Yes)
                {
                    SupplierService.SaveSupplier(TempSupplier);
                    Clear();
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            var SupplierList = SupplierService.GetAllActiveSuppliers();
            GCSupplier.DataSource = SupplierList;
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            TempSupplier = SupplierService.GetSupplierById(int.Parse(GVSupplier.GetRowCellValue(GVSupplier.FocusedRowHandle, clmnId).ToString()));
            txtName.Text = TempSupplier.Name;
            txtAddress.Text = TempSupplier.Address;
            txtPhone.Text = TempSupplier.Phone;
            txtContactPerson.Text = TempSupplier.ContactPerson;
            txtMobile.Text = TempSupplier.Mobile;
            txtEmail.Text = TempSupplier.Email;
            txtOther.Text = TempSupplier.Other;
            txtRemark.Text = TempSupplier.Remark;
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            TempSupplier = SupplierService.GetSupplierById(int.Parse(GVSupplier.GetRowCellValue(GVSupplier.FocusedRowHandle, clmnId).ToString()));
            TempSupplier.IsActive = false;

            if (TempSupplier.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to remove this supplier ?. This operation cannot be reversed!.") == DialogResult.Yes)
                {
                    SupplierService.SaveSupplier(TempSupplier);
                    Clear();
                }
            }
            LoadData();
            TempSupplier = new Supplier();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
