using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepository<TblAdmin> repo = new GenericRepository<TblAdmin>();
        public ActionResult Index()
        {
            var liste=repo.List();
            return View(liste);
        }

        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminEkle(TblAdmin a)
        {
            repo.TAdd(a);
            return RedirectToAction("Index");
        }

        public ActionResult AdminSil(int id)
        {
            var admin = repo.Find(x => x.ID == id);
            repo.TDelete(admin);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AdminGuncelle(int id)
        {
            var admin = repo.Find(x => x.ID == id);
            return View(admin);
        }
        [HttpPost]
        public ActionResult AdminGuncelle(TblAdmin a)
        {
            var admin = repo.Find(x => x.ID == a.ID);
            admin.KullaniciAdi = a.KullaniciAdi;
            admin.Sifre = a.Sifre;
            repo.TUpdate(admin);
            return RedirectToAction("Index");
        }
    }
}