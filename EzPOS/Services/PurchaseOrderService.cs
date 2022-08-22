using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;

namespace EzPOS.Services
{
    public class PurchaseOrderService
    {
        private POSContext context;

        public PurchaseOrderService(POSContext context)
        {
            this.context = context;
        }
        public IEnumerable<Supplier> GetSuppliers()
        {
            return context.Suppliers.Where(s => s.IsActive == true).ToList();
        }

        public void SavePurchaseOrderHeader(PurchaseOrder PO)
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

        public void SavePurchaseOrderDetail(PurchaseOrderDetail PO)
        {
            if (PO.Id == 0)
            {
                context.PurchaseOrderDetails.Add(PO);
                PO.CreateBy = Session.LoginUser.Username;
                PO.CreateDate = DateTime.Now;
                context.Entry(PO).State = System.Data.Entity.EntityState.Added;
            }
            else
            {
                context.PurchaseOrderDetails.Attach(PO);
                PO.UpdateBy = Session.LoginUser.Username;
                PO.UpdateDate = DateTime.Now;
                context.Entry(PO).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
        }


        public IEnumerable<PurchaseOrder> GetAllActivePurchaseOrders()
        {
            return context.PurchaseOrders.Include(p => p.Supplier).Where(x => x.IsActive == true && x.BranchId == Session.LoginBranch.Id).ToList();
        }

        public IEnumerable<PurchaseOrderDetail> GetAllActivePurchaseOrdersDetailsByPurchaseOrderId(int id)
        {
            return context.PurchaseOrderDetails.Include(x => x.Product).Where(x => x.IsActive == true && x.PurchaseOrderId == id).ToList();
        }

        public int GetNextLineItemNoByPoID(int id)
        {
            if (context.PurchaseOrderDetails.Any(x => x.PurchaseOrderId == id))
            {
                return context.PurchaseOrderDetails.Where(x => x.PurchaseOrderId == id).Max(c => c.LineItemNo + 1);
            }
            else
            {
                return 1;
            }
        }

        public IEnumerable<Product> GetAllActiveProducts()
        {
            return context.Products.Where(x => x.IsActive == true).ToList();
        }
        public PurchaseOrder GetPurchaseOrderById(int id)
        {
            return context.PurchaseOrders.Include(p=>p.Supplier).First(x => x.Id == id && x.BranchId == Session.LoginBranch.Id);
        }
    }
}
