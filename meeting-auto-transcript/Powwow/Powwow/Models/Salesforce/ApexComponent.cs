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
    public class ApexComponent
    {
        [Key]
        [Display(Name = "Component ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [Display(Name = "Api Version")]
        public double ApiVersion { get; set; }

        [Display(Name = "Label")]
        [StringLength(80)]
        public string MasterLabel { get; set; }

        public string Description { get; set; }

        [Display(Name = "Controller Type")]
        public string ControllerType { get; set; }

        [Display(Name = "Controller Key")]
        [StringLength(255)]
        public string ControllerKey { get; set; }

        public string Markup { get; set; }

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
