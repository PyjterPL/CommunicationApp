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
        public string SurvivorsScore { get; }
        [JsonProperty("scienceScore")]
        public string ScienceScore { get; }
        [JsonProperty("crewMalus")]
        public string CrewMalus { get; }
        [JsonProperty("knowledgeScore")]
        public string KnowledgeScore { get; }
        [JsonProperty("eventScore")]
        public string EventScore { get; }
        [JsonProperty("totalScore")]
        public string TotalScore { get; }

        public Score(string survivorsScore, string scienceScore, string crewMalus, string knowledgeScore, string eventScore, string totalScore)
        {
            this.SurvivorsScore = survivorsScore;
            this.ScienceScore = scienceScore;
            this.CrewMalus = crewMalus;
            this.KnowledgeScore = knowledgeScore;
            this.EventScore = eventScore;
            this.TotalScore = totalScore;
        }
        public override string ToString()
        {
            return "SurvivorsScore: " + SurvivorsScore + Environment.NewLine +
                   "ScienceScore: " + ScienceScore + Environment.NewLine +
                   "CrewMalus: " + CrewMalus + Environment.NewLine +
                   "KnowledgeScore: " + KnowledgeScore + Environment.NewLine +
                   "EventScore: " + EventScore + Environment.NewLine +
                   "TotalScore: " + TotalScore + Environment.NewLine;
        }
    }
}
