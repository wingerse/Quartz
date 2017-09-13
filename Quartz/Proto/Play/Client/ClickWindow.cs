using EncodingLib;
using Quartz.Item;

namespace Quartz.Proto.Play.Client
{
    public sealed class ClickWindow : InPacket
    {
        public byte WindowId { get; private set; }
        public short Slot { get; private set; }
        public sbyte Button { get; private set; }
        public short ActionNum { get; private set; }
        public int Mode { get; private set; }
        public ItemStack ClickedItem { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            WindowId = reader.ReadByte();
            Slot = reader.ReadShort();
            Button = reader.ReadSByte();
            ActionNum = reader.ReadShort();
            Mode = reader.ReadVarint();
            ClickedItem = reader.ReadItemStackProto();
        }
    }
}
