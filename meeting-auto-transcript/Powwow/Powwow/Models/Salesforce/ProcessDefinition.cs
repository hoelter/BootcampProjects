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
    public class ProcessDefinition
    {
        [Key]
        [Display(Name = "Approval Process ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Unique Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string DeveloperName { get; set; }

        [Display(Name = "Process Definition Type")]
        [Createable(false), Updateable(false)]
        public string Type { get; set; }

        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "Custom Object Definition ID")]
        [Createable(false), Updateable(false)]
        public string TableEnumOrId { get; set; }

        [Display(Name = "Lock Type")]
        [Createable(false), Updateable(false)]
        public string LockType { get; set; }

        [Createable(false), Updateable(false)]
        public string State { get; set; }

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
