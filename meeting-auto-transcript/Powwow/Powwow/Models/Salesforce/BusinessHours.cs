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
    public class BusinessHours
    {
        [Key]
        [Display(Name = "Business Hours ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Business Hours Name")]
        [StringLength(80)]
        public string Name { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Default Business Hours")]
        public bool IsDefault { get; set; }

        [Display(Name = "Sunday Start")]
        public DateTimeOffset? SundayStartTime { get; set; }

        [Display(Name = "Sunday End")]
        public DateTimeOffset? SundayEndTime { get; set; }

        [Display(Name = "Monday Start")]
        public DateTimeOffset? MondayStartTime { get; set; }

        [Display(Name = "Monday End")]
        public DateTimeOffset? MondayEndTime { get; set; }

        [Display(Name = "Tuesday Start")]
        public DateTimeOffset? TuesdayStartTime { get; set; }

        [Display(Name = "Tuesday End")]
        public DateTimeOffset? TuesdayEndTime { get; set; }

        [Display(Name = "Wednesday Start")]
        public DateTimeOffset? WednesdayStartTime { get; set; }

        [Display(Name = "Wednesday End")]
        public DateTimeOffset? WednesdayEndTime { get; set; }

        [Display(Name = "Thursday Start")]
        public DateTimeOffset? ThursdayStartTime { get; set; }

        [Display(Name = "Thursday End")]
        public DateTimeOffset? ThursdayEndTime { get; set; }

        [Display(Name = "Friday Start")]
        public DateTimeOffset? FridayStartTime { get; set; }

        [Display(Name = "Friday End")]
        public DateTimeOffset? FridayEndTime { get; set; }

        [Display(Name = "Saturday Start")]
        public DateTimeOffset? SaturdayStartTime { get; set; }

        [Display(Name = "Saturday End")]
        public DateTimeOffset? SaturdayEndTime { get; set; }

        [Display(Name = "Time Zone")]
        public string TimeZoneSidKey { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

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

    }
}
