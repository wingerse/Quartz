using EncodingLib;
using Quartz.Block;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class BlockChange : OutPacket
    {
        public const int IdConst = 0x0b;

        public BlockPos Location { get; set; }
        public BlockStateId BlockStateId { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteBlockPosProto(Location);
            writer.WriteVarint(BlockStateId.Short);
        }
    }
}
