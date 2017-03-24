using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BNR_Website.Controllers
{
    public class BaseController : Controller
    {

        public ActionResult Index()
        {
            return new FilePathResult("~/index.html", "text/html");
        }

        public ActionResult PageNotFound()
        {
            return View();
        }

        public ActionResult AccessDenied()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}