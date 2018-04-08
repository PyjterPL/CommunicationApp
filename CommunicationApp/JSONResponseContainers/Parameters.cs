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
        public string chaarrHatred { get; }
        [JsonProperty("knowledge")]
        public string knowledge { get; }
        [JsonProperty("crewDeaths")]
        public string crewDeaths { get; }
        [JsonProperty("survivorDeaths")]
        public string survivorDeaths { get; }
        [JsonProperty("savedScience")]
        public string savedScience { get; }
        [JsonProperty("savedSurvivors")]
        public string savedSurvivors { get; }
        [JsonProperty("południcaMatter")]
        public string poludnicaMatter { get; }
        [JsonProperty("południcaEnergy")]
        public string poludnicaEnergy { get; }
        [JsonProperty("expeditionMatter")]
        public string expeditionMatter { get; }
        [JsonProperty("expeditionEnergy")]
        public string expeditionEnergy { get; }

        public Parameters(string chaarrHatred,string knowledge,string crewDeaths,string survivorDeaths,string savedSurvivors,
            string poludnicaEnergy,string poludnicaMatter, string expeditionMatter,string expeditionEnergy)
        {
            this.chaarrHatred = chaarrHatred;
            this.knowledge = knowledge;
            this.crewDeaths = crewDeaths;
            this.survivorDeaths = survivorDeaths;
            this.savedScience = savedScience;
            this.savedSurvivors = savedSurvivors;
            this.poludnicaEnergy = poludnicaEnergy;
            this.poludnicaMatter = poludnicaMatter;
            this.expeditionEnergy = expeditionEnergy;
            this.expeditionMatter = expeditionMatter;
        }

    }
}
