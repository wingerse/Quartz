using System;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;
using EncodingLib;
using Quartz.Utils;
using Quartz.Utils.Zlib;

namespace Quartz.Proto
{
    /// <summary>
    /// Reads packet from a stream. PacketReader buffers data internally.
    /// </summary>
    public sealed class PacketReader
    {
        public const int MaxPacketLen = 2097152;
        
        private readonly Adler32 _adler32 = new Adler32();
        private readonly byte[] _scratch = new byte[4];
        private readonly BufferedOutputStream _bufStream;
        
        public Stream BaseStream { get; }
        public State State { get; set; }
        public int? Threshold { get; set; }
        
        public PacketReader(Stream baseStream)
        {
            BaseStream = baseStream;
            _bufStream = new BufferedOutputStream(baseStream, 10000);
        }

        public async Task<InPacket> ReadPacketAsync()
        {
            var raw = await ReadRawAsync();
            var packet = InPacket.GetNewPacket(State, raw.Id);
            packet.Read(raw.Reader);
            var remaining = raw.Reader.BaseStream.Length - raw.Reader.BaseStream.Position;
            if (remaining != 0)
                throw new ProtoException($"Not all packet was read. {remaining} bytes left. Packet Id: {raw.Id}");
            return packet;
        }
        
        private async Task<MemoryStream> ReadPacketBytesAsync()
        {
            var length = await Varint.ReadVarintAsync(_bufStream);
            if (length <= 0)
                throw new ProtoException("Negative or 0 length packet");
            if (length > MaxPacketLen)
                throw new ProtoException("Packet too large");
            var buf = new byte[length];
            await _bufStream.ReadFullyAsync(buf, 0, buf.Length, CancellationToken.None);
            var mem = new MemoryStream(buf, 0, length, true, true);
            return mem;
        }

        private async Task<RawMessage> ReadRawAsync()
        {
            var mem = await ReadPacketBytesAsync();
            var reader = new PrimitiveReader(mem);

            if (Threshold == null)
            {
                return ReadUncompressedRawMessage(reader);
            }

            var uncompressedLen = reader.ReadVarint();
            if (uncompressedLen < 0) 
                throw new ProtoException("Uncompressed length < 0");
            else if (uncompressedLen == 0)
            {
                return ReadUncompressedRawMessage(reader);
            }
            else
            {
                if (uncompressedLen < Threshold)
                    throw new ProtoException("Received packet was compressed before threshold size was reached");
                var uncBuf = new MemoryStream();
                ZlibDecompress(uncBuf, mem);
                if (uncBuf.Length != uncompressedLen)
                    throw new ProtoException("Wrong uncompressed length was given in the received packet");
                return ReadUncompressedRawMessage(new PrimitiveReader(uncBuf));
            }
        }

        private void ZlibDecompress(MemoryStream dst, MemoryStream src)
        {
            // read CMF and FLG
            src.ReadFully(_scratch, 0, 2);
            var h = (_scratch[0] << 8) | _scratch[1];
            if ((_scratch[0] & 0x0f) != 8 || h % 31 != 0)
                throw new ZlibException("Invalid zlib header");
            if ((_scratch[1] & 0x20) != 0)
            {
                src.ReadFully(_scratch, 0, 4);
                // ignore dictionary
            }
            if (src.Length - src.Position < 4)
                throw new ZlibException("Invalid zlib stream. There is no checksum");
            var pos = src.Position;
            src.Seek(-4, SeekOrigin.End);
            src.ReadFully(_scratch, 0, 4);
            var adler32 = ((uint)_scratch[0] << 24) |
                          ((uint)_scratch[0] << 16) |
                          ((uint)_scratch[0] << 08) |
                          ((uint)_scratch[0] << 00);
            src.Seek(pos, SeekOrigin.Begin);
            src.SetLength(src.Length - 4);

            using (var deflate = new DeflateStream(src, CompressionMode.Decompress, true))
                deflate.CopyTo(dst);

            dst.TryGetBuffer(out ArraySegment<byte> arr);
            _adler32.CalculateChecksum(arr.Array, arr.Offset, arr.Count);
            var checksum = _adler32.Checksum;
            _adler32.Reset();
            if (checksum != adler32) 
                throw new ZlibException("Decompressed data doesn't match checksum");
        }

        private static RawMessage ReadUncompressedRawMessage(PrimitiveReader reader)
        {
            var id = reader.ReadVarint();
            return new RawMessage(id, reader);
        }

        private class RawMessage
        {
            public int Id { get; }
            public PrimitiveReader Reader { get; }
            
            public RawMessage(int id, PrimitiveReader reader)
            {
                Reader = reader;
                Id = id;
            }
        }
    }
}
