using System;
using System.Runtime.Serialization;

namespace lab08lib
{
    [Serializable]
    internal class MageExistException : Exception
    {
        public MageExistException()
        {
        }

        public MageExistException(string message) : base(message)
        {
        }

        public MageExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MageExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}