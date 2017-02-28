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
    public class UserRecordAccess
    {
        [Key]
        [Display(Name = "User Record Access ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string UserId { get; set; }

        [Display(Name = "Record ID")]
        [Createable(false), Updateable(false)]
        public string RecordId { get; set; }

        [Display(Name = "Has Read Access")]
        [Createable(false), Updateable(false)]
        public bool HasReadAccess { get; set; }

        [Display(Name = "Has Edit Access")]
        [Createable(false), Updateable(false)]
        public bool HasEditAccess { get; set; }

        [Display(Name = "Has Delete Access")]
        [Createable(false), Updateable(false)]
        public bool HasDeleteAccess { get; set; }

        [Display(Name = "Has Transfer Access")]
        [Createable(false), Updateable(false)]
        public bool HasTransferAccess { get; set; }

        [Display(Name = "Has All Access")]
        [Createable(false), Updateable(false)]
        public bool HasAllAccess { get; set; }

        [Display(Name = "Maximum Access Level")]
        [Createable(false), Updateable(false)]
        public string MaxAccessLevel { get; set; }

    }
}
