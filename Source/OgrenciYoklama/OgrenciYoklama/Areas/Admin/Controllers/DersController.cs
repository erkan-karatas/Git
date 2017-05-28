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
        // GET: Admin/Ders
        public ActionResult DersListele()
        {
            var dersler = Database.Session.Query<Ders>();
            return View(new DerslerDersListele() { Dersler = dersler });
        }
    }
}