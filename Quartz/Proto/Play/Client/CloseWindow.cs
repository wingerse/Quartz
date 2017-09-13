using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class CloseWindow : InPacket
    {
        public byte WindowId { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            WindowId = reader.ReadByte();
        }
    }
}
