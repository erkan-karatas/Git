using NHibernate.Linq;
using OgrenciYoklama.Models;
using OgrenciYoklama.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciYoklama.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View(new LoginIndex());
        }

        [HttpPost]
        public ActionResult Index(LoginIndex form)
        {
            var user = Database.Session.Query<Yonetici>().FirstOrDefault(p => p.kullanici_adi == form.username);
            var pass = Database.Session.Query<Yonetici>().FirstOrDefault(p => p.sifre == form.password);


            if(user.kullanici_adi == form.username && pass.sifre == form.password)
            {
                return RedirectToRoute("Admin");

            }

            return View();

        }

    }
}