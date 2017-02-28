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
    public class ProcessInstance
    {
        [Key]
        [Display(Name = "Process Instance ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Approval Process ID")]
        [Createable(false), Updateable(false)]
        public string ProcessDefinitionId { get; set; }

        [Display(Name = "Target Object ID")]
        [Createable(false), Updateable(false)]
        public string TargetObjectId { get; set; }

        [Createable(false), Updateable(false)]
        public string Status { get; set; }

        [Display(Name = "Completed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? CompletedDate { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string LastActorId { get; set; }

        [Display(Name = "Elapsed Time in Days")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInDays { get; set; }

        [Display(Name = "Elapsed Time in Hours")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInHours { get; set; }

        [Display(Name = "Elapsed Time in Minutes")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInMinutes { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string SubmittedById { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

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
