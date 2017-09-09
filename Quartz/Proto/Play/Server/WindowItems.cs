using System.Collections.Generic;
using EncodingLib;
using Quartz.Item;

namespace Quartz.Proto.Play.Server
{
    public sealed class WindowItems : OutPacket
    {
        public const int IdConst = 0x14;

        public byte WindowId { get; set; }
        public List<ItemStack> Items { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteByte(WindowId);
            writer.WriteShort((short)Items.Count);
            foreach (var i in Items)
            {
                writer.WriteItemStackProto(i);
            }
        }
    }
}
