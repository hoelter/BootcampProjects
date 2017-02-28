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
    public class OauthToken
    {
        [Key]
        [Display(Name = "Oauth Token ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Access Token")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string AccessToken { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string UserId { get; set; }

        [Display(Name = "Request Token")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string RequestToken { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? CreatedDate { get; set; }

        [Display(Name = "Application Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string AppName { get; set; }

        [Display(Name = "Last Used Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastUsedDate { get; set; }

        [Display(Name = "Use Count")]
        [Createable(false), Updateable(false)]
        public int? UseCount { get; set; }

        [Display(Name = "Delete Token")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string DeleteToken { get; set; }

        [Display(Name = "AppMenuItem ID")]
        [Createable(false), Updateable(false)]
        public string AppMenuItemId { get; set; }

    }
}
