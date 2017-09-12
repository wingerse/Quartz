using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class UseBed : OutPacket
    {
        public const int IdConst = 0x30;

        public int EntityId { get; set; }
        public BlockPos Location { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteBlockPosProto(Location);
        }
    }
}
