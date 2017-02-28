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
    public class PermissionSet
    {
        [Key]
        [Display(Name = "PermissionSet ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Permission Set Name")]
        [StringLength(80)]
        public string Name { get; set; }

        [Display(Name = "Permission Set Label")]
        [StringLength(80)]
        public string Label { get; set; }

        [Display(Name = "User License ID")]
        [Updateable(false)]
        public string UserLicenseId { get; set; }

        [Display(Name = "Profile ID")]
        [Createable(false), Updateable(false)]
        public string ProfileId { get; set; }

        [Display(Name = "Is Owned By Profile")]
        [Createable(false), Updateable(false)]
        public bool IsOwnedByProfile { get; set; }

        [Display(Name = "Send Email")]
        public bool PermissionsEmailSingle { get; set; }

        [Display(Name = "Mass Email")]
        public bool PermissionsEmailMass { get; set; }

        [Display(Name = "Edit Tasks")]
        public bool PermissionsEditTask { get; set; }

        [Display(Name = "Edit Events")]
        public bool PermissionsEditEvent { get; set; }

        [Display(Name = "Export Reports")]
        public bool PermissionsExportReport { get; set; }

        [Display(Name = "Import Personal Contacts")]
        public bool PermissionsImportPersonal { get; set; }

        [Display(Name = "Manage Users")]
        public bool PermissionsManageUsers { get; set; }

        [Display(Name = "Manage Public Templates")]
        public bool PermissionsEditPublicTemplates { get; set; }

        [Display(Name = "Modify All Data")]
        public bool PermissionsModifyAllData { get; set; }

        [Display(Name = "Manage Cases")]
        public bool PermissionsManageCases { get; set; }

        [Display(Name = "Mass Edits from Lists")]
        public bool PermissionsMassInlineEdit { get; set; }

        [Display(Name = "Manage Articles")]
        public bool PermissionsEditKnowledge { get; set; }

        [Display(Name = "Manage Salesforce Knowledge")]
        public bool PermissionsManageKnowledge { get; set; }

        [Display(Name = "Manage Published Solutions")]
        public bool PermissionsManageSolutions { get; set; }

        [Display(Name = "Customize Application")]
        public bool PermissionsCustomizeApplication { get; set; }

        [Display(Name = "Edit Read Only Fields")]
        public bool PermissionsEditReadonlyFields { get; set; }

        [Display(Name = "Run Reports")]
        public bool PermissionsRunReports { get; set; }

        [Display(Name = "View Setup and Configuration")]
        public bool PermissionsViewSetup { get; set; }

        [Display(Name = "Transfer Record")]
        public bool PermissionsTransferAnyEntity { get; set; }

        [Display(Name = "Report Builder")]
        public bool PermissionsNewReportBuilder { get; set; }

        [Display(Name = "Activate Contracts")]
        public bool PermissionsActivateContract { get; set; }

        [Display(Name = "Activate Orders")]
        public bool PermissionsActivateOrder { get; set; }

        [Display(Name = "Import Leads")]
        public bool PermissionsImportLeads { get; set; }

        [Display(Name = "Manage Leads")]
        public bool PermissionsManageLeads { get; set; }

        [Display(Name = "Transfer Leads")]
        public bool PermissionsTransferAnyLead { get; set; }

        [Display(Name = "View All Data")]
        public bool PermissionsViewAllData { get; set; }

        [Display(Name = "Manage Public Documents")]
        public bool PermissionsEditPublicDocuments { get; set; }

        [Display(Name = "View Encrypted Data")]
        public bool PermissionsViewEncryptedData { get; set; }

        [Display(Name = "Manage Letterheads")]
        public bool PermissionsEditBrandTemplates { get; set; }

        [Display(Name = "Edit HTML Templates")]
        public bool PermissionsEditHtmlTemplates { get; set; }

        [Display(Name = "Chatter Internal User")]
        public bool PermissionsChatterInternalUser { get; set; }

        [Display(Name = "Manage Encryption Keys")]
        public bool PermissionsManageEncryptionKeys { get; set; }

        [Display(Name = "Delete Activated Contracts")]
        public bool PermissionsDeleteActivatedContract { get; set; }

        [Display(Name = "Invite Customers To Chatter")]
        public bool PermissionsChatterInviteExternalUsers { get; set; }

        [Display(Name = "Send Stay-in-Touch Requests")]
        public bool PermissionsSendSitRequests { get; set; }

        [Display(Name = "Manage Connected Apps")]
        public bool PermissionsManageRemoteAccess { get; set; }

        [Display(Name = "Drag-and-Drop Dashboard Builder")]
        public bool PermissionsCanUseNewDashboardBuilder { get; set; }

        [Display(Name = "Manage Categories")]
        public bool PermissionsManageCategories { get; set; }

        [Display(Name = "Convert Leads")]
        public bool PermissionsConvertLeads { get; set; }

        [Display(Name = "Password Never Expires")]
        public bool PermissionsPasswordNeverExpires { get; set; }

        [Display(Name = "Use Team Reassignment Wizards")]
        public bool PermissionsUseTeamReassignWizards { get; set; }

        [Display(Name = "Edit Activated Orders")]
        public bool PermissionsEditActivatedOrders { get; set; }

        [Display(Name = "Download AppExchange Packages")]
        public bool PermissionsInstallPackaging { get; set; }

        [Display(Name = "Upload AppExchange Packages")]
        public bool PermissionsPublishPackaging { get; set; }

        [Display(Name = "Create and Own New Chatter Groups")]
        public bool PermissionsChatterOwnGroups { get; set; }

        [Display(Name = "Edit Opportunity Product Sales Price")]
        public bool PermissionsEditOppLineItemUnitPrice { get; set; }

        [Display(Name = "Create AppExchange Packages")]
        public bool PermissionsCreatePackaging { get; set; }

        [Display(Name = "Bulk API Hard Delete")]
        public bool PermissionsBulkApiHardDelete { get; set; }

        [Display(Name = "Import Solutions")]
        public bool PermissionsSolutionImport { get; set; }

        [Display(Name = "Manage Call Centers")]
        public bool PermissionsManageCallCenters { get; set; }

        [Display(Name = "Manage Synonyms")]
        public bool PermissionsManageSynonyms { get; set; }

        [Display(Name = "View Content in Portals")]
        public bool PermissionsViewContent { get; set; }

        [Display(Name = "Manage Email Client Configurations")]
        public bool PermissionsManageEmailClientConfig { get; set; }

        [Display(Name = "Send Outbound Messages")]
        public bool PermissionsEnableNotifications { get; set; }

        [Display(Name = "Manage Data Integrations")]
        public bool PermissionsManageDataIntegrations { get; set; }

        [Display(Name = "Deliver Uploaded Files and Personal Content")]
        public bool PermissionsDistributeFromPersWksp { get; set; }

        [Display(Name = "View Data Categories")]
        public bool PermissionsViewDataCategories { get; set; }

        [Display(Name = "Manage Data Categories")]
        public bool PermissionsManageDataCategories { get; set; }

        [Display(Name = "Author Apex")]
        public bool PermissionsAuthorApex { get; set; }

        [Display(Name = "Manage Mobile Configurations")]
        public bool PermissionsManageMobile { get; set; }

        [Display(Name = "API Enabled")]
        public bool PermissionsApiEnabled { get; set; }

        [Display(Name = "Manage Custom Report Types")]
        public bool PermissionsManageCustomReportTypes { get; set; }

        [Display(Name = "Edit Case Comments")]
        public bool PermissionsEditCaseComments { get; set; }

        [Display(Name = "Transfer Cases")]
        public bool PermissionsTransferAnyCase { get; set; }

        [Display(Name = "Manage Salesforce CRM Content")]
        public bool PermissionsContentAdministrator { get; set; }

        [Display(Name = "Create Libraries")]
        public bool PermissionsCreateWorkspaces { get; set; }

        [Display(Name = "Manage Content Permissions")]
        public bool PermissionsManageContentPermissions { get; set; }

        [Display(Name = "Manage Content Properties")]
        public bool PermissionsManageContentProperties { get; set; }

        [Display(Name = "Manage record types and layouts for Files")]
        public bool PermissionsManageContentTypes { get; set; }

        [Display(Name = "Manage Exchange Configurations")]
        public bool PermissionsManageExchangeConfig { get; set; }

        [Display(Name = "Manage Reporting Snapshots")]
        public bool PermissionsManageAnalyticSnapshots { get; set; }

        [Display(Name = "Schedule Reports")]
        public bool PermissionsScheduleReports { get; set; }

        [Display(Name = "Manage Business Hours Holidays")]
        public bool PermissionsManageBusinessHourHolidays { get; set; }

        [Display(Name = "Manage Dynamic Dashboards")]
        public bool PermissionsManageDynamicDashboards { get; set; }

        [Display(Name = "Show Custom Sidebar On All Pages")]
        public bool PermissionsCustomSidebarOnAllPages { get; set; }

        [Display(Name = "Manage Force.com Flow")]
        public bool PermissionsManageInteraction { get; set; }

        [Display(Name = "View My Team's Dashboards")]
        public bool PermissionsViewMyTeamsDashboards { get; set; }

        [Display(Name = "Moderate Chatter")]
        public bool PermissionsModerateChatter { get; set; }

        [Display(Name = "Reset User Passwords and Unlock Users")]
        public bool PermissionsResetPasswords { get; set; }

        [Display(Name = "Require Force.com Flow User Feature License")]
        public bool PermissionsFlowUFLRequired { get; set; }

        [Display(Name = "Insert System Field Values for Chatter Feeds")]
        public bool PermissionsCanInsertFeedSystemFields { get; set; }

        [Display(Name = "Manage Knowledge Article Import/Export")]
        public bool PermissionsManageKnowledgeImportExport { get; set; }

        [Display(Name = "Manage Email Templates")]
        public bool PermissionsEmailTemplateManagement { get; set; }

        [Display(Name = "Email Administration")]
        public bool PermissionsEmailAdministration { get; set; }

        [Display(Name = "Manage Chatter Messages")]
        public bool PermissionsManageChatterMessages { get; set; }

        [Display(Name = "Email-Based Identity Confirmation Option")]
        public bool PermissionsAllowEmailIC { get; set; }

        [Display(Name = "Create and Share Content Deliveries for Chatter Files")]
        public bool PermissionsChatterFileLink { get; set; }

        [Display(Name = "Two-Factor Authentication for User Interface Logins")]
        public bool PermissionsForceTwoFactor { get; set; }

        [Display(Name = "View Event Log Files")]
        public bool PermissionsViewEventLogFiles { get; set; }

        [Display(Name = "Create and Set Up Communities")]
        public bool PermissionsManageNetworks { get; set; }

        [Display(Name = "Manage Auth. Providers")]
        public bool PermissionsManageAuthProviders { get; set; }

        [Display(Name = "Run Flows")]
        public bool PermissionsRunFlow { get; set; }

        [Display(Name = "Create and Customize Dashboards")]
        public bool PermissionsCreateCustomizeDashboards { get; set; }

        [Display(Name = "Create Dashboard Folders")]
        public bool PermissionsCreateDashboardFolders { get; set; }

        [Display(Name = "View Dashboards in Public Folders")]
        public bool PermissionsViewPublicDashboards { get; set; }

        [Display(Name = "Manage Dashboards in Public Folders")]
        public bool PermissionsManageDashbdsInPubFolders { get; set; }

        [Display(Name = "Create and Customize Reports")]
        public bool PermissionsCreateCustomizeReports { get; set; }

        [Display(Name = "Create Report Folders")]
        public bool PermissionsCreateReportFolders { get; set; }

        [Display(Name = "View Reports in Public Folders")]
        public bool PermissionsViewPublicReports { get; set; }

        [Display(Name = "Manage Reports in Public Folders")]
        public bool PermissionsManageReportsInPubFolders { get; set; }

        [Display(Name = "Edit My Dashboards")]
        public bool PermissionsEditMyDashboards { get; set; }

        [Display(Name = "Edit My Reports")]
        public bool PermissionsEditMyReports { get; set; }

        [Display(Name = "View All Users")]
        public bool PermissionsViewAllUsers { get; set; }

        [Display(Name = "Knowledge One")]
        public bool PermissionsAllowUniversalSearch { get; set; }

        [Display(Name = "Connect Organization to Environment Hub")]
        public bool PermissionsConnectOrgToEnvironmentHub { get; set; }

        [Display(Name = "Enable Work.com Calibration")]
        public bool PermissionsWorkCalibrationUser { get; set; }

        [Display(Name = "Create and Customize List Views")]
        public bool PermissionsCreateCustomizeFilters { get; set; }

        [Display(Name = "Enable Work.com")]
        public bool PermissionsWorkDotComUserPerm { get; set; }

        [Display(Name = "Manage Communities")]
        public bool PermissionsGovernNetworks { get; set; }

        [Display(Name = "Sales Console")]
        public bool PermissionsSalesConsole { get; set; }

        [Display(Name = "Two-Factor Authentication for API Logins")]
        public bool PermissionsTwoFactorApi { get; set; }

        [Display(Name = "Delete Topics")]
        public bool PermissionsDeleteTopics { get; set; }

        [Display(Name = "Edit Topics")]
        public bool PermissionsEditTopics { get; set; }

        [Display(Name = "Create Topics")]
        public bool PermissionsCreateTopics { get; set; }

        [Display(Name = "Assign Topics")]
        public bool PermissionsAssignTopics { get; set; }

        [Display(Name = "Use Identity Features")]
        public bool PermissionsIdentityEnabled { get; set; }

        [Display(Name = "Use Identity Connect")]
        public bool PermissionsIdentityConnect { get; set; }

        [Display(Name = "Allow View Knowledge")]
        public bool PermissionsAllowViewKnowledge { get; set; }

        [Display(Name = "Manage Promoted Search Terms")]
        public bool PermissionsManageSearchPromotionRules { get; set; }

        [Display(Name = "Access Custom Mobile Apps")]
        public bool PermissionsCustomMobileAppsAccess { get; set; }

        [Display(Name = "View Help Link")]
        public bool PermissionsViewHelpLink { get; set; }

        [Display(Name = "Manage Profiles and Permission Sets")]
        public bool PermissionsManageProfilesPermissionsets { get; set; }

        [Display(Name = "Assign Permission Sets")]
        public bool PermissionsAssignPermissionSets { get; set; }

        [Display(Name = "Manage Roles")]
        public bool PermissionsManageRoles { get; set; }

        [Display(Name = "Manage IP Addresses")]
        public bool PermissionsManageIpAddresses { get; set; }

        [Display(Name = "Manage Sharing")]
        public bool PermissionsManageSharing { get; set; }

        [Display(Name = "Manage Internal Users")]
        public bool PermissionsManageInternalUsers { get; set; }

        [Display(Name = "Manage Password Policies")]
        public bool PermissionsManagePasswordPolicies { get; set; }

        [Display(Name = "Manage Login Access Policies")]
        public bool PermissionsManageLoginAccessPolicies { get; set; }

        [Display(Name = "Manage Custom Permissions")]
        public bool PermissionsManageCustomPermissions { get; set; }

        [Display(Name = "Manage Unlisted Groups")]
        public bool PermissionsManageUnlistedGroups { get; set; }

        [Display(Name = "Modify Secure Agents")]
        public bool PermissionsModifySecureAgents { get; set; }

        [Display(Name = "Manage Two-Factor Authentication")]
        public bool PermissionsManageTwoFactor { get; set; }

        [Display(Name = "Access Chatter For SharePoint")]
        public bool PermissionsChatterForSharePoint { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

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

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

    }
}
