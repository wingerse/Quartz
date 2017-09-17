using System;
using EncodingLib;
using Quartz.Entity;

namespace Quartz.Proto.Play.Server
{
    public sealed class SpawnMob : OutPacket
    {
        public int EntityId { get; set; }
        public Guid Uuid { get; set; }
        public int Type { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Yaw { get; set; }
        public double Pitch { get; set; }
        public double HeadPitch { get; set; }
        public short VelocityX { get; set; }
        public short VelocityY { get; set; }
        public short VelocityZ { get; set; }
        public Quartz.Entity.EntityMetadata Metadata { get; set; }

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);            
            writer.WriteUuidProto(Uuid);
            writer.WriteVarint(Type);
            writer.WriteDouble(X);
            writer.WriteDouble(Y);
            writer.WriteDouble(Z);
            writer.WriteAngleProto(Yaw);
            writer.WriteAngleProto(Pitch);
            writer.WriteAngleProto(HeadPitch);
            writer.WriteShort(VelocityX);
            writer.WriteShort(VelocityY);
            writer.WriteShort(VelocityZ);
            writer.WriteEntityMetadataProto(Metadata);
        }
    }
}
