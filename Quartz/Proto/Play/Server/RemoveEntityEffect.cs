using EncodingLib;
using Quartz.Entity;

namespace Quartz.Proto.Play.Server
{
    public sealed class RemoveEntityEffect : OutPacket
    {
        public const int IdConst = 0x33;

        public int EntityId { get; set; }
        public EntityEffect Effect { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteVarint(Effect.Id);
        }
    }
}
