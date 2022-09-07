using System;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Models.Products;
using EzPOS.Services;
using EzPOS.Services.Products;

namespace EzPOS.UI.Master_Files
{
    public partial class FrmProductStatusCodes : DevExpress.XtraEditors.XtraForm
    {
        private ProductStatusCode tempProductStatusCode;
        public FrmProductStatusCodes()
        {
            InitializeComponent();
            tempProductStatusCode = new ProductStatusCode();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Clear()
        {
            tempProductStatusCode = new ProductStatusCode();
            txtName.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            tempProductStatusCode.Name = txtName.Text;
            if (tempProductStatusCode.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this Product Status Code ?") == DialogResult.Yes)
                {
                    ProductStatusCodeService.SaveProductStatusCode(tempProductStatusCode);
                    Clear();
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            var ProductStatusCodeList = ProductStatusCodeService.GetAllActiveProductStatusCodes();
            GCProductStatusCodes.DataSource = ProductStatusCodeList;
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            tempProductStatusCode = ProductStatusCodeService.GetProductStatusCodeById(int.Parse(GVProductStatusCodes.GetRowCellValue(GVProductStatusCodes.FocusedRowHandle, clmnId).ToString()));
            if (Alerts.Confirm("Are sure want to remove this Product Status Code ?. This operation cannot be reversed!.") == DialogResult.Yes)
            {
                ProductStatusCodeService.DeleteProductStatusCode(tempProductStatusCode.Id);
                Clear();
            }
            
            LoadData();
            tempProductStatusCode = new ProductStatusCode();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            tempProductStatusCode = ProductStatusCodeService.GetProductStatusCodeById(int.Parse(GVProductStatusCodes.GetRowCellValue(GVProductStatusCodes.FocusedRowHandle, clmnId).ToString()));
            txtName.Text = tempProductStatusCode.Name;
        }
    }
}
