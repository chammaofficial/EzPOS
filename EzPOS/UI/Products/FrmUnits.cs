using System;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Models.Products;
using EzPOS.Services;
using EzPOS.Services.Products;

namespace EzPOS.UI.Products
{
    public partial class FrmUnits : DevExpress.XtraEditors.XtraForm
    {
        private Unit TempUnit;
        private UnitService service;
        public FrmUnits()
        {
            InitializeComponent();
            service = new UnitService(new POSContext());
            TempUnit = new Unit();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Clear()
        {
            TempUnit = new Unit();
            txtName.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TempUnit.Name = txtName.Text;
            TempUnit.Symbol = txtSymbol.Text;
            if (TempUnit.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this Unit ?") == DialogResult.Yes)
                {
                    service.SaveUnit(TempUnit);
                    Clear();
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            var UnitList = service.GetAllActiveUnits();
            GCUnits.DataSource = UnitList;
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            TempUnit = service.GetUnitById(int.Parse(GVUnits.GetRowCellValue(GVUnits.FocusedRowHandle, clmnId).ToString()));
            if (Alerts.Confirm("Are sure want to remove this Unit ?. This operation cannot be reversed!.") == DialogResult.Yes)
            {
                service.DeleteUnit(TempUnit.Id);
                Clear();
            }
            
            LoadData();
            TempUnit = new Unit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            TempUnit = service.GetUnitById(int.Parse(GVUnits.GetRowCellValue(GVUnits.FocusedRowHandle, clmnId).ToString()));
            txtName.Text = TempUnit.Name;
            txtSymbol.Text = TempUnit.Symbol;
        }
    }
}
