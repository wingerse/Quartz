using System.Collections.Generic;
using EncodingLib;
using Quartz.Block;
using Quartz.Utils;
using Quartz.World;

namespace Quartz.World
{
    internal sealed class ChunkSection
    {
        public const int YLen = 16;
        public const int XLen = 16;
        public const int ZLen = 16;
        public const int TotalBlockCount = YLen * XLen * ZLen;
        public const int GlobalPaletteNeedeBitSize = 13;

        private ushort _airCount = TotalBlockCount;

        public List<BlockStateId> Palette { get; private set; } = new List<BlockStateId> {new BlockStateId(Air.IdConst, 0)};
        public VarBitArray Blocks { get; private set; } = new VarBitArray(TotalBlockCount, 4);
        public NibbleArray Blocklight { get; } = new NibbleArray(TotalBlockCount);
        public NibbleArray Skylight { get; }

        public ChunkSection(bool hasSkylight)
        {
            if (hasSkylight) Skylight = new NibbleArray(TotalBlockCount, 15);
        }

        public bool UsingGlobalPalette => Palette == null;
        public bool IsEmpty => _airCount == TotalBlockCount;
        public bool HasSkylight => Skylight != null;

        /// <summary>
        /// Gets or sets a block in this ChunkSection.
        /// The palette used will only grow, never shrink due to performance reasons.
        /// The palette will no longer be used when its size > 255 (8 bits).
        /// </summary>
        public BlockStateId this[BlockPos pos]
        {
            get => UsingGlobalPalette ? new BlockStateId((ushort)Blocks[GetIndex(pos)]) : Palette[(int)Blocks[GetIndex(pos)]];
            set
            {
                var previous = this[pos];
                if (previous == value) return;

                if (previous.Id == Air.IdConst) _airCount--;
                else if (value.Id == Air.IdConst) _airCount++;

                ulong num;
                if (UsingGlobalPalette) num = value.ToShort();
                else
                {
                    var index = Palette.IndexOf(value);
                    if (index == -1)
                    {
                        Palette.Add(value);
                        index = Palette.Count - 1;
                        OnPaletteSizeIncreased();
                        if (UsingGlobalPalette) index = value.ToShort();
                    }
                    num = (uint)index;
                }
                Blocks[GetIndex(pos)] = num;
            }
        }

        public byte GetBlocklight(BlockPos pos) => Blocklight[GetIndex(pos)];
        public void SetBlocklight(BlockPos pos, byte light) => Blocklight[GetIndex(pos)] = light;
        public byte GetSkylight(BlockPos pos) => Skylight[GetIndex(pos)];
        public void SetSkylight(BlockPos pos, byte light) => Skylight[GetIndex(pos)] = light;

        private void OnPaletteSizeIncreased()
        {
            var neededBitSize = BitsNeeded((ushort)Palette.Count);
            var currentBitSize = Blocks.BitSize;

            if (currentBitSize == neededBitSize) return;

            if (neededBitSize > 8)
            {
                // do nothing if already using global palette.
                if (currentBitSize > 8) return;

                var blocks = new VarBitArray(TotalBlockCount, GlobalPaletteNeedeBitSize);
                for (var i = 0; i < TotalBlockCount; i++)
                {
                    var stateId = Palette[(int)Blocks[i]];
                    blocks[i] = stateId.ToShort();
                }
                Blocks = blocks;
                Palette = null;
            }
            else if (neededBitSize > 4)
            {
                var blocks = new VarBitArray(TotalBlockCount, neededBitSize);
                for (var i = 0; i < TotalBlockCount; i++)
                {
                    var index = Blocks[i];
                    blocks[i] = index;
                }
                Blocks = blocks;
            }
            // else no need to increase bit size for bits <= 4.
        }

        private static int GetIndex(BlockPos pos) => pos.Y * ZLen * XLen + pos.Z * XLen + pos.X;

        private static byte BitsNeeded(ushort num)
        {
            byte count = 0;
            while (num != 0)
            {
                num >>= 1;
                count++;
            }
            return count;
        }

        public struct BlockPos
        {
            public byte X { get; }
            public byte Y { get; }
            public byte Z { get; }

            public BlockPos(byte x, byte y, byte z)
            {
                X = (byte)(x & 0xf);
                Y = (byte)(y & 0xf);
                Z = (byte)(z & 0xf);
            }

            public BlockPos(Chunk.BlockPos chunkBlockPos)
            {
                X = chunkBlockPos.X;
                Y = (byte)(chunkBlockPos.Y % 16);
                Z = chunkBlockPos.Z;
            }
        }
    }
}

internal static class ChunkSectionEx
{
    public static void WriteChunkSectionProto(this PrimitiveWriter writer, ChunkSection chunkSection)
    {
        writer.WriteByte(chunkSection.Blocks.BitSize);
        if (chunkSection.UsingGlobalPalette)
        {
            writer.WriteVarint(0);
        }
        else
        {
            writer.WriteVarint(chunkSection.Palette.Count);
            foreach (var b in chunkSection.Palette)
            {
                writer.WriteVarint(b.ToShort());
            }
        }
        
        writer.WriteVarint(chunkSection.Blocks.Backing.Length);
        foreach (var l in chunkSection.Blocks.Backing)
        {
            writer.WriteLong((long)l);
        }
        
        writer.Write(chunkSection.Blocklight.Backing, 0, chunkSection.Blocklight.Backing.Length);

        if (chunkSection.HasSkylight)
        {
            writer.Write(chunkSection.Skylight.Backing, 0, chunkSection.Skylight.Backing.Length);
        }
    }
}
