using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class ResourcePackSend : OutPacket
    {
        public const int IdConst = 0x34;

        public string Url { get; set; }
        public string Hash { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteStringProto(Url);
            writer.WriteStringProto(Hash);
        }
    }
}
