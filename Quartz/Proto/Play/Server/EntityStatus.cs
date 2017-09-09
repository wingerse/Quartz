using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class EntityStatus : OutPacket
    {
        public const int IdConst = 0x1b;

        public int EntityId { get; set; }
        public byte Status { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteInt(EntityId);
            writer.WriteByte(Status);
        }
    }
}
