using EncodingLib;

namespace Quartz.Proto.Login.Client
{
    public sealed class LoginStart : InPacket
    {
        public const int Id = 0x00;

        public string Name { get; set; }

        public override void Read(PrimitiveReader reader)
        {
            Name = reader.ReadStringProto(16);
        }
    }
}
