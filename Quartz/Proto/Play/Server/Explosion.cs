using System.Collections.Generic;
using EncodingLib;
using Quartz.Math;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class Explosion : OutPacket
    {
        public const int IdConst = 0x1c;

        public Vec3 Location { get; set; }
        public float Radius { get; set; }
        public List<BlockPos> Records { get; set; }
        public Vec3 PlayerVelocity { get; set; }

        public override int Id => IdConst;

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteFloat((float)Location.X);
            writer.WriteFloat((float)Location.Y);
            writer.WriteFloat((float)Location.Z);
            writer.WriteFloat(Radius);
            writer.WriteInt(Records.Count);
            foreach (var r in Records)
            {
                writer.WriteByte((byte)(r.X - (int)Location.X));
                writer.WriteByte((byte)(r.Y - (int)Location.Y));
                writer.WriteByte((byte)(r.Z - (int)Location.Z));
            }
            writer.WriteFloat((float)PlayerVelocity.X);
            writer.WriteFloat((float)PlayerVelocity.Y);
            writer.WriteFloat((float)PlayerVelocity.Z);
        }
    }
}
