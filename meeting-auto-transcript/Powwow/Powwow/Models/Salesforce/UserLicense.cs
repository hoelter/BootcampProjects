using Newtonsoft.Json;
using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powwow.Models.Salesforce
{
    public class UserLicense
    {
        [Key]
        [Display(Name = "User License ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "License Def. ID")]
        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string LicenseDefinitionKey { get; set; }

        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Monthly Logins Used")]
        [Createable(false), Updateable(false)]
        public int? MonthlyLoginsUsed { get; set; }

        [Display(Name = "Monthly Logins Allotted")]
        [Createable(false), Updateable(false)]
        public int? MonthlyLoginsEntitlement { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
