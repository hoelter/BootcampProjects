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
    public class EmailStatus
    {
        [Key]
        [Display(Name = "Email Status ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Activity ID")]
        [Createable(false), Updateable(false)]
        public string TaskId { get; set; }

        [Display(Name = "Name ID")]
        [Createable(false), Updateable(false)]
        public string WhoId { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "# Times Opened")]
        [Createable(false), Updateable(false)]
        public int TimesOpened { get; set; }

        [Display(Name = "Date Opened")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? FirstOpenDate { get; set; }

        [Display(Name = "Last Opened")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastOpenDate { get; set; }

        [Display(Name = "Email Template Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string EmailTemplateName { get; set; }

    }
}
