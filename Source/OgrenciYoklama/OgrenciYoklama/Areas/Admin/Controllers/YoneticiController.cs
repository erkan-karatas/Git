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
        

    }
}