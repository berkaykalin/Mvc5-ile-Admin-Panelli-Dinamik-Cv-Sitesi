using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<TblHobilerim> repo = new GenericRepository<TblHobilerim>();
        public ActionResult Index()
        {
            var hobi = repo.List();
            return View(hobi);
        }

        [HttpGet]
        public ActionResult HobiEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HobiEkle(TblHobilerim h)
        {
            repo.TAdd(h);
            return RedirectToAction("Index");
        }

        public ActionResult HobiSil(int id)
        {
            TblHobilerim h= repo.Find(x=>x.ID==id);
            repo.TDelete(h);
            return RedirectToAction("Index");
        }
    }
}