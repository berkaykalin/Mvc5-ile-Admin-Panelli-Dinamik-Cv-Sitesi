using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya
        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();
        public ActionResult Index()
        {
            var sosyalmedya = repo.List();
            return View(sosyalmedya);
        }
        [HttpGet]
        public ActionResult SosyalMedyaEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SosyalMedyaEkle(TblSosyalMedya s)
        {
            repo.TAdd(s);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SosyalMedyaDuzenle(int id)
        {
            var sosyalmedya = repo.Find(x => x.ID == id);
            return View(sosyalmedya);
        }

        [HttpPost]
        public ActionResult SosyalMedyaDuzenle(TblSosyalMedya s)
        {
            var y = repo.Find(x => x.ID == s.ID);
            y.ID = s.ID;
            y.Ad = s.Ad;
            y.Link = s.Link;
            y.ikon = s.ikon;
            y.Durum = true;
            repo.TUpdate(y);
            return RedirectToAction("Index");
        }

        public ActionResult SosyalMedyaSil(int id)
        {
            var sosyalmedya = repo.Find(x => x.ID == id);
            sosyalmedya.Durum = false;
            repo.TUpdate(sosyalmedya);
            return RedirectToAction("Index");
        }
    }
}