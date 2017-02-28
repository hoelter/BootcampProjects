using Powwow.Models.Salesforce;
using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Powwow.Models.ViewModels
{
    public class LeadCheckBoxViewModel
    {
        [Key]
        [Display(Name = "Lead ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(121)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        public bool IsSelected { get; set; }

        public LeadCheckBoxViewModel(Lead lead)
        {
            Id = lead.Id;
            Name = lead.Name;
        }
    }
}