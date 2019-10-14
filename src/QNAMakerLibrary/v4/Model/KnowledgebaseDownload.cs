using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class KnowledgebaseDownload
    {
        public KnowledgebaseDownload()
        {
            qnaDocuments = new List<QnaList>();
        }
        public List<QnaList> qnaDocuments { get; set; }

    }



}
