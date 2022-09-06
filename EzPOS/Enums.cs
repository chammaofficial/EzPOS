using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPOS
{
    public static class Enums
    {
        public static Dictionary<string, string> DateFormats = new Dictionary<string, string>();
        public static Dictionary<string, string> TimeFormats = new Dictionary<string, string>();
        public static Dictionary<string, string> CurrencySymbolPlacements = new Dictionary<string, string>();
        public static Dictionary<string, string> TimeZones = new Dictionary<string, string>();

        public static void Initilize()
        {
            DateFormats.Add("YYYY-MM-DD","YYYY-MM-DD");

            TimeFormats.Add("HH:mm:ss", "HH:mm:ss");

            CurrencySymbolPlacements.Add("Before Amount","Before Amount");
            CurrencySymbolPlacements.Add("After Amount","After Amount");

            TimeZones.Add("+05.30", "Colombo");
        }
    }
}
