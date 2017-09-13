using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class Camera : OutPacket
    {
        public int EntityId { get; set; }

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
        }
    }
}
