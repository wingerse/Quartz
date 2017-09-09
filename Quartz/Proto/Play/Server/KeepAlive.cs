using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class KeepAlive : OutPacket
    {
        public const int IdConst = 0x1f;

        public int KeepAliveId { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(KeepAliveId);
        }
    }
}
