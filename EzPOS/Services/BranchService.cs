using System;
using System.Collections.Generic;
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
    }
}
