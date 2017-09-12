using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class Entity : OutPacket
    {
        public const int IdConst = 0x25;

        public int EntityId { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
        }
    }
}
