using System.Data.Entity;
using EzPOS.Models;

namespace EzPOS
{
    public class POSContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<User> Users { get; set; }


        public POSContext() : base("EzPOS")
        {

        }
    }
}
