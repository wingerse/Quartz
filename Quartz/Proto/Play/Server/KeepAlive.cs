using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class KeepAlive : OutPacket
    {
        public int KeepAliveId { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(KeepAliveId);
        }
    }
}
