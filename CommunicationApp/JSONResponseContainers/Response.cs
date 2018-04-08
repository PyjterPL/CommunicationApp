using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    internal class Response
    {
        [JsonProperty("turn")]
        public string Turn { get; }
        [JsonProperty("location")]
        public string Location { get; }
        [JsonProperty("events")]
        public List<string> Events { get; }
        [JsonProperty("lastTurnEvents")]
        public List<string> LastTurnEvents { get; }
        [JsonProperty("equipments")]
        public List<string> Equipments { get; }
        [JsonProperty("logBook")]
        public List<string> LogBook { get; }
        [JsonProperty("scores")]
        public Score Scores { get; }
        [JsonProperty("parameters")]
        public Parameters Parameters { get; }
        [JsonProperty("isTerminated")]
        public bool IsTerminated { get; }
        public Response(string turn, string location, List<string> events, List<string> lastTurnEvents, List<string> equipments, List<string> logBook, Score scores, Parameters parameters, bool isTerminated)
        {
            this.Turn = turn;
            this.Location = location;
            this.Events = events;
            this.LastTurnEvents = lastTurnEvents;
            this.Equipments = equipments;
            this.LogBook = logBook;
            this.Scores = scores;
            this.Parameters = parameters;
            this.IsTerminated = isTerminated;
        }
        public override string ToString()
        {
            string response = string.Empty;
            response += "Turn: " + Turn + Environment.NewLine + Environment.NewLine +
                        "Location: " + Location + Environment.NewLine + Environment.NewLine +
                        "Events: " + Environment.NewLine;
            response += EventsToString() + Environment.NewLine;
            response += "LastTurnEvents: " + Environment.NewLine;
            response += LastTurnEventsToString() + Environment.NewLine;
            response += "Equipments: " + Environment.NewLine;
            response += EquipmentsToString() + Environment.NewLine;
            response += "LogBook: " + Environment.NewLine;
            response += LogBookToString() + Environment.NewLine;
            response += "Scores:" + Environment.NewLine + Scores.ToString() + Environment.NewLine;
            response += "Parameters:" + Environment.NewLine + Parameters.ToString() + Environment.NewLine;
            response += "Is terminated?: " + IsTerminated.ToString();

            return response;
        }
        public string EventsToString()
        {
            string events = string.Empty;
            foreach (string _event in Events)
            {
                events += _event + Environment.NewLine;
            }
            return events;
        }
        public string LastTurnEventsToString()
        {
            string lastTurnEvents = string.Empty;
            foreach (string lastTurnEvent in LastTurnEvents)
            {
                lastTurnEvents += lastTurnEvent + Environment.NewLine;
            }
            return lastTurnEvents;
        }
        public string LogBookToString()
        {
            string logBook = string.Empty;
            foreach (string log in LogBook)
            {
                logBook += log + Environment.NewLine + Environment.NewLine;
            }
            return logBook;
        }
        public string EquipmentsToString()
        {
            string equipments = string.Empty;
            foreach(string equipment in Equipments)
            {
                equipments += equipment + Environment.NewLine;
            }
            return equipments;
        }
    }
}
