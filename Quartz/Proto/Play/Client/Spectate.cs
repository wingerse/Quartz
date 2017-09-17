using System;
using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class Spectate : InPacket
    {
        public Guid Uuid { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Uuid = reader.ReadUuidProto();
        }
    }
}
