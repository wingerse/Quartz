using EncodingLib;
using Quartz.Text.Chat;

namespace Quartz.Proto.Play.Server
{
    public sealed class PlayerListHeaderAndFooter : OutPacket
    {
        public ChatRoot Header { get; set; }
        public ChatRoot Footer { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteChatRootProto(Header);
            writer.WriteChatRootProto(Footer);
        }
    }
}
