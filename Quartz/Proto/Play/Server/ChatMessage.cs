using EncodingLib;
using Quartz.Text.Chat;

namespace Quartz.Proto.Play.Server
{
    public sealed class ChatMessage : OutPacket
    {
        public ChatRoot ChatRoot { get; set; }
        public ChatPosition Position { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteChatRootProto(ChatRoot);
            writer.WriteByte((byte)Position);
        }
    }
}
