using System;

namespace QNAMakerClient.v4.Exceptions
{
    public class HttpSuccess //202
    {
        public string operationState { get; set; }
        public DateTime createdTimestamp { get; set; }
        public DateTime lastActionTimestamp { get; set; }
        public string userId { get; set; }
        public string operationId { get; set; }
    }


}
