using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EzPOS.Models.Products;

namespace EzPOS.Services.Products
{
    public class ProductService
    {
        private POSContext context;

        public ProductService(POSContext context)
        {
            this.context = context;
        }
        public IEnumerable<Brand> GetBrands()
        {
            using (var context = new POSContext())
            {
                return context.Brands.ToList();
            }
        }

        public IEnumerable<Category> GetMainCategories()
        {
            using (var context = new POSContext())
            {
                return context.Categories.Where(c=>c.IsSubCategory == false).ToList();
            }
        }

        public IEnumerable<Category> GetSubCategories(int? id)
        {
            using (var context = new POSContext())
            {
                return context.Categories.Where(c => c.IsSubCategory == true && c.CategoryId == id).ToList();
            }
        }

        public Product GetProductById(int id)
        {
            using (var context = new POSContext())
            {
                return context.Products.Include(x=>x.Brand).Include(x=>x.Category).Include(x=>x.SubCategory).First(c => c.Id == id);
            }
        }

        public void SaveProduct(Product prd)
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

        public IEnumerable<Product> GetProducts()
        {
            using (var context = new POSContext())
            {
                return context.Products.Include(x => x.Brand).Include(x => x.Category).Include(x => x.SubCategory).Include(x=>x.Unit).ToList();
            }
        }

        public IEnumerable<Unit> GetUnits()
        {
            return context.Units.ToList();
        }

    }
}
