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
    public class SetupAuditTrail
    {
        [Key]
        [Display(Name = "Setup Audit Trail ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string Action { get; set; }

        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string Section { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [StringLength(1000)]
        [Createable(false), Updateable(false)]
        public string Display { get; set; }

    }
}
