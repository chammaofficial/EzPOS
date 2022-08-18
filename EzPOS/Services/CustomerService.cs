using EzPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EzPOS.Services
{
    public static class CustomerService
    {
        public static void SaveCustomer(Customer cus)
        {
            using (var context = new POSContext())
            {
                if (cus.Id == 0)
                {
                    context.Customers.Add(cus);
                    cus.CreateBy = Session.LoginUser.Username;
                    cus.CreateDate = DateTime.Now;
                    context.Entry(cus).State = System.Data.Entity.EntityState.Added;
                }
                else
                {
                    context.Customers.Attach(cus);
                    cus.UpdateBy = Session.LoginUser.Username;
                    cus.UpdateDate = DateTime.Now;
                    context.Entry(cus).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
            }
        }


        public static IEnumerable<Customer> GetAllActiveCustomers()
        {
            using (var context = new POSContext())
            {
                return context.Customers.Where(x => x.IsActive == true).ToList();
            }
        }

        public static Customer GetCustomerById(int id)
        {
            using (var context = new POSContext())
            {
                return context.Customers.First(x => x.Id == id);
            }
        }
    }
}
