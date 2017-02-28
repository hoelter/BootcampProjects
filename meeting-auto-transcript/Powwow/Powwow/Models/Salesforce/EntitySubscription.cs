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
    public class EntitySubscription
    {
        [Key]
        [Display(Name = "Entity Subscription ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Parent ID")]
        [Updateable(false)]
        public string ParentId { get; set; }

        [Display(Name = "Subscriber ID")]
        [Updateable(false)]
        public string SubscriberId { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

    }
}
