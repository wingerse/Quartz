using System.Collections.Generic;
using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class TabComplete : OutPacket
    {
        public List<string> Matches { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(Matches.Count);
            foreach (var m in Matches)
            {
                writer.WriteStringProto(m);
            }
        }
    }
}
