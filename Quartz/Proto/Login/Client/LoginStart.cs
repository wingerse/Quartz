using EncodingLib;

namespace Quartz.Proto.Login.Client
{
    public sealed class LoginStart : InPacket
    {
        public string Name { get; private set; }

        public override void Read(PrimitiveReader reader)
        {
            Name = reader.ReadStringProto(16);
        }
    }
}
