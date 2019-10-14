using System.Collections.Generic;

namespace QNAMakerClient.v4.Model
{
    public class KnowledgebaseForUser
    {
        public KnowledgebaseForUser()
        {
            knowledgebases = new List<KnowledgebaseDetails>();
        }

        public List<KnowledgebaseDetails> knowledgebases { get; set; }
    }
}