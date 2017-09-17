using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class PlayerLook : InPacket
    {
        public float Yaw { get; private set; }
        public float Pitch { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Yaw = reader.ReadFloat();
            Pitch = reader.ReadFloat();
        }
    }
}
