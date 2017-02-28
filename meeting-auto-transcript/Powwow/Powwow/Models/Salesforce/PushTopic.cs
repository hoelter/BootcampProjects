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
    public class PushTopic
    {
        [Key]
        [Display(Name = "Push Topic ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Topic Name")]
        [StringLength(25)]
        public string Name { get; set; }

        [Display(Name = "SOQL Query")]
        [StringLength(1300)]
        public string Query { get; set; }

        [Display(Name = "API Version")]
        public double ApiVersion { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Notify For Fields")]
        public string NotifyForFields { get; set; }

        [Display(Name = "Notify For Operations")]
        [Createable(false), Updateable(false)]
        public string NotifyForOperations { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        [Display(Name = "Create")]
        public bool NotifyForOperationCreate { get; set; }

        [Display(Name = "Update")]
        public bool NotifyForOperationUpdate { get; set; }

        [Display(Name = "Delete")]
        public bool NotifyForOperationDelete { get; set; }

        [Display(Name = "Undelete")]
        public bool NotifyForOperationUndelete { get; set; }

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

    }
}
