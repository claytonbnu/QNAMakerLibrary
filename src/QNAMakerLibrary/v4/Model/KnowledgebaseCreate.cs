using System.Collections.Generic;
using QNAMakerClient.v4.Model;

namespace QNAMakerClient.v4.Model
{
    public class KnowledgebaseCreate
    {
        public KnowledgebaseCreate()
        {
            qnaList = new List<QnaList>();
            urls = new List<string>();
            files = new List<File>();
        }

        public string name { get; set; }
        public List<QnaList> qnaList { get; set; }
        public List<string> urls { get; set; }
        public List<File> files { get; set; }
    }
}
