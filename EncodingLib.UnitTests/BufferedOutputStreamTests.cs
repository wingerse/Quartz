using System.IO;
using Xunit;

namespace EncodingLib.UnitTests
{
    public class BufferedOutputStreamTests
    {
        [Fact]
        public void Correct_ReadByte()
        {
            var arr = new byte[100000];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = (byte)i;
            }

            var mem = new MemoryStream(arr);
            var bufreader = new BufferedOutputStream(mem);
            foreach (var e in arr)
            {
                Assert.Equal(e, bufreader.ReadByte());
            }
        }

        [Fact]
        public void Correct_Read()
        {
            var arr = new byte[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var mem = new MemoryStream(arr);
            var bufreader = new BufferedOutputStream(mem);
            var buf = new byte[arr.Length];
            bufreader.Read(buf, 0, buf.Length);
            Assert.Equal(arr, buf);
        }

        [Fact]
        public void Read_Return_Less_Than_Requested()
        {
            var arr = new byte[5000];
            var mem = new MemoryStream(arr);
            var bufreader = new BufferedOutputStream(mem);
            var buf = new byte[3000];
            var n = bufreader.Read(buf, 0, buf.Length);
            Assert.Equal(3000, n);

            n = bufreader.Read(buf, 0, buf.Length);
            // default buffer size is 4096
            // it reads in one go when buffer empty.
            // after reading 3000 bytes, 4096 - 3000 = 1096
            // tl;dr it reads what's left on buffer. Only request more from underlying stream when buf empty.
            Assert.Equal(1096, n);
        }

        [Fact]
        public void ReadByte_EOF_Well()
        {
            var arr = new byte[5000];
            var mem = new MemoryStream(arr);
            var bufreader = new BufferedOutputStream(mem);
            int b = 0;
            int i = 0;
            while(true)
            {
                b = bufreader.ReadByte();
                if (b != -1) i++;
                else break;
            }

            Assert.Equal(5000, i);
        }

        [Fact]
        public void Read_EOF_Well()
        {
            var arr = new byte[5000];
            var mem = new MemoryStream(arr);
            var bufreader = new BufferedOutputStream(mem);

            var buf = new byte[5000];
            bufreader.Read(buf, 0, buf.Length);
            var n = bufreader.Read(buf, 0, buf.Length);

            Assert.Equal(0, n);
        }
    }
}
