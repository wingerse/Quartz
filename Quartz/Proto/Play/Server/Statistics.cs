using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class Statistics : IOutPacket
    {
        public const int IdConst = 0x07;

        public (string name, int value)[] StatisticsArray { get; set; }
        
        public int Id => IdConst;
        
        public void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(StatisticsArray.Length);
            foreach (var s in StatisticsArray)
            {
                writer.WriteStringProto(s.name);
                writer.WriteVarint(s.value);
            }
        }
    }
}
