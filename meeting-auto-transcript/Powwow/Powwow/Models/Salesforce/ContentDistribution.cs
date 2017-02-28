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
    public class ContentDistribution
    {
        [Key]
        [Display(Name = "Content Delivery ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Content Delivery Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "ContentVersion ID")]
        [Updateable(false)]
        public string ContentVersionId { get; set; }

        [Display(Name = "ContentDocument ID")]
        [Createable(false), Updateable(false)]
        public string ContentDocumentId { get; set; }

        [Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; set; }

        [Display(Name = "Allow Download as PDF")]
        public bool PreferencesAllowPDFDownload { get; set; }

        [Display(Name = "Allow Download in Original Format")]
        public bool PreferencesAllowOriginalDownload { get; set; }

        [Display(Name = "Require Password to Access Content")]
        public bool PreferencesPasswordRequired { get; set; }

        [Display(Name = "Notify Me of First View or Download")]
        public bool PreferencesNotifyOnVisit { get; set; }

        [Display(Name = "Content Delivery Opens Latest Version")]
        public bool PreferencesLinkLatestVersion { get; set; }

        [Display(Name = "Allow View in the Browser")]
        public bool PreferencesAllowViewInBrowser { get; set; }

        [Display(Name = "Content Delivery Expires")]
        public bool PreferencesExpires { get; set; }

        [Display(Name = "Email when Preview Images are Ready")]
        public bool PreferencesNotifyRndtnComplete { get; set; }

        [Display(Name = "Expiration Date")]
        public DateTimeOffset? ExpiryDate { get; set; }

        [StringLength(36)]
        [Createable(false), Updateable(false)]
        public string Password { get; set; }

        [Display(Name = "View Count")]
        [Createable(false), Updateable(false)]
        public int? ViewCount { get; set; }

        [Display(Name = "First Viewed")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? FirstViewDate { get; set; }

        [Display(Name = "Last Viewed")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewDate { get; set; }

        [Display(Name = "External Link")]
        [StringLength(256)]
        [Createable(false), Updateable(false)]
        public string DistributionPublicUrl { get; set; }

    }
}
