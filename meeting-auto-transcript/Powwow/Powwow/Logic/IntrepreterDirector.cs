using Powwow.Models.Recordings;
using System;
using System.IO;

namespace Powwow.Logic
{
    public static class InterpreterDirector
    {

        public static RecordingText TranslateSpeechToText(AudioBinary audioBinary, SpeechToTextGoogleAPI interpreter)
        {
            if (audioBinary == null || interpreter == null)
            {
                throw new InvalidOperationException("AudioBinary and Interpreter cannot be null.");
            }
            InterpretationResult result = null;
            switch (interpreter.AudioRequirement)
            {
                case AudioType.Flac:
                    Tuple<int, string> sampleRateAndTargetFlac = ConvertFileToFlac(audioBinary);
                    interpreter.SpeechRequest(sampleRateAndTargetFlac.Item1, sampleRateAndTargetFlac.Item2);
                    result = new InterpretationResult(interpreter);
                    File.Delete(sampleRateAndTargetFlac.Item2);
                    break;
                default:
                    throw new NotImplementedException("This audio type is not yet implemented");
            }
            return new RecordingText(result, audioBinary);
        }
        private static Tuple<int, string> ConvertFileToFlac(string targetFilePath)
        {
            if (Path.GetExtension(targetFilePath) != ".wav")
            {
                throw new InvalidOperationException("Target file must be wav in order to convert to flac.");
            }
            Tuple<int, string> sampleRateAndTargetFlac = CUEToolsConverter.WavToFlac(targetFilePath);
            return sampleRateAndTargetFlac;
        }

        private static Tuple<int, string> ConvertFileToFlac(AudioBinary audioBinary)
        {
            if (audioBinary.AudioType != AudioType.Wav)
            {
                throw new InvalidOperationException("Target file must be wav in order to convert to flac.");
            }
            string flacSavePath = AppDomain.CurrentDomain.BaseDirectory + "uploads/" + "meeting.flac";
            Tuple<int, string> sampleRateAndTargetFlac = CUEToolsConverter.WavToFlac(audioBinary.AudioBytes, flacSavePath);
            return sampleRateAndTargetFlac;
        }
    }

    public class InterpretationResult
    {
        public string ResultText { get; private set; }
        public string InterpreterName { get; private set; }

        public InterpretationResult(SpeechToTextGoogleAPI  interpreter)
        {
            if (interpreter.InterpretationResult == null)
            {
                throw new InvalidOperationException("interpreter must have run");
            }
            ResultText = interpreter.InterpretationResult;
            InterpreterName = interpreter.InterpreterName;
        }
    }
}