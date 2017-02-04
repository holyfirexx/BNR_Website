using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BNR_Website.DAL.Models;

namespace BNR_Website.DAL.Repositories
{
    public class BNRContext : DbContext
    {
        public BNRContext()
            : base("bnrwebsite")
        {
        }
        public virtual DbSet<User> Users { get; set; }
    }
}
