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
    public class ClientBrowser
    {
        [Key]
        [Display(Name = "Client Browser ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string UsersId { get; set; }

        [Display(Name = "Full User Agent")]
        [StringLength(1024)]
        [Createable(false), Updateable(false)]
        public string FullUserAgent { get; set; }

        [Display(Name = "Proxy Info")]
        [StringLength(1024)]
        [Createable(false), Updateable(false)]
        public string ProxyInfo { get; set; }

        [Display(Name = "Last Update")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastUpdate { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

    }
}
