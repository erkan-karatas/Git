using NHibernate.Linq;
using OgrenciYoklama.Models;
using OgrenciYoklama.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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

                if (user == null || !user.checkPassword(form.password))
                {
                    return RedirectToRoute("Home");
                }
                else if (user.kullanici_adi == form.username && user.checkPassword(form.password))
                {
                    FormsAuthentication.SetAuthCookie(user.kullanici_adi, true);
                    return RedirectToRoute("Admin");
                }

            return View();

        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("Home");

        }

    }
}