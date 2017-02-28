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
    public class ThirdPartyAccountLink
    {
        [Key]
        [Display(Name = "Third Party Account Link ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Third Party Account Link Unique Key")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ThirdPartyAccountLinkKey { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string UserId { get; set; }

        [Display(Name = "Auth. Provider ID")]
        [Createable(false), Updateable(false)]
        public string SsoProviderId { get; set; }

        [Display(Name = "External User Handle")]
        [StringLength(375)]
        [Createable(false), Updateable(false)]
        public string Handle { get; set; }

        [Display(Name = "External User Id")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string RemoteIdentifier { get; set; }

        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string Provider { get; set; }

        [Display(Name = "Single Sign-On Provider Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string SsoProviderName { get; set; }

        [Display(Name = "Is Not SSO Usable")]
        [Createable(false), Updateable(false)]
        public bool IsNotSsoUsable { get; set; }

    }
}
