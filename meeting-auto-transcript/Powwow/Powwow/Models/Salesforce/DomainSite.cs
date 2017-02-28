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
    public class DomainSite
    {
        [Key]
        [Display(Name = "Custom URL ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Domain ID")]
        [Createable(false), Updateable(false)]
        public string DomainId { get; set; }

        [Display(Name = "Site ID")]
        [Createable(false), Updateable(false)]
        public string SiteId { get; set; }

        [Display(Name = "Path")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string PathPrefix { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
