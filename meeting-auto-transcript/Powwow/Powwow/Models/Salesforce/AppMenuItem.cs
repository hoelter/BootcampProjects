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
    public class AppMenuItem
    {
        [Key]
        [Display(Name = "AppMenuItem ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

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

        [Display(Name = "Sort Order")]
        [Createable(false), Updateable(false)]
        public int SortOrder { get; set; }

        [Display(Name = "Developer Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

        [StringLength(250)]
        [Createable(false), Updateable(false)]
        public string Label { get; set; }

        [StringLength(250)]
        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "Start Url")]
        [Url]
        [Createable(false), Updateable(false)]
        public string StartUrl { get; set; }

        [Display(Name = "Mobile Start Url")]
        [Url]
        [Createable(false), Updateable(false)]
        public string MobileStartUrl { get; set; }

        [Display(Name = "Logo Image URL")]
        [Url]
        [Createable(false), Updateable(false)]
        public string LogoUrl { get; set; }

        [Display(Name = "Icon Url")]
        [Url]
        [Createable(false), Updateable(false)]
        public string IconUrl { get; set; }

        [Display(Name = "Info URL")]
        [Url]
        [Createable(false), Updateable(false)]
        public string InfoUrl { get; set; }

        [Createable(false), Updateable(false)]
        public bool IsUsingAdminAuthorization { get; set; }

        [Display(Name = "Mobile device OS platform")]
        [Createable(false), Updateable(false)]
        public string MobilePlatform { get; set; }

        [Display(Name = "Minimum required mobile device OS version")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MobileMinOsVer { get; set; }

        [Display(Name = "Type of mobile device")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MobileDeviceType { get; set; }

        [Display(Name = "App requires a registered mobile device")]
        [Createable(false), Updateable(false)]
        public bool IsRegisteredDeviceOnly { get; set; }

        [Display(Name = "Version of the mobile app")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MobileAppVer { get; set; }

        [Display(Name = "Date the mobile app was most recently installed")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? MobileAppInstalledDate { get; set; }

        [Display(Name = "Most recently installed version of the mobile app")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MobileAppInstalledVersion { get; set; }

        [Display(Name = "ID for the related mobile app binary")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MobileAppBinaryId { get; set; }

        [Display(Name = "URL to install the mobile app")]
        [Url]
        [Createable(false), Updateable(false)]
        public string MobileAppInstallUrl { get; set; }

        [Display(Name = "Is this a canvas-enabled application")]
        [Createable(false), Updateable(false)]
        public bool CanvasEnabled { get; set; }

        [Display(Name = "The identifier used to render the canvas application.")]
        [StringLength(18)]
        [Createable(false), Updateable(false)]
        public string CanvasReferenceId { get; set; }

        [Display(Name = "The canvas url for the canvas application")]
        [Url]
        [Createable(false), Updateable(false)]
        public string CanvasUrl { get; set; }

        [Display(Name = "The configured access method for the canvas application")]
        [Createable(false), Updateable(false)]
        public string CanvasAccessMethod { get; set; }

        [Display(Name = "The selected/supported locations of the canvas application")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string CanvasSelectedLocations { get; set; }

        [Display(Name = "The options to hide publisher header or publisher share button")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string CanvasOptions { get; set; }

        [Display(Name = "App Type")]
        [Createable(false), Updateable(false)]
        public string Type { get; set; }

        [Display(Name = "Application ID")]
        [Createable(false), Updateable(false)]
        public string ApplicationId { get; set; }

    }
}
