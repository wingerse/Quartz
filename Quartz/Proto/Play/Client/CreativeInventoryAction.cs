using EncodingLib;
using Quartz.Item;

namespace Quartz.Proto.Play.Client
{
    public sealed class CreativeInventoryAction : InPacket
    {
        public short Slot { get; private set; }
        public ItemStack ClickedItem { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Slot = reader.ReadShort();
            ClickedItem = reader.ReadItemStackProto();
        }
    }
}
