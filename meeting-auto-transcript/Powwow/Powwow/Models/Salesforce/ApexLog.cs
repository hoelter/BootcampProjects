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
    public class ApexLog
    {
        [Key]
        [Display(Name = "Log ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Log User ID")]
        [Createable(false), Updateable(false)]
        public string LogUserId { get; set; }

        [Display(Name = "Log Size (bytes)")]
        [Createable(false), Updateable(false)]
        public int LogLength { get; set; }

        [Display(Name = "Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Request Type")]
        [StringLength(16)]
        [Createable(false), Updateable(false)]
        public string Request { get; set; }

        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string Operation { get; set; }

        [StringLength(64)]
        [Createable(false), Updateable(false)]
        public string Application { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Status { get; set; }

        [Display(Name = "Duration (ms)")]
        [Createable(false), Updateable(false)]
        public int DurationMilliseconds { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Start Time")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset StartTime { get; set; }

        [Createable(false), Updateable(false)]
        public string Location { get; set; }

    }
}
