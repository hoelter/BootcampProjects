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
    public class ContentVersion
    {
        [Key]
        [Display(Name = "ContentVersion ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "ContentDocument ID")]
        [Updateable(false)]
        public string ContentDocumentId { get; set; }

        [Display(Name = "Is Latest")]
        [Createable(false), Updateable(false)]
        public bool IsLatest { get; set; }

        [Display(Name = "Content URL")]
        [Url]
        public string ContentUrl { get; set; }

        [Display(Name = "Version Number")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string VersionNumber { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Display(Name = "Reason For Change")]
        [StringLength(1000)]
        public string ReasonForChange { get; set; }

        [Display(Name = "Path On Client")]
        [StringLength(500)]
        [Updateable(false)]
        public string PathOnClient { get; set; }

        [Display(Name = "Rating Count")]
        [Createable(false), Updateable(false)]
        public int? RatingCount { get; set; }

        [Display(Name = "Is Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Content Modified Date")]
        [Updateable(false)]
        public DateTimeOffset? ContentModifiedDate { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string ContentModifiedById { get; set; }

        [Display(Name = "Positive Rating Count")]
        [Createable(false), Updateable(false)]
        public int? PositiveRatingCount { get; set; }

        [Display(Name = "Negative Rating Count")]
        [Createable(false), Updateable(false)]
        public int? NegativeRatingCount { get; set; }

        [Display(Name = "Featured Content Boost")]
        [Createable(false), Updateable(false)]
        public int? FeaturedContentBoost { get; set; }

        [Display(Name = "Featured Content Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? FeaturedContentDate { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Tags")]
        public string TagCsv { get; set; }

        [Display(Name = "File Type")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string FileType { get; set; }

        [Display(Name = "Publish Status")]
        [Createable(false), Updateable(false)]
        public string PublishStatus { get; set; }

        [Display(Name = "Version Data")]
        [Updateable(false)]
        public byte[] VersionData { get; set; }

        [Display(Name = "Size")]
        [Createable(false), Updateable(false)]
        public int? ContentSize { get; set; }

        [Display(Name = "File Extension")]
        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string FileExtension { get; set; }

        [Display(Name = "First Publish Location ID")]
        [Updateable(false)]
        public string FirstPublishLocationId { get; set; }

        [Display(Name = "Content Origin")]
        [Updateable(false)]
        public string Origin { get; set; }

        [Display(Name = "Content Location")]
        [Updateable(false)]
        public string ContentLocation { get; set; }

        [Display(Name = "External Document Info1")]
        [StringLength(1000)]
        public string ExternalDocumentInfo1 { get; set; }

        [Display(Name = "External Document Info2")]
        [StringLength(1000)]
        public string ExternalDocumentInfo2 { get; set; }

        [Display(Name = "External Data Source ID")]
        public string ExternalDataSourceId { get; set; }

        [StringLength(50)]
        [Createable(false), Updateable(false)]
        public string Checksum { get; set; }

        [Display(Name = "Major Version")]
        [Updateable(false)]
        public bool IsMajorVersion { get; set; }

    }
}
