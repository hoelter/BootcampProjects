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
    public class Event
    {
        [Key]
        [Display(Name = "Activity ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        //specific contact and maybe lead who the event is assigned with
        [Display(Name = "Name ID")] 
        public string WhoId { get; set; }

        [Display(Name = "Related To ID")]
        public string WhatId { get; set; }

        public string Subject { get; set; }

        [StringLength(255)]
        public string Location { get; set; }

        [Display(Name = "All-Day Event")]
        public bool IsAllDayEvent { get; set; }

        [Display(Name = "Due Date Time")]
        public DateTimeOffset? ActivityDateTime { get; set; }

        [Display(Name = "Due Date Only")]
        public DateTimeOffset? ActivityDate { get; set; }

        [Display(Name = "Duration")]
        public int? DurationInMinutes { get; set; }

        [Display(Name = "Start Date Time")]
        public DateTimeOffset? StartDateTime { get; set; }

        [Display(Name = "End Date Time")]
        public DateTimeOffset? EndDateTime { get; set; }

        public string Description { get; set; }

        [Display(Name = "Account ID")]
        [Createable(false), Updateable(false)]
        public string AccountId { get; set; }

        //me or user logged in
        [Display(Name = "Assigned To ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Private")]
        public bool IsPrivate { get; set; }

        [Display(Name = "Show Time As")]
        public string ShowAs { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Is Child")]
        [Createable(false), Updateable(false)]
        public bool IsChild { get; set; }

        [Display(Name = "Is Group Event")]
        [Createable(false), Updateable(false)]
        public bool IsGroupEvent { get; set; }

        [Display(Name = "Group Event Type")]
        [Createable(false), Updateable(false)]
        public string GroupEventType { get; set; }

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

        [Display(Name = "Recurrence Activity ID")]
        [Createable(false), Updateable(false)]
        public string RecurrenceActivityId { get; set; }

        [Display(Name = "Create Recurring Series of Events")]
        [Updateable(false)]
        public bool IsRecurrence { get; set; }

        [Display(Name = "Start Date")]
        public DateTimeOffset? RecurrenceStartDateTime { get; set; }

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

        [Display(Name = "Reminder Date/Time")]
        public DateTimeOffset? ReminderDateTime { get; set; }

        [Display(Name = "Reminder Set")]
        public bool IsReminderSet { get; set; }

    }
}
