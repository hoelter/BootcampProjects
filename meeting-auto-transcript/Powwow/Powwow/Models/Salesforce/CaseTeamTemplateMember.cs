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
    public class CaseTeamTemplateMember
    {
        [Key]
        [Display(Name = "Team Template Member Id")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Team Template ID")]
        [Updateable(false)]
        public string TeamTemplateId { get; set; }

        [Display(Name = "Member ID")]
        [Updateable(false)]
        public string MemberId { get; set; }

        [Display(Name = "Team Role ID")]
        public string TeamRoleId { get; set; }

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

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
