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
    public class CronTrigger
    {
        [Key]
        [Display(Name = "Scheduled Job ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Job ID")]
        [Createable(false), Updateable(false)]
        public string CronJobDetailId { get; set; }

        [Display(Name = "Next Run Time")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? NextFireTime { get; set; }

        [Display(Name = "Previous Run Time")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? PreviousFireTime { get; set; }

        [Display(Name = "Job State")]
        [StringLength(16)]
        [Createable(false), Updateable(false)]
        public string State { get; set; }

        [Display(Name = "Start Time")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? StartTime { get; set; }

        [Display(Name = "End Time")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? EndTime { get; set; }

        [Display(Name = "Cron Expression")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string CronExpression { get; set; }

        [Display(Name = "Java Time Zone Id")]
        [Createable(false), Updateable(false)]
        public string TimeZoneSidKey { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Job Fired Count")]
        [Createable(false), Updateable(false)]
        public int? TimesTriggered { get; set; }

    }
}
