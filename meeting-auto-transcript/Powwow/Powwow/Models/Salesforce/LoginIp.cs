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
    public class LoginIp
    {
        [Key]
        [Display(Name = "Login IP ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string UsersId { get; set; }

        [Display(Name = "Source IP")]
        [StringLength(39)]
        [Createable(false), Updateable(false)]
        public string SourceIp { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Createable(false), Updateable(false)]
        public bool IsAuthenticated { get; set; }

        [Display(Name = "Challenge SentDate")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? ChallengeSentDate { get; set; }

        [Display(Name = "Challenge Method")]
        [Createable(false), Updateable(false)]
        public string ChallengeMethod { get; set; }

    }
}
