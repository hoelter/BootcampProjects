using Powwow.DataContexts;
using Powwow.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Powwow.Models.Recordings
{
    public class Recording
    {
        private RecordingsDb recordingsDb = new RecordingsDb();

        [Key]
        public int ID { get; private set; }
   
        [Required]
        [ForeignKey("SalesforceUser")]
        public int SalesforceUserID { get; private set; }

        [Display(Name = "Time of Recording")]
        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTimeOffset? RecordingTime { get; private set; }

        public string[] TargetSalesforceIDS { get; private set; }

        public virtual SalesforceUser SalesforceUser { get; private set; }

        public virtual ICollection<RecordingText> RecordingText { get; private set; }

        public virtual ICollection<AudioBinary> AudioBinary { get; private set; }


        protected Recording() { }
        public Recording(SalesforceUser user, DateTimeOffset recordingTime, AudioBinary audioBinary)
        {
            if (audioBinary == null)
            {
                throw new InvalidOperationException("Audio data must exist in order to create a recording.");
            }
            SalesforceUserID = user.ID;
            RecordingTime = recordingTime;
            audioBinary.AddRecording(this);
        }




    }
}