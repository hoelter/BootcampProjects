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
    public class FeedTrackedChange
    {
        [Key]
        [Display(Name = "Feed Tracked Change ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Feed Item ID")]
        [Createable(false), Updateable(false)]
        public string FeedItemId { get; set; }

        [Display(Name = "Field")]
        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string FieldName { get; set; }

        [Display(Name = "Old Value")]
        [Createable(false), Updateable(false)]
        public object OldValue { get; set; }

        [Display(Name = "New Value")]
        [Createable(false), Updateable(false)]
        public object NewValue { get; set; }

    }
}
