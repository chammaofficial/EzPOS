using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Models.Settings;
using EzPOS.Services;
using EzPOS.Services.Settings;

namespace EzPOS.UI.Settings
{
    public partial class FrmBranches : DevExpress.XtraEditors.XtraForm
    {

        private BranchService service;
        private Branch TempBranch;
        public FrmBranches()
        {
            InitializeComponent();
            service = new BranchService(new POSContext());
            TempBranch = new Branch();
        }

        private void FrmBranches_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            GCBranches.DataSource = service.GetBranches();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Clear()
        {
            TempBranch = null;
            txtCode.Clear();
            txtName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TempBranch.Code = txtCode.Text;
            TempBranch.Name = txtName.Text;
            TempBranch.Address1 = txtAddress1.Text;
            TempBranch.Address2 = txtAddress2.Text;
            TempBranch.City = txtCity.Text;
            TempBranch.ContactNumber = txtContactNo.Text;
            TempBranch.EmailAddress = txtEmail.Text;
            TempBranch.IsActive = chkActive.Checked;
            if (TempBranch.Id == 0)
            {
                TempBranch.BusinessSetting = new BusinessSetting();
            }

            if (TempBranch.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this Branch ?") == DialogResult.Yes)
                {
                    service.SaveBranch(TempBranch);
                    Clear();
                }
            }
            LoadData();

        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            TempBranch = service.GetBranchById(int.Parse(GVBranches.GetRowCellValue(GVBranches.FocusedRowHandle, clmnId).ToString()));
            txtCode.Text = TempBranch.Code;
            txtName.Text = TempBranch.Name;
            txtAddress1.Text = TempBranch.Address1;
            txtAddress2.Text = TempBranch.Address2;
            txtCity.Text = TempBranch.City;
            txtContactNo.Text = TempBranch.ContactNumber;
            txtEmail.Text = TempBranch.EmailAddress;
            chkActive.Checked = TempBranch.IsActive;

        }
    }
}
