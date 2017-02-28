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
    public class Period
    {
        [Key]
        [Display(Name = "Period ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Fiscal Year Settings ID")]
        [Createable(false), Updateable(false)]
        public string FiscalYearSettingsId { get; set; }

        [Createable(false), Updateable(false)]
        public string Type { get; set; }

        [Display(Name = "Start Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset StartDate { get; set; }

        [Display(Name = "End Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset EndDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Is Forecast Period")]
        [Createable(false), Updateable(false)]
        public bool IsForecastPeriod { get; set; }

        [Display(Name = "Quarter Name")]
        [Createable(false), Updateable(false)]
        public string QuarterLabel { get; set; }

        [Display(Name = "Period Name")]
        [Createable(false), Updateable(false)]
        public string PeriodLabel { get; set; }

        [Createable(false), Updateable(false)]
        public int? Number { get; set; }

    }
}
