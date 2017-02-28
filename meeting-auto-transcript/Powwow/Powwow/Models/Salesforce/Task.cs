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
    public class Task
    {
        [Key]
        [Display(Name = "Activity ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Name ID")]
        public string WhoId { get; set; }

        [Display(Name = "Related To ID")]
        public string WhatId { get; set; }

        public string Subject { get; set; }

        [Display(Name = "Due Date Only")]
        public DateTimeOffset? ActivityDate { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }

        [Display(Name = "High Priority")]
        [Createable(false), Updateable(false)]
        public bool IsHighPriority { get; set; }

        [Display(Name = "Assigned To ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        public string Description { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Account ID")]
        [Createable(false), Updateable(false)]
        public string AccountId { get; set; }

        [Display(Name = "Closed")]
        [Createable(false), Updateable(false)]
        public bool IsClosed { get; set; }

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

        [Display(Name = "Archived")]
        [Createable(false), Updateable(false)]
        public bool IsArchived { get; set; }

        [Display(Name = "Call Duration")]
        public int? CallDurationInSeconds { get; set; }

        [Display(Name = "Call Type")]
        public string CallType { get; set; }

        [Display(Name = "Call Result")]
        [StringLength(255)]
        public string CallDisposition { get; set; }

        [Display(Name = "Call Object Identifier")]
        [StringLength(255)]
        public string CallObject { get; set; }

        [Display(Name = "Reminder Date/Time")]
        public DateTimeOffset? ReminderDateTime { get; set; }

        [Display(Name = "Reminder Set")]
        public bool IsReminderSet { get; set; }

        [Display(Name = "Recurrence Activity ID")]
        [Createable(false), Updateable(false)]
        public string RecurrenceActivityId { get; set; }

        [Display(Name = "Create Recurring Series of Tasks")]
        [Updateable(false)]
        public bool IsRecurrence { get; set; }

        [Display(Name = "Start Date")]
        public DateTimeOffset? RecurrenceStartDateOnly { get; set; }

        [Display(Name = "End Date")]
        public DateTimeOffset? RecurrenceEndDateOnly { get; set; }

        [Display(Name = "Recurrence Time Zone")]
        public string RecurrenceTimeZoneSidKey { get; set; }

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

        [Display(Name = "Repeat This Task")]
        public string RecurrenceRegeneratedType { get; set; }

    }
}
