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
    public class IdeaComment
    {
        [Key]
        [Display(Name = "Idea Comment ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Idea ID")]
        [Updateable(false)]
        public string IdeaId { get; set; }

        [Display(Name = "Zone ID")]
        [Createable(false), Updateable(false)]
        public string CommunityId { get; set; }

        [Display(Name = "Comment Body")]
        public string CommentBody { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Createable(false), Updateable(false)]
        public bool IsHtml { get; set; }

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

        [Display(Name = "Up Votes")]
        [Createable(false), Updateable(false)]
        public int? UpVotes { get; set; }

    }
}
