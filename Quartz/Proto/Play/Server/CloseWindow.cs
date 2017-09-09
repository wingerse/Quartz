using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class CloseWindow : OutPacket
    {
        public const int IdConst = 0x12;

        public byte WindowId { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteByte(WindowId);
        }
    }
}
