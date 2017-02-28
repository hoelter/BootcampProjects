using Powwow.Helpers;
using Powwow.Models.Salesforce;
using Powwow.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Powwow.Models.ViewModels
{
    public class RecordingTargetSelection
    {
        public IEnumerable<EventSelectListViewModel> Events { get; set; }
        public IEnumerable<ContactCheckBoxViewModel> Contacts { get; set; }
        public IEnumerable<LeadCheckBoxViewModel> Leads { get; set; }
        public int? SelectedPersonID { get; set; }
        public int? SelectedEventID { get; set; }

        public RecordingTargetSelection(IEnumerable<Event> events=null, IEnumerable<Contact> contacts=null, IEnumerable<Lead> leads=null)
        {
            Events = EventHelper.GetEventIndexViewModel(events)
                .Select(e => new EventSelectListViewModel(e));
            Contacts = contacts.Select(c => new ContactCheckBoxViewModel(c));
            Leads = leads.Select(L => new LeadCheckBoxViewModel(L));
        }
    }
}