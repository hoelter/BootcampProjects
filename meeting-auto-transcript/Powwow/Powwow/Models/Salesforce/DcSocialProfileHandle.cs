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
    public class DcSocialProfileHandle
    {
        [Key]
        [Display(Name = "System ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "System ID")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ExternalId { get; set; }

        [Display(Name = "System ID")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string DcSocialProfileId { get; set; }

        [Display(Name = "Provider Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ProviderName { get; set; }

        [Display(Name = "Social Handle")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Handle { get; set; }

    }
}
