using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;

namespace EzPOS.Services
{
    public static class ProductService
    {
        public static IEnumerable<Brand> GetBrands()
        {
            using (var context = new POSContext())
            {
                return context.Brands.ToList();
            }
        }

        public static IEnumerable<Category> GetMainCategories()
        {
            using (var context = new POSContext())
            {
                return context.Categories.Where(c=>c.IsSubCategory == false).ToList();
            }
        }

        public static IEnumerable<Category> GetSubCategories(int? id)
        {
            using (var context = new POSContext())
            {
                return context.Categories.Where(c => c.IsSubCategory == true && c.CategoryId == id).ToList();
            }
        }

        public static Product GetProductById(int id)
        {
            using (var context = new POSContext())
            {
                return context.Products.Include(x=>x.Brand).Include(x=>x.Category).Include(x=>x.SubCategory).First(c => c.Id == id);
            }
        }

        public static void SaveProduct(Product prd)
        {
            using (var context = new POSContext())
            {
                if (prd.Id == 0)
                {
                    context.Products.Add(prd);
                    prd.CreateBy = Session.LoginUser.Username;
                    prd.CreateDate = DateTime.Now;
                    context.Entry(prd).State = System.Data.Entity.EntityState.Added;
                }
                else
                {
                    context.Products.Attach(prd);
                    prd.UpdateBy = Session.LoginUser.Username;
                    prd.UpdateDate = DateTime.Now;
                    context.Entry(prd).State = System.Data.Entity.EntityState.Modified;
                }

                context.SaveChanges();
            }
        }

        public static IEnumerable<Product> GetProducts()
        {
            using (var context = new POSContext())
            {
                return context.Products.Include(x => x.Brand).Include(x => x.Category).Include(x => x.SubCategory).ToList();
            }
        }

    }
}
