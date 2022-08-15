using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;

namespace EzPOS.Services
{
    public static class EmployeeService
    {
        public static void SaveEmployee(Employee emp)
        {
            using(var context = new POSContext())
            {
                context.Employees.Add(emp);

                if (emp.Id == 0)
                    context.Entry(emp).State = System.Data.Entity.EntityState.Added;
                else
                    context.Entry(emp).State = System.Data.Entity.EntityState.Added;

                context.SaveChanges();
            }

        }
    }
}
