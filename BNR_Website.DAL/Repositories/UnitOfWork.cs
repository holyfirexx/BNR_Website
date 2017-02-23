using BNR_Website.DAL.Repositories.Interfaces;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNR_Website.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UnitOfWork));

        private readonly BNRContext _context;

        public UnitOfWork(BNRContext context)
        {
            _context = context;
            UserRepository = new UserRepository(_context);
        }

        public IUserRepository UserRepository { get; private set; }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw;
            }
        }

        public void Dispose()
        {
            try
            {
                _context.Dispose();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw;
            }
        }

    }
}