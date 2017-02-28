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
    public class ChatterActivity
    {
        [Key]
        [Display(Name = "Chatter Activity ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Parent ID")]
        [Createable(false), Updateable(false)]
        public string ParentId { get; set; }

        [Display(Name = "Post Count")]
        [Createable(false), Updateable(false)]
        public int PostCount { get; set; }

        [Display(Name = "Comment Count")]
        [Createable(false), Updateable(false)]
        public int CommentCount { get; set; }

        [Display(Name = "Comment Received Count")]
        [Createable(false), Updateable(false)]
        public int CommentReceivedCount { get; set; }

        [Display(Name = "Like Received Count")]
        [Createable(false), Updateable(false)]
        public int LikeReceivedCount { get; set; }

        [Display(Name = "Influence Raw Rank")]
        [Createable(false), Updateable(false)]
        public int InfluenceRawRank { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
