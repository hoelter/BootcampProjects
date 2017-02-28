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
    public class ApexTestQueueItem
    {
        [Key]
        [Display(Name = "Apex Test Queue Item ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Class ID")]
        [Updateable(false)]
        public string ApexClassId { get; set; }

        [Createable(false)]
        public string Status { get; set; }

        [Display(Name = "Status Detail")]
        [StringLength(1000)]
        [Createable(false), Updateable(false)]
        public string ExtendedStatus { get; set; }

        [Display(Name = "Apex Job ID")]
        [Createable(false), Updateable(false)]
        public string ParentJobId { get; set; }

    }
}
