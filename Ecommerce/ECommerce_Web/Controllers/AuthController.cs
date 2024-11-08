using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce_Web.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Resigter()
        {
            return View();
        }

        public ActionResult ForgotPassword() 
        {
            return View();    
        }

        public ActionResult ResetPassword()
        {
            return View();
        }
    }
}