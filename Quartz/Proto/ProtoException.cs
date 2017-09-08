using System;

namespace Quartz.Proto
{
    public class ProtoException : Exception
    {
        public ProtoException(string message) : base(message)
        {
        }

        public ProtoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
