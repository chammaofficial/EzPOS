using EzPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EzPOS.Services
{
    public static class ProductStatusCodeService
    {
        public static void SaveProductStatusCode(ProductStatusCode code)
        {
            using (var context = new POSContext())
            {
                if (code.Id == 0)
                {
                    context.ProductStatusCodes.Add(code);
                    code.CreateBy = Session.LoginUser.Username;
                    code.CreateDate = DateTime.Now;
                    context.Entry(code).State = System.Data.Entity.EntityState.Added;
                }
                else
                {
                    context.ProductStatusCodes.Attach(code);
                    code.UpdateBy = Session.LoginUser.Username;
                    code.UpdateDate = DateTime.Now;
                    context.Entry(code).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public static IEnumerable<ProductStatusCode> GetAllActiveProductStatusCodes()
        {
            using (var context = new POSContext())
            {
                return context.ProductStatusCodes.ToList();
            }
        }

        public static ProductStatusCode GetProductStatusCodeById(int id)
        {
            using (var context = new POSContext())
            {
                return context.ProductStatusCodes.First(x => x.Id == id);
            }
        }

        public static void DeleteProductStatusCode(int id)
        {
            using (var context = new POSContext())
            {
                var code = context.ProductStatusCodes.First(x => x.Id == id);
                context.ProductStatusCodes.Remove(code);
                context.SaveChanges();
            }
        }
    }
}
