using Newtonsoft.Json;
using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class QnaList
    {
        public QnaList()
        {
            metadata = new List<Metadata>();
            questions = new List<string>();
        }
        public int id { get; set; }
        public string answer { get; set; }
        public string source { get; set; }
        public List<string> questions { get; set; }
        public List<Metadata> metadata { get; set; }
    }
}