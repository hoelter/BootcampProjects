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
    public class DatacloudSocialHandle
    {
        [Key]
        [Display(Name = "Data.com Social Handle ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Data.com Contact ID")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ExternalId { get; set; }

        [Display(Name = "System ID")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string DatacloudContactId { get; set; }

        [Display(Name = "Social ID")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string SocialId { get; set; }

        [Display(Name = "Provider")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ProviderName { get; set; }

        [Url]
        [Createable(false), Updateable(false)]
        public string Url { get; set; }

    }
}
