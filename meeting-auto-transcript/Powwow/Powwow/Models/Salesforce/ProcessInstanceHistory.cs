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
    public class ProcessInstanceHistory
    {
        [Key]
        [Display(Name = "Process Instance History ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Is Pending")]
        [Createable(false), Updateable(false)]
        public bool IsPending { get; set; }

        [Display(Name = "Process Instance ID")]
        [Createable(false), Updateable(false)]
        public string ProcessInstanceId { get; set; }

        [Display(Name = "Target Object ID")]
        [Createable(false), Updateable(false)]
        public string TargetObjectId { get; set; }

        [Display(Name = "Status")]
        [Createable(false), Updateable(false)]
        public string StepStatus { get; set; }

        [Display(Name = "Original Actor ID")]
        [Createable(false), Updateable(false)]
        public string OriginalActorId { get; set; }

        [Display(Name = "Actor ID")]
        [Createable(false), Updateable(false)]
        public string ActorId { get; set; }

        [Createable(false), Updateable(false)]
        public int? RemindersSent { get; set; }

        [Display(Name = "Elapsed Time in Days")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInDays { get; set; }

        [Display(Name = "Elapsed Time in Hours")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInHours { get; set; }

        [Display(Name = "Elapsed Time in Minutes")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInMinutes { get; set; }

        [StringLength(4000)]
        [Createable(false), Updateable(false)]
        public string Comments { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
