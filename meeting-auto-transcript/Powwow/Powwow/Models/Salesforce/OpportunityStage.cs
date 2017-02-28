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
    public class OpportunityStage
    {
        [Key]
        [Display(Name = "Opportunity Stage ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Master Label")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MasterLabel { get; set; }

        [Display(Name = "Is Active")]
        [Createable(false), Updateable(false)]
        public bool IsActive { get; set; }

        [Display(Name = "Sort Order")]
        [Createable(false), Updateable(false)]
        public int? SortOrder { get; set; }

        [Display(Name = "Closed")]
        [Createable(false), Updateable(false)]
        public bool IsClosed { get; set; }

        [Display(Name = "Won")]
        [Createable(false), Updateable(false)]
        public bool IsWon { get; set; }

        [Display(Name = "Forecast Category")]
        [Createable(false), Updateable(false)]
        public string ForecastCategory { get; set; }

        [Display(Name = "Forecast Category Name")]
        [Createable(false), Updateable(false)]
        public string ForecastCategoryName { get; set; }

        [Display(Name = "Probability (%)")]
        [Createable(false), Updateable(false)]
        public double? DefaultProbability { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
