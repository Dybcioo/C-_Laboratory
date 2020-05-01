using System;
using System.Runtime.Serialization;

namespace lab07
{
    [Serializable]
    internal class NoManaException : Exception
    {
        public NoManaException()
        {
        }

        public NoManaException(string message) : base(message)
        {
        }

        public NoManaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoManaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}