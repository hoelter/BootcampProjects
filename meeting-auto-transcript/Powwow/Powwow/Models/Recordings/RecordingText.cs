using Powwow.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Powwow.Models.Recordings
{
    public class RecordingText
    {
        [Key]
        public int ID { get; private set; }

        [ForeignKey("AudioBinary")]
        public int AudioBinaryID { get; private set; }

        public string Text { get; private set; }

        public string InterpreterName { get; private set; }

        public virtual AudioBinary AudioBinary { get; private set; }

        protected RecordingText() { }
        public RecordingText(InterpretationResult interpretation, AudioBinary audioBinary)
        {
            if (interpretation == null)
            {
                throw new InvalidOperationException("Inerpretation must contain data!");
            }
            Text = interpretation.ResultText;
            InterpreterName = interpretation.InterpreterName;
            AudioBinary = audioBinary;
        }
    }
}