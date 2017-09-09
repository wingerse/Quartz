using EncodingLib;
using Quartz.Entity;
using Quartz.Text.Chat;

namespace Quartz.Proto.Play.Server
{
    public sealed class OpenWindow : OutPacket
    {
        public const int IdConst = 0x13;

        public byte WindowId { get; set; }
        public string WindowType { get; set; }
        public ChatRoot WindowTitle { get; set; }
        public byte SlotCount { get; set; }
        public int EntityId { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteByte(WindowId);
            writer.WriteStringProto(WindowType);
            writer.WriteChatRootProto(WindowTitle);
            writer.WriteByte(SlotCount);
            if (WindowType == Horse.WindowType)
            {
                writer.WriteInt(EntityId);
            }
        }
    }
}
