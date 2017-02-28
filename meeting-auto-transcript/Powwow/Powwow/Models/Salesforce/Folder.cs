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
    public class Folder
    {
        [Key]
        [Display(Name = "Folder ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [Display(Name = "Folder Unique Name")]
        [StringLength(80)]
        public string DeveloperName { get; set; }

        [Display(Name = "Access Type")]
        public string AccessType { get; set; }

        [Display(Name = "Read Only")]
        public bool IsReadonly { get; set; }

        [Updateable(false)]
        public string Type { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

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
