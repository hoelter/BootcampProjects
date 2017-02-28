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
    public class PricebookEntry
    {
        [Key]
        [Display(Name = "Price Book Entry ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Product Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Price Book ID")]
        [Updateable(false)]
        public string Pricebook2Id { get; set; }

        [Display(Name = "Product ID")]
        [Updateable(false)]
        public string Product2Id { get; set; }

        [Display(Name = "List Price")]
        public double UnitPrice { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Use Standard Price")]
        public bool UseStandardPrice { get; set; }

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

        [Display(Name = "Product Code")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ProductCode { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

    }
}
