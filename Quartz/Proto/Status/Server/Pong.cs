using EncodingLib;

namespace Quartz.Proto.Status.Server
{
    public sealed class Pong : OutPacket
    {
        public long Payload { get; set; }

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteLong(Payload);
        }
    }
}
