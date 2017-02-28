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
    public class Domain
    {
        [Key]
        [Display(Name = "Domain ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Domain Type")]
        [Createable(false), Updateable(false)]
        public string DomainType { get; set; }

        [Display(Name = "Domain Name")]
        [StringLength(765)]
        [Createable(false), Updateable(false)]
        [JsonProperty("Domain")]
        public string Domain_Property { get; set; }

        [Display(Name = "Enable External HTTPS")]
        [Createable(false), Updateable(false)]
        public bool OptionsExternalHttps { get; set; }

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
