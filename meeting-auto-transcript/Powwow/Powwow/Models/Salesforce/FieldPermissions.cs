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
    public class FieldPermissions
    {
        [Key]
        [Display(Name = "Field Permissions ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Parent ID")]
        [Updateable(false)]
        public string ParentId { get; set; }

        [Display(Name = "Sobject Type Name")]
        [Updateable(false)]
        public string SobjectType { get; set; }

        [Display(Name = "Field Name")]
        [Updateable(false)]
        public string Field { get; set; }

        [Display(Name = "Edit Field")]
        public bool PermissionsEdit { get; set; }

        [Display(Name = "Read Field")]
        public bool PermissionsRead { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
