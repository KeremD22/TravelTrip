using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Concrete;

namespace TravelTrip.Controllers
{
    public class AdminController : Controller
    {
       

        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var values = c.Blogs.Find(id);
            c.Blogs.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult BlogGüncelle(int id)
        {
            var values = c.Blogs.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult BlogGüncelle(Blog p)
        {
            var values = c.Blogs.Find(p.BlogId);
            values.BlogImage = p.BlogImage;
            values.Comments = p.Comments;
            values.Description = p.Description;
            values.Time = p.Time;
            values.Title = p.Title;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Comments.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var values = c.Comments.Find(id);
            c.Comments.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YorumGüncelle(int id)
        {
            var values = c.Comments.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult YorumGüncelle(Comment p)
        {
            var values = c.Comments.Find(p.Id);
            values.UserName = p.UserName;
            values.Comment1 = p.Comment1;
            values.Mail = p.Mail;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}