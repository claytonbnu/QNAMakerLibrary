using System;

namespace QNAMakerClient.v4.Model
{
    public class OperationDetails
    {
        public string operationState { get; set; }
        public DateTime createdTimestamp { get; set; }
        public DateTime lastActionTimestamp { get; set; }
        public string resourceLocation { get; set; }
        public string userId { get; set; }
        public Guid operationId { get; set; }
    }
}