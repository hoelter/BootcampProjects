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
    public class Report
    {
        [Key]
        [Display(Name = "Report ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Owner ID")]
        [Createable(false), Updateable(false)]
        public string OwnerId { get; set; }

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

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Report Name")]
        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "Report Unique Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string DeveloperName { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

        [Display(Name = "Last Run")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastRunDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Createable(false), Updateable(false)]
        public string Format { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
