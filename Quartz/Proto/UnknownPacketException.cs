using System;

namespace Quartz.Proto
{
    public class UnknownPacketException : Exception
    {
        public UnknownPacketException(int id)
            : base($"Unknown packet. Id = {id}")
        {
        }
    }
}
