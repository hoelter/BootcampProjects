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
    public class CollaborationInvitation
    {
        [Key]
        [Display(Name = "Chatter Invitation Id")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Parent ID")]
        [Createable(false), Updateable(false)]
        public string ParentId { get; set; }

        [Display(Name = "Shared Entity ID")]
        [Updateable(false)]
        public string SharedEntityId { get; set; }

        [Display(Name = "Inviter User ID")]
        [Createable(false), Updateable(false)]
        public string InviterId { get; set; }

        [Display(Name = "Invited Email")]
        [StringLength(240)]
        [Updateable(false)]
        public string InvitedUserEmail { get; set; }

        [Display(Name = "Invited Email (Normalized)")]
        [EmailAddress]
        [Createable(false), Updateable(false)]
        public string InvitedUserEmailNormalized { get; set; }

        [Display(Name = "Invitation Status")]
        [Createable(false), Updateable(false)]
        public string Status { get; set; }

        [Display(Name = "Optional Message")]
        [StringLength(255)]
        [Updateable(false)]
        public string OptionalMessage { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Modified Date")]
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
