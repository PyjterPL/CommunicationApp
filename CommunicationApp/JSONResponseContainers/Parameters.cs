using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    internal class Parameters
    {
        [JsonProperty("chaarrHatred")]
        public string ChaarrHatred { get; }
        [JsonProperty("knowledge")]
        public string Knowledge { get; }
        [JsonProperty("crewDeaths")]
        public string CrewDeaths { get; }
        [JsonProperty("survivorDeaths")]
        public string SurvivorDeaths { get; }
        [JsonProperty("savedScience")]
        public string SavedScience { get; }
        [JsonProperty("savedSurvivors")]
        public string SavedSurvivors { get; }
        [JsonProperty("południcaMatter")]
        public string PoludnicaMatter { get; }
        [JsonProperty("południcaEnergy")]
        public string PoludnicaEnergy { get; }
        [JsonProperty("expeditionMatter")]
        public string ExpeditionMatter { get; }
        [JsonProperty("expeditionEnergy")]
        public string ExpeditionEnergy { get; }

        public Parameters(string chaarrHatred, string knowledge, string crewDeaths, string survivorDeaths, string savedScience,
            string savedSurvivors, string poludnicaEnergy, string poludnicaMatter, string expeditionMatter, string expeditionEnergy)
        {
            this.ChaarrHatred = chaarrHatred;
            this.Knowledge = knowledge;
            this.CrewDeaths = crewDeaths;
            this.SurvivorDeaths = survivorDeaths;
            this.SavedScience = savedScience;
            this.SavedSurvivors = savedSurvivors;
            this.PoludnicaEnergy = poludnicaEnergy;
            this.PoludnicaMatter = poludnicaMatter;
            this.ExpeditionEnergy = expeditionEnergy;
            this.ExpeditionMatter = expeditionMatter;
        }
        public override string ToString()
        {
            return "ChaarrHatred: " + ChaarrHatred + Environment.NewLine +
                   "Knowledge: " + Knowledge + Environment.NewLine +
                   "CrewDeaths: " + CrewDeaths + Environment.NewLine +
                   "SurvivorDeaths: " + SurvivorDeaths + Environment.NewLine +
                   "SavedScience: " + SavedScience + Environment.NewLine +
                   "SavedSurvivors: " + SavedSurvivors + Environment.NewLine +
                   "PoludnicaMatter: " + PoludnicaMatter + Environment.NewLine +
                   "PoludnicaEnergy: " + PoludnicaEnergy + Environment.NewLine +
                   "ExpeditionMatter: " + ExpeditionMatter + Environment.NewLine +
                   "ExpeditionEnergy: " + ExpeditionEnergy + Environment.NewLine;
        }

    }
}
