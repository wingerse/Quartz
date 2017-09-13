using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class Statistics : OutPacket
    {
        public (string name, int value)[] StatisticsArray { get; set; }
        
        public override void Write(PrimitiveWriter writer)
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
