using EncodingLib;
using Quartz.Block;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class BlockChange : OutPacket
    {
        public BlockPos Location { get; set; }
        public BlockStateId BlockStateId { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteBlockPosProto(Location);
            writer.WriteVarint(BlockStateId.ToShort());
        }
    }
}
