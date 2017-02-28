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
    public class Idea
    {
        [Key]
        [Display(Name = "Idea ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [Display(Name = "Record Type ID")]
        [Createable(false), Updateable(false)]
        public string RecordTypeId { get; set; }

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

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Zone ID")]
        [Updateable(false)]
        public string CommunityId { get; set; }

        [Display(Name = "Idea Body")]
        public string Body { get; set; }

        [Display(Name = "Number of Comments")]
        [Createable(false), Updateable(false)]
        public int? NumComments { get; set; }

        [Display(Name = "Vote Score")]
        [Createable(false), Updateable(false)]
        public double? VoteScore { get; set; }

        [Display(Name = "Vote Total")]
        [Createable(false), Updateable(false)]
        public double? VoteTotal { get; set; }

        public string Categories { get; set; }

        public string Status { get; set; }

        [Display(Name = "Last Idea Comment Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastCommentDate { get; set; }

        [Display(Name = "Idea Comment ID")]
        [Createable(false), Updateable(false)]
        public string LastCommentId { get; set; }

        [Display(Name = "Idea ID")]
        [Createable(false), Updateable(false)]
        public string ParentIdeaId { get; set; }

        [Createable(false), Updateable(false)]
        public bool IsHtml { get; set; }

        [Display(Name = "Is Merged")]
        [Createable(false), Updateable(false)]
        public bool IsMerged { get; set; }

        [Display(Name = "Url of Creator's Profile Photo")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string CreatorFullPhotoUrl { get; set; }

        [Display(Name = "Url of Creator's Thumbnail Photo")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string CreatorSmallPhotoUrl { get; set; }

        [Display(Name = "Name of Creator")]
        [StringLength(121)]
        [Createable(false), Updateable(false)]
        public string CreatorName { get; set; }

    }
}
