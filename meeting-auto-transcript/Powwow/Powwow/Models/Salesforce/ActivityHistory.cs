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
    public class ActivityHistory
    {
        [Key]
        [Display(Name = "Activity ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Account ID")]
        [Createable(false), Updateable(false)]
        public string AccountId { get; set; }

        [Display(Name = "Name ID")]
        [Createable(false), Updateable(false)]
        public string WhoId { get; set; }

        [Display(Name = "Related To ID")]
        [Createable(false), Updateable(false)]
        public string WhatId { get; set; }

        [Createable(false), Updateable(false)]
        public string Subject { get; set; }

        [Display(Name = "Task")]
        [Createable(false), Updateable(false)]
        public bool IsTask { get; set; }

        [Display(Name = "Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? ActivityDate { get; set; }

        [Display(Name = "Assigned To ID")]
        [Createable(false), Updateable(false)]
        public string OwnerId { get; set; }

        [Createable(false), Updateable(false)]
        public string Status { get; set; }

        [Createable(false), Updateable(false)]
        public string Priority { get; set; }

        [Display(Name = "High Priority")]
        [Createable(false), Updateable(false)]
        public bool IsHighPriority { get; set; }

        [Display(Name = "Type")]
        [Createable(false), Updateable(false)]
        public string ActivityType { get; set; }

        [Display(Name = "Closed")]
        [Createable(false), Updateable(false)]
        public bool IsClosed { get; set; }

        [Display(Name = "All-Day Event")]
        [Createable(false), Updateable(false)]
        public bool IsAllDayEvent { get; set; }

        [Display(Name = "Public")]
        [Createable(false), Updateable(false)]
        public bool IsVisibleInSelfService { get; set; }

        [Display(Name = "Duration")]
        [Createable(false), Updateable(false)]
        public int? DurationInMinutes { get; set; }

        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Location { get; set; }

        [Display(Name = "Comments")]
        [Createable(false), Updateable(false)]
        public string Description { get; set; }

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

        [Display(Name = "Call Duration")]
        [Createable(false), Updateable(false)]
        public int? CallDurationInSeconds { get; set; }

        [Display(Name = "Call Type")]
        [Createable(false), Updateable(false)]
        public string CallType { get; set; }

        [Display(Name = "Call Result")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string CallDisposition { get; set; }

        [Display(Name = "Call Object Identifier")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string CallObject { get; set; }

        [Display(Name = "Reminder Date/Time")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? ReminderDateTime { get; set; }

        [Display(Name = "Reminder Set")]
        [Createable(false), Updateable(false)]
        public bool IsReminderSet { get; set; }

        [Display(Name = "End")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? EndDateTime { get; set; }

        [Display(Name = "Start")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? StartDateTime { get; set; }

    }
}
