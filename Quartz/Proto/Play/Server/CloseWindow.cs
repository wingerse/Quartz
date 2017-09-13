using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class CloseWindow : OutPacket
    {
        public byte WindowId { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteByte(WindowId);
        }
    }
}
