using System;
using System.IO;
using System.Net;

namespace EncodingLib
{
    /// <summary>
    /// Wraps a Stream to provide minecraft style primitive reading.
    /// Does not close or flush the stream.
    /// </summary>
    public sealed class PrimitiveReader
    {
        private readonly BinaryReader _binaryReader;
        public Stream BaseStream { get; }

        public PrimitiveReader(Stream stream)
        {
            _binaryReader = new BinaryReader(stream, System.Text.Encoding.UTF8, true);
            BaseStream = stream;
        }

        public bool ReadBool()
        {
            return _binaryReader.ReadBoolean();
        }

        public byte ReadByte()
        {
            return _binaryReader.ReadByte();
        }

        public sbyte ReadSByte()
        {
            return _binaryReader.ReadSByte();
        }

        public ushort ReadUShort()
        {
            return (ushort)ReadShort();
        }

        public short ReadShort()
        {
            return IPAddress.NetworkToHostOrder(_binaryReader.ReadInt16());
        }

        public int ReadInt()
        {
            return IPAddress.NetworkToHostOrder(_binaryReader.ReadInt32());
        }

        public long ReadLong()
        {
            return IPAddress.NetworkToHostOrder(_binaryReader.ReadInt64());
        }

        public unsafe float ReadFloat()
        {
            var i = ReadInt();
            return *(float*)&i;
        }

        public double ReadDouble()
        {
            var l = ReadLong();
            return BitConverter.Int64BitsToDouble(l);
        }

        public byte[] ReadBytes(int count)
        {
            return _binaryReader.ReadBytes(count);
        }

        public int Read(byte[] buf, int index, int count)
        {
            return _binaryReader.Read(buf, index, count);
        }

        public void ReadFully(byte[] buf, int index, int count)
        {
            _binaryReader.BaseStream.ReadFully(buf, index, count);
        }

        public int ReadVarint()
        {
            return Varint.ReadVarint(_binaryReader);
        }

        public long ReadVarlong()
        {
            return Varint.ReadVarint(_binaryReader);
        }
    }
}
