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
    public class OpportunityLineItem
    {
        [Key]
        [Display(Name = "Line Item ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Opportunity ID")]
        [Updateable(false)]
        public string OpportunityId { get; set; }

        [Display(Name = "Sort Order")]
        [Createable(false), Updateable(false)]
        public int? SortOrder { get; set; }

        [Display(Name = "Price Book Entry ID")]
        [Updateable(false)]
        public string PricebookEntryId { get; set; }

        [Display(Name = "Product ID")]
        [Createable(false), Updateable(false)]
        public string Product2Id { get; set; }

        [Display(Name = "Product Code")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ProductCode { get; set; }

        [Display(Name = "Opportunity Product Name")]
        [StringLength(376)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        public double Quantity { get; set; }

        [Display(Name = "Total Price")]
        public double? TotalPrice { get; set; }

        [Display(Name = "Sales Price")]
        public double? UnitPrice { get; set; }

        [Display(Name = "List Price")]
        [Createable(false), Updateable(false)]
        public double? ListPrice { get; set; }

        [Display(Name = "Date")]
        public DateTimeOffset? ServiceDate { get; set; }

        [Display(Name = "Line Description")]
        [StringLength(255)]
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

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

    }
}
