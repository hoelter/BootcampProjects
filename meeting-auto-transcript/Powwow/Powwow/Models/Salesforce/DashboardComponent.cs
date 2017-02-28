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
    public class DashboardComponent
    {
        [Key]
        [Display(Name = "Dashboard Component ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Dashboard Component Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Dashboard ID")]
        [Createable(false), Updateable(false)]
        public string DashboardId { get; set; }

    }
}
