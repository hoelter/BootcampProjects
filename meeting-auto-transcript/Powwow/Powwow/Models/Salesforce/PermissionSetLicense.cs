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
    public class PermissionSetLicense
    {
        [Key]
        [Display(Name = "Permission Set License ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Developer Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string DeveloperName { get; set; }

        [Display(Name = "Master Language")]
        [Createable(false), Updateable(false)]
        public string Language { get; set; }

        [Display(Name = "Permission Set License Label")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string MasterLabel { get; set; }

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

        [Display(Name = "Permission Set License Key")]
        [StringLength(81)]
        [Createable(false), Updateable(false)]
        public string PermissionSetLicenseKey { get; set; }

        [Display(Name = "Total Licenses")]
        [Createable(false), Updateable(false)]
        public int TotalLicenses { get; set; }

        [Createable(false), Updateable(false)]
        public string Status { get; set; }

        [Display(Name = "Expiration Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? ExpirationDate { get; set; }

        [Display(Name = "Send Email")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEmailSingle { get; set; }

        [Display(Name = "Mass Email")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEmailMass { get; set; }

        [Display(Name = "Edit Tasks")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditTask { get; set; }

        [Display(Name = "Edit Events")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditEvent { get; set; }

        [Display(Name = "Export Reports")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsExportReport { get; set; }

        [Display(Name = "Import Personal Contacts")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsImportPersonal { get; set; }

        [Display(Name = "Manage Users")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageUsers { get; set; }

        [Display(Name = "Manage Public Templates")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditPublicTemplates { get; set; }

        [Display(Name = "Modify All Data")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsModifyAllData { get; set; }

        [Display(Name = "Manage Cases")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageCases { get; set; }

        [Display(Name = "Mass Edits from Lists")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsMassInlineEdit { get; set; }

        [Display(Name = "Manage Articles")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditKnowledge { get; set; }

        [Display(Name = "Manage Salesforce Knowledge")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageKnowledge { get; set; }

        [Display(Name = "Manage Published Solutions")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageSolutions { get; set; }

        [Display(Name = "Customize Application")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCustomizeApplication { get; set; }

        [Display(Name = "Edit Read Only Fields")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditReadonlyFields { get; set; }

        [Display(Name = "Run Reports")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsRunReports { get; set; }

        [Display(Name = "View Setup and Configuration")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewSetup { get; set; }

        [Display(Name = "Transfer Record")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsTransferAnyEntity { get; set; }

        [Display(Name = "Report Builder")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsNewReportBuilder { get; set; }

        [Display(Name = "Activate Contracts")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsActivateContract { get; set; }

        [Display(Name = "Activate Orders")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsActivateOrder { get; set; }

        [Display(Name = "Import Leads")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsImportLeads { get; set; }

        [Display(Name = "Manage Leads")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageLeads { get; set; }

        [Display(Name = "Transfer Leads")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsTransferAnyLead { get; set; }

        [Display(Name = "View All Data")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewAllData { get; set; }

        [Display(Name = "Manage Public Documents")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditPublicDocuments { get; set; }

        [Display(Name = "View Encrypted Data")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewEncryptedData { get; set; }

        [Display(Name = "Manage Letterheads")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditBrandTemplates { get; set; }

        [Display(Name = "Edit HTML Templates")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditHtmlTemplates { get; set; }

        [Display(Name = "Chatter Internal User")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsChatterInternalUser { get; set; }

        [Display(Name = "Manage Encryption Keys")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageEncryptionKeys { get; set; }

        [Display(Name = "Delete Activated Contracts")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsDeleteActivatedContract { get; set; }

        [Display(Name = "Invite Customers To Chatter")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsChatterInviteExternalUsers { get; set; }

        [Display(Name = "Send Stay-in-Touch Requests")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsSendSitRequests { get; set; }

        [Display(Name = "Manage Connected Apps")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageRemoteAccess { get; set; }

        [Display(Name = "Drag-and-Drop Dashboard Builder")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCanUseNewDashboardBuilder { get; set; }

        [Display(Name = "Manage Categories")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageCategories { get; set; }

        [Display(Name = "Convert Leads")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsConvertLeads { get; set; }

        [Display(Name = "Password Never Expires")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsPasswordNeverExpires { get; set; }

        [Display(Name = "Use Team Reassignment Wizards")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsUseTeamReassignWizards { get; set; }

        [Display(Name = "Edit Activated Orders")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditActivatedOrders { get; set; }

        [Display(Name = "Download AppExchange Packages")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsInstallPackaging { get; set; }

        [Display(Name = "Upload AppExchange Packages")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsPublishPackaging { get; set; }

        [Display(Name = "Create and Own New Chatter Groups")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsChatterOwnGroups { get; set; }

        [Display(Name = "Edit Opportunity Product Sales Price")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditOppLineItemUnitPrice { get; set; }

        [Display(Name = "Create AppExchange Packages")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCreatePackaging { get; set; }

        [Display(Name = "Bulk API Hard Delete")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsBulkApiHardDelete { get; set; }

        [Display(Name = "Import Solutions")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsSolutionImport { get; set; }

        [Display(Name = "Manage Call Centers")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageCallCenters { get; set; }

        [Display(Name = "Manage Synonyms")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageSynonyms { get; set; }

        [Display(Name = "View Content in Portals")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewContent { get; set; }

        [Display(Name = "Manage Email Client Configurations")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageEmailClientConfig { get; set; }

        [Display(Name = "Send Outbound Messages")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEnableNotifications { get; set; }

        [Display(Name = "Manage Data Integrations")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageDataIntegrations { get; set; }

        [Display(Name = "Deliver Uploaded Files and Personal Content")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsDistributeFromPersWksp { get; set; }

        [Display(Name = "View Data Categories")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewDataCategories { get; set; }

        [Display(Name = "Manage Data Categories")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageDataCategories { get; set; }

        [Display(Name = "Author Apex")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsAuthorApex { get; set; }

        [Display(Name = "Manage Mobile Configurations")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageMobile { get; set; }

        [Display(Name = "API Enabled")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsApiEnabled { get; set; }

        [Display(Name = "Manage Custom Report Types")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageCustomReportTypes { get; set; }

        [Display(Name = "Edit Case Comments")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditCaseComments { get; set; }

        [Display(Name = "Transfer Cases")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsTransferAnyCase { get; set; }

        [Display(Name = "Manage Salesforce CRM Content")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsContentAdministrator { get; set; }

        [Display(Name = "Create Libraries")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCreateWorkspaces { get; set; }

        [Display(Name = "Manage Content Permissions")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageContentPermissions { get; set; }

        [Display(Name = "Manage Content Properties")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageContentProperties { get; set; }

        [Display(Name = "Manage record types and layouts for Files")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageContentTypes { get; set; }

        [Display(Name = "Manage Exchange Configurations")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageExchangeConfig { get; set; }

        [Display(Name = "Manage Reporting Snapshots")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageAnalyticSnapshots { get; set; }

        [Display(Name = "Schedule Reports")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsScheduleReports { get; set; }

        [Display(Name = "Manage Business Hours Holidays")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageBusinessHourHolidays { get; set; }

        [Display(Name = "Manage Dynamic Dashboards")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageDynamicDashboards { get; set; }

        [Display(Name = "Show Custom Sidebar On All Pages")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCustomSidebarOnAllPages { get; set; }

        [Display(Name = "Manage Force.com Flow")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageInteraction { get; set; }

        [Display(Name = "View My Team's Dashboards")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewMyTeamsDashboards { get; set; }

        [Display(Name = "Moderate Chatter")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsModerateChatter { get; set; }

        [Display(Name = "Reset User Passwords and Unlock Users")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsResetPasswords { get; set; }

        [Display(Name = "Require Force.com Flow User Feature License")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsFlowUFLRequired { get; set; }

        [Display(Name = "Insert System Field Values for Chatter Feeds")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCanInsertFeedSystemFields { get; set; }

        [Display(Name = "Manage Knowledge Article Import/Export")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageKnowledgeImportExport { get; set; }

        [Display(Name = "Manage Email Templates")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEmailTemplateManagement { get; set; }

        [Display(Name = "Email Administration")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEmailAdministration { get; set; }

        [Display(Name = "Manage Chatter Messages")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageChatterMessages { get; set; }

        [Display(Name = "Email-Based Identity Confirmation Option")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsAllowEmailIC { get; set; }

        [Display(Name = "Create and Share Content Deliveries for Chatter Files")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsChatterFileLink { get; set; }

        [Display(Name = "Two-Factor Authentication for User Interface Logins")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsForceTwoFactor { get; set; }

        [Display(Name = "View Event Log Files")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewEventLogFiles { get; set; }

        [Display(Name = "Create and Set Up Communities")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageNetworks { get; set; }

        [Display(Name = "Manage Auth. Providers")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageAuthProviders { get; set; }

        [Display(Name = "Run Flows")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsRunFlow { get; set; }

        [Display(Name = "Create and Customize Dashboards")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCreateCustomizeDashboards { get; set; }

        [Display(Name = "Create Dashboard Folders")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCreateDashboardFolders { get; set; }

        [Display(Name = "View Dashboards in Public Folders")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewPublicDashboards { get; set; }

        [Display(Name = "Manage Dashboards in Public Folders")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageDashbdsInPubFolders { get; set; }

        [Display(Name = "Create and Customize Reports")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCreateCustomizeReports { get; set; }

        [Display(Name = "Create Report Folders")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCreateReportFolders { get; set; }

        [Display(Name = "View Reports in Public Folders")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewPublicReports { get; set; }

        [Display(Name = "Manage Reports in Public Folders")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageReportsInPubFolders { get; set; }

        [Display(Name = "Edit My Dashboards")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditMyDashboards { get; set; }

        [Display(Name = "Edit My Reports")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditMyReports { get; set; }

        [Display(Name = "View All Users")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewAllUsers { get; set; }

        [Display(Name = "Knowledge One")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsAllowUniversalSearch { get; set; }

        [Display(Name = "Connect Organization to Environment Hub")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsConnectOrgToEnvironmentHub { get; set; }

        [Display(Name = "Enable Work.com Calibration")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsWorkCalibrationUser { get; set; }

        [Display(Name = "Create and Customize List Views")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCreateCustomizeFilters { get; set; }

        [Display(Name = "Enable Work.com")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsWorkDotComUserPerm { get; set; }

        [Display(Name = "Manage Communities")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsGovernNetworks { get; set; }

        [Display(Name = "Sales Console")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsSalesConsole { get; set; }

        [Display(Name = "Two-Factor Authentication for API Logins")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsTwoFactorApi { get; set; }

        [Display(Name = "Delete Topics")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsDeleteTopics { get; set; }

        [Display(Name = "Edit Topics")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsEditTopics { get; set; }

        [Display(Name = "Create Topics")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCreateTopics { get; set; }

        [Display(Name = "Assign Topics")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsAssignTopics { get; set; }

        [Display(Name = "Use Identity Features")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsIdentityEnabled { get; set; }

        [Display(Name = "Use Identity Connect")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsIdentityConnect { get; set; }

        [Display(Name = "Allow View Knowledge")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsAllowViewKnowledge { get; set; }

        [Display(Name = "Manage Promoted Search Terms")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageSearchPromotionRules { get; set; }

        [Display(Name = "Access Custom Mobile Apps")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsCustomMobileAppsAccess { get; set; }

        [Display(Name = "View Help Link")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsViewHelpLink { get; set; }

        [Display(Name = "Manage Profiles and Permission Sets")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageProfilesPermissionsets { get; set; }

        [Display(Name = "Assign Permission Sets")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsAssignPermissionSets { get; set; }

        [Display(Name = "Manage Roles")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageRoles { get; set; }

        [Display(Name = "Manage IP Addresses")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageIpAddresses { get; set; }

        [Display(Name = "Manage Sharing")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageSharing { get; set; }

        [Display(Name = "Manage Internal Users")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageInternalUsers { get; set; }

        [Display(Name = "Manage Password Policies")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManagePasswordPolicies { get; set; }

        [Display(Name = "Manage Login Access Policies")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageLoginAccessPolicies { get; set; }

        [Display(Name = "Manage Custom Permissions")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageCustomPermissions { get; set; }

        [Display(Name = "Manage Unlisted Groups")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageUnlistedGroups { get; set; }

        [Display(Name = "Modify Secure Agents")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsModifySecureAgents { get; set; }

        [Display(Name = "Manage Two-Factor Authentication")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsManageTwoFactor { get; set; }

        [Display(Name = "Access Chatter For SharePoint")]
        [Createable(false), Updateable(false)]
        public bool MaximumPermissionsChatterForSharePoint { get; set; }

        [Display(Name = "Used Licenses")]
        [Createable(false), Updateable(false)]
        public int UsedLicenses { get; set; }

    }
}
