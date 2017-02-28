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
    public class ProcessInstanceWorkitem
    {
        [Key]
        [Display(Name = "Process Instance Workitem ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Process Instance ID")]
        [Createable(false)]
        public string ProcessInstanceId { get; set; }

        [Display(Name = "Original Actor ID")]
        [Createable(false)]
        public string OriginalActorId { get; set; }

        [Display(Name = "Actor ID")]
        [Createable(false)]
        public string ActorId { get; set; }

        [Display(Name = "Elapsed Time in Days")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInDays { get; set; }

        [Display(Name = "Elapsed Time in Hours")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInHours { get; set; }

        [Display(Name = "Elapsed Time in Minutes")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInMinutes { get; set; }

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
