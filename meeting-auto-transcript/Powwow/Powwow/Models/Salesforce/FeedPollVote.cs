﻿using Newtonsoft.Json;
using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powwow.Models.Salesforce
{
    public class FeedPollVote
    {
        [Key]
        [Display(Name = "Feed Poll Vote ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Feed Item ID")]
        [Createable(false), Updateable(false)]
        public string FeedItemId { get; set; }

        [Display(Name = "Feed Poll Choice ID")]
        [Createable(false), Updateable(false)]
        public string ChoiceId { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

    }
}
