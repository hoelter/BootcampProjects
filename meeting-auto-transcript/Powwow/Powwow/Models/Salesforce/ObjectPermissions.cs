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
    public class ObjectPermissions
    {
        [Key]
        [Display(Name = "ObjectPermissions ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Parent ID")]
        [Updateable(false)]
        public string ParentId { get; set; }

        [Display(Name = "Sobject Type Name")]
        [Updateable(false)]
        public string SobjectType { get; set; }

        [Display(Name = "Create Records")]
        public bool PermissionsCreate { get; set; }

        [Display(Name = "Read Records")]
        public bool PermissionsRead { get; set; }

        [Display(Name = "Edit Records")]
        public bool PermissionsEdit { get; set; }

        [Display(Name = "Delete Records")]
        public bool PermissionsDelete { get; set; }

        [Display(Name = "Read All Records")]
        public bool PermissionsViewAllRecords { get; set; }

        [Display(Name = "Edit All Records")]
        public bool PermissionsModifyAllRecords { get; set; }

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
