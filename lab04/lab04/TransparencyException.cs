using System;
using System.Runtime.Serialization;

namespace lab04
{
    [Serializable]
    internal class TransparencyException : Exception
    {
        public TransparencyException()
        {
        }

        public TransparencyException(string message) : base(message)
        {
        }

        public TransparencyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TransparencyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}