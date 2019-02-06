using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace TopHealthInsurancePlan.App_Start
{
    public class BundelConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.ResetAll();
            // create an object of ScriptBundle and 
            // specify bundle name (as virtual path) as constructor parameter 
            ScriptBundle scriptJs = new ScriptBundle("~/bundles/js");
            StyleBundle styleCss = new StyleBundle("~/content/css/bundles");

            //use Include() method to add all the script files with their paths 
            scriptJs.Include(
                                "~/content/js/jquery3.3.1.js",
                                "~/content/js/popper.js",
                                "~/content/js/bootstrap.min.js",
                                "~/content/js/bootstrap.bundle.min.js",
                                "~/content/js/custom.js"
                              );

            styleCss.Include(
                "~/content/css/bootstrap.min.css",
                 "~/content/css/bootstrap-reboot.min.css",
                 "~/content/css/normalize.css",
                 "~/content/css/style.css"
                 );

            ////Add the bundle into BundleCollection

            bundles.Add(styleCss);
            bundles.Add(scriptJs);


            BundleTable.EnableOptimizations = true;
        }
    }
}