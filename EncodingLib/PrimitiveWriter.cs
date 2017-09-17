using System;
using System.IO;
using System.Net;

namespace EncodingLib
{
    /// <summary>
    /// Wraps a MemoryStream to provide minecraft style primitive writing reading.
    /// Does not close or flush the stream.
    /// </summary>
    public sealed class PrimitiveWriter
    {
        private readonly BinaryWriter _binaryWriter;
        private readonly byte[] _buf = new byte[Varint.MaxVarlongLen];
        public Stream BaseStream { get; }
        
        public PrimitiveWriter(Stream stream)
        {
            _binaryWriter = new BinaryWriter(stream, System.Text.Encoding.UTF8, true);
            BaseStream = stream;
        }

        public void WriteBool(bool b)
        {
            _binaryWriter.Write(b);
        }

        public void WriteByte(byte b)
        {
            _binaryWriter.Write(b);
        }

        public void WriteSByte(sbyte b)
        {
            _binaryWriter.Write(b);
        }

        public void WriteShort(short s)
        {
            _binaryWriter.Write(IPAddress.HostToNetworkOrder(s));
        }

        public void WriteUShort(ushort s)
        {
            WriteShort((short)s);
        }

        public void WriteInt(int i)
        {
            _binaryWriter.Write(IPAddress.HostToNetworkOrder(i));
        }

        public void WriteLong(long l)
        {
            _binaryWriter.Write(IPAddress.HostToNetworkOrder(l));
        }

        public unsafe void WriteFloat(float f)
        {
            _binaryWriter.Write(IPAddress.HostToNetworkOrder(*(int*)&f));
        }

        public void WriteDouble(double d)
        {
            _binaryWriter.Write(IPAddress.HostToNetworkOrder(BitConverter.DoubleToInt64Bits(d)));
        }

        public void Write(byte[] buffer, int index, int count)
        {
            _binaryWriter.Write(buffer, index, count);
        }

        public void WriteVarint(int i)
        {
            var count = Varint.PutVarint(_buf, i);
            _binaryWriter.Write(_buf, 0, count);
        }

        public void WriteVarlong(long l)
        {
            var count = Varint.PutVarlong(_buf, l);
            _binaryWriter.Write(_buf, 0, count);
        }
    }
}
