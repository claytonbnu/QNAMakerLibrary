using Newtonsoft.Json;
using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class Question
    {
        public Question()
        {
            strictFilters = new List<Metadata>();
        }

        public string question { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int top { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Metadata> strictFilters { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string userId { get; set; }
        
        [JsonIgnore]
        public float Score { get; set; }
    }
}