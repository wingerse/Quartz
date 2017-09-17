using System.IO;
using System.Threading;
using System.Threading.Tasks;

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
        
        /// <summary>
        /// Reads exactly count bytes from stream into buf.
        /// If fewer bytes were read, an exception is thrown.
        /// </summary>
        public static async Task ReadFullyAsync(this Stream stream, byte[] buf, int offset, int count, CancellationToken token)
        {
            while (count > 0)
            {
                token.ThrowIfCancellationRequested();
                var read = await stream.ReadAsync(buf, offset, count, token);
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
