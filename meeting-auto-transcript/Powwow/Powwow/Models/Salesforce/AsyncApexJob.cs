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
    public class AsyncApexJob
    {
        [Key]
        [Display(Name = "Apex Job ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Job Type")]
        [Createable(false), Updateable(false)]
        public string JobType { get; set; }

        [Display(Name = "Class ID")]
        [Createable(false), Updateable(false)]
        public string ApexClassId { get; set; }

        [Createable(false), Updateable(false)]
        public string Status { get; set; }

        [Display(Name = "Batches Processed")]
        [Createable(false), Updateable(false)]
        public int JobItemsProcessed { get; set; }

        [Display(Name = "Total Batches")]
        [Createable(false), Updateable(false)]
        public int? TotalJobItems { get; set; }

        [Display(Name = "Failures")]
        [Createable(false), Updateable(false)]
        public int? NumberOfErrors { get; set; }

        [Display(Name = "Completion Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? CompletedDate { get; set; }

        [Display(Name = "Apex Method")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MethodName { get; set; }

        [Display(Name = "Status Detail")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ExtendedStatus { get; set; }

        [Display(Name = "Apex Job ID")]
        [Createable(false), Updateable(false)]
        public string ParentJobId { get; set; }

        [Display(Name = "Last ID processed and committed")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string LastProcessed { get; set; }

        [Display(Name = "Offset of last ID processed and committed")]
        [Createable(false), Updateable(false)]
        public int? LastProcessedOffset { get; set; }

    }
}
