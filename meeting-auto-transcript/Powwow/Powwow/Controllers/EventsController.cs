using Salesforce.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Powwow.Models.Salesforce;
using Powwow.Salesforce;
using Powwow.Models.ViewModels;
using Powwow.Logic;
using Powwow.Helpers;

namespace Powwow.Controllers
{
    public class EventsController : Controller
    {
        const string _EventsPostBinding = "";
        const string _SelectAll = "SELECT Id, WhoId, WhatId, Subject, Location, IsAllDayEvent, ActivityDateTime, ActivityDate, DurationInMinutes, StartDateTime, EndDateTime, Description, AccountId, OwnerId, IsPrivate, ShowAs, IsDeleted, IsChild, IsGroupEvent, GroupEventType, CreatedDate, CreatedById, LastModifiedDate, LastModifiedById From Event";

        // GET: Events
        public async Task<ActionResult> Index()
        {
            IEnumerable<Event> selectedEvents = Enumerable.Empty<Event>();
            try
            {
                selectedEvents = await SalesforceService
                    .MakeAuthenticatedClientRequestAsync(
                    async (client) =>
                    {
                        QueryResult<Event> events = await client
                        .QueryAsync<Event>(_SelectAll);
                        return events.Records;
                    }
                    );
            }
            catch (Exception e)
            {
                ViewBag.OperationName = "query Salesforce Events";
                ViewBag.AuthorizationUrl = SalesforceOAuthRedirectHandler
                    .GetAuthorizationUrl(Request.Url.ToString());
                ViewBag.ErrorMessage = e.Message;
            }
            if (ViewBag.ErrorMessage == "AuthorizationRequired")
            {
                return Redirect(ViewBag.AuthorizationUrl);
            }
            IEnumerable<EventIndexViewModel> viewEvents = EventHelper.GetEventIndexViewModel(selectedEvents);
            return View(viewEvents);
        }

        public async Task<ActionResult> Details(string id)
        {
            IEnumerable<Event> selectedEvents = Enumerable.Empty<Event>();
            try
            {
                selectedEvents = await SalesforceService
                    .MakeAuthenticatedClientRequestAsync(
                    async (client) =>
                    {
                        QueryResult<Event> Events =
                            await client
                            .QueryAsync<Event>(
                                _SelectAll + $" Where Id='{id}'");
                        return Events.Records;
                    }
                    );
            }
            catch (Exception e)
            {
                ViewBag.OperationName = "Salesforce Events Details";
                ViewBag.AuthorizationUrl = SalesforceOAuthRedirectHandler
                    .GetAuthorizationUrl(Request.Url.ToString());
                ViewBag.ErrorMessage = e.Message;
            }
            if (ViewBag.ErrorMessage == "AuthorizationRequired")
            {
                return Redirect(ViewBag.AuthorizationUrl);
            }
            return View(selectedEvents.Single());
        }

        public async Task<ActionResult> Edit(string id)
        {
            IEnumerable<Event> selectedEvents = Enumerable.Empty<Event>();
            try
            {
                selectedEvents = await SalesforceService
                    .MakeAuthenticatedClientRequestAsync(
                    async (client) =>
                    {
                        QueryResult<Event> Events =
                            await client
                            .QueryAsync<Event>(
                                _SelectAll + $" Where Id= '{id}'");
                        return Events.Records;
                    }
                    );
            }
            catch (Exception e)
            {
                ViewBag.OperationName = "Edit Salesforce Events";
                ViewBag.AuthorizationUrl = SalesforceOAuthRedirectHandler
                    .GetAuthorizationUrl(Request.Url.ToString());
                ViewBag.ErrorMessage = e.Message;
            }
            if (ViewBag.ErrorMessage == "AuthorizationRequired")
            {
                return Redirect(ViewBag.AuthorizationUrl);
            }
            return View(selectedEvents.FirstOrDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = _EventsPostBinding)] Event Event)
        {
            SuccessResponse success = new SuccessResponse();
            try
            {
                success = await SalesforceService
                    .MakeAuthenticatedClientRequestAsync(
                    async (client) =>
                    {
                        success = await client
                        .UpdateAsync("Event", Event.Id, Event);
                        return success;
                    }
                    );
            }
            catch (Exception e)
            {
                ViewBag.OperationName = "Edit Salesforce Event";
                ViewBag.AuthorizationUrl = SalesforceOAuthRedirectHandler
                    .GetAuthorizationUrl(Request.Url.ToString());
                ViewBag.ErrorMessage = e.Message;
            }
            if (ViewBag.ErrorMessage == "AuthorizationRequired")
            {
                return Redirect(ViewBag.AuthorizationUrl);
            }
            if (success.Success)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(Event);
            }
        }

        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IEnumerable<Event> selectedEvents = Enumerable.Empty<Event>();
            try
            {
                selectedEvents = await SalesforceService
                    .MakeAuthenticatedClientRequestAsync(
                async (client) =>
                {
                    // Query the properties you'll display for the user to confirm they wish to delete this Event
                    QueryResult<Event> Events =
                        await client
                        .QueryAsync<Event>(
                            _SelectAll + $" Where Id='{id}'");
                    return Events.Records;
                }
                );
            }
            catch (Exception e)
            {
                ViewBag.OperationName = "query Salesforce Events";
                ViewBag.AuthorizationUrl = SalesforceOAuthRedirectHandler
                    .GetAuthorizationUrl(Request.Url.ToString());
                ViewBag.ErrorMessage = e.Message;
            }
            if (ViewBag.ErrorMessage == "AuthorizationRequired")
            {
                return Redirect(ViewBag.AuthorizationUrl);
            }
            if (selectedEvents.Count() == 0)
            {
                return View();
            }
            else
            {
                return View(selectedEvents.FirstOrDefault());
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            bool success = false;
            try
            {
                success = await SalesforceService
                    .MakeAuthenticatedClientRequestAsync(
                    async (client) =>
                    {
                        success = await client
                        .DeleteAsync("Event", id);
                        return success;
                    }
                    );
            }
            catch (Exception e)
            {
                ViewBag.OperationName = "Delete Salesforce Events";
                ViewBag.AuthorizationUrl = SalesforceOAuthRedirectHandler
                    .GetAuthorizationUrl(Request.Url.ToString());
                ViewBag.ErrorMessage = e.Message;
            }
            if (ViewBag.ErrorMessage == "AuthorizationRequired")
            {
                return Redirect(ViewBag.AuthorizationUrl);
            }
            if (success)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = _EventsPostBinding)] Event Event)
        {
            SuccessResponse success = new SuccessResponse();
            String id = String.Empty;
            try
            {
                success = await SalesforceService.MakeAuthenticatedClientRequestAsync(
                    async (client) =>
                    {
                        return await client.CreateAsync("Event", Event);
                    }
                    );
                id = success.Id;
            }
            catch (Exception e)
            {
                this.ViewBag.OperationName = "Create Salesforce Event";
                this.ViewBag.AuthorizationUrl = SalesforceOAuthRedirectHandler.GetAuthorizationUrl(this.Request.Url.ToString());
                this.ViewBag.ErrorMessage = e.Message;
            }
            if (this.ViewBag.ErrorMessage == "AuthorizationRequired")
            {
                return Redirect(this.ViewBag.AuthorizationUrl);
            }
            if (this.ViewBag.ErrorMessage == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(Event);
            }
        }
    }
}