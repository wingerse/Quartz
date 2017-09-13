using System.Collections.Generic;
using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class SetPassengers : OutPacket
    {
        public int EntityId { get; set; }
        public List<int> PassengerEntityIds { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteVarint(PassengerEntityIds.Count);
            foreach (var i in PassengerEntityIds)
            {
                writer.WriteVarint(i);
            }
        }
    }
}
