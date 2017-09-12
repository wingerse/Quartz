using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class Camera : OutPacket
    {
        public const int IdConst = 0x39;

        public int EntityId { get; set; }

        public override int Id => IdConst;

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
        }
    }
}
