using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class Answers
    {
        public Answers()
        {
            answers = new List<Answer>();
        }
        public List<Answer> answers { get; set; }
    }
}