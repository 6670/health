using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopHealthInsurancePlan.Models;
using WebSeearchMediaService;

namespace TopHealthInsurancePlan.Controllers
{
    public class HomeController : Controller
    {
        private readonly CaptureService _captureService = new CaptureService();

        // GET: Home
        #region Health
        public ActionResult Index()
        {
            return View(new HealthFilterLeadModel());
        }
        public ActionResult familyHealth()
        {
            return View(new HealthFilterLeadModel());
        }
        public ActionResult Over50()
        {
            return View(new HealthFilterLeadModel());
        }
        public ActionResult Comprehensive()
        {
            return View(new HealthFilterLeadModel());
        }
        public ActionResult CriticalIllness()
        {
            return View(new HealthFilterLeadModel());
        }
        public ActionResult PrivateHealth()
        {
            return View(new HealthFilterLeadModel());
        }
        [HttpPost]
        public ActionResult Index(HealthFilterLeadModel model)
        {
            if (ModelState.IsValid)
            {
                var Dob = DateTime.Parse(SqlDateTime.MinValue.ToString());
                if (model.Day != 0 && model.Month != 0 && model.Year != 0)
                {
                    var daysOfMonth = DateTime.DaysInMonth(model.Year, model.Month);
                    if (daysOfMonth < model.Day)
                    {
                        model.Day = daysOfMonth;
                    }
                    Dob = new DateTime(model.Year, model.Month, model.Day);
                }
                model.Dob = Dob;
                model.Age = CalculateAge(Dob);

                HealthLead healthLead = new HealthLead()
                {
                    CoverTypeId = model.CoverType,
                    FamilyNumber = model.TotalPerson,
                    ExistingPolicy = model.ExistingPolicy,// default Value
                    Smoker = model.Smoker,

                    Title = model.YourTitle,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Dob = Dob,
                    Age = CalculateAge(Dob),
                    HomePhone = model.HomePhone,
                    WorkPhone = model.WorkPhone ?? model.HomePhone,
                    Email = model.Email,
                    Address = model.Address,
                    City = model.City ?? string.Empty,
                    PostCode = model.PostCode,


                    GeneratedDateTime = DateTime.Now,


                    Status = "NEW",

                    SiteId = 3,
                    ProductName = "Health",
                    Source = Session["Source"] as string ?? null,
                    Keyword = Session["Keyword"] as string ?? null,
                    MatchType = Session["Match"] as string ?? null,
                    IpAddress = Session["RemoteIPAddress"] as string ?? null
                };
              //var id = _captureService.NewAdminLeadCapture(healthLead, "http://localhost:3431/dataConverstion/capture");

               var id = _captureService.NewAdminLeadCapture(healthLead, "https://api.websearchmedia.co.uk/dataConverstion/capture");
                //  var id = _captureService.NewAdminLeadCapture(lead, "");
                if (id > 0)
                {
                    TempData["LeadId"] = id;

                }
                else
                {
                    return View(model);

                }
                ThankModel thank = new ThankModel()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Title = model.YourTitle
                };
                return RedirectToAction("Thank", "Home", thank);

            }
            return View(model);
        }

        #endregion
        #region CorporateHealth

        public ActionResult Corporate()
        {
            return View(new CorporateHealthFilterLeadModel());
        }
        public ActionResult Business()
        {
            return View(new CorporateHealthFilterLeadModel());
        }
        public ActionResult group()
        {
            return View(new CorporateHealthFilterLeadModel());
        }
        
       [HttpPost]
        public ActionResult Corporate(CorporateHealthFilterLeadModel model)
        {
            if (ModelState.IsValid)
            {
                var Dob = DateTime.Parse(SqlDateTime.MinValue.ToString());
                if (model.Day != 0 && model.Month != 0 && model.Year != 0)
                {
                    var daysOfMonth = DateTime.DaysInMonth(model.Year, model.Month);
                    if (daysOfMonth < model.Day)
                    {
                        model.Day = daysOfMonth;
                    }
                    Dob = new DateTime(model.Year, model.Month, model.Day);
                }
               
                model.Dob = Dob;
                model.Age = CalculateAge(Dob);
                CorporateHealthLead lead = new CorporateHealthLead()
                {
                    CompanyName = model.ComplayeeName,
                    EmployeeNumber = model.TotalEmployee,
                    ExistingPolicy = model.ExistingPolicy,// default Value
                    
                    Title = model.YourTitle,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Dob = Dob,
                    Age = CalculateAge(Dob),
                    HomePhone = model.HomePhone,
                    WorkPhone = model.WorkPhone ?? model.HomePhone,
                    Email = model.Email,
                    Address = model.Address,
                    City = model.City ?? string.Empty,
                    PostCode = model.PostCode,


                    GeneratedDateTime = DateTime.Now,


                    Status = "NEW",

                    SiteId = 4,
                    ProductName = "CorporateHealth",
                    Source = Session["Source"] as string ?? null,
                    Keyword = Session["Keyword"] as string ?? null,
                    MatchType = Session["Match"] as string ?? null,
                    IpAddress = Session["RemoteIPAddress"] as string ?? null
                };
                //var id = _captureService.NewAdminLeadCapture(lead, "http://localhost:3431/dataConverstion/capture");

                  var id = _captureService.NewAdminLeadCapture(lead, "https://api.websearchmedia.co.uk/dataConverstion/capture");
                //var id = _captureService.NewAdminLeadCapture(lead, "");
                if (id > 0)
                {
                    TempData["LeadId"] = id;

                }
                else
                {
                   return View(model);

                }
                ThankModel thank = new ThankModel()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Title = model.YourTitle
                };
                return RedirectToAction("Thank", "Home",thank);
            
            }
            return View(model);
        }
        #endregion


        public ActionResult Thank(ThankModel model)
        {
            return View(model);
        }
        public static int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            int age = DateTime.Now.Year - birthDate.Year;
            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) age--;
            return age;
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult termsAndCondition()
        {
            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }
    }
}