using EncodingLib;

namespace Quartz.Proto.Status.Client
{
    public sealed class Ping : IInPacket
    {
        public const int Id = 0x01;
        
        public long Payload { get; set; }
        
        public void Read(PrimitiveReader reader)
        {
            Payload = reader.ReadLong();
        }
    }
}
