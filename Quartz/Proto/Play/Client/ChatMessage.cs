using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class ChatMessage : InPacket
    {
        public string Message { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Message = reader.ReadStringProto(256);
        }
    }
}
