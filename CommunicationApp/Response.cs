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
        public string turn { get; }
        [JsonProperty("location")]
        public string location { get; }
        [JsonProperty("events")]
        public List<string> events { get; }
        [JsonProperty("lastTurnEvents")]
        public List<string> lastTurnEvents { get; }
        [JsonProperty("equipments")]
        public List<string> equipments { get; }
        [JsonProperty("logBook")]
        public List<string> logBook { get; }
        [JsonProperty("scores")]
        public Score scores { get; }
        [JsonProperty("parameters")]
        public Parameters parameters { get; }
        [JsonProperty("isTerminated")]
        public bool isTerminated { get; }
        public Response(string turn, string location, List<string> events, List<string> lastTurnEvents, List<string> equipments, List<string> logBook, Score scores, Parameters parameters, bool isTerminated)
        {
            this.turn = turn;
            this.location = location;
            this.events = events;
            this.lastTurnEvents = lastTurnEvents;
            this.equipments = equipments;
            this.logBook = logBook;
            this.scores = scores;
            this.parameters = parameters;
            this.isTerminated = isTerminated;
        }
    }
}
