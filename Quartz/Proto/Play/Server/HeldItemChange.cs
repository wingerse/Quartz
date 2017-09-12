using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class HeldItemChange : OutPacket
    {
        public const int IdConst = 0x3a;
	
		public byte Slot { get; set; }
	
        public override int Id => IdConst;
	
        public override void Write(PrimitiveWriter writer)
        {
			writer.WriteByte(Slot);
        }
    }
}
