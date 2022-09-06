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
using EzPOS.Services;

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

        }
    }
}
