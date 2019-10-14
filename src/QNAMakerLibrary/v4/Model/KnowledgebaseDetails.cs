using System;
using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class KnowledgebaseDetails
    {
        public KnowledgebaseDetails()
        {
            urls = new List<string>(); 
            sources = new List<string>();
        }

        public string id { get; set; }
        public string hostName { get; set; }
        public DateTime lastAccessedTimestamp { get; set; }
        public DateTime lastChangedTimestamp { get; set; }
        public DateTime lastPublishedTimestamp { get; set; }
        public string name { get; set; }
        public string userId { get; set; }
        public List<string> urls { get; set; }
        public List<string> sources { get; set; }
    }


}
