using System;
using EncodingLib;
using Quartz.Math;

namespace Quartz.Proto.Play.Server
{
    public sealed class PlayerPositionAndLook : OutPacket
    {
        public Vec3 Position { get; set; }
        public float Yaw { get; set; }
        public float Pitch { get; set; }
        public FlagsEnum Flags { get; set; }
        public int TeleportId { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteDouble(Position.X);
            writer.WriteDouble(Position.Y);
            writer.WriteDouble(Position.Z);
            writer.WriteFloat(Yaw);
            writer.WriteFloat(Pitch);
            writer.WriteByte((byte)Flags);
            writer.WriteVarint(TeleportId);
        }

        [Flags]
        public enum FlagsEnum : byte
        {
            X = 1 << 0,
            Y = 1 << 1,
            Z = 1 << 2,
            Pitch = 1 << 3,
            Yaw = 1 << 4
        }
    }
}
