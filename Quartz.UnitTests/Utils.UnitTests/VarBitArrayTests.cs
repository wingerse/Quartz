using System;
using Quartz.Utils;
using Xunit;

namespace Quartz.UnitTests.Utils.UnitTests
{
    public class VarBitArrayTests
    {
        [Fact]
        public void Backing_Len_Correct()
        {
            var a = new VarBitArray(10, 13);
            Assert.Equal(3, a.Backing.Length);
            Assert.Equal(10, a.Length);
        }

        [Fact]
        public void Throws_OutOfRange()
        {
            var a = new VarBitArray(10, 13);
            Assert.Throws<IndexOutOfRangeException>(() => a[10] = 10);
        }

        [Fact]
        public void Set_Get_Consistent()
        {
            var a = new VarBitArray(10, 5);
            Assert.Equal(0UL, a[1]);
            a[4] = 4;
            Assert.Equal(4UL, a[4]);
            a[9] = 30;
            Assert.Equal(30UL, a[9]);
        }

        [Fact]
        public void Correctly_Reads_From_Backing()
        {
            var a = new VarBitArray(new ulong[] {0b00100_00011_00010_00001}, 4, 5);
            Assert.Equal(1UL, a[0]);
            Assert.Equal(2UL, a[1]);
            Assert.Equal(3UL, a[2]);
            Assert.Equal(4UL, a[3]);
            
            a = new VarBitArray(new ulong[] {0b100000000000_0000000000000_0000000000000_0000000000000_0000000000000, 1}, 5, 13);
            Assert.Equal(6144UL, a[4]);
        }
    }
}
