using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class PlayerAbilities : OutPacket
    {
        public const int IdConst = 0x2c;

        public bool Invulnerable { get; set; }
        public bool Flying { get; set; }
        public bool AllowFlying { get; set; }
        public bool CreativeMode { get; set; }
        public float FlyingSpeed { get; set; }
        public float FieldOfView { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            byte x;
            if (Invulnerable) x |= 0x01;
            if (Flying) x |= 0x02;
            if (AllowFlying) x |= 0x03;
            if (CreativeMode) x |= 0x08;
            writer.WriteByte(x);
            writer.WriteFloat(FlyingSpeed);
            writer.WriteFloat(FieldOfView);
        }
    }
}
