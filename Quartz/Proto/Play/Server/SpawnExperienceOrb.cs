using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class SpawnExperienceOrb : OutPacket
    {
        public const int IdConst = 0x01;

        public int EntityId { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public short Count { get; set; }
        
        public override int Id => IdConst;

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteDouble(X);
            writer.WriteDouble(Y);
            writer.WriteDouble(Z);
            writer.WriteShort(Count);
        }
    }
}
