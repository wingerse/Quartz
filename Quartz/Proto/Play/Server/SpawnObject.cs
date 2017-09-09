using System;
using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class SpawnObject : OutPacket
    {
        public const int IdConst = 0x00;

        public int EntityId { get; set; }
        public Guid Uuid { get; set; }
        public byte Type { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Pitch { get; set; }
        public double Yaw { get; set; }
        public int Data { get; set; }
        public short VelocityX { get; set; }
        public short VelocityY { get; set; }
        public short VelocityZ { get; set; }

        public override int Id => IdConst;

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteUuidProto(Uuid);
            writer.WriteByte(Type);
            writer.WriteDouble(X);
            writer.WriteDouble(Y);
            writer.WriteDouble(Z);
            writer.WriteAngleProto(Pitch);
            writer.WriteAngleProto(Yaw);
            writer.WriteInt(Data);
            writer.WriteShort(VelocityX);
            writer.WriteShort(VelocityY);
            writer.WriteShort(VelocityZ);
        }
    }
}
