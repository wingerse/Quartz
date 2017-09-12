using EncodingLib;
using Quartz.Entity;

namespace Quartz.Proto.Play.Server
{
    public sealed class EntityMetadata : OutPacket
    {
        public const int IdConst = 0x3c;
	
		public int EntityId { get; set; }
	    public Quartz.Entity.EntityMetadata Metadata { get; set; } 
	
        public override int Id => IdConst;
	
        public override void Write(PrimitiveWriter writer)
        {
			writer.WriteVarint(EntityId);
	        writer.WriteEntityMetadataProto(Metadata);
        }
    }
}
