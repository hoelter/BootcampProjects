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
    public class DocumentAttachmentMap
    {
        [Key]
        [Display(Name = "Document Entity Map Id")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Entity ID")]
        public string ParentId { get; set; }

        [Display(Name = "Document ID")]
        public string DocumentId { get; set; }

        [Display(Name = "Attachment Sequence")]
        public int DocumentSequence { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

    }
}
