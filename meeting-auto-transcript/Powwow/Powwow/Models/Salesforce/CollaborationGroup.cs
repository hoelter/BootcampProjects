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
    public class CollaborationGroup
    {
        [Key]
        [Display(Name = "Group Id")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [Display(Name = "Member Count")]
        [Createable(false), Updateable(false)]
        public int? MemberCount { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Access Type")]
        public string CollaborationType { get; set; }

        public string Description { get; set; }

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

        [Display(Name = "Url for full-sized Photo")]
        [Url]
        [Createable(false), Updateable(false)]
        public string FullPhotoUrl { get; set; }

        [Display(Name = "Photo")]
        [Url]
        [Createable(false), Updateable(false)]
        public string SmallPhotoUrl { get; set; }

        [Display(Name = "Last Feed Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastFeedModifiedDate { get; set; }

        [Display(Name = "Information Title")]
        [StringLength(30)]
        public string InformationTitle { get; set; }

        [Display(Name = "Information")]
        public string InformationBody { get; set; }

        [Display(Name = "Has Private Fields Access")]
        [Createable(false), Updateable(false)]
        public bool HasPrivateFieldsAccess { get; set; }

        [Display(Name = "Allow Customers")]
        public bool CanHaveGuests { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Archive")]
        public bool IsArchived { get; set; }

        [Display(Name = "Disable Automatic Archiving")]
        public bool IsAutoArchiveDisabled { get; set; }

        [Display(Name = "Announcement ID")]
        public string AnnouncementId { get; set; }

        [Display(Name = "Group Email")]
        [EmailAddress]
        [Createable(false), Updateable(false)]
        public string GroupEmail { get; set; }

    }
}
