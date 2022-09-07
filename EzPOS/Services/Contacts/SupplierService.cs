using System;
using System.Collections.Generic;
using System.Linq;
using EzPOS.Models.Contacts;

namespace EzPOS.Services.Contacts
{
    public static class SupplierService
    {
        public static void SaveSupplier(Supplier sup)
        {
            using (var context = new POSContext())
            {
                if (sup.Id == 0)
                {
                    context.Suppliers.Add(sup);
                    sup.CreateBy = Session.LoginUser.Username;
                    sup.CreateDate = DateTime.Now;
                    context.Entry(sup).State = System.Data.Entity.EntityState.Added;
                }
                else
                {
                    context.Suppliers.Attach(sup);
                    sup.UpdateBy = Session.LoginUser.Username;
                    sup.UpdateDate = DateTime.Now;
                    context.Entry(sup).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public static IEnumerable<Supplier> GetAllActiveSuppliers()
        {
            using (var context = new POSContext())
            {
                return context.Suppliers.Where(s => s.IsActive == true).ToList();
            }
        }

        public static Supplier GetSupplierById(int id)
        {
            using (var context = new POSContext())
            {
                return context.Suppliers.First(x => x.Id == id);
            }
        }
    }
}
