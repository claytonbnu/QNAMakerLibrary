using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class Alterations
    {
        public Alterations()
        {
            wordAlterations = new List<Wordalteration>();
        }

        public List<Wordalteration> wordAlterations { get; set; }
    }
}