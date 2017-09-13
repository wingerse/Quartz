using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class BlockBreakAnimation : OutPacket
    {
        public int EntityId { get; set; }
        public BlockPos Location { get; set; }
        public byte DestroyStage { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteBlockPosProto(Location);
            writer.WriteByte(DestroyStage);
        }
    }
}
