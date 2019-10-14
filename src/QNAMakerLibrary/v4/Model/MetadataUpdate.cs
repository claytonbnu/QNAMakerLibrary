using System.Collections.Generic;
using Newtonsoft.Json;

namespace QNAMakerClient.v4.Model
{

    public class MetadataUpdate
    {
        public MetadataUpdate()
        {
           // add = new List<Metadata>();
            //delete = new List<Metadata>();
        }

        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public List<Metadata> delete { get; set; }

        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public List<Metadata> add { get; set; }
    }

}
