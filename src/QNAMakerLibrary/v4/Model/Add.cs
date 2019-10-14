using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class Add
    {
        public Add()
        {
            qnaList = new List<QnaList>();
            files = new List<File>();
            urls = new List<string>();
        }
        public List<QnaList> qnaList { get; set; }
        public List<string> urls { get; set; }
        public List<File> files { get; set; }
    }

}
