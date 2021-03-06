﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TopHealthInsurancePlan.Models
{
    [Description("Health")]
    public class HealthLead
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
        //produc fields
        public DateTime Dob { get; set; }
        [Description("Age")]
        public int? Age { get; set; }
       
        [Description("Family Number")]
        public int? FamilyNumber { get; set; }
        [Description("Smoker")]
        public bool Smoker { get; set; }
        
      
      
        public int CoverTypeId { get; set; }

        
       
        [Description("Existing Policy")]
        public bool ExistingPolicy { get; set; }

    }
}