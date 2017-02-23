using BNR_Website.DAL.Models;
using BNR_Website.DAL.Repositories.Interfaces;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNR_Website.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UserRepository));

        public UserRepository(BNRContext context) : base(context)
        {
        }

        public BNRContext BNRContext
        {
            get { return Context as BNRContext; }
        }


    }
}
