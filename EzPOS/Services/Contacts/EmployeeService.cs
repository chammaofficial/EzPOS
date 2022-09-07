using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EzPOS.Models.Contacts;

namespace EzPOS.Services.Contacts
{
    public static class EmployeeService
    {
        public static void SaveEmployee(Employee emp)
        {
            using (var context = new POSContext())
            {
                if (emp.Id == 0)
                {
                    context.Employees.Add(emp);
                    emp.CreateBy = Session.LoginUser.Username;
                    emp.CreateDate = DateTime.Now;
                    context.Entry(emp).State = System.Data.Entity.EntityState.Added;
                }
                else
                {
                    context.Employees.Attach(emp);
                    emp.UpdateBy = Session.LoginUser.Username;
                    emp.UpdateDate = DateTime.Now;
                    context.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public static IEnumerable<Employee> GetAllEmployeesByBranch()
        {
            using (var context = new POSContext())
            {
                return context.Employees.Include(b => b.Branch).Where(x => x.BranchId == Session.LoginBranch.Id).ToList();
            }
        }

        public static IEnumerable<Employee> GetAllActiveEmployeesByBranch()
        {
            using (var context = new POSContext())
            {
                return context.Employees.Include(b => b.Branch).Where(x => x.BranchId == Session.LoginBranch.Id && x.IsActive == true).ToList();
            }
        }

        public static Employee GetEmployeeById(int id)
        {
            using (var context = new POSContext())
            {
                return context.Employees.Include(b => b.Branch).First(x => x.BranchId == Session.LoginBranch.Id && x.Id == id);
            }
        }
    }
}
