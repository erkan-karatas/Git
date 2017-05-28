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
        // GET: Admin/Ogrenci
        public ActionResult OgrenciListele()
        {
            var ogrenciler = Database.Session.Query<Ogrenci>();
            return View(new OgrencilerOgrenciListele() { Ogrenciler = ogrenciler });
        }
    }
}