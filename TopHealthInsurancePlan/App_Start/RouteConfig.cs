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
            #region health

            routes.MapRoute(
           name: "Medical",
           url: "medical",
           defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
       );
            routes.MapRoute(
                   name: "PrivateHealth",
                   url: "private-health",
                   defaults: new { controller = "Home", action = "PrivateHealth", id = UrlParameter.Optional }
               );

            routes.MapRoute(
                 name: "FamilyHealth",
                 url: "family-health",
                 defaults: new { controller = "Home", action = "familyHealth", id = UrlParameter.Optional }
             );
            routes.MapRoute(
                name: "over50",
                url: "Over-50s",
                defaults: new { controller = "Home", action = "Over50", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "comprehensive",
               url: "comprehensive",
               defaults: new { controller = "Home", action = "Comprehensive", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "criticalillness",
               url: "critical-illness",
               defaults: new { controller = "Home", action = "CriticalIllness", id = UrlParameter.Optional }
           );


            #endregion
            #region corporate

            routes.MapRoute(
          name: "CorporateHealth",
          url: "corporate",
          defaults: new { controller = "Home", action = "Corporate", id = UrlParameter.Optional }
      );


            routes.MapRoute(
          name: "Business",
          url: "business",
          defaults: new { controller = "Home", action = "Business", id = UrlParameter.Optional }
      );
            routes.MapRoute(
         name: "Group",
         url: "group",
         defaults: new { controller = "Home", action = "Group", id = UrlParameter.Optional }
     );


            #endregion
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
