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
    public class EventLogFile
    {
        [Key]
        [Display(Name = "Event Log File ID")]
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

        [Display(Name = "Event Type")]
        [Createable(false), Updateable(false)]
        public string EventType { get; set; }

        [Display(Name = "Log Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LogDate { get; set; }

        [Display(Name = "Log File Length")]
        [Createable(false), Updateable(false)]
        public double LogFileLength { get; set; }

        [Display(Name = "Log File Content Type")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string LogFileContentType { get; set; }

        [Display(Name = "API Version")]
        [Createable(false), Updateable(false)]
        public double ApiVersion { get; set; }

        [Display(Name = "Log File Field Names")]
        [StringLength(1333)]
        [Createable(false), Updateable(false)]
        public string LogFileFieldNames { get; set; }

        [Display(Name = "Log File Field Types")]
        [StringLength(1333)]
        [Createable(false), Updateable(false)]
        public string LogFileFieldTypes { get; set; }

        [Display(Name = "Log File")]
        [Createable(false), Updateable(false)]
        public byte[] LogFile { get; set; }

    }
}
