using System.Collections.Generic;
using System.Linq;
using EzPOS.Models.Settings;

namespace EzPOS.Services.Common
{
    public static class LoginService
    {
        public static List<Branch> GetAllBranches()
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

                //if (user.Password != Helpers.EncryptionService.EncryptPassword(Password))
                //    return false;

                if (user.Password != Password)
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
