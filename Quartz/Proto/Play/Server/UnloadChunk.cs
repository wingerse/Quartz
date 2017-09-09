using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class UnloadChunk : OutPacket
    {
        public const int IdConst = 0x1d;

        public ChunkPos Pos { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteInt(Pos.X);
            writer.WriteInt(Pos.Z);
        }
    }
}
