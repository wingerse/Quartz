using System;

namespace EncodingLib.Nbt
{
    public class NBTException : Exception
    {
        public NBTException(string message) : base(message)
        {
        }

        public NBTException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}