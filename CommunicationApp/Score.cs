using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    internal class Score
    {

        [JsonProperty("survivorsScore")]
        public string survivorsScore { get; }
        [JsonProperty("scienceScore")]
        public string scienceScore { get; }
        [JsonProperty("crewMalus")]
        public string crewMalus { get; }
        [JsonProperty("knowledgeScore")]
        public string knowledgeScore { get; }
        [JsonProperty("eventScore")]
        public string eventScore { get; }
        [JsonProperty("totalScore")]
        public string totalScore { get; }

        public Score(string survivorsScore, string scienceScore, string crewMalus, string knowledgeScore, string eventScore, string totalScore)
        {
            this.survivorsScore = survivorsScore;
            this.scienceScore = scienceScore;
            this.crewMalus = crewMalus;
            this.knowledgeScore = knowledgeScore;
            this.eventScore = eventScore;
            this.totalScore = totalScore;
        }
    }
}
