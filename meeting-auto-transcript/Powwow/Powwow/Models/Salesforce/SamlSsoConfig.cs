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
    public class SamlSsoConfig
    {
        [Key]
        [Display(Name = "SAML Single Sign-On Setting ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string DeveloperName { get; set; }

        [Display(Name = "Master Language")]
        [Createable(false), Updateable(false)]
        public string Language { get; set; }

        [Display(Name = "Label")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
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

        [Display(Name = "SAML Version")]
        [Createable(false), Updateable(false)]
        public string Version { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Issuer { get; set; }

        [Display(Name = "SpInitBinding")]
        [Createable(false), Updateable(false)]
        public bool OptionsSpInitBinding { get; set; }

        [Display(Name = "UserProvisioning")]
        [Createable(false), Updateable(false)]
        public bool OptionsUserProvisioning { get; set; }

        [Display(Name = "Name ID Format")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string AttributeFormat { get; set; }

        [Display(Name = "Attribute Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string AttributeName { get; set; }

        [Display(Name = "Entity Id")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Audience { get; set; }

        [Display(Name = "SAML Identity Type")]
        [Createable(false), Updateable(false)]
        public string IdentityMapping { get; set; }

        [Display(Name = "SAML Identity Location")]
        [Createable(false), Updateable(false)]
        public string IdentityLocation { get; set; }

        [Display(Name = "Identity Provider Login URL")]
        [StringLength(1500)]
        [Createable(false), Updateable(false)]
        public string LoginUrl { get; set; }

        [Display(Name = "Identity Provider Logout URL")]
        [StringLength(1500)]
        [Createable(false), Updateable(false)]
        public string LogoutUrl { get; set; }

        [Display(Name = "Custom Error URL")]
        [StringLength(500)]
        [Createable(false), Updateable(false)]
        public string ErrorUrl { get; set; }

        [Display(Name = "Identity Provider Certificate")]
        [StringLength(4000)]
        [Createable(false), Updateable(false)]
        public string ValidationCert { get; set; }

        [Display(Name = "Request Signature Method")]
        [Createable(false), Updateable(false)]
        public string RequestSignatureMethod { get; set; }

    }
}
