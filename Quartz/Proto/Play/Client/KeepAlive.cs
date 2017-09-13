using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class KeepAlive : InPacket
    {
        public int KeepAliveId { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            KeepAliveId = reader.ReadVarint();
        }
    }
}
