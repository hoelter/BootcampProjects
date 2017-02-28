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
    public class OrderItem
    {
        [Key]
        [Display(Name = "Order Product ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Order ID")]
        [Updateable(false)]
        public string OrderId { get; set; }

        [Display(Name = "Price Book Entry ID")]
        [Updateable(false)]
        public string PricebookEntryId { get; set; }

        [Display(Name = "Original Order Item ID")]
        [Updateable(false)]
        public string OriginalOrderItemId { get; set; }

        [Display(Name = "Available Quantity")]
        [Createable(false), Updateable(false)]
        public double? AvailableQuantity { get; set; }

        public double Quantity { get; set; }

        [Display(Name = "Unit Price")]
        public double? UnitPrice { get; set; }

        [Display(Name = "List Price")]
        [Createable(false), Updateable(false)]
        public double? ListPrice { get; set; }

        [Display(Name = "Start Date")]
        public DateTimeOffset? ServiceDate { get; set; }

        [Display(Name = "End Date")]
        public DateTimeOffset? EndDate { get; set; }

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

        [Display(Name = "Order Product Number")]
        [StringLength(30)]
        [Createable(false), Updateable(false)]
        public string OrderItemNumber { get; set; }

    }
}
