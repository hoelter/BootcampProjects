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
    public class SecureAgentPlugin
    {
        [Key]
        [Display(Name = "Secure Agent Plug-in ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

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

        [Display(Name = "Secure Agent ID")]
        [Createable(false), Updateable(false)]
        public string SecureAgentId { get; set; }

        [Display(Name = "Name")]
        [StringLength(64)]
        [Createable(false), Updateable(false)]
        public string PluginName { get; set; }

        [Display(Name = "Type")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string PluginType { get; set; }

        [Display(Name = "Requested Version")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string RequestedVersion { get; set; }

        [Display(Name = "Update Window Start")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? UpdateWindowStart { get; set; }

        [Display(Name = "Update Window End")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? UpdateWindowEnd { get; set; }

    }
}
