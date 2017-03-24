using BNR_Website.DAL.Models;
using BNR_Website.DAL.Repositories;
using BNR_Website.DAL.Repositories.Interfaces;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BNR_Website.BusinessLogic
{
    public class UserService : IUserService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UserService));

        private IUnitOfWork _unitOfWork = null;

        #region Constructors
        public UserService()
        {
            if (_unitOfWork == null)
            {
                _unitOfWork = new UnitOfWork(new BNRContext());
            }
        }
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion



        public void UpdateUser(User user)
        {
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.Save();
        }

        public void CreateUser(User user)
        {
            _unitOfWork.UserRepository.Insert(user);
            _unitOfWork.Save();
        }




        public IEnumerable<User> GetAllUsers()
        {
            return _unitOfWork.UserRepository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _unitOfWork.UserRepository.Get(id);
        }

        public void RemoveUser(int id)
        {
            User user = _unitOfWork.UserRepository.Get(id);
            _unitOfWork.UserRepository.Delete(user);
            _unitOfWork.Save();
        }

    }
}