using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class EntityLook : OutPacket
    {
        public const int IdConst = 0x28;

        public int EntityId { get; set; }
        public double Yaw { get; set; }
        public double Pitch { get; set; }
        public bool OnGround { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteAngleProto(Yaw);
            writer.WriteAngleProto(Pitch);
            writer.WriteBool(OnGround);
        }
    }
}
