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
    public class DcSocialProfile
    {
        [Key]
        [Display(Name = "System ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "BlueTail Master ID")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ExternalId { get; set; }

        [Display(Name = "Data.com Contact ID")]
        [StringLength(25)]
        [Createable(false), Updateable(false)]
        public string ContactId { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string CompanyName { get; set; }

        [Display(Name = "First Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string LastName { get; set; }

        [EmailAddress]
        [Createable(false), Updateable(false)]
        public string Email { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string City { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string State { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Country { get; set; }

    }
}
