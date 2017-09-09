using EncodingLib;

namespace Quartz.Proto.Status.Client
{
    public sealed class Ping : InPacket
    {
        public const int Id = 0x01;
        
        public long Payload { get; set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Payload = reader.ReadLong();
        }
    }
}
