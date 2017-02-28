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
    public class ForecastShare
    {
        [Key]
        [Display(Name = "Forecast Share ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "User Role ID")]
        [Createable(false), Updateable(false)]
        public string UserRoleId { get; set; }

        [Display(Name = "User/Group ID")]
        [Createable(false), Updateable(false)]
        public string UserOrGroupId { get; set; }

        [Display(Name = "Forecast Access")]
        [Createable(false), Updateable(false)]
        public string AccessLevel { get; set; }

        [Display(Name = "Submit Allowed")]
        [Createable(false), Updateable(false)]
        public bool CanSubmit { get; set; }

        [Display(Name = "Row Cause")]
        [Createable(false), Updateable(false)]
        public string RowCause { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

    }
}
