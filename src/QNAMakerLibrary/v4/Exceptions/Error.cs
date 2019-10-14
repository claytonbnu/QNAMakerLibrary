namespace QNAMakerClient.v4.Exceptions
{
    public class Error
    {
        public string code { get; set; }
        public string message { get; set; }
        public Detail[] details { get; set; }
    }
}