using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPOS.Models
{
    public class BusinessSetting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public int TransactionEditDays { get; set; }
        public int DefaultProfitPrecentage { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public string DateFormat { get; set; }
        public string CurrencySymbolPlacement { get; set; }
        public string TimeZone { get; set; }
        public string TimeFormat { get; set; }
        public int QtyPrecision { get; set; }
        public int CurrencyPrecision { get; set; }
        public int FinancialYearStartMonth { get; set; }
        public string StockAccountingMethod { get; set; }

        public BusinessSetting()
        {
            StartDate = DateTime.Now;
            TransactionEditDays = 10;
            DefaultProfitPrecentage = 14;
            CurrencyId = 1;
            DateFormat = Enums.DateFormats.First().Value;
            CurrencySymbolPlacement = Enums.CurrencySymbolPlacements.First().Value;
            TimeFormat = Enums.TimeFormats.First().Value;
            TimeZone = Enums.TimeZones.First().Value;
            QtyPrecision = 2;
            CurrencyPrecision = 2;
            FinancialYearStartMonth = 1;
            StockAccountingMethod = "NONE";
        }

    }
}
