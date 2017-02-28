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
    public class CustomObjectUserLicenseMetrics
    {
        [Key]
        [Display(Name = "Custom Object Usage By User License Metrics Id")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Metrics Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset MetricsDate { get; set; }

        [Display(Name = "User License ID")]
        [Createable(false), Updateable(false)]
        public string UserLicenseId { get; set; }

        [Display(Name = "Custom Object Id")]
        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string CustomObjectId { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Custom Object Type")]
        [Createable(false), Updateable(false)]
        public string CustomObjectType { get; set; }

        [Display(Name = "Custom Object Name")]
        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string CustomObjectName { get; set; }

        [Display(Name = "Count of Objects assigned")]
        [Createable(false), Updateable(false)]
        public int? ObjectCount { get; set; }

    }
}
