using System;

namespace EncodingLib.Nbt
{
    public static class NbtPrimitiveEx
    {
        /// <summary>
        /// Writes an NBT style string
        /// </summary>
        /// <exception cref="ArgumentException">String length is longer than is allowed for nbt</exception>
        public static void WriteStringNbt(this PrimitiveWriter primitiveWriter, string s)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(s);
            if (bytes.Length > ushort.MaxValue)
            {
                throw new ArgumentException("String length longer than maximum allowed for nbt.");
            }
            
            primitiveWriter.WriteUShort((ushort)bytes.Length);
            primitiveWriter.Write(bytes, 0, bytes.Length);
        }
        
        /// <summary>
        /// Reads an Nbt style string.
        /// </summary>
        public static string ReadStringNbt(this PrimitiveReader reader)
        {
            var length = reader.ReadUShort();
            var bytes = reader.ReadBytes(length);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}
