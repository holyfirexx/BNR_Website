using BNR_Website.DAL.Models;
using System.Collections.Generic;

namespace BNR_Website.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {


        IEnumerable<User> GetAllUsersByRole(string role);



    }
}
