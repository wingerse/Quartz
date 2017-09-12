using System;

namespace Quartz.Utils
{
    public sealed class VarBitArray
    {
        public ulong[] Backing { get; }
        public int Length { get; }
        public byte BitSize { get; }

        private readonly ulong _mask;

        public VarBitArray(int length, byte bitSize)
        {
            var bits = bitSize * length;
            Backing = new ulong[(int) System.Math.Ceiling(bits / 64d)];
            Length = length;
            BitSize = bitSize;
            _mask = (ulong) (1 << bitSize) - 1;
        }

        public VarBitArray(ulong[] backing, int length, byte bitSize)
        {
            if (bitSize * length > backing.Length * 64)
            {
                throw new ArgumentOutOfRangeException(nameof(length),
                    "impossible to contain that many Varbits in backing array");
            }

            Backing = backing;
            Length = length;
            BitSize = bitSize;
            _mask = (ulong) (1 << bitSize) - 1;
        }

        public ulong this[int index]
        {
            get
            {
                if (index >= Length) throw new IndexOutOfRangeException();

                var offset = index * BitSize;
                var relativeOffset = offset % 64;
                var endOffset = relativeOffset + BitSize;
                var num = Backing[offset / 64];

                // falls within one long.
                if (endOffset <= 64)
                {
                    return (num >> relativeOffset) & _mask;
                }

                var x = num >> relativeOffset;
                var nextLong = Backing[offset / 64 + 1];
                x |= nextLong << (64 - relativeOffset);
                return x & _mask;
            }
            set
            {
                if (index >= Length) throw new IndexOutOfRangeException();

                var offset = index * BitSize;
                var relativeOffset = offset % 64;
                var endOffset = relativeOffset + BitSize;
                var longIndex = offset / 64;
                var num = Backing[longIndex];

                num &= ~(_mask << relativeOffset);
                num |= (value & _mask) << relativeOffset;
                Backing[longIndex] = num;

                // falls within one long. 
                if (endOffset <= 64) return;

                var nextLong = Backing[longIndex + 1];
                var extraBits = endOffset - 64;
                nextLong = nextLong >> extraBits << extraBits;
                nextLong |= (value & _mask) >> (64 - relativeOffset);
                Backing[longIndex + 1] = nextLong;
            }
        }
    }
}
