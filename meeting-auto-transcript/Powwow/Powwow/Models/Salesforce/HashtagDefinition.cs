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
    public class HashtagDefinition
    {
        [Key]
        [Display(Name = "Hashtag Definition ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Normalized Hashtag Text")]
        [StringLength(765)]
        [Createable(false), Updateable(false)]
        public string NameNorm { get; set; }

        [Display(Name = "Hashtag Text")]
        [StringLength(765)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Hashtag Count")]
        [Createable(false), Updateable(false)]
        public int? HashtagCount { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
