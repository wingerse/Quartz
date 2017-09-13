using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class TimeUpdate : OutPacket
    {
        public long WorldAge { get; set; }
        public long TimeOfDay { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteLong(WorldAge);
            writer.WriteLong(TimeOfDay);
        }
    }
}
