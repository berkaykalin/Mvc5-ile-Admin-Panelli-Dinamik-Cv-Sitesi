﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;


namespace MvcCv.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepository<TblSertifikalarim> repo = new GenericRepository<TblSertifikalarim> ();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }

        [HttpGet]
        public ActionResult SertifikaDuzenle(int id)
        {
            var sertifika=repo.Find(x=>x.ID == id);
            ViewBag.d = id;
            return View(sertifika);
        }

        [HttpPost]
        public ActionResult SertifikaDuzenle(TblSertifikalarim t)
        {
            var s=repo.Find(x=> x.ID == t.ID);
            s.Tarih=t.Tarih;
            s.Aciklama = t.Aciklama;
            repo.TUpdate(s);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SertifikaEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SertifikaEkle(TblSertifikalarim s)
        {
            repo.TAdd(s);
            return RedirectToAction("Index");
        }

        public ActionResult SertifikaSil(int id)
        {
            var sertifika = repo.Find(x=>x.ID == id);
            repo.TDelete(sertifika);
            return RedirectToAction("Index");
        }


    }
}