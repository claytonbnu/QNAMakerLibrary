using Newtonsoft.Json;

namespace QNAMakerClient.v4.Model
{
    public class KnowledgebaseUpdate
    {
        public KnowledgebaseUpdate()
        {
            add = new Add();
            delete = new Delete();
            update = new Update();
        }
        public Add add { get; set; }
        
        public Delete delete { get; set; }

        public Update update { get; set; }
    }

}
