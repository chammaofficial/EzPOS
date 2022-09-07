﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;

namespace EzPOS.Services
{
    public class BusinessSettingService
    {
        private POSContext context;

        public BusinessSettingService(POSContext context)
        {
            this.context = context;
        }

        public BusinessSetting GetBusinessSettingById(int id)
        {
            return context.BusinessSettings.First(x => x.Id == id);
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            return context.Currencies.ToList();
        }

        public void SaveBusinessSettings(BusinessSetting s)
        {
            context.BusinessSettings.Attach(s);
            context.Entry(s).State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}
