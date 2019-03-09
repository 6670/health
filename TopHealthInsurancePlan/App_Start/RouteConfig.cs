using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TopHealthInsurancePlan
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           
            routes.MapRoute(
           name: "Health",
           url: "health",
           defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
       );
            routes.MapRoute(
          name: "CorporateHealth",
          url: "corporatehealth",
          defaults: new { controller = "Home", action = "Corporate", id = UrlParameter.Optional }
      );
            routes.MapRoute(
          name: "CpntactUs",
          url: "Contactus",
          defaults: new { controller = "Home", action = "ContactUs", id = UrlParameter.Optional }
      );
            routes.MapRoute(
          name: "Thank",
          url: "thank",
          defaults: new { controller = "Home", action = "thank", id = UrlParameter.Optional }

      );

            routes.MapRoute(
        name: "Privacy Policy",
        url: "privacyPolicy",
        defaults: new { controller = "Home", action = "Privacy", id = UrlParameter.Optional }

    );
            routes.MapRoute(
     name: "terms And Condition",
     url: "termsAndCondition",
     defaults: new { controller = "Home", action = "termsAndCondition", id = UrlParameter.Optional }

 );
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

        }
    }
}
