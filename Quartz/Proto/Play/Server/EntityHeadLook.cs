using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class EntityHeadLook : OutPacket
    {
        public const int IdConst = 0x36;

        public int EntityId { get; set; }
        public double HeadYaw { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteAngleProto(HeadYaw);
            
        }
    }
}
