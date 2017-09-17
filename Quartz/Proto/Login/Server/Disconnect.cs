using EncodingLib;
using Quartz.Text.Chat;

namespace Quartz.Proto.Login.Server
{
    public sealed class Disconnect : OutPacket
    {
        public ChatRoot Reason { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteChatRootProto(Reason);
        }
    }
}
