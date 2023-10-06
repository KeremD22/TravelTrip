using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Concrete;

namespace TravelTrip.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(9).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.BlogId).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var degerler = c.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.BlogId).Take(3).ToList();
            return PartialView(degerler);
        }
    }
}