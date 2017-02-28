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
    public class DatacloudContact
    {
        [Key]
        [Display(Name = "System ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Data.com Contact ID")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ExternalId { get; set; }

        [Display(Name = "Company Id")]
        [StringLength(25)]
        [Createable(false), Updateable(false)]
        public string CompanyId { get; set; }

        [Display(Name = "Data.com Contact ID")]
        [StringLength(25)]
        [Createable(false), Updateable(false)]
        public string ContactId { get; set; }

        [Display(Name = "Company")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string CompanyName { get; set; }

        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string Title { get; set; }

        [Display(Name = "Inactive Status")]
        [Createable(false), Updateable(false)]
        public bool IsInactive { get; set; }

        [Display(Name = "First name")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string LastName { get; set; }

        [Phone]
        [Createable(false), Updateable(false)]
        public string Phone { get; set; }

        [EmailAddress]
        [Createable(false), Updateable(false)]
        public string Email { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Street { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string City { get; set; }

        [StringLength(50)]
        [Createable(false), Updateable(false)]
        public string State { get; set; }

        [StringLength(50)]
        [Createable(false), Updateable(false)]
        public string Country { get; set; }

        [Display(Name = "ZIP code")]
        [StringLength(32)]
        [Createable(false), Updateable(false)]
        public string Zip { get; set; }

        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string Department { get; set; }

        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string Level { get; set; }

        [Display(Name = "Owned")]
        [Createable(false), Updateable(false)]
        public bool IsOwned { get; set; }

        [Display(Name = "Updated Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? UpdatedDate { get; set; }

    }
}
