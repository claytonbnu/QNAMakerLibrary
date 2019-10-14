using System;
using System.Collections.Generic;
using QNAMakerClient.v4.Enumerator;
using QNAMakerClient.v4.Model;

namespace QNAMakerLibrary.v4
{
    public class QnAMakerEndpoint
    {
        public QnAMakerEndpoint()
        {
            Enviroment = Enviroment.Prod;
            Filters = new List<Metadata>();
            Score = 0f;
        }

        public Guid KnowledgeBaseId { get; set; }
        public Guid EndpointKey { get; set; }
        public string SubscriptionKey { get; set; }
        public string Host { get; set; }
        public Enviroment Enviroment { get; set; }
        public List<Metadata> Filters { get; set; }
        public float Score { get; set; }
    }
}