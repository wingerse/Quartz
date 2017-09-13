using EncodingLib;
using Quartz.Item;

namespace Quartz.Proto.Play.Server
{
    public sealed class SetSlot : OutPacket
    {
        public sbyte WindowId { get; set; }
        public short Slot { get; set; }
        public ItemStack ItemStack { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteSByte(WindowId);
            writer.WriteShort(Slot);
            writer.WriteItemStackProto(ItemStack);
        }
    }
}
