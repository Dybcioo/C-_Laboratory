using System;
using System.Runtime.Serialization;

namespace lab04
{
    [Serializable]
    internal class SpeedException : Exception
    {
        public SpeedException()
        {
        }

        public SpeedException(string message) : base(message)
        {
        }

        public SpeedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SpeedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}