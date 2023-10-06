using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTrip.Models.Concrete;

namespace TravelTrip.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
     
 
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var values = c.Admins.FirstOrDefault(x => x.User == ad.User && x.Password == ad.Password);
            if(values != null)
            {
                FormsAuthentication.SetAuthCookie(values.User, false);
                Session["User"] = values.User.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}