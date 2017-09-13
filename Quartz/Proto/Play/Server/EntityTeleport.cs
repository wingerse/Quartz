using EncodingLib;
using Quartz.Math;

namespace Quartz.Proto.Play.Server
{
    public sealed class EntityTeleport : OutPacket
    {
        public int EntityId { get; set; }
        public Vec3 Position { get; set; }
        public double Yaw { get; set; }
        public double Pitch { get; set; }
        public bool OnGround { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteDouble(Position.X);
            writer.WriteDouble(Position.Y);
            writer.WriteDouble(Position.Z);
            writer.WriteAngleProto(Yaw);
            writer.WriteAngleProto(Pitch);
            writer.WriteBool(OnGround);
        }
    }
}
