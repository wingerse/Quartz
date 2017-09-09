using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class ConfirmTransaction : OutPacket
    {
        public const int IdConst = 0x11;

        public byte WindowId { get; set; }
        public short ActionNum { get; set; }
        public bool Accepted { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteByte(WindowId);
            writer.WriteShort(ActionNum);
            writer.WriteBool(Accepted);
        }
    }
}
