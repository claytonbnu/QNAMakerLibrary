using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class Wordalteration
    {
        public Wordalteration()
        {
            alterations = new List<string>();
        }

        public List<string> alterations { get; set; }
    }


}
