using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class SpawnPosition : OutPacket
    {
        public BlockPos Position { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteBlockPosProto(Position);
        }
    }
}
