namespace Quartz.Utils.Zlib
{
    public sealed class Adler32
    {
        private const int Base = 65521;

        public uint Checksum { get; private set; } = 1;

        /// <summary>
        /// If first call, Calculates adler32 of bytes buf[0..len-1],
        /// else update this running adler32 with bytes buf[0..len-1]
        /// </summary>
        public void CalculateChecksum(byte[] buf, int offset, int length)
        {
            var s1 = Checksum & 0xffff;
            var s2 = (Checksum >> 16) & 0xffff;

            for (var n = 0; n < length; n++)
            {
                s1 = (s1 + buf[n]) % Base;
                s2 = (s2 + s1) % Base;
            }

            Checksum = (s2 << 16) + s1;
        }

        public void Reset()
        {
            Checksum = 1;
        }
    }
}
