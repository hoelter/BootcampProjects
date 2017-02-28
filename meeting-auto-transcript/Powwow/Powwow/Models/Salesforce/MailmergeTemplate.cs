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
    public class MailmergeTemplate
    {
        [Key]
        [Display(Name = "Mail Merge Template ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Display(Name = "File")]
        [StringLength(255)]
        [Updateable(false)]
        public string Filename { get; set; }

        [Display(Name = "Body Length")]
        [Createable(false), Updateable(false)]
        public int? BodyLength { get; set; }

        [Updateable(false)]
        public byte[] Body { get; set; }

        [Display(Name = "Last Used Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastUsedDate { get; set; }

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

        [Display(Name = "Attachment has been scanned for XSS")]
        public bool SecurityOptionsAttachmentScannedForXSS { get; set; }

        [Display(Name = "XSS threat was detected in the attachment")]
        public bool SecurityOptionsAttachmentHasXSSThreat { get; set; }

        [Display(Name = "Attachment has been scanned for Flash Injection")]
        public bool SecurityOptionsAttachmentScannedforFlash { get; set; }

        [Display(Name = "Flash Injection was detected in the attachment")]
        public bool SecurityOptionsAttachmentHasFlash { get; set; }

    }
}
