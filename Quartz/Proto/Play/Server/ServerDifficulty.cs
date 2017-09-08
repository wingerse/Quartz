using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class ServerDifficulty : IOutPacket
    {
        public const int IdConst = 0x0d;

        public Difficulty Difficulty { get; set; }
        
        public int Id => IdConst;
        
        public void Write(PrimitiveWriter writer)
        {
            writer.WriteByte((byte)Difficulty);
        }
    }
}
