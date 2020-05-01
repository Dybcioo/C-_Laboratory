using System;
using System.Runtime.Serialization;

namespace lab03
{
    [Serializable]
    internal class TomExsistException : Exception
    {
        public TomExsistException()
        {
        }

        public TomExsistException(string message) : base(message)
        {
        }

        public TomExsistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TomExsistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}