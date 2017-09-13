using EncodingLib;
using Quartz.Item;

namespace Quartz.Proto.Play.Server
{
    public sealed class EntityEquipment : OutPacket
    {
        public int EntityId { get; set; }
        public EquipmentSlot Slot { get; set; }
        public ItemStack Item { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteVarint((int)Slot);
            writer.WriteItemStackProto(Item);
        }
    }
}
