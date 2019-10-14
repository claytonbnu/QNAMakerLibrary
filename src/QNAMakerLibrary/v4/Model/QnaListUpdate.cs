using Newtonsoft.Json;

namespace QNAMakerClient.v4.Model
{
    public class QnaListUpdate
    {
        public int id { get; set; }

        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public string answer { get; set; }
        
        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public string source { get; set; }

        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public QuestionsUpdate questions { get; set; }

        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public MetadataUpdate metadata { get; set; }
    }

}
