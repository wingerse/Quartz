using EncodingLib;

namespace Quartz.World
{
    public struct BlockPos
    {
        public static readonly BlockPos Origin = new BlockPos(0, 0, 0);

        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public BlockPos(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public BlockPos(ChunkPos chunkPos, int y)
        {
            X = chunkPos.X * 16;
            Y = y;
            Z = chunkPos.Z * 16;
        }
    }

    public static class BlockPosEx
    {
        public static void WriteBlockPosProto(this PrimitiveWriter writer, BlockPos blockPos)
        {
            var x = ((ulong)(uint)blockPos.X & 0x3ffffff) << 38;
            x |= ((ulong)(uint)blockPos.Y & 0xfff) << 26;
            x |= (ulong)(uint)blockPos.Z & 0x3ffffff;
            writer.WriteLong((long)x);
        }

        public static BlockPos ReadBlockPosProto(this PrimitiveReader reader)
        {
            var l = reader.ReadLong();
            var x = (int)(l >> 38);
            var y = (int)(l << 26 >> 38);
            var z = (int)l << 6 >> 6;
            return new BlockPos(x, y, z);
        }
    }
}
