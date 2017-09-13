using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class UnloadChunk : OutPacket
    {
        public ChunkPos Pos { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteInt(Pos.X);
            writer.WriteInt(Pos.Z);
        }
    }
}
