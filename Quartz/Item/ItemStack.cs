using EncodingLib;
using EncodingLib.Nbt;

namespace Quartz.Item
{
    public sealed class ItemStack
    {
        public static readonly ItemStack Empty = new ItemStack();

        /// <summary>
        /// Can be null, in which case, this ItemStack will be "Empty".
        /// Use ItemStack.Empty when possible.
        /// </summary>
        public Item Item { get; set; }
        public byte Count { get; set; }
        public short Damage { get; set; }
        public NbtBlob Nbt { get; set; }

        public bool IsEmpty => Item == null;
    }

    public static class ItemStackEx
    {
        public static void WriteItemStackProto(this PrimitiveWriter writer, ItemStack itemStack)
        {
            if (itemStack.IsEmpty)
            {
                writer.WriteShort(-1);
                return;
            }
            writer.WriteShort(itemStack.Item.Id);
            writer.WriteByte(itemStack.Count);
            writer.WriteShort(itemStack.Damage);
            writer.WriteNbtBlob(itemStack.Nbt);
        }

        public static ItemStack ReadItemStackProto(this PrimitiveReader reader)
        {
            var id = reader.ReadShort();
            if (id == -1)
            {
                return ItemStack.Empty;
            }
            return new ItemStack()
            {
                Item = Item.GetFromId(id),
                Count = reader.ReadByte(),
                Damage = reader.ReadShort(),
                Nbt = reader.ReadNbtBlob()
            };
        }
    }
}
