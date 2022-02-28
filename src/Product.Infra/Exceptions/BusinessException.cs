using System;
using System.Runtime.Serialization;

namespace Product.Infra.Exceptions
{
    /// <summary>
    /// Representa uma exceção de negócio.
    /// É a classe base para a implementação de exceções de negócio.
    /// </summary>
    [Serializable]
    public class BusinessException : Exception
    {
        public BusinessException(ErrorCodes errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        public ErrorCodes ErrorCode { get; }

        protected BusinessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public BusinessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public BusinessException()
        {
        }

        public BusinessException(string message) : base(message)
        {
        }
    }
}