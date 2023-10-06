using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Concrete;

namespace TravelTrip.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Destek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Destek(Contact a)
        {
            c.Contacts.Add(a);
            c.SaveChanges();
            return RedirectToAction("Index","Default");
        }
    }
}