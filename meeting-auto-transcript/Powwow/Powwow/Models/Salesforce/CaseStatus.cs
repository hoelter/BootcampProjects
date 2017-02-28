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
    public class CaseStatus
    {
        [Key]
        [Display(Name = "Case Status Value ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Master Label")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MasterLabel { get; set; }

        [Display(Name = "Sort Order")]
        [Createable(false), Updateable(false)]
        public int? SortOrder { get; set; }

        [Display(Name = "Is Default")]
        [Createable(false), Updateable(false)]
        public bool IsDefault { get; set; }

        [Display(Name = "Is Closed")]
        [Createable(false), Updateable(false)]
        public bool IsClosed { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
