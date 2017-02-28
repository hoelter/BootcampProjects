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
    public class ContentDistributionView
    {
        [Key]
        [Display(Name = "Content Delivery View ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Content Delivery ID")]
        [Createable(false), Updateable(false)]
        public string DistributionId { get; set; }

        [Display(Name = "Content Delivery View ID")]
        [Createable(false), Updateable(false)]
        public string ParentViewId { get; set; }

        [Display(Name = "View Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Internal View")]
        [Createable(false), Updateable(false)]
        public bool IsInternal { get; set; }

        [Display(Name = "File Downloaded")]
        [Createable(false), Updateable(false)]
        public bool IsDownload { get; set; }

    }
}
