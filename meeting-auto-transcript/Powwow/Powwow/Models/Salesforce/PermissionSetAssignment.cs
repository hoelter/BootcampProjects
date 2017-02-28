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
    public class PermissionSetAssignment
    {
        [Key]
        [Display(Name = "PermissionSetAssignment ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "PermissionSet ID")]
        [Updateable(false)]
        public string PermissionSetId { get; set; }

        [Display(Name = "Assignee ID")]
        [Updateable(false)]
        public string AssigneeId { get; set; }

        [Display(Name = "Date Assigned")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
