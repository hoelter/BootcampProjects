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
    public class ApexTrigger
    {
        [Key]
        [Display(Name = "Trigger ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Custom Object Definition ID")]
        public string TableEnumOrId { get; set; }

        [Display(Name = "BeforeInsert")]
        public bool UsageBeforeInsert { get; set; }

        [Display(Name = "AfterInsert")]
        public bool UsageAfterInsert { get; set; }

        [Display(Name = "BeforeUpdate")]
        public bool UsageBeforeUpdate { get; set; }

        [Display(Name = "AfterUpdate")]
        public bool UsageAfterUpdate { get; set; }

        [Display(Name = "BeforeDelete")]
        public bool UsageBeforeDelete { get; set; }

        [Display(Name = "AfterDelete")]
        public bool UsageAfterDelete { get; set; }

        [Display(Name = "IsBulk")]
        public bool UsageIsBulk { get; set; }

        [Display(Name = "AfterUndelete")]
        public bool UsageAfterUndelete { get; set; }

        [Display(Name = "Api Version")]
        public double ApiVersion { get; set; }

        public string Status { get; set; }

        [Display(Name = "Is Valid")]
        public bool IsValid { get; set; }

        [Display(Name = "Body CRC")]
        public double? BodyCrc { get; set; }

        public string Body { get; set; }

        [Display(Name = "Size Without Comments")]
        public int LengthWithoutComments { get; set; }

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
