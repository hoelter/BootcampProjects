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
    public class CollaborationGroupMemberRequest
    {
        [Key]
        [Display(Name = "Group Member Request Id")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "CollaborationGroup ID")]
        [Updateable(false)]
        public string CollaborationGroupId { get; set; }

        [Display(Name = "User ID")]
        [Updateable(false)]
        public string RequesterId { get; set; }

        [Display(Name = "Response Message")]
        [StringLength(255)]
        [Createable(false)]
        public string ResponseMessage { get; set; }

        [Createable(false)]
        public string Status { get; set; }

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
