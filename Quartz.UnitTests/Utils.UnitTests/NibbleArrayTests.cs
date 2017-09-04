using System;
using Quartz.Utils;
using Xunit;

namespace Quartz.UnitTests.Utils.UnitTests
{
    public class NibbleArrayTests
    {
        [Fact]
        public void Correct_Backing_len()
        {
            var a = new NibbleArray(3);
            Assert.Equal(2, a.Backing.Length);
        }

        [Fact]
        public void Correct_Default_Value()
        {
            var a = new NibbleArray(3, 0xf);
            Assert.Equal(0xf, a[0]);
            Assert.Equal(0xf, a[1]);
            Assert.Equal(0xf, a[2]);
            Assert.Equal(0xff, a.Backing[0]);
            Assert.Equal(0xf, a.Backing[1]);
        }

        [Fact]
        public void Throws_OutOfRange()
        {
            var a = new NibbleArray(3);
            Assert.Throws<IndexOutOfRangeException>(() => a[3] = 10);
        }

        [Fact]
        public void Consistent_Get_Set()
        {
            var a = new NibbleArray(10, 5);
            Assert.Equal(5, a[2]);
            a[5] = 10;
            Assert.Equal(10, a[5]);
        }
    }
}
