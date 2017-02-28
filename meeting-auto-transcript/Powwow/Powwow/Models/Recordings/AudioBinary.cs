using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Powwow.Models.Recordings
{
    public class AudioBinary
    { 
        [Key]
        public int ID { get; set; }
        
        [ForeignKey("Recording")]
        public int RecordingID { get; set; }

        public byte[] AudioBytes { get; set; }

        public AudioType AudioType { get; set; }

        public virtual Recording Recording { get; set; }

        public ICollection<RecordingText> RecordingText { get; set; }

        protected AudioBinary() { }
        public AudioBinary(byte[] audioBytes, AudioType audioType)
        {
            if (audioBytes == null || audioBytes.Length < 1)
            {
                throw new InvalidOperationException("AudioBytes must contain values.");
            }
            AudioBytes = audioBytes;
            AudioType = audioType;
        }

        public void AddRecordingText(RecordingText recordingText)
        {
            RecordingText.Add(recordingText);
        }

        public void AddRecording(Recording recording)
        {
            Recording = recording;
        }

        public void DeleteBinary()
        {
            AudioBytes = null;
        }
    }

  
}