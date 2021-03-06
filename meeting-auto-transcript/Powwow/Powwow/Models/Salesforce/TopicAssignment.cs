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
    public class TopicAssignment
    {
        [Key]
        [Display(Name = "Topic Assignment Id")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Topic ID")]
        [Updateable(false)]
        public string TopicId { get; set; }

        [Display(Name = "Entity ID")]
        [Updateable(false)]
        public string EntityId { get; set; }

        [Display(Name = "Record Key Prefix")]
        [StringLength(3)]
        [Createable(false), Updateable(false)]
        public string EntityKeyPrefix { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
