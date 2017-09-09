using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class PluginMessage : OutPacket
    {
        public const int IdConst = 0x18;

        public string Channel { get; set; }
        public byte[] Data { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteStringProto(Channel);
            writer.Write(Data, 0, Data.Length);
        }
    }
}
