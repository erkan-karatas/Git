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
        public ActionResult DersleriGoster()
        {
            return View();
        }

        public ActionResult DersEkle()
        {
            return View();
        }
    }
}