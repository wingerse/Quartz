using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class WindowProperty : OutPacket
    {
        public byte WindowId { get; set; }
        public short Property { get; set; }
        public short Value { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteByte(WindowId);
            writer.WriteShort(Property);
            writer.WriteShort(Value);
        }
    }
}
