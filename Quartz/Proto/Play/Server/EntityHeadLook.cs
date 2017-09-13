using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class EntityHeadLook : OutPacket
    {
        public int EntityId { get; set; }
        public double HeadYaw { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteAngleProto(HeadYaw);
            
        }
    }
}
