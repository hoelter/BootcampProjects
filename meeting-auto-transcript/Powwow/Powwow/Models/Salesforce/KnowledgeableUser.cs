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
    public class KnowledgeableUser
    {
        [Key]
        [Display(Name = "Knowledgeable User ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string UserId { get; set; }

        [Display(Name = "Topic ID")]
        [Createable(false), Updateable(false)]
        public string TopicId { get; set; }

        [Display(Name = "Rank")]
        [Createable(false), Updateable(false)]
        public int? RawRank { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
