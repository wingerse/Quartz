using EncodingLib;
using Quartz.Math;

namespace Quartz.Proto.Play.Server
{
    public sealed class DisplayParticle : OutPacket
    {
        public const int IdConst = 0x22;

        public Particle Particle { get; set; }
        public bool LongDistance { get; set; }
        public Vec3 Position { get; set; }
        public Vec3 Offset { get; set; }
        public float Speed { get; set; }
        public int Count { get; set; }
        
        /// <summary>
        /// Get this by calling GetData on particles which have it.
        /// This can be null for other particles.
        /// </summary>
        public int[] Data { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteInt(Particle.Id);
            writer.WriteBool(LongDistance);
            writer.WriteFloat((float)Position.X);
            writer.WriteFloat((float)Position.Y);
            writer.WriteFloat((float)Position.Z);
            writer.WriteFloat((float)Offset.X);
            writer.WriteFloat((float)Offset.Y);
            writer.WriteFloat((float)Offset.Z);
            writer.WriteFloat(Speed);
            writer.WriteInt(Count);
            if (Data == null) return;
            foreach (var i in Data)
            {
                writer.WriteInt(i);
            }
        }
    }
}
