using System.Collections.Generic;
using EncodingLib;
using Quartz.Block;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class MultiBlockChange : OutPacket
    {
        public const int IdConst = 0x10;

        public ChunkPos ChunkPos { get; set; }
        public List<Record> Records { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteInt(ChunkPos.X);
            writer.WriteInt(ChunkPos.Z);
            writer.WriteVarint(Records.Count);
            foreach (var r in Records)
            {
                writer.WriteByte((byte)(r.BlockPosInChunk.X << 4 | r.BlockPosInChunk.Z));
                writer.WriteByte(r.BlockPosInChunk.Y);
                writer.WriteVarint(r.BlockStateId.ToShort());
            }
        }

        public class Record
        {
            public Chunk.BlockPos BlockPosInChunk { get; set; }
            public BlockStateId BlockStateId { get; set; }
        }
    }
}
