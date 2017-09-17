using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class UseItem : InPacket
    {
        public Hand Hand { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Hand = (Hand)reader.ReadVarint();
            if (!Hand.IsValid())
            {
                throw new InvalidPacketException(nameof(Hand), Hand);
            }
        }
    }
}
