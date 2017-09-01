using System.IO;

namespace EncodingLib
{
    public static class StreamEx
    {
        /// <summary>
        /// Reads exactly count bytes from stream into buf.
        /// If fewer bytes were read, an exception is thrown.
        /// </summary>
        public static void ReadFully(this Stream stream, byte[] buf, int offset, int count)
        {
            while (count > 0)
            {
                var read = stream.Read(buf, offset, count);
                if (read <= 0)
                {
                    throw new EndOfStreamException();
                }
                count -= read;
                offset += read;
            }
        }
    }
}