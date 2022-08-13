using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Permissions;
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

        public static bool VerifyLogin(string Username , string Password , string BranchCode)
        {
            using (var context = new POSContext())
            {
                var user = context.Users.FirstOrDefault(x => x.Username == Username);
                if(user == null)
                    return false;

                if (user.Password != Helpers.EncryptionService.EncryptPassword(Password))
                    return false;
                else
                {
                    Session.LoginUser = user;
                    Session.LoginBranch = context.Branches.FirstOrDefault(x => x.Code == BranchCode);
                    return true;
                }
            }
        }
    }
}
