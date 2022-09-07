using System.Data.Entity;
using EzPOS.Models;
using EzPOS.Models.Common;
using EzPOS.Models.Contacts;
using EzPOS.Models.Products;
using EzPOS.Models.Settings;

namespace EzPOS
{
    public class POSContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet <Supplier> Suppliers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductStatusCode> ProductStatusCodes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BusinessSetting> BusinessSettings { get; set; }

        public DbSet<Unit> Units { get; set; }


        public POSContext() : base("EzPOS")
        {

        }
    }
}
