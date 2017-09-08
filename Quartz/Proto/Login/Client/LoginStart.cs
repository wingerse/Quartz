using EncodingLib;

namespace Quartz.Proto.Login.Client
{
    public sealed class LoginStart : IInPacket
    {
        public const int Id = 0x00;

        public string Name { get; set; }

        public void Read(PrimitiveReader reader)
        {
            Name = reader.ReadStringProto(16);
        }
    }
}
