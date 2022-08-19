using EzPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EzPOS.Services
{
    public static class BrandService
    {
        public static void SaveBrand(Brand brand)
        {
            using (var context = new POSContext())
            {
                if (brand.Id == 0)
                {
                    context.Brands.Add(brand);
                    brand.CreateBy = Session.LoginUser.Username;
                    brand.CreateDate = DateTime.Now;
                    context.Entry(brand).State = System.Data.Entity.EntityState.Added;
                }
                else
                {
                    context.Brands.Attach(brand);
                    brand.UpdateBy = Session.LoginUser.Username;
                    brand.UpdateDate = DateTime.Now;
                    context.Entry(brand).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public static IEnumerable<Brand> GetAllActiveBrands()
        {
            using (var context = new POSContext())
            {
                return context.Brands.ToList();
            }
        }

        public static Brand GetBrandById(int id)
        {
            using (var context = new POSContext())
            {
                return context.Brands.First(x => x.Id == id);
            }
        }

        public static void DeleteBrand(int id)
        {
            using (var context = new POSContext())
            {
                var brand = context.Brands.First(x => x.Id == id);
                context.Brands.Remove(brand);
                context.SaveChanges();
            }
        }
    }
}
