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
    public class ApexTestResult
    {
        [Key]
        [Display(Name = "Apex Test Result ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Time Started")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset TestTimestamp { get; set; }

        [Display(Name = "Pass/Fail")]
        [Createable(false), Updateable(false)]
        public string Outcome { get; set; }

        [Display(Name = "Class ID")]
        [Createable(false), Updateable(false)]
        public string ApexClassId { get; set; }

        [Display(Name = "Method Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MethodName { get; set; }

        [Display(Name = "Error Message")]
        [StringLength(4000)]
        [Createable(false), Updateable(false)]
        public string Message { get; set; }

        [Display(Name = "Stack Trace")]
        [StringLength(4000)]
        [Createable(false), Updateable(false)]
        public string StackTrace { get; set; }

        [Display(Name = "Apex Job ID")]
        [Createable(false), Updateable(false)]
        public string AsyncApexJobId { get; set; }

        [Display(Name = "Apex Test Queue Item ID")]
        [Createable(false), Updateable(false)]
        public string QueueItemId { get; set; }

        [Display(Name = "Log ID")]
        [Createable(false), Updateable(false)]
        public string ApexLogId { get; set; }

    }
}
