using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class HeldItemChange : InPacket
    {
        public short Slot { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Slot = reader.ReadShort();
        }
    }
}
