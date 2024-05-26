﻿using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        GenericRepository<TblHakkimda> repo = new GenericRepository<TblHakkimda>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda=repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TblHakkimda h)
        {
            var hakkimda = repo.Find(x=>x.ID==h.ID);
            hakkimda.ID = h.ID;
            hakkimda.Ad=h.Ad;
            hakkimda.Soyad=h.Soyad;
            hakkimda.Adres=h.Adres;
            hakkimda.Telefon=h.Telefon;
            hakkimda.Mail=h.Mail;
            hakkimda.Aciklama=h.Aciklama;
            hakkimda.Resim = h.Resim;
            repo.TUpdate(hakkimda);
            return RedirectToAction("Index");
        }
    }
}