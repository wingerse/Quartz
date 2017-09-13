using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class ChangeGameState : OutPacket
    {
        public byte Reason { get; set; }
        public float Value { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteByte(Reason);
            writer.WriteFloat(Value);
        }
    }
}
