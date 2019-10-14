using System.Collections.Generic;
using Newtonsoft.Json;

namespace QNAMakerClient.v4.Model
{
    public class Update
    {
        public Update()
        {
          //  qnaList = new List<QnaListUpdate>();
          //  urls = new List<string>();
        }

        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public string name { get; set; }

        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public List<QnaListUpdate> qnaList { get; set; }
        
        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public List<string> urls { get; set; }
    }

}
