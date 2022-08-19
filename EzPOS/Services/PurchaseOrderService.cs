using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;

namespace EzPOS.Services
{
    public static class PurchaseOrderService
    {
        public static IEnumerable<Supplier> GetSuppliers()
        {
            using (var context = new POSContext())
            {
                return context.Suppliers.Where(s => s.IsActive == true).ToList();
            }
        }

        public static void SavePurchaseOrderHeader(PurchaseOrder PO)
        {
            using (var context = new POSContext())
            {
                if (PO.Id == 0)
                {
                    context.PurchaseOrders.Add(PO);
                    PO.CreateBy = Session.LoginUser.Username;
                    PO.CreateDate = DateTime.Now;
                    context.Entry(PO).State = System.Data.Entity.EntityState.Added;
                }
                else
                {
                    context.PurchaseOrders.Attach(PO);
                    PO.UpdateBy = Session.LoginUser.Username;
                    PO.UpdateDate = DateTime.Now;
                    context.Entry(PO).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public static IEnumerable<PurchaseOrder> GetAllActivePurchaseOrders()
        {
            using (var context = new POSContext())
            {
                return context.PurchaseOrders.Include(p => p.Supplier).Where(x => x.IsActive == true && x.BranchId == Session.LoginBranch.Id).ToList();
            }
        }

        public static PurchaseOrder GetPurchaseOrderById(int id)
        {
            using (var context = new POSContext())
            {
                return context.PurchaseOrders.Include(p=>p.Supplier).First(x => x.Id == id && x.BranchId == Session.LoginBranch.Id);
            }
        }

    }
}
