using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using EncodingLib;
using Quartz.Utils.Zlib;

namespace Quartz.Proto
{
    public sealed class PacketWriter
    {
        private readonly Adler32 _adler32 = new Adler32();
        private readonly byte[] _zlibHeader = {0x78, 0x9c}; // no dict, default compression.
        private readonly byte[] _checksumBuf = new byte[4];
        private readonly byte[] _varintBuf = new byte[Varint.MaxVarintLen];
                                                                                                                     
        /// <summary>
        /// Threshold for compression. If null, all packets are uncompressed.
        /// </summary>
        public int? Threshold { get; set; }

        public State State { get; set; }
        public Stream BaseStream { get; }

        public PacketWriter(Stream stream)
        {
            BaseStream = stream;
        }

        public async Task WritePacketAsync(OutPacket packet)
        {
            var buf = new MemoryStream();
            var writer = new PrimitiveWriter(buf);
            writer.WriteVarint(OutPacket.GetId(State, packet));
            packet.Write(writer);

            var uncompressedLen = buf.Length;

            if (Threshold != null)
            {
                var compressedBuf = new MemoryStream();
                if (uncompressedLen > Threshold)
                {
                    ZlibCompress(compressedBuf, buf);

                    buf.SetLength(0);
                    var n = Varint.PutVarint(_varintBuf, (int)uncompressedLen);
                    buf.Write(_varintBuf, 0, n);
                    compressedBuf.CopyTo(buf);
                }
                else
                {
                    buf.CopyTo(compressedBuf);
                    buf.SetLength(0);
                    buf.WriteByte(0);
                    compressedBuf.CopyTo(buf);
                }
            }
            buf.Seek(0, SeekOrigin.Begin);
            
            var n2 = Varint.PutVarint(_varintBuf, (int)buf.Length);
            await BaseStream.WriteAsync(_varintBuf, 0, n2);
            await buf.CopyToAsync(BaseStream);
        }

        private void ZlibCompress(MemoryStream dst, MemoryStream src)
        {
            dst.Write(_zlibHeader, 0, _zlibHeader.Length);

            src.TryGetBuffer(out ArraySegment<byte> bufArray);
            _adler32.CalculateChecksum(bufArray.Array, bufArray.Offset, bufArray.Count);

            using (var deflateStream = new DeflateStream(dst, CompressionMode.Compress, true))
                deflateStream.Write(bufArray.Array, bufArray.Offset, bufArray.Count);

            var checksum = _adler32.Checksum;
            _checksumBuf[0] = (byte)(checksum >> 24);
            _checksumBuf[1] = (byte)(checksum >> 16);
            _checksumBuf[2] = (byte)(checksum >> 8);
            _checksumBuf[3] = (byte)(checksum >> 0);
            dst.Write(_checksumBuf, 0, _checksumBuf.Length);
            _adler32.Reset();
        }
    }
}
