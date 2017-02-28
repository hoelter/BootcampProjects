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
    public class DatacloudPurchaseUsage
    {
        [Key]
        [Display(Name = "Data.com Usage ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Sequence ID")]
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
        [Createable(false), Updateable(false)]
        public string UserId { get; set; }

        [Display(Name = "Data.com Usage Type")]
        [Createable(false), Updateable(false)]
        public string UserType { get; set; }

        [Display(Name = "Data.com Purchase Type")]
        [Createable(false), Updateable(false)]
        public string PurchaseType { get; set; }

        [Display(Name = "Data.com Object Type")]
        [Createable(false), Updateable(false)]
        public string DatacloudEntityType { get; set; }

        [Display(Name = "Purchase Count")]
        [Createable(false), Updateable(false)]
        public double Usage { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Description { get; set; }

    }
}
