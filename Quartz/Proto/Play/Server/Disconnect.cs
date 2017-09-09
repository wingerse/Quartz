using EncodingLib;
using Quartz.Text.Chat;

namespace Quartz.Proto.Play.Server
{
    public sealed class Disconnect : OutPacket
    {
        public const int IdConst = 0x1a;

        public ChatRoot Reason { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteChatRootProto(Reason);
        }
    }
}
