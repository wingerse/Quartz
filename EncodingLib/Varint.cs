using System.IO;

namespace EncodingLib
{
    public static class Varint
    {
        public const int MaxVarintLen = 5;
        public const int MaxVarlongLen = 10;

        /// <summary>
        /// Encodes <paramref name="i"/> as a varint into <paramref name="buf"/>.  
        /// <paramref name="buf"/>'s Length should be at least <see cref="MaxVarintLen"/>.
        /// </summary>
        /// <param name="buf">buffer to put into</param>
        /// <param name="i">long to encode</param>
        /// <returns>the count of bytes encoded</returns>
        public static int PutVarint(byte[] buf, int i)
        {
            return PutVarlong(buf, (uint)i);
        }

        /// <summary>
        /// Decodes a varint from <paramref name="buf"/> and returns it and the number of bytes read.
        /// <paramref name="buf"/> should contain a full varint.
        /// </summary>
        /// <param name="buf">buffer</param>
        /// <returns>varint and number of bytes read</returns>
        /// <exception cref="EncodingException">Varint longer than <see cref="MaxVarintLen"/> bytes</exception>
        public static (int varint, int read) GetVarint(byte[] buf)
        {
            uint x = 0;

            var i = 0;
            while (true)
            {
                var b = buf[i];
                x |= (uint)(b & 0x7f) << (i * 7);
                i++;
                // msb not set
                if ((b & 0x80) == 0)
                {
                    break;
                }
                // above if should break at MaxVarintLen
                if (i >= MaxVarintLen)
                { 
                    throw new EncodingException($"Varint longer than {MaxVarintLen} bytes.");
                }
            }
            return ((int)x, i);
        }

        /// <summary>
        /// Decodes a varint from <paramref name="reader"/> and returns it.
        /// </summary>
        /// <exception cref="EncodingException">Varint longer than <see cref="MaxVarintLen"/> bytes</exception>
        public static int ReadVarint(BinaryReader reader)
        {
            uint x = 0;
            var i = 0;

            while (true)
            {
                var b = reader.ReadByte();
                x |= (uint)(b & 0x7f) << (i * 7);
                i++;
                // msb not set
                if ((b & 0x80) == 0)
                {
                    break;
                }

                if (i >= MaxVarintLen)
                {
                    throw new EncodingException($"Varint longer than {MaxVarintLen} bytes.");
                }
            }
            return (int)x;
        }

        /// <summary>
        /// Encodes <paramref name="l"/> as a varlong into <paramref name="buf"/>.
        /// <paramref name="buf"/>'s Length should be at least <see cref="MaxVarlongLen"/>
        /// </summary>
        /// <param name="buf">buffer to put into</param>
        /// <param name="l">long to encode</param>
        /// <returns>the count of bytes encoded</returns>
        public static int PutVarlong(byte[] buf, long l)
        {
            var ul = (ulong)l;
            int i = 0;
            while (ul >= 0x80)
            {
                
                buf[i] = (byte)((ul & 0x7f) | 0x80);
                ul >>= 7;
                i++;
            }
            buf[i] = (byte)ul;

            return i + 1;
        }

        /// <summary>
        /// Decodes a varlong from <paramref name="buf"/> and returns it and the number of bytes read.
        /// <paramref name="buf"/> should contain a full varlong.
        /// </summary>
        /// <exception cref="EncodingException">varlong longer than <see cref="MaxVarlongLen"/> bytes</exception>
        public static (long varlong, int read) GetVarlong(byte[] buf)
        {
            ulong x = 0;

            var i = 0;
            while (true)
            {
                var b = buf[i];
                x |= (ulong)(b & 0x7f) << (i * 7);
                i++;
                // msb not set
                if ((b & 0x80) == 0)
                {
                    break;
                }

                if (i >= MaxVarlongLen)
                {
                    throw new EncodingException($"Varlong longer than {MaxVarlongLen} bytes.");
                }
            }
            return ((long)x, i);
        }

        /// <summary>
        /// Decodes a varlong from <paramref name="reader"/> and returns it.
        /// </summary>
        /// <exception cref="EncodingException">Varlong longer than <see cref="MaxVarlongLen"/> bytes</exception>
        public static long ReadVarlong(BinaryReader reader)
        {
            ulong x = 0;
            var i = 0;

            while (true)
            {
                var b = reader.ReadByte();
                x |= (ulong)(b & 0x7f) << (i * 7);
                i++;
                // msb not set
                if ((b & 0x80) == 0)
                {
                    break;
                }

                if (i >= MaxVarlongLen)
                {
                    throw new EncodingException($"Varlong longer than {MaxVarlongLen} bytes.");
                }
            }
            return (long)x;
        }
    }
}
