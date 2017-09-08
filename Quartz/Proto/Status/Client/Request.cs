using EncodingLib;

namespace Quartz.Proto.Status.Client
{
    public sealed class Request : IInPacket
    {
        public const int Id = 0x00;
        
        public void Read(PrimitiveReader reader)
        {
        }
    }
}
