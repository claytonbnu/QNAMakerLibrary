using System;
using System.Net;
using Newtonsoft.Json;
using QNAMakerClient.v4.Exceptions;

namespace QNAClient
{
    public class HttpError //400, 401, 403, 404, 500
    {
        public Error error { get; set; }
    }

    public class QnaMakerException : Exception

    {

        public QnaMakerException()

        {

        }



        public QnaMakerException(HttpStatusCode code)

        {

            HttpStatusCode = code;

        }



        public QnaMakerException(HttpStatusCode code, Error error)

        {

            HttpStatusCode = code;

            Error = error;

        }



        [JsonIgnore]

        public HttpStatusCode HttpStatusCode { get; set; }



        public Error Error { get; set; }

    }
}
