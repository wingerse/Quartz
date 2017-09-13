using EncodingLib;
using Quartz.Math;

namespace Quartz.Proto.Play.Server
{
    public sealed class VehicleMove : OutPacket
    {
        public Vec3 Position { get; set; }
        public float Yaw { get; set; }
        public float Pitch { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteDouble(Position.X);
            writer.WriteDouble(Position.Y);
            writer.WriteDouble(Position.Z);
            writer.WriteFloat(Yaw);
            writer.WriteFloat(Pitch);
        }
    }
}
