using NHibernate.Linq;
using OgrenciYoklama.Areas.Admin.ViewModels;
using OgrenciYoklama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciYoklama.Areas.Admin.Controllers
{
    public class YoklamaController : Controller
    {
        // GET: Admin/Yoklama
        public ActionResult Index()
        {
            //  var dersler = Database.Session.Query<Ders>();
            //  ViewBag.YoklamaId = new DerslerDersListele() { Dersler = dersler };
            ogrenciders ogrders = new ogrenciders();

            var ogrenciler = Database.Session.Query<Ogrenci>();
            var ogr = new OgrencilerOgrenciListele()
            {
                Ogrenciler = ogrenciler
            };
            ogrders.Ogrenciler = ogr.Ogrenciler;
            var dersler = Database.Session.Query<Ders>();
            var drs = new DerslerDersListele()
            {
                Dersler = dersler
            };
            ogrders.Dersler = drs.Dersler;
            return View(ogrders);
        }
    }
}