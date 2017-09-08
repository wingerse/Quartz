using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class BlockBreakAnimation : IOutPacket
    {
        public const int IdConst = 0x08;

        public int EntityId { get; set; }
        public BlockPos Location { get; set; }
        public byte DestroyStage { get; set; }
        
        public int Id => IdConst;
        
        public void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteBlockPosProto(Location);
            writer.WriteByte(DestroyStage);
        }
    }
}
