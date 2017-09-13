using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class AttachEntity : OutPacket
    {
		public int AttachedEntityId { get; set; }
	    public int HoldingEntityId { get; set; }
	
        public override void Write(PrimitiveWriter writer)
        {
			writer.WriteInt(AttachedEntityId);
	        writer.WriteInt(HoldingEntityId);
        }
    }
}
