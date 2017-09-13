using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class HeldItemChange : OutPacket
    {
		public byte Slot { get; set; }
	
        public override void Write(PrimitiveWriter writer)
        {
			writer.WriteByte(Slot);
        }
    }
}
