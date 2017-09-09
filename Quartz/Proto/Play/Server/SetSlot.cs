using EncodingLib;
using Quartz.Item;

namespace Quartz.Proto.Play.Server
{
    public sealed class SetSlot : OutPacket
    {
        public const int IdConst = 0x16;

        public sbyte WindowId { get; set; }
        public short Slot { get; set; }
        public ItemStack ItemStack { get; set; }

        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteSByte(WindowId);
            writer.WriteShort(Slot);
            writer.WriteItemStackProto(ItemStack);
        }
    }
}
