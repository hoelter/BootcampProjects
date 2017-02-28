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
    public class Holiday
    {
        [Key]
        [Display(Name = "Holiday ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Holiday Name")]
        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Display(Name = "All Day")]
        public bool IsAllDay { get; set; }

        [Display(Name = "Holiday Date")]
        public DateTimeOffset? ActivityDate { get; set; }

        [Display(Name = "Start Time In Minutes From Midnight")]
        public int? StartTimeInMinutes { get; set; }

        [Display(Name = "End Time In Minutes From Midnight")]
        public int? EndTimeInMinutes { get; set; }

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

        [Display(Name = "Recurring Holiday")]
        public bool IsRecurrence { get; set; }

        [Display(Name = "Start Date")]
        public DateTimeOffset? RecurrenceStartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTimeOffset? RecurrenceEndDateOnly { get; set; }

        [Display(Name = "Recurrence Type")]
        public string RecurrenceType { get; set; }

        [Display(Name = "Recurrence Interval")]
        public int? RecurrenceInterval { get; set; }

        [Display(Name = "Recurrence Day of Week Mask")]
        public int? RecurrenceDayOfWeekMask { get; set; }

        [Display(Name = "Recurrence Day of Month")]
        public int? RecurrenceDayOfMonth { get; set; }

        [Display(Name = "Recurrence Instance")]
        public string RecurrenceInstance { get; set; }

        [Display(Name = "Recurrence Month of Year")]
        public string RecurrenceMonthOfYear { get; set; }

    }
}
