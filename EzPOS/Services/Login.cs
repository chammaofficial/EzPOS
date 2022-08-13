using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;

namespace EzPOS.Services
{
    public static class Login
    {
        public static List<Branch> GetAllBranchesByUser(string username)
        {
            using (var context = new POSContext())
            {
                var branches = context.Branches.ToList();
                return branches;
            }
        }
    }
}
