using NHibernate.Linq;
using OgrenciYoklama.Areas.Admin.ViewModels;
using OgrenciYoklama.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System;
using System.Web;

namespace OgrenciYoklama.Areas.Admin.Controllers
{
    
    public class OgrenciController : Controller
    {
        public ActionResult OgrenciListele()
        {
            var ogrenciler = Database.Session.Query<Ogrenci>();
            return View(new OgrencilerOgrenciListele() { Ogrenciler = ogrenciler });
        }

        public ActionResult OgrenciEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OgrenciEkle(Ogrenci form)
        {

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            var ogrenci = new Ogrenci()
            {
                ogrenci_no = form.ogrenci_no,
                ogrenci_ad = form.ogrenci_ad,
                ogrenci_soyad = form.ogrenci_soyad,
                ogrenci_bolum = form.ogrenci_bolum
            };
            Database.Session.Save(ogrenci);
            return RedirectToAction("OgrenciListele");
        }

        [HttpPost]
        public ActionResult OgrenciSil(int id)
        {
            var ogrenci = Database.Session.Query<Ogrenci>().FirstOrDefault(p => p.ogrenci_id == id);
            Database.Session.Delete(ogrenci);
            Database.Session.Flush();
            return RedirectToAction("OgrenciListele");
        }
        
    }
}