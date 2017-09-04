using System;
using EncodingLib;

namespace Quartz.Proto
{
    public static class ProtoPrimitiveWriterEx
    {
        public static void WriteString(this PrimitiveWriter primitiveWriter, string s)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(s);
            primitiveWriter.WriteVarint(bytes.Length);
            primitiveWriter.Write(bytes, 0, bytes.Length);
        }

        public static void WriteAngle(this PrimitiveWriter writer, double angle)
        {
            writer.WriteByte((byte)(Math.Round(angle) % 360 * 256d / 360d));
        }

        public static void WriteUuid(this PrimitiveWriter writer, Guid uuid)
        {
            var bytes = uuid.ToByteArray();
            Array.Reverse(bytes);
            writer.Write(bytes, 0, bytes.Length);
        }
    }

    public static class ProtoPrimitiveReaderEx
    {
        public static string ReadString(this PrimitiveReader primitiveReader)
        {
            var length = primitiveReader.ReadVarint();
            var bytes = primitiveReader.ReadBytes(length);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        public static double ReadAngle(this PrimitiveReader reader)
        {
            return reader.ReadByte() * 360d / 256d;
        }

        public static Guid ReadUuid(this PrimitiveReader reader)
        {
            var buf = new byte[16];
            reader.ReadFully(buf, 0, 16);
            Array.Reverse(buf);
            return new Guid(buf);
        }
    }
}
