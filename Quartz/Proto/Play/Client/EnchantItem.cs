using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class EnchantItem : InPacket
    {
        public sbyte WindowId { get; private set; }
        public byte EnchantmentPos { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            WindowId = reader.ReadSByte();
            EnchantmentPos = reader.ReadByte();
        }
    }
}
