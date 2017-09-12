using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class AttachEntity : OutPacket
    {
        public const int IdConst = 0x3d;
	
		public int AttachedEntityId { get; set; }
	    public int HoldingEntityId { get; set; }
	
        public override int Id => IdConst;
	
        public override void Write(PrimitiveWriter writer)
        {
			writer.WriteInt(AttachedEntityId);
	        writer.WriteInt(HoldingEntityId);
        }
    }
}
