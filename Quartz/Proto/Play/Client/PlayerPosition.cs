using EncodingLib;
using Quartz.Math;

namespace Quartz.Proto.Play.Client
{
    public sealed class PlayerPosition : InPacket
    {
        public Vec3 Position { get; private set; }
        public bool OnGround { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Position = new Vec3(reader.ReadDouble(), reader.ReadDouble(), reader.ReadDouble());
            OnGround = reader.ReadBool();
        }
    }
}
