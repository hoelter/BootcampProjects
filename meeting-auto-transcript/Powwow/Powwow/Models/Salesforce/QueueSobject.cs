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
    public class QueueSobject
    {
        [Key]
        [Display(Name = "Queue Sobject ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Group ID")]
        [Updateable(false)]
        public string QueueId { get; set; }

        [Display(Name = "Sobject Type")]
        [Updateable(false)]
        public string SobjectType { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
