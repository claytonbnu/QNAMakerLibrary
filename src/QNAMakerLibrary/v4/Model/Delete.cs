using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class Delete
    {
        public Delete()
        {
            ids = new List<int>();
            sources = new List<string>();
        }
        public List<int> ids { get; set; }
        public List<string> sources { get; set; }
    }

}
