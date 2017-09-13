using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class SelectAdvancementTab : OutPacket
    {
        /// <summary>
        /// can be null
        /// </summary>
        public string Identifier { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteBool(Identifier != null);
            if (Identifier != null) writer.WriteStringProto(Identifier);
        }
    }
}
