using EncodingLib;

namespace Quartz.Proto.Login.Server
{
    public sealed class SetCompression : IOutPacket
    {
        public const int Id = 3;
        
        public int Threshold { get; set; }

        public int GetId() => Id;

        public void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(Threshold);
        }
    }
}
