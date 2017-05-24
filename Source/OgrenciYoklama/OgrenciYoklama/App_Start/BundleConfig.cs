﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace OgrenciYoklama.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(
                    new StyleBundle("~/admin/styles")
                    .Include("~/Content/Styles/bootstrap.css")
                    .Include("~/Content/Styles/menu.css")

                );

            bundles.Add(
                    new StyleBundle("~/styles")
                    .Include("~/Content/Styles/bootstrap.css")
                    .Include("~/Content/Styles/Anasayfa.css")

                );


            bundles.Add(new ScriptBundle("~/admin/scripts")
                 .Include("~/scripts/jquery-3.1.1.js")
                 .Include("~/scripts/jquery.validate.js")
                 .Include("~/scripts/jquery.validate.unobtrusive.js")
                 .Include("~/scripts/bootstrap.js")
                 .Include("~/areas/admin/scripts/forms.js")
                 );

            bundles.Add(new ScriptBundle("~/scripts")
               .Include("~/scripts/jquery-3.1.1.js")
               .Include("~/scripts/jquery.validate.js")
               .Include("~/scripts/jquery.validate.unobtrusive.js")
               .Include("~/scripts/bootstrap.js")
               );
        }
    }
}