using EncodingLib;
using Quartz.Entity;

namespace Quartz.Proto.Play.Server
{
    public sealed class RemoveEntityEffect : OutPacket
    {
        public int EntityId { get; set; }
        public Quartz.Entity.EntityEffect Effect { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteVarint(Effect.Id);
        }
    }
}
