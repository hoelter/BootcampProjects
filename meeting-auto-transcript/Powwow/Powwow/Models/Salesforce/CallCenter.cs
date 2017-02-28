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
    public class CallCenter
    {
        [Key]
        [Display(Name = "Call Center ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [StringLength(255)]
        [Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Internal Name")]
        [StringLength(240)]
        [Updateable(false)]
        public string InternalName { get; set; }

        [Updateable(false)]
        public double? Version { get; set; }

        [Display(Name = "CTI Adapter URL")]
        [StringLength(2000)]
        [Updateable(false)]
        public string AdapterUrl { get; set; }

        [Display(Name = "Custom Settings")]
        [StringLength(3000)]
        [Updateable(false)]
        public string CustomSettings { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

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

    }
}
