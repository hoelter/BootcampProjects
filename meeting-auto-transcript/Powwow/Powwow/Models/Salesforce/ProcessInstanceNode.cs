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
    public class ProcessInstanceNode
    {
        [Key]
        [Display(Name = "Process Instance Node ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

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

        [Display(Name = "Process Instance ID")]
        [Createable(false), Updateable(false)]
        public string ProcessInstanceId { get; set; }

        [Display(Name = "Process Node ID")]
        [Createable(false), Updateable(false)]
        public string ProcessNodeId { get; set; }

        [Display(Name = "Node Status")]
        [Createable(false), Updateable(false)]
        public string NodeStatus { get; set; }

        [Display(Name = "Completed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? CompletedDate { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string LastActorId { get; set; }

        [Display(Name = "Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ProcessNodeName { get; set; }

        [Display(Name = "Elapsed Time in Days")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInDays { get; set; }

        [Display(Name = "Elapsed Time in Hours")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInHours { get; set; }

        [Display(Name = "Elapsed Time in Minutes")]
        [Createable(false), Updateable(false)]
        public double? ElapsedTimeInMinutes { get; set; }

    }
}
