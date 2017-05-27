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
    public class OgrenciController : Controller
    {
        
        // GET: Admin/Ogrenci
        public ActionResult OgrenciListele()
        {
            var ogrenciler = Database.Session.Query<Ogrenci>();
            return View(new OgrencilerOgrenciListele() { Ogrenciler = ogrenciler });
        }

        public ActionResult OgrenciEkle()
        {
            return View();
        }
    }
}