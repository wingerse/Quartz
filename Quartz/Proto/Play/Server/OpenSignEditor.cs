using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class OpenSignEditor : OutPacket
    {
        public BlockPos Location { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteBlockPosProto(Location);
        }
    }
}
