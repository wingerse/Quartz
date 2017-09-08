using System.Collections.Generic;
using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class TabComplete : IOutPacket
    {
        public const int IdConst = 0x0e;

        public List<string> Matches { get; set; }
        
        public int Id => IdConst;
        
        public void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(Matches.Count);
            foreach (var m in Matches)
            {
                writer.WriteStringProto(m);
            }
        }
    }
}
