using System;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Services;

namespace EzPOS.UI.Master_Files
{
    public partial class FrmBrands : DevExpress.XtraEditors.XtraForm
    {
        private Brand TempBrand;
        public FrmBrands()
        {
            InitializeComponent();
            TempBrand = new Brand();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Clear()
        {
            TempBrand = new Brand();
            txtName.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TempBrand.Name = txtName.Text;
            if (TempBrand.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this brand ?") == DialogResult.Yes)
                {
                    BrandService.SaveBrand(TempBrand);
                    Clear();
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            var BrandList = BrandService.GetAllActiveBrands();
            GCBrands.DataSource = BrandList;
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            TempBrand = BrandService.GetBrandById(int.Parse(GVBrands.GetRowCellValue(GVBrands.FocusedRowHandle, clmnId).ToString()));
            if (Alerts.Confirm("Are sure want to remove this brand ?. This operation cannot be reversed!.") == DialogResult.Yes)
            {
                BrandService.DeleteBrand(TempBrand.Id);
                Clear();
            }
            
            LoadData();
            TempBrand = new Brand();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            TempBrand = BrandService.GetBrandById(int.Parse(GVBrands.GetRowCellValue(GVBrands.FocusedRowHandle, clmnId).ToString()));
            txtName.Text = TempBrand.Name;
        }
    }
}
