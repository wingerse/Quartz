using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class TeleportConfirm : InPacket
    {
        public int TeleportId { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            TeleportId = reader.ReadVarint();
        }
    }
}
