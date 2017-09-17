using System;
using EncodingLib;
using Quartz.Entity;

namespace Quartz.Proto.Play.Server
{
    public sealed class SpawnPlayer : OutPacket
    {
        public int EntityId { get; set; }
        public Guid Uuid { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Yaw { get; set; }
        public double Pitch { get; set; }
        public Quartz.Entity.EntityMetadata Metadata { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteUuidProto(Uuid);
            writer.WriteDouble(X);
            writer.WriteDouble(Y);
            writer.WriteDouble(Z);
            writer.WriteAngleProto(Yaw);
            writer.WriteAngleProto(Pitch);
            writer.WriteEntityMetadataProto(Metadata);
        }
    }
}
