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
    public class AggregateResult
    {
        [Key]
        [Display(Name = "Aggregate Result ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

    }
}
