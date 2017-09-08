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
    }

    public static class BlockPosEx
    {
        public static void WriteBlockPosProto(this PrimitiveWriter writer, BlockPos blockPos)
        {
            var x = (ulong)(blockPos.X & 0x3ffffff) << 38;
            x |= (ulong)(blockPos.Y & 0xfff) << 26;
            x |= (ulong)(blockPos.Z & 0x3ffffff);
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
