using System;
using System.Runtime.Serialization;

namespace lab03
{
    [Serializable]
    internal class TomNumberException : Exception
    {
        public TomNumberException()
        {
        }

        public TomNumberException(string message) : base(message)
        {
        }

        public TomNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TomNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}