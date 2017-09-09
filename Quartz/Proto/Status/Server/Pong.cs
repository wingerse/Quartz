using EncodingLib;

namespace Quartz.Proto.Status.Server
{
    public sealed class Pong : OutPacket
    {
        public const int IdConst = 0x01;
        
        public long Payload { get; set; }

        public override int Id => IdConst;

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteLong(Payload);
        }
    }
}
