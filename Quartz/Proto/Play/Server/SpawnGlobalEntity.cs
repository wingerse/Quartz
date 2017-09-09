using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class SpawnGlobalEntity : OutPacket
    {
        public const int IdConst = 0x02;

        public int EntityId { get; set; }
        public byte Type { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        
        public override int Id => IdConst;

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteByte(Type);
            writer.WriteDouble(X);
            writer.WriteDouble(Y);
            writer.WriteDouble(Z);
        }
    }
}
