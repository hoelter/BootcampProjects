using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace VacationLib
{
    class GoogleCalendar

    {
        CalendarService service;
        public GoogleCalendar()
        {
            string[] Scopes = { CalendarService.Scope.Calendar };
            string ApplicationName = "Google Calendar API Quickstart";
            UserCredential credential;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                   GoogleClientSecrets.Load(stream).Secrets,
                   Scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;

            }
             service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
        public Event CreateEvent(DateTime start, DateTime end)
        {
            
            Event newEvent = new Event()
            {
                Summary = "",
                Location = "",
                Start  = new EventDateTime()
                {
                    DateTime = start,
                    TimeZone = "America/chicago",
                },
                End = new EventDateTime()
                {
                    DateTime = end,
                    TimeZone = "America Chicago",
                }
                   
            };
            return newEvent;
        }
        public void pushEvent(Event newEvent)
        {
            EventsResource.InsertRequest request = service.Events.Insert(newEvent, "primary");
            Event createdEvent = request.Execute();
        }
    }
}
