using System;
using System.Runtime.Serialization;

namespace Product.Infra.Exceptions
{
    /// <summary>
    /// Representa uma exceção de sistema indisponível.
    /// </summary>
    [Serializable]
    public class ServiceUnavailableException : BusinessException
    {
        public ServiceUnavailableException() { }

        public ServiceUnavailableException(string message) : base(FormatMessage(message)) { }

        public ServiceUnavailableException(ErrorCodes errorCode, string message) : base(FormatMessage(message))
        {
        }
        public ServiceUnavailableException(System.Net.HttpStatusCode httpStatusCode, string responseContent) : base(ErrorCodes.ServiceUnavailable, $"{httpStatusCode} - Service Unavailable. Original message: {responseContent}") { }
        public ServiceUnavailableException(string message, Exception innerException) : base(FormatMessage(message), innerException)
        {
        }

        protected ServiceUnavailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        private static string FormatMessage(string msg) => ($"Service Unavailable: {msg}");


    }
}
