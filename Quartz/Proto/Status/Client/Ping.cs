using EncodingLib;

namespace Quartz.Proto.Status.Client
{
    public sealed class Ping : InPacket
    {
        public long Payload { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Payload = reader.ReadLong();
        }
    }
}
