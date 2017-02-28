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
    public class AttachedContentDocument
    {
        [Key]
        [Display(Name = "Content Document Link Id")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Parent ID")]
        [Createable(false), Updateable(false)]
        public string LinkedEntityId { get; set; }

        [Display(Name = "ContentDocument ID")]
        [Createable(false), Updateable(false)]
        public string ContentDocumentId { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Title { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "Content Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "File Type")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string FileType { get; set; }

        [Display(Name = "Content Size")]
        [Createable(false), Updateable(false)]
        public int? ContentSize { get; set; }

        [Display(Name = "File Extension")]
        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string FileExtension { get; set; }

        [Display(Name = "Content URL")]
        [Url]
        [Createable(false), Updateable(false)]
        public string ContentUrl { get; set; }

        [Display(Name = "External Data Source")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string ExternalDataSourceName { get; set; }

    }
}
