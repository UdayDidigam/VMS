using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VMS.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}