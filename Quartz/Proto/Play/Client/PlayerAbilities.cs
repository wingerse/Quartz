using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class PlayerAbilities : InPacket
    {
        public bool GodMode { get; private set; }
        public bool CanFly { get; private set; }
        public bool IsFlying { get; private set; }
        public bool IsCreative { get; private set; }
        public float FlyingSpeed { get; private set; }
        public float WalkingSpeed { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            var flags = reader.ReadByte();
            if ((flags & 0x01) != 0) IsCreative = true;
            if ((flags & 0x02) != 0) IsFlying = true;
            if ((flags & 0x04) != 0) CanFly = true;
            if ((flags & 0x08) != 0) GodMode = true;
            FlyingSpeed = reader.ReadFloat();
            WalkingSpeed = reader.ReadFloat();
        }
    }
}
