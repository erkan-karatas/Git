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
    public class YoneticiController : Controller
    {
        public ActionResult YoneticiListele()
        {
            var yoneticiler = Database.Session.Query<Yonetici>();
            return View(new YoneticilerYoneticiListele() { Yoneticiler = yoneticiler });

            
        }

    }
}