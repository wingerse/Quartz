using System;
using System.Globalization;
using EncodingLib;

namespace Quartz.Proto
{
    public static class ProtoPrimitiveEx
    {
        /// <summary>
        /// Writes a proto style string
        /// </summary>
        /// <exception cref="ArgumentException">if Unicode code point length of s > max allowed.</exception>
        public static void WriteStringProto(this PrimitiveWriter primitiveWriter, string s)
        {
            if (new StringInfo(s).LengthInTextElements > ProtoConsts.MaxStringChars) 
                throw new ArgumentException("num. characters greater than maximum allowed.", nameof(s));
            var bytes = System.Text.Encoding.UTF8.GetBytes(s);
            primitiveWriter.WriteVarint(bytes.Length);
            primitiveWriter.Write(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Reads a proto style string.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">if <paramref name="n"/> > max allowed (<see cref="ProtoConsts.MaxStringChars"/></exception>
        /// <exception cref="ProtoException">if read string is invalid.</exception>
        public static string ReadStringProto(this PrimitiveReader primitiveReader, uint n)
        {
            if (n > ProtoConsts.MaxStringChars) 
                throw new ArgumentOutOfRangeException(nameof(n), "greater than maximum allowed.");
            var length = primitiveReader.ReadVarint();
            if (length < 0) 
                throw new ProtoException("Negative string length");
            if (length > n * 4) 
                throw new ProtoException($"Received string byte length greater than allowed n({n})");
            var bytes = primitiveReader.ReadBytes(length);
            var s = System.Text.Encoding.UTF8.GetString(bytes);
            if (new StringInfo(s).LengthInTextElements > n)
                throw new ProtoException($"Received string has more unicode code points than allowed ({n})");
            return s;
        }

        public static void WriteAngleProto(this PrimitiveWriter writer, double angle)
        {
            writer.WriteByte((byte) (angle * 256d / 360d));
        }

        public static double ReadAngleProto(this PrimitiveReader reader)
        {
            return reader.ReadByte() * 360d / 256d;
        }

        public static void WriteUuidProto(this PrimitiveWriter writer, Guid uuid)
        {
            var bytes = uuid.ToByteArray();
            Array.Reverse(bytes);
            writer.Write(bytes, 0, bytes.Length);
        }

        public static Guid ReadUuidProto(this PrimitiveReader reader)
        {
            var buf = new byte[16];
            reader.ReadFully(buf, 0, 16);
            Array.Reverse(buf);
            return new Guid(buf);
        }
    }
}
