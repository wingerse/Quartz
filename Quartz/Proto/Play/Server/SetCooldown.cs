using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class SetCooldown : OutPacket
    {
        public const int IdConst = 0x17;

        public int ItemId { get; set; }
        public int CooldownTicks { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(ItemId);
            writer.WriteVarint(CooldownTicks);
        }
    }
}
