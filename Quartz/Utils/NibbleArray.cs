using System;

namespace Quartz.Utils
{
    public sealed class NibbleArray
    {
        public byte[] Backing { get; }
        public int Length { get; }

        public NibbleArray(int len)
        {
            Backing = new byte[(len + 1) / 2];
            Length = len;
        }

        public NibbleArray(byte[] backing, int length)
        {
            if (length * 4 > backing.Length * 8)
            {
                throw new ArgumentOutOfRangeException(nameof(length),
                    "impossible to contain that many Varbits in backing array");
            }

            Backing = backing;
            Length = length;
        }

        public NibbleArray(int len, byte defalt)
            : this(len)
        {
            defalt &= 0x0f;
            for (var i = 0; i < Backing.Length; i++)
            {
                Backing[i] = (byte) ((defalt << 4) | defalt);
            }
            if (len % 2 != 0)
            {
                // clear high nibble for odd length.
                Backing[Backing.Length - 1] &= 0x0f;
            }
        }

        public byte this[int index]
        {
            get
            {
                if (index >= Length) throw new IndexOutOfRangeException();
                var byt = Backing[index / 2];
                return index % 2 == 0 ? (byte) (byt & 0x0f) : (byte) (byt >> 4);
            }
            set
            {
                if (index >= Length) throw new IndexOutOfRangeException();
                var byt = Backing[index / 2];
                if (index % 2 == 0)
                {
                    Backing[index / 2] = (byte) ((byt & 0xf0) | (value & 0x0f));
                }
                else
                {
                    Backing[index / 2] = (byte) ((byt & 0x0f) | (value << 4));
                }
            }
        }
    }
}
