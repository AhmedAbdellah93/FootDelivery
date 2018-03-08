using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CooKHouseProject1.Controllers
{
    public class LoginAndRegisterationController : Controller
    {
        // GET: LoginAndRegisteration
        public ActionResult loginPage()
        {
            return View();
        }
    }
}