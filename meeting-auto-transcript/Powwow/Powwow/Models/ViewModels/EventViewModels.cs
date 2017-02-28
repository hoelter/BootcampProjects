using Powwow.Models.Salesforce;
using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Powwow.Models.ViewModels
{
    public class EventIndexViewModel
    {
        [Key]
        [Display(Name = "Activity ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Name ID")] 
        public string WhoId { get; set; }

        public string Subject { get; set; }

        [StringLength(255)]
        public string Location { get; set; }

        [Display(Name = "Start Date Time")]
        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTimeOffset? StartDateTime { get; set; }

        [Display(Name = "End Date Time")]
        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTimeOffset? EndDateTime { get; set; }

        public string Description { get; set; }

        [Display(Name = "Created Date")]
        [DisplayFormat(DataFormatString = "{0:g}")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Assigned To ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }
    }

    public class EventSelectListViewModel
    {
        [Key]
        [Display(Name = "Activity ID")]
        [Createable(false), Updateable(false)]

        public string Id { get; set; }
        [Display(Name = "Start Date Time")]
        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTimeOffset? StartDateTime { get; set; }

        public EventSelectListViewModel(EventIndexViewModel eivm)
        {
            Id = eivm.Id;
            StartDateTime = eivm.StartDateTime;
        }

    }
     

}