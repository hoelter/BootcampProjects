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
    public class Asset
    {
        [Key]
        [Display(Name = "Asset ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Contact ID")]
        public string ContactId { get; set; }

        [Display(Name = "Account ID")]
        public string AccountId { get; set; }

        [Display(Name = "Product ID")]
        public string Product2Id { get; set; }

        [Display(Name = "Competitor Asset")]
        public bool IsCompetitorProduct { get; set; }

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

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Asset Name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Serial Number")]
        [StringLength(80)]
        public string SerialNumber { get; set; }

        [Display(Name = "Install Date")]
        public DateTimeOffset? InstallDate { get; set; }

        [Display(Name = "Purchase Date")]
        public DateTimeOffset? PurchaseDate { get; set; }

        [Display(Name = "Usage End Date")]
        public DateTimeOffset? UsageEndDate { get; set; }

        public string Status { get; set; }

        public double? Price { get; set; }

        public double? Quantity { get; set; }

        public string Description { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
