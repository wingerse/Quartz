using System;

namespace Quartz.Proto
{
    public class InvalidPacketException : ProtoException
    {
        public InvalidPacketException(string field, object value) : base($"field:{field},value:{value}")
        {
        }

        public InvalidPacketException(string field, object value, Exception innerException) : base($"field:{field},value:{value}", innerException)
        {
        }
    }
}
