using Powwow.DataContexts;
using Powwow.Helpers;
using Powwow.Logic;
using Powwow.Models.Recordings;
using Powwow.Models.Salesforce;
using Powwow.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Powwow.Controllers
{
    public class RecordController : Controller
    {
        private RecordingsDb recordingsDb = new RecordingsDb();
        private ControllerHelper helper = new ControllerHelper();

        public async Task<ActionResult> Index(int? id)
        {
            if (id != null)
            {
                Recording recording = await recordingsDb.Recordings.FindAsync(id);
                if (recording == null)
                {
                    return HttpNotFound();
                }
                Session[helper.RecordingKey] = id;
            }
            IEnumerable<Event> selectedEvents = Enumerable.Empty<Event>();
            IEnumerable<Contact> selectedContacts = Enumerable.Empty<Contact>();
            IEnumerable<Lead> selectedLeads = Enumerable.Empty<Lead>();
            string eventsQuery = "SELECT Id, WhoId, OwnerId, Description, Location, Subject, IsAllDayEvent, ActivityDateTime, ActivityDate, DurationInMinutes, StartDateTime, EndDateTime, CreatedDate From Event";
            string contactsQuery = "SELECT Id, Name From Contact";
            string leadsQuery = "SELECT Id, Name From Lead";
            string operationName = "Query all Salesforce Events, Contacts, and Leads.";
            try
            {
                selectedEvents = await helper.SalesforceRequest<Event>(eventsQuery);
                selectedContacts = await helper.SalesforceRequest<Contact>(contactsQuery);
                selectedLeads = await helper.SalesforceRequest<Lead>(leadsQuery);
            }
            catch (Exception ex)
            {
                helper.CatchSalesforceRequest(this, ex, operationName);
            }
            if (helper.LoginRedirectNeeded(this))
            {
                return helper.RedirectToLogin(this);
            }
            RecordingTargetSelection recordingTargets = new RecordingTargetSelection(selectedEvents, selectedContacts, selectedLeads);
            return View(recordingTargets);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> IndexSelection(string[] selectedContacts, string[] selectedLeads)
        {

            return RedirectToAction("Index", "Home");
        }

        public async Task<ActionResult> Record(int? id)
        {
            if (id == helper.RecordFailureRouteValue)
            {
                ViewBag.RecordFailure = "Recording failed, please try again.";
            }
            SalesforceUser user = await helper.GetCurrentUser(this);
            if (helper.LoginRedirectNeeded(this))
            {
                return helper.RedirectToLogin(this);
            }
            if (user == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Session[helper.UserKey] = user;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Recorded()
        {
            byte[] audioBytes = null;
            HttpPostedFileBase file = null;
            SalesforceUser user = Session[helper.UserKey] as SalesforceUser;
            DateTimeOffset recordingTime = DateTime.Now;
            SpeechToTextGoogleAPI googleInterpreter = new SpeechToTextGoogleAPI();
            if (Request.Files.Count < 1)
            {
                return RedirectToAction("Record", new { id = helper.RecordFailureRouteValue });
            }
            foreach (string upload in Request.Files)
            {
                file = Request.Files[upload];
                if (file == null) continue;
                audioBytes = new byte[file.ContentLength];
            }
            //Only want the one file, will default to last file iterated and write to the audioBytes
            file.InputStream.Read(audioBytes, 0, file.ContentLength);
            AudioBinary audioBinary = new AudioBinary(audioBytes, AudioType.Wav);
            RecordingText googleText = InterpreterDirector.TranslateSpeechToText(audioBinary, googleInterpreter);
            Recording newRecording = new Recording(user, recordingTime, audioBinary);
            recordingsDb.Recordings.Add(newRecording);
            await recordingsDb.SaveChangesAsync();
            recordingsDb.AudioBinarys.Add(audioBinary);
            await recordingsDb.SaveChangesAsync();
            recordingsDb.RecordingTexts.Add(googleText);
            await recordingsDb.SaveChangesAsync();

            return RedirectToAction("index", new { id = newRecording.ID });
        }
    }
}