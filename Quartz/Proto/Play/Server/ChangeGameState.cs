using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class ChangeGameState : OutPacket
    {
        public const int IdConst = 0x1e;

        public byte Reason { get; set; }
        public float Value { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteByte(Reason);
            writer.WriteFloat(Value);
        }
    }
}
