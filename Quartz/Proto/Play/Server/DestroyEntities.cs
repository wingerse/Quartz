using System.Collections.Generic;
using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class DestroyEntities : OutPacket
    {
        public List<int> EntityIds { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityIds.Count);
            foreach(var i in EntityIds)
                writer.WriteVarint(i);
        }
    }
}
