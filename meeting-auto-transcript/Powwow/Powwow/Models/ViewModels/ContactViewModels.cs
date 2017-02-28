using Powwow.Models.Salesforce;
using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Powwow.Models.ViewModels
{
    public class ContactCheckBoxViewModel
    {
        [Key]
        [Display(Name = "Contact ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(121)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        public bool IsSelected { get; set; }

        public ContactCheckBoxViewModel(Contact contact)
        {
            Id = contact.Id;
            Name = contact.Name;
        }
    }
}