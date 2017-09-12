using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class SelectAdvancementTab : OutPacket
    {
        public const int IdConst = 0x37;

        /// <summary>
        /// can be null
        /// </summary>
        public string Identifier { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteBool(Identifier != null);
            if (Identifier != null) writer.WriteStringProto(Identifier);
        }
    }
}
