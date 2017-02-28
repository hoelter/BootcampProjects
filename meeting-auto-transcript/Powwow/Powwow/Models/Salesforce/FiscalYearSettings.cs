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
    public class FiscalYearSettings
    {
        [Key]
        [Display(Name = "Fiscal Year Settings ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Period ID")]
        [Createable(false), Updateable(false)]
        public string PeriodId { get; set; }

        [Display(Name = "Start Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? StartDate { get; set; }

        [Display(Name = "End Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? EndDate { get; set; }

        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Is Standard Year")]
        [Createable(false), Updateable(false)]
        public bool IsStandardYear { get; set; }

        [Display(Name = "Year Type")]
        [Createable(false), Updateable(false)]
        public string YearType { get; set; }

        [Display(Name = "Quarter Name Scheme")]
        [Createable(false), Updateable(false)]
        public string QuarterLabelScheme { get; set; }

        [Display(Name = "Period Name Scheme")]
        [Createable(false), Updateable(false)]
        public string PeriodLabelScheme { get; set; }

        [Display(Name = "Week Name Scheme")]
        [Createable(false), Updateable(false)]
        public string WeekLabelScheme { get; set; }

        [Display(Name = "Quarter Prefix")]
        [Createable(false), Updateable(false)]
        public string QuarterPrefix { get; set; }

        [Display(Name = "Period Prefix")]
        [Createable(false), Updateable(false)]
        public string PeriodPrefix { get; set; }

        [Display(Name = "Week Start Day")]
        [Createable(false), Updateable(false)]
        public int? WeekStartDay { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
