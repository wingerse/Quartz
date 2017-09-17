using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class EntityEffect : OutPacket
    {
        public int EntityId { get; set; }
        public Quartz.Entity.EntityEffect Effect { get; set; }
        public byte Amplifier { get; set; }
        public int Duration { get; set; }
        public bool IsAmbient { get; set; }
        public bool ShowParticles { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteByte(Effect.Id);
            writer.WriteByte(Amplifier);
            writer.WriteVarint(Duration);
            byte x = 0;
            if (IsAmbient) x |= 0x01;
            if (ShowParticles) x |= 0x02;
            writer.WriteByte(x);
        }
    }
}
