using System;
using CUETools.Codecs.FLAKE;
using CUETools.Codecs;
using System.IO;

namespace Powwow.Logic
{
    public static class CUEToolsConverter
    {
        public static Tuple<int, string> WavToFlac(string targetWavFile)
        {
            string targetFlacPath = FormatFileName(targetWavFile, ".FLAC");
            WAVReader audioSource = new WAVReader(targetWavFile, null);
            //AudioBuffer buffer = new AudioBuffer(audioSource, 0x10000);
            //FlakeWriterSettings settings = new FlakeWriterSettings();
            //settings.PCM = audioSource.PCM;
            //FlakeWriter audioDestination = new FlakeWriter(targetFlacPath, settings);
            //while (audioSource.Read(buffer, -1) != 0)
            //{
            //    audioDestination.Write(buffer);
            //}
            //sampleRate = settings.PCM.SampleRate;
            //audioDestination.Close();
            //audioSource.Close();
            //Tuple<int, string> output = new Tuple<int, string>(sampleRate, targetFlacPath);
            return WavToFlacHelper(audioSource, targetFlacPath);
        }

        public static Tuple<int, string> WavToFlac(byte[] wavBytes, string flacSavePath)
        {
            Tuple<int, string> sampleRateAndTargetFlac = null;
            string targetFlacPath = FormatFileName(flacSavePath, ".FLAC");
            using (Stream dataStream = new MemoryStream(wavBytes))
            {
                WAVReader audioSource = new WAVReader(null, dataStream);
                sampleRateAndTargetFlac = WavToFlacHelper(audioSource, targetFlacPath);
            }
            return sampleRateAndTargetFlac;
        }

        private static Tuple<int, string> WavToFlacHelper(WAVReader audioSource, string targetFlacPath)
        {
            int sampleRate;
            AudioBuffer buffer = new AudioBuffer(audioSource, 0x10000);
            FlakeWriterSettings settings = new FlakeWriterSettings();
            settings.PCM = audioSource.PCM;
            FlakeWriter audioDestination = new FlakeWriter(targetFlacPath, settings);
            while (audioSource.Read(buffer, -1) != 0)
            {
                audioDestination.Write(buffer);
            }
            sampleRate = settings.PCM.SampleRate;
            audioDestination.Close();
            audioSource.Close();
            return new Tuple<int, string>(sampleRate, targetFlacPath);
        }

        private static string FormatFileName(string originalFilePath, string newFileType)
        {
            string newTargetFile = null;
            if (newFileType[0] != '.')
            {
                newFileType = '.' + newFileType;
            }
            for(int i = originalFilePath.Length - 1; i > 0; i--)
            {
                if (originalFilePath[i] == '.')
                {
                    newTargetFile = originalFilePath.Substring(0, i) + newFileType;
                }
            }
            return newTargetFile;
        }
    }
}