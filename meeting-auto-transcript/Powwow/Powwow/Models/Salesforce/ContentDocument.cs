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
    public class ContentDocument
    {
        [Key]
        [Display(Name = "ContentDocument ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Is Archived")]
        [Createable(false)]
        public bool IsArchived { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string ArchivedById { get; set; }

        [Display(Name = "Archived Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? ArchivedDate { get; set; }

        [Display(Name = "Is Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Owner ID")]
        [Createable(false), Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Title { get; set; }

        [Display(Name = "Publish Status")]
        [Createable(false), Updateable(false)]
        public string PublishStatus { get; set; }

        [Display(Name = "Latest Published Version ID")]
        [Createable(false), Updateable(false)]
        public string LatestPublishedVersionId { get; set; }

        [Display(Name = "Parent ID")]
        [Createable(false)]
        public string ParentId { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "Size")]
        [Createable(false), Updateable(false)]
        public int? ContentSize { get; set; }

        [Display(Name = "File Type")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string FileType { get; set; }

        [Display(Name = "File Extension")]
        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string FileExtension { get; set; }

        [Display(Name = "Content Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? ContentModifiedDate { get; set; }

    }
}
