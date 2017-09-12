using EncodingLib;
using Quartz.Math;

namespace Quartz.Proto.Play.Server
{
    public sealed class EntityLookAndRelativeMove : OutPacket
    {
        public const int IdConst = 0x27;

        public int EntityId { get; set; }
        public Vec3 PreviousPos { get; set; }
        public Vec3 CurrentPos { get; set; }
        public double Yaw { get; set; }
        public double Pitch { get; set; }
        public bool OnGround { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteShort((short)((CurrentPos.X * 32 - PreviousPos.X * 32) * 128));
            writer.WriteShort((short)((CurrentPos.Y * 32 - PreviousPos.Y * 32) * 128));
            writer.WriteShort((short)((CurrentPos.Z * 32 - PreviousPos.Z * 32) * 128));
            writer.WriteAngleProto(Yaw);
            writer.WriteAngleProto(Pitch);
            writer.WriteBool(OnGround);
        }
    }
}
