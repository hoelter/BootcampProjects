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
    public class FeedLike
    {
        [Key]
        [Display(Name = "Feed Like ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Feed Item ID")]
        [Updateable(false)]
        public string FeedItemId { get; set; }

        [Display(Name = "Feed Item ID")]
        [Updateable(false)]
        public string FeedEntityId { get; set; }

        [Display(Name = "Created By ID")]
        [Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "InsertedBy ID")]
        [Createable(false), Updateable(false)]
        public string InsertedById { get; set; }

    }
}
