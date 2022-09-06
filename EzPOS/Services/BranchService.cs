using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;

namespace EzPOS.Services
{
    public class BranchService
    {
        private POSContext context;

        public BranchService(POSContext context)
        {
            this.context = context;
        }

        public IEnumerable<Branch> GetBranches()
        {
            return context.Branches.ToList();
        }

        public void SaveBranch(Branch b)
        {
            if (b.Id == 0)
            {
                context.Branches.Add(b);
                context.Entry(b).State = System.Data.Entity.EntityState.Added;
            }
            else
            {
                context.Branches.Attach(b);
                context.Entry(b).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
        }

        public Branch GetBranchById(int id)
        {
            return context.Branches.Include(x=>x.BusinessSetting).First(x => x.Id == id);
        }

        public BusinessSetting GetBusinessSettingsByLoggedBranch()
        {
            return context.Branches.Include(x => x.BusinessSetting).First(x => x.Id == Session.LoginBranch.Id).BusinessSetting;
        }
    }
}
