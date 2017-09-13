using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class Effect : OutPacket
    {
        public int EffectId { get; set; }
        public BlockPos Location { get; set; }
        public int Data { get; set; }
        public bool ServerWide { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteInt(EffectId);
            writer.WriteBlockPosProto(Location);
            writer.WriteInt(Data);
            writer.WriteBool(ServerWide);
        }
    }
}
