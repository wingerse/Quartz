using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class ServerDifficulty : OutPacket
    {
        public Difficulty Difficulty { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteByte((byte)Difficulty);
        }
    }
}
