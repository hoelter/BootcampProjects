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
    public class UserProvisioningRequest
    {
        [Key]
        [Display(Name = "UserProvisioningRequest ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

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

        [Display(Name = "User ID")]
        public string SalesforceUserId { get; set; }

        [Display(Name = "External User Id")]
        [StringLength(150)]
        public string ExternalUserId { get; set; }

        [Display(Name = "App Name")]
        [StringLength(150)]
        public string AppName { get; set; }

        public string State { get; set; }

        public string Operation { get; set; }

        [Display(Name = "Scheduled Provisioning Time")]
        public DateTimeOffset? ScheduleDate { get; set; }

        [Display(Name = "Approval Status")]
        public string ApprovalStatus { get; set; }

        [Display(Name = "User ID")]
        public string ManagerId { get; set; }

    }
}
