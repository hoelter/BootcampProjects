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
    public class OpportunityHistory
    {
        [Key]
        [Display(Name = "Opportunity History ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Opportunity ID")]
        [Createable(false), Updateable(false)]
        public string OpportunityId { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Stage Name")]
        [Createable(false), Updateable(false)]
        public string StageName { get; set; }

        [Createable(false), Updateable(false)]
        public double? Amount { get; set; }

        [Display(Name = "Expected Revenue")]
        [Createable(false), Updateable(false)]
        public double? ExpectedRevenue { get; set; }

        [Display(Name = "Close Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? CloseDate { get; set; }

        [Createable(false), Updateable(false)]
        public double? Probability { get; set; }

        [Display(Name = "To ForecastCategory")]
        [Createable(false), Updateable(false)]
        public string ForecastCategory { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

    }
}
