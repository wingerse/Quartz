using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class ConfirmTransaction : InPacket
    {
        public sbyte WindowId { get; private set; }
        public short ActionNum { get; private set; }
        public bool Accepted { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            WindowId = reader.ReadSByte();
            ActionNum = reader.ReadShort();
            Accepted = reader.ReadBool();
        }
    }
}
