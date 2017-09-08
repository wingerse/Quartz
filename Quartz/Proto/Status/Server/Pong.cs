using EncodingLib;

namespace Quartz.Proto.Status.Server
{
    public sealed class Pong : IOutPacket
    {
        public const int Id = 0x01;
        
        public long Payload { get; set; }

        public int GetId() => Id;

        public void Write(PrimitiveWriter writer)
        {
            writer.WriteLong(Payload);
        }
    }
}
