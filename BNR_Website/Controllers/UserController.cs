using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BNR_Website.DAL.Models;
using BNR_Website.DAL.Repositories;
using BNR_Website.DAL.Repositories.Interfaces;

namespace BNR_Website.Controllers
{
    public class UserController : Controller
    {
        private IUnitOfWork _unitOfWork = null;

        public UserController()
        {
            if(_unitOfWork == null)
            {
                _unitOfWork = new UnitOfWork(new BNRContext());
            }
        }
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        // GET: User
        public ActionResult Index()
        {
            return View(_unitOfWork.UserRepository.GetAll());
        }
    // GET: User
        [HttpPost]
        public ActionResult GetUsers()
        {

          var test = _unitOfWork.UserRepository.GetAll();
          User[] userList = new User[test.Count()];

          for (int i = 0; i < test.Count();i++)
          {
            userList[i] = test.ElementAt(i);
          }
          return Json(userList);
        }
        // GET: User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = _unitOfWork.UserRepository.Get(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[Bind(Include = "id,Name,Credentials")]
        public ActionResult Create( User user)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.UserRepository.Insert(user);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = _unitOfWork.UserRepository.Get(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Credentials")] User user)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.UserRepository.Update(user);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = _unitOfWork.UserRepository.Get(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = _unitOfWork.UserRepository.Get(id);
            _unitOfWork.UserRepository.Delete(user);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
