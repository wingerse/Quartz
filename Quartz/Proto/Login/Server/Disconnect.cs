using EncodingLib;
using Quartz.Text.Chat;

namespace Quartz.Proto.Login.Server
{
    public sealed class Disconnect : IOutPacket
    {
        public const int Id = 0;
        
        public ChatRoot Reason { get; set; }
        public int GetId() => Id;

        public void Write(PrimitiveWriter writer)
        {
            writer.WriteChatRootProto(Reason);
        }
    }
}
