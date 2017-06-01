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
    public class DersController : Controller
    {
        public ActionResult DersEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DersEkle(Ders form)
        {

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            var ders = new Ders()
            {
                ders_adi = form.ders_adi,
                baslangic_tarihi = form.baslangic_tarihi,
                bitis_tarihi = form.bitis_tarihi,
                haftalik_saat = form.haftalik_saat
            };
            Database.Session.Save(ders);
     
            return RedirectToAction("DersListele");
        }
        public ActionResult DersListele()
        {
            var dersler = Database.Session.Query<Ders>();
            return View(new DerslerDersListele() { Dersler = dersler });
        }

        public ActionResult DersSil(int id)
        {
            var ders = Database.Session.Query<Ders>().FirstOrDefault(p => p.ders_id == id);
            Database.Session.Delete(ders);
            Database.Session.Flush();
            return RedirectToAction("DersListele");

        }
    }
}