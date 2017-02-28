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
    public class Document
    {
        [Key]
        [Display(Name = "Document ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Folder ID")]
        public string FolderId { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Document Name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Document Unique Name")]
        [StringLength(80)]
        public string DeveloperName { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

        [Display(Name = "MIME Type")]
        [StringLength(120)]
        public string ContentType { get; set; }

        [Display(Name = "File Extension")]
        [StringLength(40)]
        public string Type { get; set; }

        [Display(Name = "Externally Available")]
        public bool IsPublic { get; set; }

        [Display(Name = "Body Length")]
        [Createable(false), Updateable(false)]
        public int BodyLength { get; set; }

        public byte[] Body { get; set; }

        [StringLength(255)]
        public string Url { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string Keywords { get; set; }

        [Display(Name = "Internal Use Only")]
        public bool IsInternalUseOnly { get; set; }

        [Display(Name = "Author ID")]
        public string AuthorId { get; set; }

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

        [Display(Name = "Document Content Searchable")]
        [Createable(false), Updateable(false)]
        public bool IsBodySearchable { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
