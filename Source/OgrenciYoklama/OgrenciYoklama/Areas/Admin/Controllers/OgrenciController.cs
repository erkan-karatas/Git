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
            return View();
        }

        public ActionResult OgrenciEkle()
        {
            return View();
        }
    }
}