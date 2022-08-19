using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;

namespace EzPOS.Services
{
    public static class CategoryService
    {
        public static IEnumerable<Category> GetParentCategories()
        {
            using (var context = new POSContext())
            {
                return context.Categories.Where(c => c.IsSubCategory == false).ToList();
            }
        }

        public static Category GetCategoryById(int id)
        {
            using (var context = new POSContext())
            {
                return context.Categories.Include(x => x.category).First(c => c.Id == id);
            }
        }

        public static IEnumerable<Category> GetAllCategories()
        {
            using (var context = new POSContext())
            {
                return context.Categories.Include(c => c.category).ToList();
            }
        }

        public static void SaveCategory(Category cat)
        {
            using (var context = new POSContext())
            {
                if (cat.Id == 0)
                {
                    context.Categories.Add(cat);
                    cat.CreateBy = Session.LoginUser.Username;
                    cat.CreateDate = DateTime.Now;
                    context.Entry(cat).State = System.Data.Entity.EntityState.Added;
                }
                else
                {
                    context.Categories.Attach(cat);
                    cat.UpdateBy = Session.LoginUser.Username;
                    cat.UpdateDate = DateTime.Now;
                    context.Entry(cat).State = System.Data.Entity.EntityState.Modified;
                }

                context.SaveChanges();
            }
        }

        public static void DeleteCategory(int id)
        {
            using (var context = new POSContext())
            {
                var category = context.Categories.First(x => x.Id == id);
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
