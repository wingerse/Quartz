using System;

namespace Quartz.Block
{
    public struct BlockStateId : IEquatable<BlockStateId>
    {
        public byte Id { get; }
        public byte Data { get; }

        public BlockStateId(byte id, byte data)
        {
            Id = id;
            Data = (byte)(data & 0xf);
        }

        public BlockStateId(ushort num)
        {
            Id = (byte)((num >> 4) & 0xff);
            Data = (byte)(num & 0xf);
        }

        public ushort ToShort() => (ushort)((Id << 4) | Data);

        public bool Equals(BlockStateId other) => Id == other.Id && Data == other.Data;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is BlockStateId && Equals((BlockStateId)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Id.GetHashCode() * 397) ^ Data.GetHashCode();
            }
        }

        public static bool operator ==(BlockStateId left, BlockStateId right) => left.Equals(right);

        public static bool operator !=(BlockStateId left, BlockStateId right) => !left.Equals(right);
    }
}
