using BNR_Website.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BNR_Website.BusinessLogic
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();

        User GetUserById(int id);

        void RemoveUser(int id);

        void UpdateUser(User user);

        void CreateUser(User user);
    }
}