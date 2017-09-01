using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace EncodingLib.UnitTests
{
    public class VarintTests
    {
        [Fact]
        public void TestVarintAndLong()
        {
            var buf = new byte[Varint.MaxVarlongLen];
            Varint.PutVarint(buf, 0);
            var result = Varint.GetVarint(buf);
            Assert.Equal(0, result.varint);

            Varint.PutVarint(buf, 127);
            result = Varint.GetVarint(buf);
            Assert.Equal(127, result.varint);

            Varint.PutVarint(buf, -2147483648);
            result = Varint.GetVarint(buf);
            Assert.Equal(-2147483648, result.varint);

            Varint.PutVarlong(buf, -12937480389237438);
            (long res, _) = Varint.GetVarlong(buf);
            Assert.Equal(-12937480389237438, res);

            Varint.PutVarlong(buf, -12937480389237438);
            Assert.Throws(typeof(EncodingException), () => Varint.GetVarint(buf));
        }
    }
}