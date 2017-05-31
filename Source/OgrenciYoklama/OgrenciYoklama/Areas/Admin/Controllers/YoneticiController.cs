using NHibernate.Linq;
using OgrenciYoklama.Areas.Admin.ViewModels;
using OgrenciYoklama.Infrastructure;
using OgrenciYoklama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OgrenciYoklama.Areas.Admin.Controllers
{
    
    public class YoneticiController : Controller
    {
        public ActionResult YoneticiListele()
        {
            var yoneticiler = Database.Session.Query<Yonetici>();
            return View(new YoneticilerYoneticiListele() { Yoneticiler = yoneticiler });
                        
        }

        public ActionResult YoneticiEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YoneticiEkle(Yonetici form)
        {

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            var yonetici = new Yonetici()
            {
                yonetici_ad = form.yonetici_ad,
                yonetici_soyad = form.yonetici_soyad,
                kullanici_adi = form.kullanici_adi
                
            };
            yonetici.SetPassword(form.sifre);
            Database.Session.Save(yonetici);
            return RedirectToAction("YoneticiListele");
        }


    }
}