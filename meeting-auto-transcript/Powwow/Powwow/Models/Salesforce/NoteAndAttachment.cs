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
    public class NoteAndAttachment
    {
        [Key]
        [Display(Name = "Note or Attachment Id")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Is Note")]
        [Createable(false), Updateable(false)]
        public bool IsNote { get; set; }

        [Display(Name = "Parent ID")]
        [Createable(false), Updateable(false)]
        public string ParentId { get; set; }

        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Title { get; set; }

        [Display(Name = "Private")]
        [Createable(false), Updateable(false)]
        public bool IsPrivate { get; set; }

        [Display(Name = "Owner ID")]
        [Createable(false), Updateable(false)]
        public string OwnerId { get; set; }

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

    }
}
