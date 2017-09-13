using EncodingLib;

namespace Quartz.Proto.Login.Server
{
    public sealed class SetCompression : OutPacket
    {
        
        
        public int Threshold { get; set; }

        public override int Id => IdConst;

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(Threshold);
        }
    }
}
