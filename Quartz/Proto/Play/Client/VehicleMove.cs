using EncodingLib;
using Quartz.Math;

namespace Quartz.Proto.Play.Client
{
    public sealed class VehicleMove : InPacket
    {
        public Vec3 Position { get; private set; } 
        public float Yaw { get; private set; }
        public float Pitch { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Position = new Vec3(reader.ReadDouble(), reader.ReadDouble(), reader.ReadDouble());
            Yaw = reader.ReadFloat();
            Pitch = reader.ReadFloat();
        }
    }
}
