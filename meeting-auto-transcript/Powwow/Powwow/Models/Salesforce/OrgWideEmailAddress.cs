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
    public class OrgWideEmailAddress
    {
        [Key]
        [Display(Name = "Organization-wide From Email Address ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Address { get; set; }

        [Display(Name = "Display Name")]
        [StringLength(300)]
        public string DisplayName { get; set; }

        [Display(Name = "Allow All Profiles")]
        public bool IsAllowAllProfiles { get; set; }

    }
}
