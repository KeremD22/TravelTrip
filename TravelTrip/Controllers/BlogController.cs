using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Concrete;

namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(2).ToList();
            return View(by);
        }
        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
          
            by.Deger1 = c.Blogs.Where(x => x.BlogId == id).ToList();
            by.Deger2 = c.Comments.Where(x => x.Blogid == id).ToList();
            ViewBag.id = 1;
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
            public PartialViewResult YorumYap(Comment b)
        {
            c.Comments.Add(b);
            c.SaveChanges();
            return PartialView();
        }
    }
}