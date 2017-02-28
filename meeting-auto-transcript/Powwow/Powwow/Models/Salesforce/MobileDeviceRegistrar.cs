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
    public class MobileDeviceRegistrar
    {
        [Key]
        [Display(Name = "Provider Id")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Name")]
        [StringLength(80)]
        public string DeveloperName { get; set; }

        [Display(Name = "Master Language")]
        public string Language { get; set; }

        [Display(Name = "Label")]
        [StringLength(80)]
        public string MasterLabel { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

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

        public string Provider { get; set; }

        [Display(Name = "Mdm Provider Enroll Endpoint")]
        [Url]
        public string MdmProviderEnrollEndpoint { get; set; }

        [Display(Name = "Mdm Provider Push App Endpoint")]
        [Url]
        public string MdmProviderPushAppEndpoint { get; set; }

        [Display(Name = "Mdm Provider Api Access Token")]
        [StringLength(255)]
        public string MdmProviderApiAccessToken { get; set; }

        [Display(Name = "Mdm Provider Api Username")]
        [StringLength(255)]
        public string MdmProviderApiUsername { get; set; }

        [Display(Name = "Mdm Provider Api Password")]
        [StringLength(255)]
        public string MdmProviderApiPassword { get; set; }

    }
}
