using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class Answer
    {
        public Answer()
        {
            questions = new List<string>();
            metadata = new List<Metadata>();
        }

        public List<string> questions { get; set; }

        public string answer { get; set; }

        public float score { get; set; }

        public int id { get; set; }

        public string source { get; set; }

        public List<Metadata> metadata { get; set; }
    }
}