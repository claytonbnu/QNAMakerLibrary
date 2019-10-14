using System.Collections.Generic;
using Newtonsoft.Json;

namespace QNAMakerClient.v4.Model
{
    public class QuestionsUpdate
    {
        public QuestionsUpdate()
        {
         //   add = new List<string>();    
           // delete = new List<string>();
        }

        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public List<string> add { get; set; }

        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public List<string> delete { get; set; }
    }

}
