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
    public class ProcessNode
    {
        [Key]
        [Display(Name = "Process Node ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Unique Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string DeveloperName { get; set; }

        [Display(Name = "Approval Process ID")]
        [Createable(false), Updateable(false)]
        public string ProcessDefinitionId { get; set; }

        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
