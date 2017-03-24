using System.Linq;
using System.Web.Mvc;
using BNR_Website.DAL.Models;
using BNR_Website.BusinessLogic;

namespace BNR_Website.Controllers
{
    public class UserController : BaseController
    {
        private IUserService _userService = null;



        #region Constructors
        public UserController()
        {
            _userService = new UserService();
        }

        #endregion


        //TODO do routeconfig mapping

        //public ActionResult Index()
        //{
        //    return View(_userService.GetAllUsers());
        //}


        [HttpPost]
        public ActionResult GetUsers()
        {
          var test = _userService.GetAllUsers();
          User[] userList = new User[test.Count()];

          for (int i = 0; i < test.Count();i++)
          {
            userList[i] = test.ElementAt(i);
          }
          return Json(userList);
        }





        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        //[Bind(Include = "id,Name,Credentials")]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.CreateUser(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            User user = _userService.GetUserById((int)id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Credentials")] User user)
        {
            if (ModelState.IsValid)
            {
                _userService.UpdateUser(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }





        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            User user = _userService.GetUserById((int)id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: User/Delete/5
        public ActionResult Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            User user = _userService.GetUserById((int)id);
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
            _userService.RemoveUser(id);
            return RedirectToAction("Index");
        }

    }
}
