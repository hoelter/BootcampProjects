using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using Powwow.Models.Recordings;

namespace Powwow.Logic
{
    public class SpeechToTextGoogleAPI
    {
        private const string APIURL = "http://www.google.com/speech-api/v2/recognize?";
        private readonly Uri fullURL;
        public readonly string InterpreterName = "Google Speech To Text API";
        public readonly AudioType AudioRequirement = AudioType.Flac;
        public string InterpretationResult { get; private set; }

        public SpeechToTextGoogleAPI(string client="chromium", string lang="en_US")
        {
            string finalUrl = BuildFinalUrl(client, lang, Secrets.GoogleDeveloperKey);
            fullURL = new Uri(finalUrl);
        }

        private string BuildFinalUrl(string client, string lang, string key)
        {
            //h/ttp://www.google.com/speech-api/v2/recognize?client=chromium&lang=en-US&key=your_key
            string finalUrl = APIURL;
            //poss add &maxresults=1
            finalUrl = finalUrl + $"client={client}&lang={lang}&key={key}";
            return finalUrl;
        }

        public void SpeechRequest(int sampleRate, string targetFile)
        {
            string response = null;
            WebRequest request = WebRequest.Create(fullURL);
            request.Method = "POST";
            byte[] audioBytes = File.ReadAllBytes(targetFile);
            request.ContentType = $"audio/x-flac; rate={sampleRate}";
            request.ContentLength = audioBytes.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(audioBytes, 0, audioBytes.Length);
            }
            using (StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                reader.ReadLine();
                response = reader.ReadLine();
            }
            InterpretationResult = ParseSpeechResponse(response);
        }

        private string ParseSpeechResponse(string response)
        {
            JToken j = JObject.Parse(response);
            var result = j["result"][0]["alternative"][0]["transcript"].Value<string>();
            return result;
        }
    }
}