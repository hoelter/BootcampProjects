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
    public class DatacloudOwnedEntity
    {
        [Key]
        [Display(Name = "Data.com Owned Entity ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Description")]
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

        [Display(Name = "Data.com key")]
        [StringLength(25)]
        [Createable(false), Updateable(false)]
        public string DataDotComKey { get; set; }

        [Display(Name = "Data.com Object Type")]
        [Createable(false), Updateable(false)]
        public string DatacloudEntityType { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string UserId { get; set; }

        [Display(Name = "Data.com Usage ID")]
        [Createable(false), Updateable(false)]
        public string PurchaseUsageId { get; set; }

        [Display(Name = "Data.com Purchase Type")]
        [Createable(false), Updateable(false)]
        public string PurchaseType { get; set; }

    }
}
