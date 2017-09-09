using EncodingLib;

namespace Quartz.Proto.Status.Client
{
    public sealed class Request : InPacket
    {
        public const int Id = 0x00;
        
        public override void Read(PrimitiveReader reader)
        {
        }
    }
}
