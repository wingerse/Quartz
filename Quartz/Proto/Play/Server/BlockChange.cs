using EncodingLib;
using Quartz.Block;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class BlockChange : IOutPacket
    {
        public const int IdConst = 0x0b;

        public BlockPos Location { get; set; }
        public BlockStateId BlockStateId { get; set; }
        
        public int Id => IdConst;
        
        public void Write(PrimitiveWriter writer)
        {
            writer.WriteBlockPosProto(Location);
            writer.WriteVarint(BlockStateId.Short);
        }
    }
}
