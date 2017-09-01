namespace EncodingLib.Nbt
{
    public static class NbtPrimitiveWriterEx
    {
        /// <summary>
        /// Writes an NBT style string
        /// </summary>
        /// <exception cref="NBTException">String length is longer than is allowed for nbt</exception>
        public static void WriteString(this PrimitiveWriter primitiveWriter, string s)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(s);
            if (bytes.Length > ushort.MaxValue)
            {
                throw new NBTException("String length longer than maximum allowed for nbt.");
            }
            
            primitiveWriter.WriteUShort((ushort)bytes.Length);
            primitiveWriter.Write(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Writes an Uncompressed NbtBlob.
        /// </summary>
        /// <exception cref="NBTException">Invalid Nbt.</exception>
        public static void WriteNbtBlob(this PrimitiveWriter writer, NbtBlob blob)
        {
            if (blob.IsEmpty)
            {
                writer.WriteByte((byte) TypeID.End);
                return;
            }
            
            writer.WriteByte((byte) blob.Root.ID);
            writer.WriteString(blob.Name);
            blob.Root.Write(writer);
        }
    }

    public static class NbtPrimitiveReaderEx
    {
        /// <summary>
        /// Reads an Nbt style string.
        /// </summary>
        public static string ReadString(this PrimitiveReader reader)
        {
            var length = reader.ReadUShort();
            var bytes = reader.ReadBytes(length);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        /// <summary>
        /// Reads an Uncompressed NbtBlob.
        /// </summary>
        /// <exception cref="NBTException">Invalid NbtBlob</exception>
        public static NbtBlob ReadNbtBlob(this PrimitiveReader reader)
        {
            var id = (TypeID) reader.ReadByte();
            if (id == TypeID.End)
            {
                return NbtBlob.Empty;
            }
            if (id != TypeID.Compound)
            {
                throw new NBTException("NBT root is not a compound.");
            }
            
            var name = reader.ReadString();
            var tag = new Tag.Compound();
            tag.Read(reader, 0);
            return new NbtBlob(name, tag);
        }
    }
}
