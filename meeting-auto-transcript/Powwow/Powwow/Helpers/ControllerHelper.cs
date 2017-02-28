using Powwow.DataContexts;
using Powwow.Models;
using Powwow.Models.Recordings;
using Powwow.Models.Salesforce;
using Powwow.Salesforce;
using Salesforce.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Powwow.Helpers
{
    public class ControllerHelper : Controller
    {
        public readonly string UserKey = "CurrentSalesforceUser";
        public readonly int? RecordFailureRouteValue = 909;
        public readonly string RecordingKey = "CurrentRecording";
        private RecordingsDb recordingsDb = new RecordingsDb();

        public Task<List<T>> SalesforceRequest<T>(string soqlQuery)
        {
            var requestTask = SalesforceService
                    .MakeAuthenticatedClientRequestAsync(
                    async (client) =>
                    {
                        QueryResult<T> entities = await client
                        .QueryAsync<T>(soqlQuery);
                        return entities.Records;
                    }
                    );
            return requestTask;
        }

        public void CatchSalesforceRequest(Controller caller, Exception ex, string operationName)
        {
            caller.ViewBag.OperationName = operationName;
            caller.ViewBag.AuthorizationUrl = SalesforceOAuthRedirectHandler
                    .GetAuthorizationUrl(caller.Request.Url.ToString());
            caller.ViewBag.ErrorMessage = ex.Message;
        }

        public async Task<SalesforceUser> GetCurrentUser(Controller caller)
        {
            IEnumerable<AuthSession> sessions = Enumerable.Empty<AuthSession>();
            string id = null;
            SalesforceUser user = null;
            string userQuery = "SELECT UsersId From AuthSession";
            try
            {
                sessions = await SalesforceRequest<AuthSession>(userQuery);
                id = sessions.FirstOrDefault().UsersId;
            }
            catch(Exception ex)
            {
                CatchSalesforceRequest(caller, ex, "Getting user Id through AuthSession");
            }
            if (id != null)
            {
                user = await GetSalesforceUserCreatingNewIfNecessary(id);
            }
            return user;
        }

        public ActionResult RedirectToLogin(Controller caller)
        {
            if (caller.ViewBag.ErrorMessage == "AuthorizationRequired")
            {
                return Redirect(caller.ViewBag.AuthorizationUrl);
            }
            return HttpNotFound();
        }

        public bool LoginRedirectNeeded(Controller caller)
        {
            if (caller.ViewBag.ErrorMessage == "AuthorizationRequired")
            {
                return true;
            }
            return false;
        }

        private async Task<SalesforceUser> GetSalesforceUserCreatingNewIfNecessary(string id)
        {
            if (id == null)
            {
                return null;
            }
            SalesforceUser user = null;
            if (!recordingsDb.SalesforceUsers.Any(u => u.SalesforceIdCode == id))
            {
                user = new SalesforceUser(id);
                recordingsDb.SalesforceUsers.Add(user);
                await recordingsDb.SaveChangesAsync();
                return user;
            }
            return recordingsDb.SalesforceUsers.Single(u => u.SalesforceIdCode == id);
        }

    }
}