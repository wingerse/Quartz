namespace EncodingLib.Nbt
{
    public sealed class NbtBlob
    {
        public static readonly NbtBlob Empty = new NbtBlob(null, null);
        
        public string Name { get; set; }
        
        /// <summary>
        /// Can be null. In which case, this NbtBlob will be "Empty".
        /// Use NbtBlob.Empty when possible.
        /// </summary>
        public Tag.Compound Root { get; set; }

        public NbtBlob(string name, Tag.Compound root)
        {
            Name = name;
            Root = root;
        }

        public bool IsEmpty => Root == null;
    }

    public static class NbtBlobEx
    {
        /// <summary>
        /// Writes an Uncompressed NbtBlob.
        /// </summary>
        /// <exception cref="NBTException">Invalid Nbt.</exception>
        public static void WriteNbtBlob(this PrimitiveWriter writer, NbtBlob blob)
        {
            if (blob.IsEmpty)
            {
                writer.WriteByte(Tag.EndId);
                return;
            }
            
            writer.WriteByte(blob.Root.ID);
            writer.WriteStringNbt(blob.Name);
            blob.Root.Write(writer);
        }
        
        /// <summary>
        /// Reads an Uncompressed NbtBlob.
        /// </summary>
        /// <exception cref="NBTException">Invalid NbtBlob</exception>
        public static NbtBlob ReadNbtBlob(this PrimitiveReader reader)
        {
            var id = reader.ReadByte();
            if (id == Tag.EndId)
            {
                return NbtBlob.Empty;
            }
            if (id != Tag.Compound.Id)
            {
                throw new NBTException("NBT root is not a compound.");
            }
            
            var name = reader.ReadStringNbt();
            var tag = new Tag.Compound();
            tag.Read(reader, 0);
            return new NbtBlob(name, tag);
        }
    }
}
