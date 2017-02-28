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
    public class TenantUsageEntitlement
    {
        [Key]
        [Display(Name = "Tenant Usage Entitlement ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

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

        [Display(Name = "Resource Group Key")]
        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string ResourceGroupKey { get; set; }

        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string Setting { get; set; }

        [Display(Name = "Start Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset StartDate { get; set; }

        [Display(Name = "End Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? EndDate { get; set; }

        [Display(Name = "Current Amount Allowed")]
        [Createable(false), Updateable(false)]
        public double CurrentAmountAllowed { get; set; }

        [Createable(false), Updateable(false)]
        public string Frequency { get; set; }

        [Display(Name = "Is Persistent Resource")]
        [Createable(false), Updateable(false)]
        public bool IsPersistentResource { get; set; }

        [Display(Name = "Has Rollover")]
        [Createable(false), Updateable(false)]
        public bool HasRollover { get; set; }

        [Display(Name = "Overage Grace")]
        [Createable(false), Updateable(false)]
        public double? OverageGrace { get; set; }

        [Display(Name = "Amount Used")]
        [Createable(false), Updateable(false)]
        public double? AmountUsed { get; set; }

        [Display(Name = "Usage Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? UsageDate { get; set; }

        [Display(Name = "Setting Label")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MasterLabel { get; set; }

    }
}
