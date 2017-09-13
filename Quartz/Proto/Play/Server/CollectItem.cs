using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class CollectItem : OutPacket
    {
        public int CollectedEntityId { get; set; }
        public int CollectorEntityId { get; set; }
        public int ItemCount { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(CollectedEntityId);
            writer.WriteVarint(CollectorEntityId);
            writer.WriteVarint(ItemCount);
        }
    }
}
