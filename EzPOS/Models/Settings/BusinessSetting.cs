using System;
using System.Linq;

namespace EzPOS.Models.Settings
{
    public class BusinessSetting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public int TransactionEditDays { get; set; }
        public decimal DefaultProfitPrecentage { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public string DateFormat { get; set; }
        public string CurrencySymbolPlacement { get; set; }
        public int FinancialYearStartMonth { get; set; }
        public string StockAccountingMethod { get; set; }
        public byte[] Logo { get; set; }


        public BusinessSetting()
        {
            StartDate = DateTime.Now;
            TransactionEditDays = 10;
            DefaultProfitPrecentage = 14;
            CurrencyId = 1;
            DateFormat = Enums.DateFormats.First().Value;
            CurrencySymbolPlacement = Enums.CurrencySymbolPlacements.First().Value;
            FinancialYearStartMonth = 1;
            StockAccountingMethod = "NONE";
        }

    }
}
