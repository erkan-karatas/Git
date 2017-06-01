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
            OgrenciDers ogrders = new OgrenciDers();

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

            List<SelectListItem> items = new List<SelectListItem>();

          
            foreach (var item in drs.Dersler)
            {
                items.Add(new SelectListItem { Text = item.ders_adi, Value = item.ders_id.ToString()});
            }
            ViewBag.Dersler = items;
            ogrders.Dersler = drs.Dersler;
            return View(ogrders);
        }
    }
}