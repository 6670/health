using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TopHealthInsurancePlan.Models
{
    public class HealthFilterLeadModel
    {
        [Required]
        [Display(Name = "Cover Required For?")]
        public int CoverType { get; set; } = 1;
        public List<SelectListItem> CoverTypeItems { get { return GetCoverTypeItems(); } set { CoverTypeItems = value; } }

        [Required]
        [Display(Name = "No. of People on Policy:")]
        public int TotalPerson { get; set; } = 1;
        public List<SelectListItem> TotalPersonItems { get { return GetTotalPersonItems(); } set { TotalPersonItems = value; } }
        [Required]
        [Display(Name = "Title:")]
        public string YourTitle { get; set; }
        public List<SelectListItem> TitleItems { get { return GetTitleItems(); } set { TitleItems = value; } }

        [Required]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }


        [Required]
        [Display(Name = "Address:")]
        public string Address { get; set; }

        //[Required]
        [Display(Name = "City:")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Post Code:")]
        [RegularExpression(@"[a-zA-Z]{1,2}[0-9][0-9A-Za-z]? {0,1}[0-9][a-zA-Z]{2}")]
        public string PostCode { get; set; }

        [Required]
        [Display(Name = "Home/Mobile Phone:")]
        [RegularExpression(@"^(((\+44\s?\d{4}|\(?0\d{4}\)?)\s?\d{3}\s?\d{3})|((\+44\s?\d{3}|\(?0\d{3}\)?)\s?\d{3}\s?\d{4})|((\+44\s?\d{2}|\(?0\d{2}\)?)\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?$")]
        public string HomePhone { get; set; }


        [Display(Name = "Alternative Phone:")]
        [RegularExpression(@"^(((\+44\s?\d{4}|\(?0\d{4}\)?)\s?\d{3}\s?\d{3})|((\+44\s?\d{3}|\(?0\d{3}\)?)\s?\d{3}\s?\d{4})|((\+44\s?\d{2}|\(?0\d{2}\)?)\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?$")]
        public string WorkPhone { get; set; }

        [Required]
        [Display(Name = "Email:")]
        [RegularExpression(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }

        public DateTime Dob { get; set; }
        public int Age { get; set; }
        [Required]
        public int Day { get; set; }

        public List<SelectListItem> DayItems { get { return GetBirthDay(); } set { DayItems = value; } }

        [Required]
        public int Month { get; set; }

        public List<SelectListItem> MonthItems { get { return GetBirthMonth(); } set { MonthItems = value; } }

        [Required]
        public int Year { get; set; }

        public List<SelectListItem> YearItems { get { return GetBirthYear(); } set { YearItems = value; } }


        public bool Opt { get; set; }

        [Required]
        [Display(Name = "Have An Existing Policy?")]
        public bool ExistingPolicy { get; set; } = true;
        public List<SelectListItem> ExistingPolicyItems { get { return GetExistingPolicyItems(); } set { ExistingPolicyItems = value; } }

        [Required]
        [Display(Name = "Do You Smoke?")]
        public bool Smoker { get; set; } = false;
        public List<SelectListItem> SmokerItems { get { return GetSmokerList(); } set { SmokerItems = value; } }

       
        private List<SelectListItem> GetExistingPolicyItems()
        {
            List<SelectListItem> list = new List<SelectListItem>
           {
                new SelectListItem { Text= "Yes" , Value= "true"},
                new SelectListItem { Text= "No" , Value= "false"},
           };
            return list;
        }
        private List<SelectListItem> GetSmokerList()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text="Yes", Value="true", Selected=false},
                new SelectListItem { Text="No", Value="false", Selected=false},
            };
        }


        private List<SelectListItem> GetTitleItems()
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem { Text= "Mr" , Value= "Mr"},
                new SelectListItem { Text= "Mrs" , Value= "Mrs"},
                new SelectListItem { Text= "Miss" , Value= "Miss"},
                new SelectListItem { Text= "Ms" , Value= "Ms"},
            };

            return list;
        }


        private List<SelectListItem> GetBirthDay()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            for (int iDay = 1; iDay <= 31; iDay++)
                list.Add(new SelectListItem
                {
                    Text = string.Format("{0}", iDay),
                    Value = iDay.ToString(),
                });

            return list;
        }

        private List<SelectListItem> GetBirthMonth()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            for (int iMonth = 1; iMonth <= 12; iMonth++)
                list.Add(new SelectListItem
                {
                    Text = string.Format("{0}", GetMonthName(iMonth, true)),
                    Value = iMonth.ToString(),
                });

            return list;
        }

        private static string GetMonthName(int month, bool abbrev)
        {
            DateTime date = new DateTime(1900, month, 1);

            if (abbrev) return date.ToString("MMM");

            return date.ToString("MMMM");
        }

        private List<SelectListItem> GetBirthYear()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var maxYear = DateTime.Now.Year - 100;
            var minYear = DateTime.Now.Year - 18;
            for (int iYear = minYear; iYear >= maxYear; iYear--)
                list.Add(new SelectListItem
                {
                    Text = string.Format("{0}", iYear),
                    Value = iYear.ToString(),
                });

            return list;
        }
        private List<SelectListItem> GetTotalPersonItems()
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem { Text= "1 Person" , Value= "1"},
                new SelectListItem { Text= "2 People" , Value= "2"},
                new SelectListItem { Text= "3 People" , Value= "3"},
                new SelectListItem { Text= "4 People" , Value= "4"},
                new SelectListItem { Text= "5+ People" , Value= "5"},
            };

            return list;
        }


        private List<SelectListItem> GetCoverTypeItems()
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem { Text= "Just Yourself" , Value= "1"},
                new SelectListItem { Text= "You & Your Partner" , Value= "2"},
                new SelectListItem { Text= "You & Your Family" , Value= "3"},
                new SelectListItem { Text= "Group Medical Plan" , Value= "5"},
            };

            return list;
        }
    }
}