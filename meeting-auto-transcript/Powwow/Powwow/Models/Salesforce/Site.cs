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
    public class Site
    {
        [Key]
        [Display(Name = "Site ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Site Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Site Subdomain Prefix")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Subdomain { get; set; }

        [Display(Name = "Default Web Address")]
        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string UrlPathPrefix { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string GuestUserId { get; set; }

        [Display(Name = "Site Status")]
        [Createable(false), Updateable(false)]
        public string Status { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string AdminId { get; set; }

        [Display(Name = "Enable Feeds")]
        [Createable(false), Updateable(false)]
        public bool OptionsEnableFeeds { get; set; }

        [Display(Name = "Require Secure Connections (HTTPS)")]
        [Createable(false), Updateable(false)]
        public bool OptionsRequireHttps { get; set; }

        [Display(Name = "Enable Standard Home Page")]
        [Createable(false), Updateable(false)]
        public bool OptionsAllowHomePage { get; set; }

        [Display(Name = "Enable Standard Ideas Pages")]
        [Createable(false), Updateable(false)]
        public bool OptionsAllowStandardIdeasPages { get; set; }

        [Display(Name = "Enable Standard Lookup Pages")]
        [Createable(false), Updateable(false)]
        public bool OptionsAllowStandardSearch { get; set; }

        [Display(Name = "Enable Standard Search Pages")]
        [Createable(false), Updateable(false)]
        public bool OptionsAllowStandardLookups { get; set; }

        [Display(Name = "Enable Standard Answers Pages")]
        [Createable(false), Updateable(false)]
        public bool OptionsAllowStandardAnswersPages { get; set; }

        [Display(Name = "Site Description")]
        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "Site Label")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MasterLabel { get; set; }

        [Display(Name = "Analytics Tracking Code")]
        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string AnalyticsTrackingCode { get; set; }

        [Display(Name = "Site Type")]
        [Createable(false), Updateable(false)]
        public string SiteType { get; set; }

        [Display(Name = "Clickjack Protection Level")]
        [Createable(false), Updateable(false)]
        public string ClickjackProtectionLevel { get; set; }

        [Display(Name = "Daily Bandwidth Limit (MB)")]
        [Createable(false), Updateable(false)]
        public int? DailyBandwidthLimit { get; set; }

        [Display(Name = "Daily Bandwidth Used")]
        [Createable(false), Updateable(false)]
        public int? DailyBandwidthUsed { get; set; }

        [Display(Name = "Daily Request Time Limit (min)")]
        [Createable(false), Updateable(false)]
        public int? DailyRequestTimeLimit { get; set; }

        [Display(Name = "Daily Request Time Used")]
        [Createable(false), Updateable(false)]
        public int? DailyRequestTimeUsed { get; set; }

        [Display(Name = "Monthly Page Views Allowed")]
        [Createable(false), Updateable(false)]
        public int? MonthlyPageViewsEntitlement { get; set; }

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
