using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TopHealthInsurancePlan.Models
{
    public class CorporateHealthLead
    {
        public DateTime GeneratedDateTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedDateTime { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ProductName { get; set; }
        public int SiteId { get; set; }
        public string Status { get; set; }
        public string Source { get; set; } = string.Empty;
        public string Keyword { get; set; } = string.Empty;
        public string MatchType { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;



        //products fields
        [Description("Dob")]
            public DateTime Dob { get; set; }
            [Description("Age")]
            public int? Age { get; set; }
            [Description("Period")]
            public int Period { get; set; }
            [Description("Premium Type Id")]
            public int PremiumTypeId { get; set; }
            [Description("Insurance Type Id")]
            public int InsuranceTypeId { get; set; }
            [Description("Company Name")]
            public string CompanyName { get; set; }
            [Description("Company Postcode")]
            public string CompanyPostCode { get; set; }
            [Description("Company City")]
            public string CompanyCity { get; set; }
            [Description("Company Address")]
            public string CompanyAddress { get; set; }
        [Description("Employee Number")]
        public int EmployeeNumber { get; set; }
        [Description("Existing Policy")]
            public bool ExistingPolicy { get; set; }
            [Description("Partner Gender")]
            public string PartnerGender { get; set; }
            [Description("Cover Type")]
            public int CorporateCoverTypeHealth { get; set; }
          
            
        }
    }