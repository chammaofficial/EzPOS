using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Services;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EzPOS.UI.Settings
{
    public partial class FrmBusinessSettings : DevExpress.XtraEditors.XtraForm
    {
        private BusinessSettingService service;
        private BusinessSetting tempBusinessSetting;
        public FrmBusinessSettings()
        {
            InitializeComponent();
            service = new BusinessSettingService(new POSContext());
            tempBusinessSetting = service.GetBusinessSettingById(Session.LoginBranch.BusinessSettingId);
        }

        private void FrmBusinessSettings_Load(object sender, EventArgs e)
        {
            LoadData();

            txtBusinessName.Text = tempBusinessSetting.Name;

            dteStartDate.EditValue = tempBusinessSetting.StartDate;

            txtTransactionEditDays.Text = tempBusinessSetting.TransactionEditDays.ToString();

            txtDefaultProfitPrecentage.Text = tempBusinessSetting.DefaultProfitPrecentage.ToString();

            txtCurrencySymbolPlacement.Text = tempBusinessSetting.CurrencySymbolPlacement;

            txtCurrency.EditValue = tempBusinessSetting.Currency.Id;

            txtFinancialYearStartMonth.Text = tempBusinessSetting.FinancialYearStartMonth.ToString();

            txtStockAccountingMethod.Text = tempBusinessSetting.StockAccountingMethod;

            txtDateFormat.Text = tempBusinessSetting.DateFormat;

            if (tempBusinessSetting.Logo != null)
            {
                pictureBox1.Image = tempBusinessSetting.Logo.ConvertToImage();
            }
        }

        private void LoadData()
        {
            txtCurrency.Properties.DataSource = service.GetCurrencies();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            xtraOpenFileDialog1.ShowDialog();
        }

        private void xtraOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.ImageLocation = xtraOpenFileDialog1.FileName;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            tempBusinessSetting.Name = txtBusinessName.Text;

            tempBusinessSetting.StartDate = dteStartDate.DateTime;

            tempBusinessSetting.TransactionEditDays = txtTransactionEditDays.Text.ToInt();

            tempBusinessSetting.DefaultProfitPrecentage = txtDefaultProfitPrecentage.Text.ToDecimal();

            tempBusinessSetting.CurrencySymbolPlacement = txtCurrencySymbolPlacement.Text;

            tempBusinessSetting.Currency.Id = txtCurrency.EditValue.ToString().ToInt();

            tempBusinessSetting.FinancialYearStartMonth = txtFinancialYearStartMonth.Text.ToInt();

            tempBusinessSetting.StockAccountingMethod = txtStockAccountingMethod.Text;

            tempBusinessSetting.DateFormat = txtDateFormat.Text;

            if (pictureBox1.Image != null)
            {
                tempBusinessSetting.Logo = pictureBox1.Image.ConvertToByteArray();
            }

            if (tempBusinessSetting.Validate())
            {
                if (Alerts.Confirm("Are sure want to save this Settings ?") == DialogResult.Yes)
                {
                    service.SaveBusinessSettings(tempBusinessSetting);
                    Alerts.Info("Operation Success.!");
                    LoadData();
                }
            }
        }
    }
}
