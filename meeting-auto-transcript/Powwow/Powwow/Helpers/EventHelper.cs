using Powwow.Models.Salesforce;
using Powwow.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Powwow.Helpers
{
        public class EventHelper
        {
         //whoid= fk for primary lead/contact
        //whocount= multiple contacts if enabled
        //whatID=fk associated with account/oppur/camp/cases/ or custom obj
        //whatcount= for mult activities if enabled
        //type = use to check for 'meeting'
        //subject = subject line of meeting...also use for check?
        //startdatetime = what it seems, unless activitydate/datetime is present
        //activitydatetime = may also be needed
        //activitydate = exists if isalldayevent is set to true
        //location = location of event
        //enddatetime / durationinminutes= one or the other used to calc end
        //description = event description
        //accountid= id of related account
        //
            public static IEnumerable<EventIndexViewModel> GetEventIndexViewModel(IEnumerable<Event> events)
            {
                List<EventIndexViewModel> eventIndexViewModels = new List<EventIndexViewModel>();
                foreach (Event e in events)
                {
                    if (e.Subject.ToLower().Contains("meeting"))
                    {
                        EventIndexViewModel eivm = new EventIndexViewModel();
                        eivm.Id = e.Id;
                        eivm.Location = e.Location;
                        eivm.WhoId = e.WhoId;
                        eivm.OwnerId = e.OwnerId;
                        eivm.Description = e.Description;
                        eivm.Subject = e.Subject;
                        MapDatesEventIndexViewModel(eivm, e);
                        eventIndexViewModels.Add(eivm);
                    }
                }
                return eventIndexViewModels;
            }

            private static void MapDatesEventIndexViewModel(EventIndexViewModel eivm, Event e)
            {
                if (string.IsNullOrWhiteSpace(e.StartDateTime.ToString()))
                {
                    if (e.IsAllDayEvent)
                    {
                        eivm.StartDateTime = e.ActivityDate;
                    }
                    else
                    {
                        eivm.StartDateTime = e.ActivityDateTime;
                    }
                }
                else
                {
                    eivm.StartDateTime = e.StartDateTime;
                }
                //may need to be made more comprehensive, durationInMinutes
                eivm.EndDateTime = e.EndDateTime;
                eivm.CreatedDate = e.CreatedDate;
            }
    }
}