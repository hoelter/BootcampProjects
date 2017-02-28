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
    public class Topic
    {
        [Key]
        [Display(Name = "Topic ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [StringLength(99)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Talking About")]
        [Createable(false), Updateable(false)]
        public int TalkingAbout { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
