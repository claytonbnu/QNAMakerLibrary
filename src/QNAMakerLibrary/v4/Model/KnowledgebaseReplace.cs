using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class KnowledgebaseReplace
    {
        public KnowledgebaseReplace()
        {
            qnaList = new List<QnaList>();
        }

        public List<QnaList> qnaList { get; set; }
    }
}
