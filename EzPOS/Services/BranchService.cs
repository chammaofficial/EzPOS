using EzPOS.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
                context.Entry(b).State = EntityState.Added;
            }
            else
            {
                context.Branches.Attach(b);
                context.Entry(b).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        

        public Branch GetBranchById(int id)
        {
            return context.Branches.Include(x => x.BusinessSetting).First(x => x.Id == id);
        }

      

        
    }
}
