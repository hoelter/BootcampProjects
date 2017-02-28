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
    public class CategoryNode
    {
        [Key]
        [Display(Name = "Category Node ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Parent Category Node ID")]
        public string ParentId { get; set; }

        [Display(Name = "Name")]
        [StringLength(40)]
        public string MasterLabel { get; set; }

        [Display(Name = "Sort Order")]
        public int? SortOrder { get; set; }

        [Display(Name = "Subcategory Sort Style")]
        public string SortStyle { get; set; }

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
