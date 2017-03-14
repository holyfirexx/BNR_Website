using System.Data.Entity;
using BNR_Website.DAL.Models;

namespace BNR_Website.DAL.Repositories
{
    public class BNRContext : DbContext
    {
        public BNRContext() : base("db_a19aa3_bnrweb")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
