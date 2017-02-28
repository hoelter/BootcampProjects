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
    public class SetupEntityAccess
    {
        [Key]
        [Display(Name = "SetupEntityAccess ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Parent ID")]
        [Updateable(false)]
        public string ParentId { get; set; }

        [Display(Name = "Setup Entity ID")]
        [Updateable(false)]
        public string SetupEntityId { get; set; }

        [Display(Name = "Setup Entity Type")]
        [Createable(false), Updateable(false)]
        public string SetupEntityType { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
