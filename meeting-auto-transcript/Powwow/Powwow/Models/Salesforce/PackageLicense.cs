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
    public class PackageLicense
    {
        [Key]
        [Display(Name = "Package License ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Createable(false), Updateable(false)]
        public string Status { get; set; }

        [Display(Name = "Is Provisioned")]
        [Createable(false), Updateable(false)]
        public bool IsProvisioned { get; set; }

        [Display(Name = "Allowed Licenses")]
        [Createable(false), Updateable(false)]
        public int AllowedLicenses { get; set; }

        [Display(Name = "Used Licenses")]
        [Createable(false), Updateable(false)]
        public int UsedLicenses { get; set; }

        [Display(Name = "Expiration Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? ExpirationDate { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

    }
}
