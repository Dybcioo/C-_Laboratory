using System;
using System.Runtime.Serialization;

namespace lab08lib
{
    [Serializable]
    internal class MageNotExistException : Exception
    {
        public MageNotExistException()
        {
        }

        public MageNotExistException(string message) : base(message)
        {
        }

        public MageNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MageNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}